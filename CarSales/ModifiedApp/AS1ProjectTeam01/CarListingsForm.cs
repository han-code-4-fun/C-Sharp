using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace AS1ProjectTeam01
{
    public class EventHandler
    {

    }
  
    public partial class CarListingsForm : Form
    {
        //save xml to this list
        private List<Car> listCars;

        // Init list string to hold list of selections
        private List<string> selectedYearList = new List<string>();
        private List<string> selectedMakeList = new List<string>();
        private List<string> selectedColorList = new List<string>();
        private List<string> selectedDealerList = new List<string>();

        FileLoader carLoader = new FileLoader();

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


        public void SelectAllListboxes()
        {
            SelectAllOptionsInOneListBox(ListBoxMakes);
            selectedMakeList = UpdateSelectItem(ListBoxMakes);

            SelectAllOptionsInOneListBox(ListBoxColors);
            selectedColorList = UpdateSelectItem(ListBoxColors);

            SelectAllOptionsInOneListBox(ListBoxYears);
            selectedYearList = UpdateSelectItem(ListBoxYears);

            SelectAllOptionsInOneListBox(ListBoxDealers);
            selectedDealerList = UpdateSelectItem(ListBoxDealers);
        }

        public void SelectAllOptionsInOneListBox(ListBox list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetSelected(i, true);
            }
        }

        private void FilterHandler(object sender, EventArgs e)
        {
            ListBox triggeredLists = sender as ListBox;

            if (triggeredLists != null)
            {
                string name = triggeredLists.Name;
                switch (name)
                {
                    case "ListBoxYears":
                        selectedYearList = UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxColors":
                        selectedColorList = UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxDealers":
                        selectedDealerList = UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxMakes":
                        selectedMakeList = UpdateSelectItem(triggeredLists);
                        break;

                }
            }

            populateLowerTable();
        }

        public List<string> UpdateSelectItem(ListBox triggeredLists)
        {
            List<string> tempList = new List<String>();
            for (int i = 0; i < triggeredLists.SelectedItems.Count; i++)
            {
                string temp = triggeredLists.SelectedItems[i].ToString();
                tempList.Add(temp);
            }
            return tempList;
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
            
            
            ApplyDataToTable(CreateDataTable(query), dataSelectedCars);


            CalculateSelectedDataList();
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
            carLoader.GetXmlCarListingsSerialize(ref listCars, ref query);


            // Setting up and format UI
            SetDataGridView(dataAllCars);
            SetDataGridView(dataSelectedCars);
            
            ApplyDataToTable(CreateDataTable(listCars), dataAllCars);
            ApplyDataToTable(CreateDataTable(query), dataSelectedCars);

            ApplyDataToListBox();

            SelectAllListboxes();
            
            resetButton.Click += Reset;

            RegisterEventHandler();

            populateLowerTable();
            
        }

        public void ApplyDataToListBox()
        {
            //select data from the listCars
            var makesList = listCars
                .GroupBy(car => car.Make)
                .Select(car => car.First())
                .OrderBy(car => car.Make)
                .Select(car => car.Make.ToString());

            ListBoxMakes.DataSource = makesList.ToList();

            // Query Colors list
            var colorsList = listCars
                .GroupBy(car => car.Color)
                .Select(car => car.First())
                .OrderBy(car => car.Color)
                .Select(car => car.Color.ToString());

            ListBoxColors.DataSource = colorsList.ToList();
         
      
            // Query Years list
            var yearsList = listCars
                .GroupBy(car => car.Year)
                .Select(car => car.First())
                .OrderBy(car => car.Year)
                .Select(car => car.Year.ToString());
            ListBoxYears.DataSource = yearsList.ToList();
       
        
            // Query Dealers list
            var dealersList = listCars
                .GroupBy(car => car.Dealer.ToString())
                .Select(car => car.First())
                .OrderBy(car => car.Dealer)
                .Select(car => car.Dealer.ToString());
            ListBoxDealers.DataSource = dealersList.ToList();

            SelectAllListboxes();
        }


       

        public void SetDataGridView(DataGridView gridView)
        {
            gridView.Columns.Clear(); // any columns created by the designer, get rid of them
            gridView.ReadOnly = true; // no cell editing allowed
            gridView.AllowUserToAddRows = false; // no rows can be added or deleted
            gridView.AllowUserToDeleteRows = false;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridView.RowHeadersVisible = false;
            gridView.AutoSize = false; // don't autosize the cells
                                       // right justify everything
            gridView.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }



        public void CalculateSelectedDataList()
        {
            if (query.Count() > 0)
            {
                var average = query.Select(car => car.Price).Average();
                labelAverageSelected.Text = average.ToString("C2");
            }
            else
            {
                labelAverageSelected.Text = 0.ToString("C2");
            }
            labelCountSelected.Text = query.Count().ToString();
        }

        
        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static void ApplyDataToTable(DataTable input, DataGridView tableToShow)
        {
            tableToShow.DataSource = input;
            tableToShow.Columns["Price"].DefaultCellStyle.Format = "c";
        }
    }
}
