
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AS1ProjectTeam01
{
    public class XMLLoaderAndSorter
    {
        XMLoader myXMLloader = new XMLoader();
        LINQHandler myLINQ = new LINQHandler();
        public List<Car> LoadXMLAndSort(string fileName, List<Car> listCars)
        {
            listCars = myXMLloader.LoadXML("ArrayOfCar", fileName, listCars);

            listCars = myLINQ.SortInitialList(listCars).ToList();
           
            return listCars;
        }
    }
}
