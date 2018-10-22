using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{

    public class FormEvents
    {
        private CarListingsForm inputForm;
        private GlobalVariable inputGBV;

        public FormEvents(CarListingsForm form, ref GlobalVariable GBVinForm)
        {
            inputForm = form;
            inputGBV = GBVinForm;
            inputForm.resetButton.Click += Reset;
            EventsOn();

        }

        public void EventsOn()
        {
            inputForm.ListBoxYears.SelectedIndexChanged += ListBoxHandler;
            inputForm.ListBoxColors.SelectedIndexChanged += ListBoxHandler;
            inputForm.ListBoxMakes.SelectedIndexChanged += ListBoxHandler;
            inputForm.ListBoxDealers.SelectedIndexChanged += ListBoxHandler;

            inputForm.searchEngineSize.CheckedChanged += ListBoxHandler;
            inputForm.searchPrice.CheckedChanged += ListBoxHandler;
            inputForm.txtMinPrice.TextChanged += ListBoxHandler;
            inputForm.txtMaxPrice.TextChanged += ListBoxHandler;
            inputForm.txtMinEngineSize.TextChanged += ListBoxHandler;
            inputForm.txtMaxEngineSize.TextChanged += ListBoxHandler;
        }

        public void EventsOff()
        {
            inputForm.ListBoxYears.SelectedIndexChanged -= ListBoxHandler;
            inputForm.ListBoxColors.SelectedIndexChanged -= ListBoxHandler;
            inputForm.ListBoxMakes.SelectedIndexChanged -= ListBoxHandler;
            inputForm.ListBoxDealers.SelectedIndexChanged -= ListBoxHandler;

            inputForm.searchEngineSize.CheckedChanged -= ListBoxHandler;
            inputForm.searchPrice.CheckedChanged -= ListBoxHandler;
            inputForm.txtMinPrice.TextChanged -= ListBoxHandler;
            inputForm.txtMaxPrice.TextChanged -= ListBoxHandler;
            inputForm.txtMinEngineSize.TextChanged -= ListBoxHandler;
            inputForm.txtMaxEngineSize.TextChanged -= ListBoxHandler;
        }


        public void Reset(object sender, EventArgs e)
        {
            ResetCheckBoxes();
            ResetToDefault();
        }

        public void ResetCheckBoxes()
        {
            // Set search checkbox to false
            inputForm.searchPrice.Checked = false;
            inputForm.searchEngineSize.Checked = false;
            // Set textbox to empty
            inputForm.txtMaxEngineSize.Text = "";
            inputForm.txtMinEngineSize.Text = "";
            inputForm.txtMaxPrice.Text = "";
            inputForm.txtMinPrice.Text = "";
        }


        public void ResetToDefault()
        {

            EventsOff();

            EventsOn();

            MyListBoxControl.SelectAllListboxesAndUpdateToMyLists(inputGBV);

            inputForm.populateLowerTable();
        }

       

        public void ListBoxHandler(object sender, EventArgs e)
        {
            ListBox triggeredLists = sender as ListBox;

            if (triggeredLists != null)
            {
                string name = triggeredLists.Name;
                switch (name)
                {
                    case "ListBoxYears":
                        inputGBV.selectedYearList = MyListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxColors":
                        inputGBV.selectedColorList = MyListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxDealers":
                        inputGBV.selectedDealerList = MyListBoxControl.UpdateSelectItem(triggeredLists);
                        break;
                    case "ListBoxMakes":
                        inputGBV.selectedMakeList = MyListBoxControl.UpdateSelectItem(triggeredLists);
                        break;

                }
            }

            inputForm.populateLowerTable();
        }

    }
}
