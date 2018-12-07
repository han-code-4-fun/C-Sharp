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
        public Snack(CinemaEntities cinemaContext)
        {
            this.context = cinemaContext;

            InitializeComponent();
            this.Load += SnackForm_Load;
            this.buttonIncrease.Click += SnackIncrease_Click;
            this.buttonDecrease.Click += SnackDecrease_Click;
            this.textBoxQuantity.TextChanged += SnackQuantityChange_Click;
            this.buttonProcess.Click += ConfirmSnack_Click;
            dataGridView1.SelectionChanged += SnackChange_Click;
        }
        private void SnackForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Snacks.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["SnackId"].Visible = false;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["OrdersSnacks"].Visible = false;
        }
        private void SnackChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //dataListViewSnackList
                // Get current selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int snackId = Convert.ToInt32(selectedRow.Cells["SnackId"].Value);
                // Find the selected Snack
                selectedSnack = context.Snacks.Find(snackId);
                // TODO: Handler for int only
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
        private void ConfirmSnack_Click(object sender, EventArgs e)
        {
            if(currentSnack.ItemQuantity == 0)
            {
                MessageBox.Show("Please order at least 1 item");
                return;
            }
            // TODO: Check if at least one snack selected
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void SnackIncrease_Click(object sender, EventArgs e)
        {
            // TODO: Handler for int only
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            quantity += 1;
            setQuantity(quantity);
        }
        private void SnackDecrease_Click(object sender, EventArgs e)
        {
            // TODO: Handler for int only
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                if (quantity > 0)
                {
                    quantity -= 1;
                    setQuantity(quantity);
                }
        }
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
