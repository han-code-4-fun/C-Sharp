
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
    public partial class AdminPasswd : Form
    {
        //this is a popup form for user to enter password 
        //in order to access the report and back up function


        
        private const string passwd = "1234";

        //global button
        Button a1, a2;

        //passing report and backup button for latter use
        public AdminPasswd(Button b1,Button b2)
        {
            a1 = b1;
            a2 = b2;
            InitializeComponent();
        }

        private void buttonEnterPasswd_Click(object sender, EventArgs e)
        {
            //if password matches, show the report and back up button
            if(textBoxPasswd.Text == "1234")
            {
                a1.Visible = true;
                a2.Visible = true;
                this.Close();
                 
            }else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
