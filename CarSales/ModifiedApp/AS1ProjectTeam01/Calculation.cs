using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static public class Calculation 
    {

        static public void CalculateSelectedDataList(IEnumerable<Car> query, 
            Label labelAverageSelected, Label labelCountSelected)
        {
            if (query.Count() > 0)
            {
                var average = query.Select(car => car.Price).Average();
                labelAverageSelected.Text = average.ToString("C2");
            }
            else
            {
                labelAverageSelected.Text = 0.ToString("C2");
            }
            labelCountSelected.Text = query.Count().ToString();
        }
    }
}
