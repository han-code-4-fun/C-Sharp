using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;



namespace AS1ProjectTeam01
{

   // public delegate void myEventDelegate(object sender, EventArgs e);



    public partial class CarListingsForm : Form
    {
       
        FileLoader carLoader = new FileLoader();
        ListBoxDataHandler myLBData = new ListBoxDataHandler();
        GlobalVariable myGB = new GlobalVariable();
        
      

        public CarListingsForm(ref GlobalVariable inputGB)
        {
            myGB = inputGB;

            InitializeComponent();

            MyListBoxControl.LinkFormToControl(this);

            InitLoad();

            BringToTop();
            
        }

        
        #region Bring form to top
        public void BringToTop()
        {
            // Show the current form
            this.Show();
            // Keeps the current topmost status of form
            bool top = TopMost;
            // Brings the form to top
            TopMost = true;
            // Set form's topmost status back to whatever it was
            TopMost = top;
        }
        #endregion

        public void InitLoad()
        {
            //load xml to list of cars
            myGB.listCars = carLoader.OpenFile(myGB.listCars);
            myGB.query = myGB.listCars;


            // Setting up and format UI
            PrepareTable.SetDataGridView(dataAllCars);
            PrepareTable.SetDataGridView(dataSelectedCars);

            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(myGB.listCars), dataAllCars);
            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(myGB.query), dataSelectedCars);

            myLBData.ApplyDataToAllListBox(myGB.listCars,  ListBoxMakes, 
                 ListBoxColors,  ListBoxYears,  ListBoxDealers);

            MyListBoxControl.SelectAllListboxesAndUpdateToMyLists(myGB);
            

            populateLowerTable();
            
        }

        public void populateLowerTable()
        {


            myGB.query = myLBData.QuerySelectedCars(myGB);

            // Query price if checked
            if (searchPrice.Checked)
            {
                // Validate input before process query
                if (TextBoxHandler.TxtBoxValidation(searchPrice, txtMinPrice, txtMaxPrice))
                {
                    myGB.query = myGB.query.Where(car =>
                      car.Price <= decimal.Parse(txtMaxPrice.Text)
                      && car.Price >= decimal.Parse(txtMinPrice.Text));
                }

            }

            // Query Engine size if checked
            if (searchEngineSize.Checked)
            {
                // Validate input before process query
                if (TextBoxHandler.TxtBoxValidation(searchEngineSize, txtMinEngineSize, txtMaxEngineSize))
                {
                    myGB.query = myGB.query
                        .Where(car => car.EngineSize <= decimal.Parse(txtMaxEngineSize.Text)
                      && car.EngineSize >= decimal.Parse(txtMinEngineSize.Text));
                }

            }


            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(myGB.query), dataSelectedCars);

            Calculation.CalculateSelectedDataList(myGB.query, labelAverageSelected, labelCountSelected);
            Calculation.CalculateSelectedDataList(myGB.listCars, labelAveragePriceAll, labelCountAll);
        }





    }
}
