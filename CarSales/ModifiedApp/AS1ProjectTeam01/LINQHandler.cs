using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    public class LINQHandler
    {
        public IOrderedEnumerable<Car> SortInitialList(List<Car> inputList)
        {
            // Sort all cars by Make, Price, Year and Color
            var tempSorted = from car in inputList
                             orderby car.Make, car.Year, car.Color, car.Dealer
                             select car;
            return tempSorted;
        }


        //this one is terrible, need to improve later
        public void ApplyDataToListBox(List<Car> inputList, 
            ref ListBox ListBoxMakes, ref ListBox ListBoxColors,
            ref ListBox ListBoxYears, ref ListBox ListBoxDealers)
        {
            //select data from the listCars
            var makesList = inputList
                .GroupBy(car => car.Make)
                .Select(car => car.First())
                .OrderBy(car => car.Make)
                .Select(car => car.Make.ToString());

            ListBoxMakes.DataSource = makesList.ToList();

            // Query Colors list
            var colorsList = inputList
                .GroupBy(car => car.Color)
                .Select(car => car.First())
                .OrderBy(car => car.Color)
                .Select(car => car.Color.ToString());

            ListBoxColors.DataSource = colorsList.ToList();


            // Query Years list
            var yearsList = inputList
                .GroupBy(car => car.Year)
                .Select(car => car.First())
                .OrderBy(car => car.Year)
                .Select(car => car.Year.ToString());
            ListBoxYears.DataSource = yearsList.ToList();


            // Query Dealers list
            var dealersList = inputList
                .GroupBy(car => car.Dealer.ToString())
                .Select(car => car.First())
                .OrderBy(car => car.Dealer)
                .Select(car => car.Dealer.ToString());
            ListBoxDealers.DataSource = dealersList.ToList();

        }
    }
}
