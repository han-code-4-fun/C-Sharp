
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
        private const string passwd = "1234";
        Button a1, a2;

        public AdminPasswd(Button b1,Button b2)
        {
            a1 = b1;
            a2 = b2;
            InitializeComponent();
        }

        private void buttonEnterPasswd_Click(object sender, EventArgs e)
        {
            if(textBoxPasswd.Text == "1234")
            {
                a1.Visible = true;
                a2.Visible = true;
                this.Visible = false;
            }else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
