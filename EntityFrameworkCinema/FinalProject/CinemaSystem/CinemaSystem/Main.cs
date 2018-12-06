using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;
using System.Windows.Forms;
using CinemaSystem.EF_Class;
using System.IO;

namespace CinemaSystem
{
    public partial class Main : Form
    {
        CinemaEntities context;
        public Main()
        {
            InitializeComponent();

            // Init Entity Framework
            context = new CinemaEntities();

            this.Load += MainForm_load;
            buttonTicket.Click += TicketForm_Init;
            buttonRegistration.Click += RegistrationForm_Init;
            buttonAddMovie.Click += AddMovieForm_Init;
            buttonBackup.Click += BackUp_Data;
        }
        private void BackUp_Data(object sender, EventArgs e)
        {
            Backup_Customer();
            Backup_Hall();
            Backup_Movie();
            Backup_Order();
            Backup_OrdersSnacks();
            Backup_Schedule();
            Backup_SeatsOrders();
            MessageBox.Show("Backup success !");
        }

        private void Backup_Customer()
        {
            var query = context.Customers.ToList();
            FileInfo file = new FileInfo("..\\..\\customers" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Customer>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_Hall()
        {
            var query = context.Halls.ToList();
            FileInfo file = new FileInfo("..\\..\\halls" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Hall>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_Movie()
        {
            var query = context.Movies.ToList();
            FileInfo file = new FileInfo("..\\..\\movies" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Movie>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_Order()
        {
            var query = context.Orders.ToList();
            FileInfo file = new FileInfo("..\\..\\orders" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Order>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_OrdersSnacks()
        {
            var query = context.OrdersSnacks.ToList();
            FileInfo file = new FileInfo("..\\..\\ordersSnacks" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<OrdersSnack>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_Schedule()
        {
            var query = context.Schedules.ToList();
            FileInfo file = new FileInfo("..\\..\\schedules" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Schedule>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void Backup_SeatsOrders()
        {
            var query = context.SeatsOrders.ToList();
            FileInfo file = new FileInfo("..\\..\\seatsOrders" + ".xml");
            StreamWriter sw = file.AppendText();
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<SeatsOrder>));
            writer.Serialize(sw, query);
            sw.Close();
        }
        private void MainForm_load(object sender, EventArgs e)
        {
            context.Database.Log = (s => Debug.Write(s));

        }
        private void TicketForm_Init(object sender, EventArgs e)
        {
            Ticket ticketForm = new Ticket(context);

            ticketForm.Show();
        }
        private void RegistrationForm_Init(object sender, EventArgs e)
        {
            MemberRegistration registrationForm = new MemberRegistration(context);
            //registrationForm.button
            registrationForm.Show();
        }
        private void AddMovieForm_Init(object sender, EventArgs e)
        {
            AddMovie registrationForm = new AddMovie(context);
            registrationForm.Show();
        }
    }
}
