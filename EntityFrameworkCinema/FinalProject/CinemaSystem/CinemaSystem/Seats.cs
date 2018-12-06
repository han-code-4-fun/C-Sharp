using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem.EF_Class;

namespace CinemaSystem
{
    public partial class Seats : Form
    {
        CinemaEntities context;
        Schedule schedule;
        List<Button> seats = new List<Button>();
        List<Ticket.Seat> selectedSeats;
        public Seats(CinemaEntities cinemaContext, Schedule schedule, List<Ticket.Seat> seats)
        {
            InitializeComponent();
            this.context = cinemaContext;
            this.schedule = schedule;
            this.selectedSeats = seats;
            this.Load += SeatsForm_Load;
            buttonConfirm.Click += ConfirmSeats_Click;

        }
        private void SeatsForm_Load(object sender, EventArgs e)
        {
            // Init list of seats
            int startX = 63;
            int currentY = 78;
            int currentX = 63;
            int incrementX = 80;
            int incrementY = 58;
            for (int i =1; i <= (schedule.Hall.NMaxColum * schedule.Hall.NMaxRow); i++)
            {
                Button newButton = new Button();
                newButton.Location = new Point(currentX, currentY);
                newButton.BackColor = DefaultBackColor;
                newButton.Text = i.ToString();
                if(i % schedule.Hall.NMaxColum == 0)
                {
                    currentX = startX;
                    currentY += incrementY;
                } else
                {
                    currentX += incrementX;
                }
                newButton.Click += Seat_Click;
                seats.Add(newButton);
                this.Controls.Add(newButton);
            }

            // Check for not available seats
            var notAvailableSeats = context.SeatsOrders.Where(s => s.Order.Schedule.ScheduleId == schedule.ScheduleId).ToList();
            foreach(SeatsOrder seatOrder in notAvailableSeats)
            {
                Ticket.Seat seat = new Ticket.Seat
                {
                    X = (int) seatOrder.Column,
                    Y = (int) seatOrder.Row,
                };
                int index = ConvertPositionToIndex(seat);
                seats[index - 1].BackColor = Color.DarkGray;
            }
            // Check if seats is selected
            foreach (Ticket.Seat seat in selectedSeats)
            {
                int index = ConvertPositionToIndex(seat);
                seats[index -1].BackColor = Color.Red;
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Red)
            {
                Ticket.Seat position = CalculatePosition(Convert.ToInt32(button.Text));
                selectedSeats.RemoveAll(s => (s.X == position.X && s.Y == position.Y));
                button.BackColor = DefaultBackColor;
            } else if(button.BackColor == DefaultBackColor)
            {
                selectedSeats.Add(CalculatePosition(Convert.ToInt32(button.Text)));
                button.BackColor = Color.Red;
            }
        }
        private void ConfirmSeats_Click(object sender, EventArgs e)
        {
            if(selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }


        public List<Ticket.Seat> GetSelectedSeats()
        {
            return selectedSeats;
        }
        public Schedule GetSchedule()
        {
            return schedule;
        }
        private Ticket.Seat CalculatePosition(int index)
        {
            Ticket.Seat seat = new Ticket.Seat();
            int maxColumn = schedule.Hall.NMaxColum;
            int maxRow = schedule.Hall.NMaxRow;
            // Calculate X
            if (index % maxColumn == 0) seat.X = maxColumn;
            else seat.X = index % maxColumn;
            // Calculate Y
            if (index % maxColumn == 0) seat.Y = index / maxColumn;
            else seat.Y = (index / maxColumn) +1 ;
            return seat;
        }
        private int ConvertPositionToIndex(Ticket.Seat seat)
        {
            int maxColumn = schedule.Hall.NMaxColum;
            int index = ((seat.Y-1) * maxColumn) + seat.X;
            return index;
        }
    }
}
