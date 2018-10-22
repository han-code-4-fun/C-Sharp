
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AS1ProjectTeam01
{
    public class XMLLoaderAndSorter : ListBoxDataHandler
    {
      
        public List<Car> LoadXMLAndSort(string fileName, List<Car> listCars)
        {
            listCars = XMLoader.LoadXML("ArrayOfCar", fileName, listCars);

            listCars = SortInitialList(listCars).ToList();
           
            return listCars;
        }
    }
}
