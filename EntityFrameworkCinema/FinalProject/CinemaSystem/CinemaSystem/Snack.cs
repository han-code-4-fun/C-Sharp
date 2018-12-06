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
    public partial class Snack : Form
    {
        CinemaEntities context;

        public Snack(CinemaEntities cinemaContext)
        {
            this.context = cinemaContext;
            InitializeComponent();
        }
    }
}
