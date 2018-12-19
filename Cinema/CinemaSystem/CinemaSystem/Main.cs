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

        // Load all database tables
        
        public Main()
        {
            InitializeComponent();
            buttonReport.Visible = false;
            buttonBackup.Visible = false;

            
            // Init Entity Framework
            InitializeEntities();

            LoadForms();


        }

        private void InitializeEntities()
        {
            context = new CinemaEntities();

            context.Schedules.Load();

            context.Halls.Load();

            context.Movies.Load();

            context.Orders.Load();

            context.Customers.Load();

            context.OrdersSnacks.Load();

            context.SeatsOrders.Load();

            context.Snacks.Load();
        }

        private void LoadForms()
        {
            this.Load += MainForm_load;
            buttonTicket.Click += TicketForm_Init;
            buttonRegistration.Click += RegistrationForm_Init;
            buttonAddMovie.Click += AddMovieForm_Init;
            buttonReport.Click += OpenReportForm;
            buttonSwitch.Click += EnterAdmin;
            buttonBackup.Click += BackUp_Data;
        }


        //back up database
        private void BackUp_Data(object sender, EventArgs e)
        {
            
            Backup myBackup = new Backup(context);
            myBackup.runBackup();
        }
        

        // run this method when this for loaded
        private void MainForm_load(object sender, EventArgs e)
        {
            context.Database.Log = (s => Debug.Write(s));

        }


        //open ticket form
        private void TicketForm_Init(object sender, EventArgs e)
        {
            Ticket ticketForm = new Ticket(context);

            ticketForm.Show();
        }


        //open registeration form
        private void RegistrationForm_Init(object sender, EventArgs e)
        {
            MemberRegistration registrationForm = new MemberRegistration(context);
            //registrationForm.button
            registrationForm.Show();
        }

        //open add movie form
        private void AddMovieForm_Init(object sender, EventArgs e)
        {
            AddMovie registrationForm = new AddMovie(context);
            registrationForm.Show();
        }


        //open report
        private void OpenReportForm(object sender, EventArgs e)
        {
            Report myReport = new Report(context);
            myReport.Show();
        }


        //open password form for showing report button
        private void EnterAdmin(object sender, EventArgs e)
        {
            AdminPasswd myPasswd = new AdminPasswd(buttonReport, buttonBackup);
            myPasswd.Show();
        }
       
    }
}
