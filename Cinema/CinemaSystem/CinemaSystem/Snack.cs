using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem.EF_Class;

namespace CinemaSystem
{
    public partial class Snack : Form
    {
        CinemaEntities context;
        EF_Class.Snack selectedSnack;
        Ticket.Snack currentSnack;

        //constructor that takes EFentities input
        public Snack(CinemaEntities cinemaContext)
        {
            this.context = cinemaContext;

            InitializeComponent();
            this.Load += SnackForm_Load;
            this.buttonIncrease.Click += SnackIncrease_Click;
            this.buttonDecrease.Click += SnackDecrease_Click;
            this.textBoxQuantity.TextChanged += SnackQuantityChange_Click;
            this.buttonProcess.Click += ConfirmSnack_Click;
            dataGridViewSnackList.SelectionChanged += SnackChange_Click;
        }

        //set datagridview in the begining
        private void SnackForm_Load(object sender, EventArgs e)
        {
            dataGridViewSnackList.DataSource = context.Snacks.ToList();
            dataGridViewSnackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSnackList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSnackList.Columns["SnackId"].Visible = false;
            dataGridViewSnackList.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridViewSnackList.Columns["OrdersSnacks"].Visible = false;
        }

        //event handling if user click different snack
        private void SnackChange_Click(object sender, EventArgs e)
        {
            //dataListViewSnackList
            if (dataGridViewSnackList.SelectedRows.Count > 0)
            {
                // Get current selected row
                DataGridViewRow selectedRow = dataGridViewSnackList.SelectedRows[0];
                int snackId = Convert.ToInt32(selectedRow.Cells["SnackId"].Value);
                // Find the selected Snack
                selectedSnack = context.Snacks.Find(snackId);
                
                int quantity = Convert.ToInt32(textBoxQuantity.Text);

                Ticket.Snack newSnack = new Ticket.Snack
                {
                    ItemId = snackId,
                    ItemPrice = selectedSnack.Price,
                    ItemName = selectedSnack.Name,
                    ItemQuantity = quantity,
            };

                currentSnack = newSnack;
                calculateTotalPrice();
            }
        }

        //process snack order
        private void ConfirmSnack_Click(object sender, EventArgs e)
        {
            if(currentSnack.ItemQuantity == 0)
            {
                MessageBox.Show("Please order at least 1 item");
                return;
            }
            
            this.DialogResult = DialogResult.OK;
            Close();
        }

        //add snack amount
        private void SnackIncrease_Click(object sender, EventArgs e)
        {
            
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            quantity += 1;
            setQuantity(quantity);
        }


        //minus snack amount
        private void SnackDecrease_Click(object sender, EventArgs e)
        {
            
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                if (quantity > 0)
                {
                    quantity -= 1;
                    setQuantity(quantity);
                }
        }


        //handle textbox changes
        private void SnackQuantityChange_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
            setQuantity(quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please only type number");
            }
        }


            public Ticket.Snack GetSnack()
        {
            return currentSnack;
        }

        //input number into quantity textbox
        private void setQuantity(int quantity)
        {
            currentSnack.ItemQuantity = quantity;
            textBoxQuantity.Text = quantity.ToString();
            calculateTotalPrice();
        }



        private void calculateTotalPrice()
        {
            textBoxSnackPrice.Text = (currentSnack.ItemPrice * currentSnack.ItemQuantity).ToString("c");
        }
    }
}
