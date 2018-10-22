using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AS1ProjectTeam01
{
    public class LINQGenerator
    {
        public object GetPropertyValue(object obj, string inputProperty)
        {
            PropertyInfo pi = obj.GetType().GetProperty(inputProperty);
            return pi.GetValue(obj, null);
        }

        public IEnumerable<string> CovertToListBoxData(string filter, List<Car> listCars)
        {
            var tempList = (from element in listCars
                            orderby GetPropertyValue(element, filter)
                            select GetPropertyValue(element, filter).ToString()).Distinct();
            return tempList.ToList();
        }

        public IEnumerable<Car> QuerySelectedCars(GlobalVariable myGB)
        {
            myGB.query = myGB.listCars.Where(car => (
                    myGB.selectedYearList.Contains(car.Year.ToString()))
                    && (myGB.selectedColorList.Contains(car.Color))
                    && (myGB.selectedDealerList.Contains(car.Dealer))
                    && (myGB.selectedMakeList.Contains(car.Make))
                    ).OrderBy(car => car.Make)
                    .ThenBy(car => car.Year)
                    .ThenBy(car => car.Color)
                    .ThenBy(car => car.Dealer);
            return myGB.query;
        }


    }
}
