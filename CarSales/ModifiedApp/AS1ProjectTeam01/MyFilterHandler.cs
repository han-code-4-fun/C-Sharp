using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    //public class MyFilterHandler
    //{
    //    private List<string> _selectedYearList = new List<string>();
    //    private List<string> _selectedColorList = new List<string>();
    //    private List<string> _selectedMakeList = new List<string>();
    //    private List<string> _selectedDealerList = new List<string>();
    //    private IEnumerable<Car> query;

    //    TextBoxHandler tbHanlder = new TextBoxHandler();

    //    public MyFilterHandler(List<string> selectedYearList, List<string> selectedColorList,
    //        List<string> selectedMakeList, List<string> selectedDealerList)
    //    {
    //        _selectedYearList = selectedYearList;
    //        _selectedColorList = selectedColorList;
    //        _selectedMakeList = selectedMakeList;
    //        _selectedDealerList = selectedDealerList;
    //    }

    //    public void FilterHandler(object sender, EventArgs e)
    //    {
    //        ListBox triggeredLists = sender as ListBox;

    //        if (triggeredLists != null)
    //        {
    //            string name = triggeredLists.Name;
    //            switch (name)
    //            {
    //                case "ListBoxYears":
    //                    _selectedYearList = ListBoxControl.UpdateSelectItem(triggeredLists);
    //                    break;
    //                case "ListBoxColors":
    //                    _selectedColorList = ListBoxControl.UpdateSelectItem(triggeredLists);
    //                    break;
    //                case "ListBoxMakes":
    //                    _selectedMakeList = ListBoxControl.UpdateSelectItem(triggeredLists);
    //                    break;
    //                case "ListBoxDealers":
    //                    _selectedDealerList = ListBoxControl.UpdateSelectItem(triggeredLists);
    //                    break;



    //            }
    //        }

    //        populateLowerTable(listCars, searchPrice, searchEngineSize, txtMinPrice);
    //    }

    //    public void populateLowerTable(List<Car> listCars, CheckBox searchPrice, CheckBox searchEngineSize,
    //        TextBox txtMinPrice, TextBox txtMaxPrice, TextBox txtMinEngineSize, TextBox txtMaxEngineSize,
    //        DataGridView dataSelectedCars, Label labelAverageSelected, Label labelCountSelected)
    //    {
           
    //        // Query all selected options
    //        query = listCars.Where(car => (
    //        _selectedYearList.Contains(car.Year.ToString()))
    //        && (_selectedColorList.Contains(car.Color))
    //        && (_selectedDealerList.Contains(car.Dealer))
    //        && (_selectedMakeList.Contains(car.Make))
    //        ).OrderBy(car => car.Make).ThenBy(car => car.Year).ThenBy(car => car.Color).ThenBy(car => car.Dealer);
    //        // Query price if checked
    //        if (searchPrice.Checked)
    //        {
    //            // Validate input before process query
    //            if (tbHanlder.TxtBoxValidation(searchPrice, txtMinPrice, txtMaxPrice))
    //            {
    //                query = query.Where(car =>
    //                  (decimal)car.Price <= decimal.Parse(txtMaxPrice.Text)
    //                  && (decimal)car.Price >= decimal.Parse(txtMinPrice.Text));
    //            }

    //        }

    //        // Query Engine size if checked
    //        if (searchEngineSize.Checked)
    //        {
    //            // Validate input before process query
    //            if (tbHanlder.TxtBoxValidation(searchEngineSize, txtMinEngineSize, txtMaxEngineSize))
    //            {
    //                query = query.Where(car => (decimal)car.EngineSize <= decimal.Parse(txtMaxEngineSize.Text)
    //                  && (decimal)car.EngineSize >= decimal.Parse(txtMinEngineSize.Text));
    //            }

    //        }


    //        PrepareTable.ApplyDataToTable(PrepareTable.CreateDataTable(query), dataSelectedCars);


    //        Calculation.CalculateSelectedDataList(query, labelAverageSelected, labelCountSelected);
          
    //    }
    //}
}
