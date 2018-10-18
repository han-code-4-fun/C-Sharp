using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AS1ProjectTeam01
{
    public class XMLoader
    {
        public List<Car> LoadXML(string rootElement, string fileName, List<Car> inputListObj)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = rootElement; //"ArrayOfCar";
            xRoot.IsNullable = true;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Car>), xRoot);
            StreamReader thisFile = new StreamReader(fileName);
            inputListObj = xmlFormat.Deserialize(thisFile) as List<Car>;

            return inputListObj;
        }
    }
}
