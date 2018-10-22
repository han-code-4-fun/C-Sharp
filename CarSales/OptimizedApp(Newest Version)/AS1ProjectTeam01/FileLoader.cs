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
        XMLLoaderAndSorter myXML = new XMLLoaderAndSorter();
        public List<Car> OpenFile(List<Car> listCars)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                    Filter = "xml files | *.xml"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    listCars = myXML.LoadXMLAndSort(fileName, listCars);
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
            return listCars;
            
        }



    }
}
