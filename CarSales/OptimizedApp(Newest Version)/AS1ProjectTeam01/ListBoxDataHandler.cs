using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    public class ListBoxDataHandler :LINQGenerator
    {
        public IOrderedEnumerable<Car> SortInitialList(List<Car> inputList)
        {
            // Sort all cars by Make, Price, Year and Color
            var tempSorted = from car in inputList
                             orderby car.Make, car.Year, car.Color, car.Dealer
                             select car;
            return tempSorted;
        }


        
        public void ApplyDataToAllListBox(List<Car> inputList, 
             ListBox ListBoxMakes,  ListBox ListBoxColors,
             ListBox ListBoxYears,  ListBox ListBoxDealers)
        {
          
            ListBoxMakes.DataSource = CovertToListBoxData("Make",inputList);
            
            ListBoxColors.DataSource = CovertToListBoxData("Color", inputList);
            
            ListBoxYears.DataSource = CovertToListBoxData("Year", inputList);

            ListBoxDealers.DataSource = CovertToListBoxData("Dealer", inputList);

        }

       
    }
}
