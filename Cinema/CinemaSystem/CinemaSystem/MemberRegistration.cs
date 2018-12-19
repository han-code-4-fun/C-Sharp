using System;
using System.Diagnostics;
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

        public MemberRegistration()
        {
        }

        private void registerCustomer()
        {
            if(CheckEmpty())
            {
                if(CheckNumber())
                {
                    if(CheckEmailFormat())
                    {

                        //extract textbox string
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
                        
                        //add string to our entities
                        context.Customers.Add(newCust);

                        //update entities contextes
                        context.SaveChanges();
                        clearTexboxes();
                        MessageBox.Show("You have SUCCESSFULLY registered customer");


                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all textboxes");
            }
        }


        //check if all fields are entered
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


        //check if user enter number for phone number
        private bool CheckNumber()
        {
            try
            {
                if(textBoxPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please enter 10 digits number");
                    return false;
                }else
                {
                    long temp = long.Parse(textBoxPhone.Text);
                }

                return true;
            }
            catch(FormatException e)
            {
                MessageBox.Show("Please enter purely numbers");
                return false;
            }
        }


        //check if user enter correct email format
        private bool CheckEmailFormat()
        {
            string temp = textBoxEmail.Text;


            //user may pass the CheckEmailSymbol test if
            //they entered 1 '@', but it cannot be 
            //at the beginning and at the end
            if (temp.EndsWith("@") == false &&
                CheckEmailSymbol(temp) &&
                temp.StartsWith("@") == false)
            {
                return true;
            }
            MessageBox.Show("Please enter a valid email");
            return false;
        }


        //check if the string contains 1 '@' for email input
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


        //reset textboxes
        private void clearTexboxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
        }

    }
}
