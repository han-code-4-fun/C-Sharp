using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AS1ProjectTeam01
{
    public class FileLoader
    {
        //private List<Car> listCars;
        //IEnumerable<Car> query = null;

        public void GetXmlCarListingsSerialize(ref List<Car> listCars, ref IEnumerable<Car> query)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    load(fileName, ref listCars, ref query);
                }
                else
                {
                    
                   MessageBox.Show("You didn't select a file, goodbye!");
                   Environment.Exit(1);

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }



        public void load(string fileName, ref List<Car> listCars, ref IEnumerable<Car> query)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "ArrayOfCar";
            xRoot.IsNullable = true;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Car>), xRoot);
            StreamReader carsFile = new StreamReader(fileName);
            listCars = xmlFormat.Deserialize(carsFile) as List<Car>;

            // Sort all cars by Make, Price, Year and Color
            var carsSorted = from car in listCars
                             orderby car.Make, car.Year, car.Color, car.Dealer
                             select car;
            listCars = carsSorted.ToList();
            query = listCars;
        }

    }
}
