using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static class CarListingsProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalVariable myGBV = new GlobalVariable();

            CarListingsForm myForm = new CarListingsForm(ref myGBV);

            //reference form to event
            FormEvents myEvent = new FormEvents(myForm, ref myGBV);

            Application.Run(myForm);
        }
    }
}
