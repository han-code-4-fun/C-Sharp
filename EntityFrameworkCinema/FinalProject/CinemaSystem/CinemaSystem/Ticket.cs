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
        public Ticket(CinemaEntities cinemaContext)
        {
            // Assign db context
            context = cinemaContext;
            InitializeComponent();
            TicketForm_Load();
            seatsButton.Click += SeatsForm_Init;
            findCustomer.Click += FindCustomer_Click;
        }
        private void TicketForm_Load()
        {
            // Load list of movies
            var listSchedule = from movie in context.Movies
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
            dataGridViewMovie.DataSource = listSchedule.ToList();
            dataGridViewMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovie.Columns["ScheduleId"].Visible = false;
            dataGridViewMovie.Columns["MoviePrice"].DefaultCellStyle.Format = "c";
            dataGridViewMovie.RowTemplate.Height = 30;
            dataGridViewMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SeatsForm_Init(object sender, EventArgs e)
        {
            // TODO: Check for at least one selected
            DataGridViewRow selectedRow = dataGridViewMovie.SelectedRows[0];
            int scheduleId = Convert.ToInt32(selectedRow.Cells["ScheduleId"].Value);
            Schedule schedule = context.Schedules.Find(scheduleId);
            Seats seatsForm = new Seats(context, schedule, currentSeats);
            var result = seatsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentSeats = seatsForm.GetSelectedSeats();
            }
        }
        private void FindCustomer_Click(object sender, EventArgs e)
        {
            String phone = textBoxPhone.Text;
            // TODO: Handler for null result
            currentCustomer = context.Customers.Where(c => c.Phone == phone).FirstOrDefault();
            textBoxFirstName.Text = currentCustomer.FirstName;
            textBoxLastName.Text = currentCustomer.LastName;
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
        private class ShoppingCart
        {
            [DisplayName("Item ID")]
            public int ItemId { get; set; }
            [DisplayName("Item Name")]
            public Type ItemType { get; set; }
            [DisplayName("Item Quantity")]
            public decimal ItemQuantity { get; set; }
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
