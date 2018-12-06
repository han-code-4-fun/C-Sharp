namespace CinemaSystem
{
    partial class Ticket
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
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.textBoxMoviePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSnackPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.seatsButton = new System.Windows.Forms.Button();
            this.snackButton = new System.Windows.Forms.Button();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.findCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(475, 48);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(229, 44);
            this.textBoxPhone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Customer Phone #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(798, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info.";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(317, 128);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(229, 44);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(317, 65);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(229, 44);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(76, 265);
            this.dataGridViewMovie.MultiSelect = false;
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowTemplate.Height = 46;
            this.dataGridViewMovie.Size = new System.Drawing.Size(1454, 494);
            this.dataGridViewMovie.TabIndex = 5;
            // 
            // textBoxMoviePrice
            // 
            this.textBoxMoviePrice.Location = new System.Drawing.Point(1235, 1324);
            this.textBoxMoviePrice.Name = "textBoxMoviePrice";
            this.textBoxMoviePrice.ReadOnly = true;
            this.textBoxMoviePrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxMoviePrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1229, 1284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subtotal Movies:";
            // 
            // textBoxSnackPrice
            // 
            this.textBoxSnackPrice.Location = new System.Drawing.Point(86, 1324);
            this.textBoxSnackPrice.Name = "textBoxSnackPrice";
            this.textBoxSnackPrice.ReadOnly = true;
            this.textBoxSnackPrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxSnackPrice.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 1284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Subtotal Snacks:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(1235, 1437);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxTotalPrice.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1229, 1383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Price:";
            // 
            // seatsButton
            // 
            this.seatsButton.Location = new System.Drawing.Point(76, 796);
            this.seatsButton.Name = "seatsButton";
            this.seatsButton.Size = new System.Drawing.Size(193, 68);
            this.seatsButton.TabIndex = 23;
            this.seatsButton.Text = "Seat Map";
            this.seatsButton.UseVisualStyleBackColor = true;
            // 
            // snackButton
            // 
            this.snackButton.Location = new System.Drawing.Point(86, 1418);
            this.snackButton.Name = "snackButton";
            this.snackButton.Size = new System.Drawing.Size(557, 68);
            this.snackButton.TabIndex = 24;
            this.snackButton.Text = "Snacks";
            this.snackButton.UseVisualStyleBackColor = true;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Location = new System.Drawing.Point(519, 1560);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(557, 68);
            this.confirmOrderButton.TabIndex = 25;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            // 
            // findCustomer
            // 
            this.findCustomer.Location = new System.Drawing.Point(519, 145);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(193, 68);
            this.findCustomer.TabIndex = 26;
            this.findCustomer.Text = "Find Customer";
            this.findCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(76, 886);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowTemplate.Height = 46;
            this.dataGridViewCart.Size = new System.Drawing.Size(1454, 369);
            this.dataGridViewCart.TabIndex = 27;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 1861);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.findCustomer);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.snackButton);
            this.Controls.Add(this.seatsButton);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSnackPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMoviePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhone);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.TextBox textBoxMoviePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSnackPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button seatsButton;
        private System.Windows.Forms.Button snackButton;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Button findCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCart;
    }
}