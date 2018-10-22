using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1ProjectTeam01
{
    public class GlobalVariable
    {
     

        //stores xml data
        private List<Car> _listCars;

        // Init list string to hold list of selections
        private List<string> _selectedYearList = new List<string>();
        private List<string> _selectedColorList = new List<string>();
        private List<string> _selectedMakeList = new List<string>();
        private List<string> _selectedDealerList = new List<string>();
        
        private IEnumerable<Car> _query = null;
        #region Access above variables
        public List<Car> listCars
        {
            get { return _listCars; }
            set { _listCars = value; }
        }
        public List<string> selectedYearList
        {
            get { return _selectedYearList; }
            set { _selectedYearList = value; }
        }
        public List<string> selectedColorList
        {
            get { return _selectedColorList; }
            set { _selectedColorList = value; }
        }
        public List<string> selectedMakeList
        {
            get { return _selectedMakeList; }
            set { _selectedMakeList = value; }
        }
        public List<string> selectedDealerList
        {
            get { return _selectedDealerList; }
            set { _selectedDealerList = value; }
        }
        public IEnumerable<Car> query
        {
            get { return _query; }
            set { _query = value; }
        }
        #endregion

    }
}
