using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem.EF_Class;
namespace CinemaSystem
{
    public partial class Ticket : Form
    {
        CinemaEntities context;
        Customer currentCustomer;
        List<Seat> currentSeats = new List<Seat>();
        List<Snack> snacks = new List<Snack>();
        BindingSource snackSource;
        Schedule currentSchedule;
        decimal totalPrice;
        static Random random = new Random();

        public Ticket(CinemaEntities cinemaContext)
        {
            // Assign db context
            context = cinemaContext;
            InitializeComponent();
            TicketForm_Load();
            seatsButton.Click += SeatsForm_Init;
            textBoxPhone.KeyPress += EnterKeyPress;
            findCustomer.Click += FindCustomer_Click;
            snackButton.Click += SnacksForm_Init;
            confirmOrderButton.Click += ConfirmOrder_Click;
        }

        //initial form setting when loaded
        private void TicketForm_Load()
        {
            // Load list of movies
             populateDateGridView(GetDataFromContext());

            // Reset all values
            Reset();
        }

        private IQueryable<ListScheduleSelection> GetDataFromContext()
        {
            var output = from movie in context.Movies
                                join schedule in context.Schedules on movie.MovieId equals schedule.MovieId
                                orderby schedule.StartTime
                                select new ListScheduleSelection
                                {
                                    ScheduleId = schedule.ScheduleId,
                                    MovieName = movie.Name,
                                    MovieDuration = movie.Duration_Minutes,
                                    MovieDescription = movie.Description,
                                    MoviePrice = movie.InitialPrice,
                                    StartTime = schedule.StartTime,
                                };
            return output;
        }

        private void populateDateGridView(IQueryable<ListScheduleSelection> listSchedule)
        {
            dataGridViewMovie.DataSource = listSchedule.ToList();
            dataGridViewMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovie.Columns["ScheduleId"].Visible = false;
            dataGridViewMovie.Columns["MoviePrice"].DefaultCellStyle.Format = "c";
            dataGridViewMovie.RowTemplate.Height = 30;
            dataGridViewMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Load list snacks
            snackSource = new BindingSource();
            snackSource.DataSource = snacks;
            dataGridViewCart.DataSource = snackSource;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCart.Columns["ItemPrice"].DefaultCellStyle.Format = "c";
            dataGridViewCart.RowTemplate.Height = 30;
        }

        //open seat booking form
        private void SeatsForm_Init(object sender, EventArgs e)
        {
            
            // Get current selected row
            DataGridViewRow selectedRow = dataGridViewMovie.SelectedRows[0];
            int scheduleId = Convert.ToInt32(selectedRow.Cells["ScheduleId"].Value);
            // Find the selected Schedule
            Schedule schedule = context.Schedules.Find(scheduleId);
            if (currentSchedule == null || (currentSchedule.ScheduleId != schedule.ScheduleId))
            {
                currentSeats = new List<Seat>();
            }
            currentSchedule = schedule;
            Seats seatsForm = new Seats(context, schedule, currentSeats);
            var result = seatsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentSeats = seatsForm.GetSelectedSeats();
                // Update selected Movie
                textBoxSelectedMovie.Text = currentSchedule.Movie.Name;
                textBoxNumberOfTickets.Text = currentSeats.Count.ToString();
                // Update price
                calculateTotal();
            }
        }

