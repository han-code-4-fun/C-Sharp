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
namespace CinemaSystem
{
    public partial class Main : Form
    {
        CinemaEntities context;
        public Main()
        {
            InitializeComponent();
            buttonReport.Visible = false;
            buttonBackup.Visible = false;


            // Init Entity Framework
            context = new CinemaEntities();

            this.Load += MainForm_load;
            buttonTicket.Click += TicketForm_Init;
            buttonRegistration.Click += RegistrationForm_Init;
            buttonAddMovie.Click += AddMovieForm_Init;
            buttonReport.Click += OpenReportForm;
            buttonSwitch.Click += EnterAdmin;

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

        private void OpenReportForm(object sender, EventArgs e)
        {
            Report myReport = new Report(context);
            myReport.Show();
        }

        private void EnterAdmin(object sender, EventArgs e)
        {
            AdminPasswd myPasswd = new AdminPasswd(buttonReport, buttonBackup);
            myPasswd.Show();
        }
        
        
    }
}
