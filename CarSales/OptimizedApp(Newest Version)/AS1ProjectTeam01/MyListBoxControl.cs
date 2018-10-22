using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static public class MyListBoxControl 
    {
        static private CarListingsForm myForm;
        
        static public void LinkFormToControl(CarListingsForm inputForm)
        {
            myForm = inputForm;
        }

        static public void SelectAllOptionsInOneListBox(ListBox list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetSelected(i, true);
            }

        }

        static public List<string> UpdateSelectItem(ListBox triggeredLists)
        {
            List<string> tempList = new List<String>();
            for (int i = 0; i < triggeredLists.SelectedItems.Count; i++)
            {
                string temp = triggeredLists.SelectedItems[i].ToString();
                tempList.Add(temp);
            }
            return tempList;
        }

        static public void SelectAllListboxesAndUpdateToMyLists(GlobalVariable myGB)
        {
            SelectAllOptionsInOneListBox(myForm.ListBoxMakes);
            myGB.selectedMakeList = UpdateSelectItem(myForm.ListBoxMakes);

            SelectAllOptionsInOneListBox(myForm.ListBoxColors);
            myGB.selectedColorList = UpdateSelectItem(myForm.ListBoxColors);

            SelectAllOptionsInOneListBox(myForm.ListBoxYears);
            myGB.selectedYearList = UpdateSelectItem(myForm.ListBoxYears);

            SelectAllOptionsInOneListBox(myForm.ListBoxDealers);
            myGB.selectedDealerList = UpdateSelectItem(myForm.ListBoxDealers);
        }
    }
}
