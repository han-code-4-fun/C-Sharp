namespace CinemaSystem
{
    partial class Snack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSnack = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSnackCheckOut = new System.Windows.Forms.DataGridView();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnackCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snack Purchase";
            // 
            // dataGridViewSnack
            // 
            this.dataGridViewSnack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSnack.Location = new System.Drawing.Point(54, 143);
            this.dataGridViewSnack.Name = "dataGridViewSnack";
            this.dataGridViewSnack.RowTemplate.Height = 46;
            this.dataGridViewSnack.Size = new System.Drawing.Size(1473, 435);
            this.dataGridViewSnack.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(181, 614);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(104, 80);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(54, 614);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 80);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSnackCheckOut
            // 
            this.dataGridViewSnackCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSnackCheckOut.Location = new System.Drawing.Point(54, 732);
            this.dataGridViewSnackCheckOut.Name = "dataGridViewSnackCheckOut";
            this.dataGridViewSnackCheckOut.RowTemplate.Height = 46;
            this.dataGridViewSnackCheckOut.Size = new System.Drawing.Size(1063, 366);
            this.dataGridViewSnackCheckOut.TabIndex = 11;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(1278, 958);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(196, 140);
            this.buttonBuy.TabIndex = 12;
            this.buttonBuy.Text = "Check Out";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1271, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Price:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(1278, 834);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(196, 44);
            this.textBoxTotalPrice.TabIndex = 14;
            // 
            // Snack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 1141);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.dataGridViewSnackCheckOut);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSnack);
            this.Controls.Add(this.label1);
            this.Name = "Snack";
            this.Text = "Snack";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnackCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSnack;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSnackCheckOut;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
    }
}