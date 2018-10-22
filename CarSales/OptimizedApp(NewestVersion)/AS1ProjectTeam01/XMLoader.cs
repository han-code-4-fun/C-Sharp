using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AS1ProjectTeam01
{
    static public class XMLoader
    {
        static public List<T> LoadXML<T>(string rootElement, string fileName, List<T> inputList)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = rootElement; 
            xRoot.IsNullable = true;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<T>), xRoot);
            StreamReader thisFile = new StreamReader(fileName);
            inputList = xmlFormat.Deserialize(thisFile) as List<T>;

            return inputList;
        }
    }
}
