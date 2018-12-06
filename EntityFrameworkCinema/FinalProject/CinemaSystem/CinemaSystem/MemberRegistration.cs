using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem.EF_Class;

namespace CinemaSystem
{
    public partial class MemberRegistration : Form
    {
        CinemaEntities context;
        string fName, lName, number, email;

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registerCustomer();
        }

        public MemberRegistration(CinemaEntities cinemaContext)
        {
            context = cinemaContext;
            
            InitializeComponent();
        }
       
        private void registerCustomer()
        {
            if(CheckEmpty())
            {
                if(CheckNumber())
                {
                    if(CheckEmailFormat())
                    {
                        fName = textBoxFirstName.Text;
                        lName = textBoxLastName.Text;
                        email = textBoxEmail.Text;
                        number = textBoxPhone.Text;

                        Customer newCust = new Customer()
                        {
                            FirstName = fName,
                            LastName = lName,
                            Email = email,
                            Phone = number
                        };

                        context.Database.Log = (s => Debug.Write(s));

                        context.Customers.Add(newCust);

                        context.SaveChanges();
                    }else
                    {
                        MessageBox.Show("Please enter a valid email");
                    }
  
                }
                
            }
            else
            {
                MessageBox.Show("Please fill all textboxes");
            }

           

        }

        private bool CheckEmpty()
        {
            if(textBoxFirstName.Text =="" ||
                textBoxLastName.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxPhone.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool CheckNumber()
        {
            try
            {
                int temp = int.Parse(textBoxPhone.Text);
                return true;
            }
            catch(FormatException e)
            {
                MessageBox.Show("Please enter purely numbers");
                return false;
            }
                 
        }

        private bool CheckEmailFormat()
        {
            string temp = textBoxEmail.Text;

            if(temp.EndsWith("@") == false &&
                CheckEmailSymbol(temp) &&
                temp.StartsWith("@") == false)
            {
                return true;
            }
            return false;
        }

        private bool CheckEmailSymbol(string input)
        {
            int Count = 0;
            foreach(char c in input)
            {
                if(c.Equals('@'))
                {
                    Count++;
                }
                if (Count > 1)
                {
                    return false;
                }
            }
            if(Count == 0)
            {
                return false;
            }else
            {
                return true;
            }
            
            
           
        }

    }
}
