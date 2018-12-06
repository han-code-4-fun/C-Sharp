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
            this.dataListViewSnackList = new System.Windows.Forms.DataGridView();
            this.textBoxSnackPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewSnackList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(179, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Snack Purchase";
            // 
            // dataListViewSnackList
            // 
            this.dataListViewSnackList.AllowUserToAddRows = false;
            this.dataListViewSnackList.AllowUserToDeleteRows = false;
            this.dataListViewSnackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListViewSnackList.Location = new System.Drawing.Point(50, 91);
            this.dataListViewSnackList.Margin = new System.Windows.Forms.Padding(1);
            this.dataListViewSnackList.Name = "dataListViewSnackList";
            this.dataListViewSnackList.ReadOnly = true;
            this.dataListViewSnackList.RowTemplate.Height = 46;
            this.dataListViewSnackList.Size = new System.Drawing.Size(402, 183);
            this.dataListViewSnackList.TabIndex = 3;
            // 
            // textBoxSnackPrice
            // 
            this.textBoxSnackPrice.Location = new System.Drawing.Point(361, 322);
            this.textBoxSnackPrice.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxSnackPrice.Name = "textBoxSnackPrice";
            this.textBoxSnackPrice.ReadOnly = true;
            this.textBoxSnackPrice.Size = new System.Drawing.Size(93, 20);
            this.textBoxSnackPrice.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Snack total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Number:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(173, 303);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxQuantity.Size = new System.Drawing.Size(53, 32);
            this.textBoxQuantity.TabIndex = 25;
            this.textBoxQuantity.Text = "0";
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.Location = new System.Drawing.Point(237, 303);
            this.buttonDecrease.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(33, 28);
            this.buttonDecrease.TabIndex = 24;
            this.buttonDecrease.Text = "-";
            this.buttonDecrease.UseVisualStyleBackColor = true;
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Location = new System.Drawing.Point(128, 303);
            this.buttonIncrease.Margin = new System.Windows.Forms.Padding(1);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(33, 28);
            this.buttonIncrease.TabIndex = 23;
            this.buttonIncrease.Text = "+";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(198, 391);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(1);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(115, 28);
            this.buttonProcess.TabIndex = 27;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            // 
            // Snack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonDecrease);
            this.Controls.Add(this.buttonIncrease);
            this.Controls.Add(this.textBoxSnackPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataListViewSnackList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Snack";
            this.Text = "Snack";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewSnackList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataListViewSnackList;
        private System.Windows.Forms.TextBox textBoxSnackPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.Button buttonProcess;
    }
}