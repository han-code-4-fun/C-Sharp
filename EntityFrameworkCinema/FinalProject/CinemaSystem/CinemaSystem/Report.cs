using CinemaSystem.EF_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystem
{
    public partial class Report : Form
    {
        CinemaEntities context;
       
        public Report(CinemaEntities inputContext)
        {
            context = inputContext;
            InitializeComponent();
            populateListBox();
        }

        private void populateListBox()
        {
            var listMovies = from movie in context.Movies
                             select movie.Name;

            listBoxMovie.DataSource = listMovies.ToList();
            
        }

        private void button7Days_Click(object sender, EventArgs e)
        {
            DateTime days7before = DateTime.Today.AddDays(-7);
            MessageBox.Show(days7before.ToString());
            var temp = from movie in context.Movies
                       join schedule in context.Schedules
                        on movie.MovieId equals schedule.MovieId
                       join order in context.Orders
                       on schedule.ScheduleId equals order.ScheduleId
                       join seatorder in context.SeatsOrders
                       on order.OrderId equals seatorder.OrderId
                       where order.OrderDateTime > days7before
                       select new { movie.Name, order.OrderTotal, seatorder.Id }
                       into t
                       group t by t.Name into m
                       select new ReportFormat()
                       {
                           movie = m.FirstOrDefault().Name,
                           numCust = m.Count(),
                           totalSales = m.Sum(n => (double)n.OrderTotal)
                       };



            dataGridViewReport.DataSource = temp.ToList();
        }

        private void button30Days_Click(object sender, EventArgs e)
        {
            DateTime days30before = DateTime.Today.AddDays(-30);

            var temp = from movie in context.Movies
                       join schedule in context.Schedules
                        on movie.MovieId equals schedule.MovieId
                       join order in context.Orders
                       on schedule.ScheduleId equals order.ScheduleId
                       join seatorder in context.SeatsOrders
                       on order.OrderId equals seatorder.OrderId
                       where order.OrderDateTime > days30before
                       select new { movie.Name, order.OrderTotal, seatorder.Id }
                       into t
                       group t by t.Name into m
                       select new ReportFormat()
                       {
                           movie = m.FirstOrDefault().Name,
                           numCust = m.Count(),
                           totalSales = m.Sum(n => (double)n.OrderTotal)
                       };



            dataGridViewReport.DataSource = temp.ToList();

        }

        private void buttonAllTime_Click(object sender, EventArgs e)
        {
           

            var temp = from movie in context.Movies
                       join schedule in context.Schedules
                        on movie.MovieId equals schedule.MovieId
                       join order in context.Orders
                       on schedule.ScheduleId equals order.ScheduleId
                       join seatorder in context.SeatsOrders
                       on order.OrderId equals seatorder.OrderId
                       select new { movie.Name, order.OrderTotal, seatorder.Id } 
                       into t
                       group t by t.Name into m
                       select new ReportFormat()
                       {
                           movie = m.FirstOrDefault().Name,
                           numCust = m.Count(),
                           totalSales = m.Sum(n=>(double)n.OrderTotal)
                       };

     

            dataGridViewReport.DataSource = temp.ToList();


        }

        private class ReportFormat
        {
            [DisplayName("Movie Name")]
            public string movie { get; set; }
            [DisplayName("Number of Customers")]
            public int numCust { get; set; }
            [DisplayName("Total Sales")]
            public double totalSales { get; set; }
        }
    }
}
