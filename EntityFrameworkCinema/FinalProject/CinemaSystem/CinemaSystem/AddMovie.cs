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
    public partial class AddMovie : Form
    {
        CinemaEntities context;
        public AddMovie(CinemaEntities cinemaContext)
        {
            context = cinemaContext;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            registerMovie();
        }

        private void registerMovie()
        {
            if(ISAllEntered())
            {
                if(IntCheck() && DecimalCheck())
                {
                    int temp;
                    int.TryParse(textBoxMovieDuration.Text, out temp);

                    Movie addM = new Movie
                    {
                        Name = textBoxMovieName.Text,
                        Description = textBoxMovieDescription.Text,
                        Duration_Minutes = int.Parse(textBoxMovieDuration.Text),
                        InitialPrice = decimal.Parse(textBoxMoviePrice.Text),
                        Director = textBoxMovieDirector.Text

                    };

                    context.Movies.Add(addM);

                    context.SaveChanges();

                    MessageBox.Show("You added a movie: " + textBoxMovieName.Text);
                    CleanText();
                }
               
            }
            else
            {
                MessageBox.Show("Please enter informations to all textboxes");
            }
            



        }
        private void CleanText()
        {
            textBoxMovieName.Text = "";
            textBoxMovieDescription.Text = "";
            textBoxMovieDuration.Text = "";
            textBoxMoviePrice.Text = "";
            textBoxMovieDirector.Text = "";
        }
        private void ValidateInput()
        {

        }

        private bool ISAllEntered()
        {
            if (textBoxMovieName.Text == "" ||
            textBoxMovieDescription.Text == ""||
            textBoxMovieDuration.Text == ""||
            textBoxMoviePrice.Text == "" ||
            textBoxMovieDirector.Text == "")
            {
                
                return false;
            }
            return true;
        }

        private bool IntCheck()
        {
            try
            {
                int temp = int.Parse(textBoxMovieDuration.Text);
                return true;
            }
            catch(FormatException e)
            {
                MessageBox.Show("Please enter an integer");
                return false;
            }
           

        }
        private bool DecimalCheck()
        {
            try
            {
                decimal temp = decimal.Parse(textBoxMoviePrice.Text);
                return true;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Please enter a number");
                return false;
            }
        }
    }
}