        //enable user hit 'enter' key to look up customer information
        private void EnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                FindCustomerInContext();
            }

        }

        //open snack form
        private void SnacksForm_Init(object sender, EventArgs e)
        {
            CinemaSystem.Snack snackForm = new CinemaSystem.Snack(context);
            var result = snackForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Snack selectedSnack = snackForm.GetSnack();
                Snack query = snacks.FirstOrDefault(s => s.ItemId == selectedSnack.ItemId);
                if(query != null)
                {
                    query.ItemQuantity += selectedSnack.ItemQuantity;
                }else snacks.Add(snackForm.GetSnack());
                snackSource.ResetBindings(false);

                // Update price
                calculateTotal();
            }
        }



        //process  order
        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            if(snacks.Count == 0 && currentSeats.Count == 0)
            {
                MessageBox.Show("Please choose at least one item to order");
                return;
            }
            if (currentCustomer == null) currentCustomer = context.Customers.FirstOrDefault(c => c.Email == "N/A");
            Order order = new Order
            {
                CustomerId = currentCustomer.CustomerId,
                OrderTotal = totalPrice,
                OrderDateTime = DateTime.Now,
                TicketIdentifier = RandomString(10),
            };
            if (currentSchedule != null) order.ScheduleId = currentSchedule.ScheduleId;
            // Add new order and save changes
            context.Orders.Add(order);
            context.SaveChanges();

            // Add seats
            foreach (Seat seat in currentSeats)
            {
                SeatsOrder seatsOrder = new SeatsOrder
                {
                    Column = seat.X,
                    Row = seat.Y,
                    OrderId = order.OrderId,
                };
                context.SeatsOrders.Add(seatsOrder);
            }
            // Add Snacks
            foreach (Snack snack in snacks)
            {
                OrdersSnack ordersSnack = new OrdersSnack
                {
                    OrderId = order.OrderId,
                    SnackId = snack.ItemId,
                    Quantity = snack.ItemQuantity,
                    UnitPrice = snack.ItemPrice,
                    OrderTotal = snack.ItemQuantity * snack.ItemPrice,
                };
                context.OrdersSnacks.Add(ordersSnack);
            }
            context.SaveChanges();

            MessageBox.Show("Your order has been placed successfully. Order ID:" + order.TicketIdentifier);

            // Reset all values
            Reset();
        }



        private void Reset()
        {
            // Reset all 
            currentSeats.Clear();
            currentSchedule = null;
            snacks.Clear();
            snackSource.ResetBindings(false);
            currentCustomer = null;
            textBoxSelectedMovie.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxNumberOfTickets.Text = "";
            totalPrice = 0;
            textBoxSnackPrice.Text = 0.ToString("c");
            textBoxMoviePrice.Text = 0.ToString("c");
            textBoxTotalPrice.Text = 0.ToString("c");
        }


        //check user input with database and extract customer information
        private void FindCustomer_Click(object sender, EventArgs e)
        {
            FindCustomerInContext();
        }

        private void FindCustomerInContext()
        {
            String phone = textBoxPhone.Text;
            if (phone == "" || phone == null)
            {
                MessageBox.Show("Please enter a phone number to find");
                return;
            }
            currentCustomer = context.Customers.Where(c => c.Phone == phone).FirstOrDefault();
            if (currentCustomer != null)
            {
                textBoxFirstName.Text = currentCustomer.FirstName;
                textBoxLastName.Text = currentCustomer.LastName;
            }
            else
            {
                MessageBox.Show("No Result found");
                return;
            }
        }


        //calculated total movie, snack and total price
        private void calculateTotal()
        {
            decimal totalMoviePrice = 0;
            if (currentSchedule != null) { 
            // Calculate total Movie Price
            decimal moviePrice = currentSchedule.Movie.InitialPrice;
            totalMoviePrice = moviePrice * currentSeats.Count;
            textBoxMoviePrice.Text = totalMoviePrice.ToString("c");
            }
            // Calculate total Snack Price
            decimal totalSnackPrice = 0;
            foreach(Snack snack in snacks)
            {
                totalSnackPrice += snack.ItemPrice * snack.ItemQuantity;
            }
            textBoxSnackPrice.Text = totalSnackPrice.ToString("c");
            totalPrice = totalSnackPrice + totalMoviePrice;
            textBoxTotalPrice.Text = totalPrice.ToString("c");
        }


        // Generate random string
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        private class ListScheduleSelection
        {
            [DisplayName("Schedule ID")]
            public int ScheduleId { get; set; }
            [DisplayName("Movie Name")]
            public string MovieName { get; set; }
            [DisplayName("Movie Duration")]
            public int MovieDuration { get; set; }
            [DisplayName("Movie Description")]
            public string MovieDescription { get; set; }
            [DisplayName("Start Time")]
            public TimeSpan StartTime { get; set; }
            [DisplayName("Movie Price")]
            public decimal MoviePrice { get; set; }

        }
        public class Snack
        {
            [DisplayName("Item ID")]
            public int ItemId { get; set; }
            [DisplayName("Item Name")]
            public string ItemName { get; set; }
            [DisplayName("Item Quantity")]
            public int ItemQuantity { get; set; }
            [DisplayName("Item Price")]
            public decimal ItemPrice { get; set; }
        }
        public class Seat
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
