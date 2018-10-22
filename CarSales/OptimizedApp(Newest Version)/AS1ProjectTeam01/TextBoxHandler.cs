using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static public class TextBoxHandler
    {
        static public bool TxtBoxValidation(CheckBox checkbox, TextBox minTxt, TextBox maxTxt)
        {
            // handle input of empty, letter, or min value greater than max value
            try
            {
                decimal min = decimal.Parse(minTxt.Text);
                decimal max = decimal.Parse(maxTxt.Text);
                if (min > max)
                {
                    return errorForTxtBox(checkbox, "minmax");
                }
            }
            catch 
            {
                return errorForTxtBox(checkbox);
            }


            return true;

        }


        static public bool errorForTxtBox(CheckBox checkbox, string input = "")
        {
            //if error, display error MSG and uncheck checkbox
            if (input == "minmax")
            {
                MessageCenter.ErrorTBoxMinOverMax();
            }
            else
            {
                MessageCenter.ErrorTBoxEmptyOrNaN();
            }

            checkbox.Checked = false;
            return false;
        }
    }
}
