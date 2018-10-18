using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    public class TextBoxHandler
    {
        public bool TxtBoxValidation(CheckBox checkbox, TextBox minTxt, TextBox maxTxt)
        {
            // try parse string to decimal
            try
            {
                decimal min = decimal.Parse(minTxt.Text);
                decimal max = decimal.Parse(maxTxt.Text);
                if (min > max)
                {
                    return errorForTxtBox(checkbox, "minmax");
                }
            }
            catch (Exception e)
            {
                return errorForTxtBox(checkbox);
            }


            return true;

        }


        public bool errorForTxtBox(CheckBox checkbox, string input = "")
        {
            string print;
            if (input == "minmax")
            {
                print = "minimum value should be smaller than maximum value";
            }
            else
            {
                print = "Textbox is empty or is not a number";
            }
            MessageBox.Show(print);
            checkbox.Checked = false;
            return false;
        }
    }
}
