using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static public class MessageCenter
    {
        static public void ErrorTBoxMinOverMax()
        {
            MessageBox.Show("minimum value should be smaller than maximum value");
        }
        static public void ErrorTBoxEmptyOrNaN()
        {
            MessageBox.Show("Textbox is empty or is not a number");
        }
        

    }
}
