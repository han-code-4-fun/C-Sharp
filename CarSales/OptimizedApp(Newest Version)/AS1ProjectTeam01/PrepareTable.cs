using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    static public class PrepareTable
    {
        //datagrid view setting
        static public void SetDataGridView(DataGridView gridView)
        {
            gridView.Columns.Clear();
            gridView.ReadOnly = true;
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridView.RowHeadersVisible = false;
            gridView.AutoSize = false;
            gridView.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        //create datagridview table
        static public DataTable CreateDataTable<T>(IEnumerable<T> list)
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

        //set format for price column
        static public void ApplyDataToTable(DataTable input, DataGridView tableToShow)
        {
            tableToShow.DataSource = input;
            tableToShow.Columns["Price"].DefaultCellStyle.Format = "c";
        }
    }
}
