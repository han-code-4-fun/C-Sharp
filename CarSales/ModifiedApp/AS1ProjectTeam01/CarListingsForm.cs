using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;



namespace AS1ProjectTeam01
{
   

    public partial class CarListingsForm : Form
    {
        //save xml to this list
        private List<Car> listCars;

        // Init list string to hold list of selections
        private List<string> selectedYearList = new List<string>();
        private List<string> selectedColorList = new List<string>();
        private List<string> selectedMakeList = new List<string>();
        private List<string> selectedDealerList = new List<string>();

        FileLoader carLoader = new FileLoader();
        LINQHandler myLinq = new LINQHandler();


        //global LINQ 
        IEnumerable<Car> query = null;
        



        public CarListingsForm()
        {
            
            InitializeComponent();

            InitLoad();

            BringToTop();
            
        }



        public void Reset(object sender, EventArgs e)
        {
            ResetCheckBoxes();
            ResetToDefault();
        }

        public void ResetCheckBoxes()
        {
            // Set search checkbox to false
            searchPrice.Checked = false;
            searchEngineSize.Checked = false;
            // Set textbox to empty
            txtMaxEngineSize.Text = "";
            txtMinEngineSize.Text = "";
            txtMaxPrice.Text = "";
            txtMinPrice.Text = "";
        }


        public void ResetToDefault()
        {

            unRegisterEventHandler();

            RegisterEventHandler();

            // Select all options AND update their relative List<string> 
            SelectAllListboxes();

            populateLowerTable();
        }

        public void unRegisterEventHandler()
        {
            ListBoxYears.SelectedIndexChanged -= FilterHandler;
            ListBoxColors.SelectedIndexChanged -= FilterHandler;
            ListBoxMakes.SelectedIndexChanged -= FilterHandler;
            ListBoxDealers.SelectedIndexChanged -= FilterHandler;
            
            searchEngineSize.CheckedChanged += FilterHandler;
            searchPrice.CheckedChanged += FilterHandler;
            txtMinPrice.TextChanged += FilterHandler;
            txtMaxPrice.TextChanged += FilterHandler;
            txtMinEngineSize.TextChanged += FilterHandler;
            txtMaxEngineSize.TextChanged += FilterHandler;
        }

        public void RegisterEventHandler()
        {
            ListBoxYears.SelectedIndexChanged += FilterHandler;
            ListBoxColors.SelectedIndexChanged += FilterHandler;
            ListBoxMakes.SelectedIndexChanged += FilterHandler;
            ListBoxDealers.SelectedIndexChanged += FilterHandler;
            
            searchEngineSize.CheckedChanged += FilterHandler;
            searchPrice.CheckedChanged += FilterHandler;
            txtMinPrice.TextChanged += FilterHandler;
            txtMaxPrice.TextChanged += FilterHandler;
            txtMinEngineSize.TextChanged += FilterHandler;
            txtMaxEngineSize.TextChanged += FilterHandler;
        }


        public void FilterHandler(object sender, EventArgs e)
        {
            ListBox triggeredLists = sender as ListBox;

            if (triggeredLists != null)
            {
                string name = triggeredLists.Name;
                switch (name)
                {
                    case "ListBoxYears":
                        selectedYearList = ListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxColors":
                        selectedColorList = ListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxDealers":
                        selectedDealerList = ListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxMakes":
                        selectedMakeList = ListBoxControl.UpdateSelectItem(triggeredLists);
                        break;

                }
            }

            populateLowerTable();
        }

        public void SelectAllListboxes()
        {
            ListBoxControl.SelectAllOptionsInOneListBox(ListBoxMakes);
            selectedMakeList = ListBoxControl.UpdateSelectItem(ListBoxMakes);

            ListBoxControl.SelectAllOptionsInOneListBox(ListBoxColors);
            selectedColorList = ListBoxControl.UpdateSelectItem(ListBoxColors);

            ListBoxControl.SelectAllOptionsInOneListBox(ListBoxYears);
            selectedYearList = ListBoxControl.UpdateSelectItem(ListBoxYears);

            ListBoxControl.SelectAllOptionsInOneListBox(ListBoxDealers);
            selectedDealerList = ListBoxControl.UpdateSelectItem(ListBoxDealers);
        }

     

        public void populateLowerTable()
        {
            // Query all selected options
            query = listCars.Where(car => (
            selectedYearList.Contains(car.Year.ToString()))
            && (selectedColorList.Contains(car.Color))
            && (selectedDealerList.Contains(car.Dealer))
            && (selectedMakeList.Contains(car.Make))
            ).OrderBy(car => car.Make).ThenBy(car => car.Year).ThenBy(car => car.Color).ThenBy(car => car.Dealer);
            // Query price if checked
            if (searchPrice.Checked)
            {
                // Validate input before process query
                if (TxtBoxValidation(searchPrice, txtMinPrice, txtMaxPrice))
                {
                    query = query.Where(car =>
                      (decimal)car.Price <= decimal.Parse(txtMaxPrice.Text)
                      && (decimal)car.Price >= decimal.Parse(txtMinPrice.Text));
                }

            }

            // Query Engine size if checked
            if (searchEngineSize.Checked)
            {
                // Validate input before process query
                if (TxtBoxValidation(searchEngineSize, txtMinEngineSize, txtMaxEngineSize))
                {
                    query = query.Where(car => (decimal)car.EngineSize <= decimal.Parse(txtMaxEngineSize.Text)
                      && (decimal)car.EngineSize >= decimal.Parse(txtMinEngineSize.Text));
                }

            }


            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(query), dataSelectedCars);


            Calculation.CalculateSelectedDataList(query, labelAverageSelected, labelCountSelected);
            Calculation.CalculateSelectedDataList(listCars, labelAveragePriceAll, labelCountAll);
        }

        public bool TxtBoxValidation(CheckBox checkbox, TextBox minTxt, TextBox maxTxt)
        {
            // try parse string to decimal
            try
            {
                decimal min = decimal.Parse(minTxt.Text);
                decimal max = decimal.Parse(maxTxt.Text);
                if (min > max)
                {
                    return errorForTxtBox(checkbox, "minmax");
                }
            }
            catch (Exception e)
            {
                return errorForTxtBox(checkbox);
            }


            return true;

        }


        public bool errorForTxtBox(CheckBox checkbox, string input = "")
        {
            string print;
            if (input == "minmax")
            {
                print = "minimum value should be smaller than maximum value";
            }
            else
            {
                print = "Textbox is empty or is not a number";
            }
            MessageBox.Show(print);
            checkbox.Checked = false;
            return false;
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
            listCars = carLoader.OpenFile(listCars);
            query = listCars;


            // Setting up and format UI
            PrepareTable.SetDataGridView(dataAllCars);
            PrepareTable.SetDataGridView(dataSelectedCars);

            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(listCars), dataAllCars);
            PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(query), dataSelectedCars);

            myLinq.ApplyDataToListBox(listCars, ref ListBoxMakes, 
                ref ListBoxColors, ref ListBoxYears, ref ListBoxDealers);

            SelectAllListboxes();
            
            resetButton.Click += Reset;

            RegisterEventHandler();


            populateLowerTable();
            
        }

        


    
    }
}
