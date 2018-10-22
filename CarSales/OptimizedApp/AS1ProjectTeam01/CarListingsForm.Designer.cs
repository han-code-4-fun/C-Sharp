using System;
using System.Windows.Forms;

namespace AS1ProjectTeam01
{
    partial class CarListingsForm
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
            this.dataAllCars = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountAll = new System.Windows.Forms.Label();
            this.labelAveragePriceAll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.ListBoxMakes = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBoxYears = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListBoxColors = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListBoxDealers = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxEngineSize = new System.Windows.Forms.TextBox();
            this.txtMinEngineSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.searchPrice = new System.Windows.Forms.CheckBox();
            this.searchEngineSize = new System.Windows.Forms.CheckBox();
            this.labelAverageSelected = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCountSelected = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataSelectedCars = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Cars";
            // 
            // dataAllCars
            // 
            this.dataAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllCars.Location = new System.Drawing.Point(36, 90);
            this.dataAllCars.Margin = new System.Windows.Forms.Padding(7);
            this.dataAllCars.Name = "dataAllCars";
            this.dataAllCars.RowTemplate.Height = 24;
            this.dataAllCars.Size = new System.Drawing.Size(1805, 382);
            this.dataAllCars.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count =";
            // 
            // labelCountAll
            // 
            this.labelCountAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountAll.Location = new System.Drawing.Point(354, 509);
            this.labelCountAll.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCountAll.Name = "labelCountAll";
            this.labelCountAll.Size = new System.Drawing.Size(230, 39);
            this.labelCountAll.TabIndex = 3;
            // 
            // labelAveragePriceAll
            // 
            this.labelAveragePriceAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAveragePriceAll.Location = new System.Drawing.Point(1389, 509);
            this.labelAveragePriceAll.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAveragePriceAll.Name = "labelAveragePriceAll";
            this.labelAveragePriceAll.Size = new System.Drawing.Size(240, 39);
            this.labelAveragePriceAll.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1121, 509);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Price = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 583);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filters";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(734, 571);
            this.resetButton.Margin = new System.Windows.Forms.Padding(7);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(318, 53);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Filters";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // ListBoxMakes
            // 
            this.ListBoxMakes.FormattingEnabled = true;
            this.ListBoxMakes.ItemHeight = 37;
            this.ListBoxMakes.Location = new System.Drawing.Point(36, 701);
            this.ListBoxMakes.Margin = new System.Windows.Forms.Padding(7);
            this.ListBoxMakes.Name = "ListBoxMakes";
            this.ListBoxMakes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxMakes.Size = new System.Drawing.Size(353, 300);
            this.ListBoxMakes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 657);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Makes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 657);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Years";
            // 
            // ListBoxYears
            // 
            this.ListBoxYears.FormattingEnabled = true;
            this.ListBoxYears.ItemHeight = 37;
            this.ListBoxYears.Location = new System.Drawing.Point(556, 701);
            this.ListBoxYears.Margin = new System.Windows.Forms.Padding(7);
            this.ListBoxYears.Name = "ListBoxYears";
            this.ListBoxYears.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxYears.Size = new System.Drawing.Size(175, 300);
            this.ListBoxYears.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(924, 657);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Colors";
            // 
            // ListBoxColors
            // 
            this.ListBoxColors.FormattingEnabled = true;
            this.ListBoxColors.ItemHeight = 37;
            this.ListBoxColors.Location = new System.Drawing.Point(922, 701);
            this.ListBoxColors.Margin = new System.Windows.Forms.Padding(7);
            this.ListBoxColors.Name = "ListBoxColors";
            this.ListBoxColors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxColors.Size = new System.Drawing.Size(263, 300);
            this.ListBoxColors.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1444, 657);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dealers";
            // 
            // ListBoxDealers
            // 
            this.ListBoxDealers.FormattingEnabled = true;
            this.ListBoxDealers.ItemHeight = 37;
            this.ListBoxDealers.Location = new System.Drawing.Point(1451, 701);
            this.ListBoxDealers.Margin = new System.Windows.Forms.Padding(7);
            this.ListBoxDealers.Name = "ListBoxDealers";
            this.ListBoxDealers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxDealers.Size = new System.Drawing.Size(384, 300);
            this.ListBoxDealers.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(28, 1064);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 39);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 1064);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 37);
            this.label10.TabIndex = 17;
            this.label10.Text = "Min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 1135);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 37);
            this.label11.TabIndex = 18;
            this.label11.Text = "Max";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(261, 1057);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(7);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(232, 44);
            this.txtMinPrice.TabIndex = 19;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(261, 1128);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(232, 44);
            this.txtMaxPrice.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(955, 1064);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 39);
            this.label12.TabIndex = 21;
            this.label12.Text = "Engine Size";
            // 
            // txtMaxEngineSize
            // 
            this.txtMaxEngineSize.Location = new System.Drawing.Point(1316, 1126);
            this.txtMaxEngineSize.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaxEngineSize.Name = "txtMaxEngineSize";
            this.txtMaxEngineSize.Size = new System.Drawing.Size(232, 44);
            this.txtMaxEngineSize.TabIndex = 25;
            // 
            // txtMinEngineSize
            // 
            this.txtMinEngineSize.Location = new System.Drawing.Point(1316, 1054);
            this.txtMinEngineSize.Margin = new System.Windows.Forms.Padding(7);
            this.txtMinEngineSize.Name = "txtMinEngineSize";
            this.txtMinEngineSize.Size = new System.Drawing.Size(232, 44);
            this.txtMinEngineSize.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1233, 1133);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 37);
            this.label13.TabIndex = 23;
            this.label13.Text = "Max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1233, 1061);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 37);
            this.label14.TabIndex = 22;
            this.label14.Text = "Min";
            // 
            // searchPrice
            // 
            this.searchPrice.AutoSize = true;
            this.searchPrice.Location = new System.Drawing.Point(261, 1193);
            this.searchPrice.Margin = new System.Windows.Forms.Padding(7);
            this.searchPrice.Name = "searchPrice";
            this.searchPrice.Size = new System.Drawing.Size(290, 41);
            this.searchPrice.TabIndex = 26;
            this.searchPrice.Text = "Search on Price";
            this.searchPrice.UseVisualStyleBackColor = true;
            // 
            // searchEngineSize
            // 
            this.searchEngineSize.AutoSize = true;
            this.searchEngineSize.Location = new System.Drawing.Point(1240, 1191);
            this.searchEngineSize.Margin = new System.Windows.Forms.Padding(7);
            this.searchEngineSize.Name = "searchEngineSize";
            this.searchEngineSize.Size = new System.Drawing.Size(387, 41);
            this.searchEngineSize.TabIndex = 27;
            this.searchEngineSize.Text = "Search on Engine Size";
            this.searchEngineSize.UseVisualStyleBackColor = true;
            // 
            // labelAverageSelected
            // 
            this.labelAverageSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAverageSelected.Location = new System.Drawing.Point(1399, 1744);
            this.labelAverageSelected.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAverageSelected.Name = "labelAverageSelected";
            this.labelAverageSelected.Size = new System.Drawing.Size(240, 39);
            this.labelAverageSelected.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1130, 1744);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(253, 37);
            this.label16.TabIndex = 32;
            this.label16.Text = "Average Price = ";
            // 
            // labelCountSelected
            // 
            this.labelCountSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountSelected.Location = new System.Drawing.Point(363, 1744);
            this.labelCountSelected.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCountSelected.Name = "labelCountSelected";
            this.labelCountSelected.Size = new System.Drawing.Size(230, 39);
            this.labelCountSelected.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(226, 1744);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 37);
            this.label18.TabIndex = 30;
            this.label18.Text = "Count =";
            // 
            // dataSelectedCars
            // 
            this.dataSelectedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelectedCars.Location = new System.Drawing.Point(45, 1325);
            this.dataSelectedCars.Margin = new System.Windows.Forms.Padding(7);
            this.dataSelectedCars.Name = "dataSelectedCars";
            this.dataSelectedCars.RowTemplate.Height = 24;
            this.dataSelectedCars.Size = new System.Drawing.Size(1805, 382);
            this.dataSelectedCars.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 1256);
            this.label19.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 38);
            this.label19.TabIndex = 28;
            this.label19.Text = "Selected Cars";
            // 
            // CarListingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1866);
            this.Controls.Add(this.labelAverageSelected);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelCountSelected);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataSelectedCars);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.searchEngineSize);
            this.Controls.Add(this.searchPrice);
            this.Controls.Add(this.txtMaxEngineSize);
            this.Controls.Add(this.txtMinEngineSize);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListBoxDealers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListBoxColors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListBoxYears);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBoxMakes);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAveragePriceAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCountAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAllCars);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CarListingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 1 - Car Listings - ProjectTeam 01 ";
            ((System.ComponentModel.ISupportInitialize)(this.dataAllCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAllCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountAll;
        private System.Windows.Forms.Label labelAveragePriceAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListBox ListBoxMakes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxYears;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ListBoxColors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListBoxDealers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxEngineSize;
        private System.Windows.Forms.TextBox txtMinEngineSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox searchPrice;
        private System.Windows.Forms.CheckBox searchEngineSize;
        private System.Windows.Forms.Label labelAverageSelected;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCountSelected;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataSelectedCars;
        private System.Windows.Forms.Label label19;


       
    }
}

