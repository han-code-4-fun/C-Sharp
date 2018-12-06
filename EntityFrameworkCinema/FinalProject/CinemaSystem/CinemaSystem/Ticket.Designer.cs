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
            this.labelMovieList = new System.Windows.Forms.Label();
            this.labelSelectedSnacks = new System.Windows.Forms.Label();
            this.labelSelectedMovie = new System.Windows.Forms.Label();
            this.textBoxSelectedMovie = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfTickets = new System.Windows.Forms.TextBox();
            this.labelNumberOfTickets = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(150, 17);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(75, 20);
            this.textBoxPhone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Customer Phone #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(252, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(231, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info.";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(100, 45);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(75, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(100, 23);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(75, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(24, 93);
            this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewMovie.MultiSelect = false;
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowTemplate.Height = 46;
            this.dataGridViewMovie.Size = new System.Drawing.Size(459, 174);
            this.dataGridViewMovie.TabIndex = 5;
            // 
            // textBoxMoviePrice
            // 
            this.textBoxMoviePrice.Location = new System.Drawing.Point(390, 507);
            this.textBoxMoviePrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMoviePrice.Name = "textBoxMoviePrice";
            this.textBoxMoviePrice.ReadOnly = true;
            this.textBoxMoviePrice.Size = new System.Drawing.Size(93, 20);
            this.textBoxMoviePrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 493);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subtotal Movies:";
            // 
            // textBoxSnackPrice
            // 
            this.textBoxSnackPrice.Location = new System.Drawing.Point(27, 507);
            this.textBoxSnackPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxSnackPrice.Name = "textBoxSnackPrice";
            this.textBoxSnackPrice.ReadOnly = true;
            this.textBoxSnackPrice.Size = new System.Drawing.Size(93, 20);
            this.textBoxSnackPrice.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 493);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Subtotal Snacks:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(390, 547);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(93, 20);
            this.textBoxTotalPrice.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 528);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Price:";
            // 
            // seatsButton
            // 
            this.seatsButton.Location = new System.Drawing.Point(24, 280);
            this.seatsButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.seatsButton.Name = "seatsButton";
            this.seatsButton.Size = new System.Drawing.Size(61, 24);
            this.seatsButton.TabIndex = 23;
            this.seatsButton.Text = "Seat Map";
            this.seatsButton.UseVisualStyleBackColor = true;
            // 
            // snackButton
            // 
            this.snackButton.Location = new System.Drawing.Point(27, 540);
            this.snackButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.snackButton.Name = "snackButton";
            this.snackButton.Size = new System.Drawing.Size(176, 24);
            this.snackButton.TabIndex = 24;
            this.snackButton.Text = "Snacks";
            this.snackButton.UseVisualStyleBackColor = true;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Location = new System.Drawing.Point(164, 590);
            this.confirmOrderButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(176, 24);
            this.confirmOrderButton.TabIndex = 25;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            // 
            // findCustomer
            // 
            this.findCustomer.Location = new System.Drawing.Point(164, 51);
            this.findCustomer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(61, 24);
            this.findCustomer.TabIndex = 26;
            this.findCustomer.Text = "Find Customer";
            this.findCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(24, 353);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowTemplate.Height = 46;
            this.dataGridViewCart.Size = new System.Drawing.Size(459, 130);
            this.dataGridViewCart.TabIndex = 27;
            // 
            // labelMovieList
            // 
            this.labelMovieList.AutoSize = true;
            this.labelMovieList.Location = new System.Drawing.Point(28, 76);
            this.labelMovieList.Name = "labelMovieList";
            this.labelMovieList.Size = new System.Drawing.Size(55, 13);
            this.labelMovieList.TabIndex = 28;
            this.labelMovieList.Text = "Movie List";
            this.labelMovieList.UseWaitCursor = true;
            // 
            // labelSelectedSnacks
            // 
            this.labelSelectedSnacks.AutoSize = true;
            this.labelSelectedSnacks.Location = new System.Drawing.Point(25, 339);
            this.labelSelectedSnacks.Name = "labelSelectedSnacks";
            this.labelSelectedSnacks.Size = new System.Drawing.Size(88, 13);
            this.labelSelectedSnacks.TabIndex = 29;
            this.labelSelectedSnacks.Text = "Selected Snacks";
            this.labelSelectedSnacks.UseWaitCursor = true;
            // 
            // labelSelectedMovie
            // 
            this.labelSelectedMovie.AutoSize = true;
            this.labelSelectedMovie.Location = new System.Drawing.Point(167, 280);
            this.labelSelectedMovie.Name = "labelSelectedMovie";
            this.labelSelectedMovie.Size = new System.Drawing.Size(84, 13);
            this.labelSelectedMovie.TabIndex = 30;
            this.labelSelectedMovie.Text = "Selected Movie:";
            // 
            // textBoxSelectedMovie
            // 
            this.textBoxSelectedMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSelectedMovie.Location = new System.Drawing.Point(260, 278);
            this.textBoxSelectedMovie.Name = "textBoxSelectedMovie";
            this.textBoxSelectedMovie.ReadOnly = true;
            this.textBoxSelectedMovie.Size = new System.Drawing.Size(214, 20);
            this.textBoxSelectedMovie.TabIndex = 31;
            // 
            // textBoxNumberOfTickets
            // 
            this.textBoxNumberOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumberOfTickets.Location = new System.Drawing.Point(260, 305);
            this.textBoxNumberOfTickets.Name = "textBoxNumberOfTickets";
            this.textBoxNumberOfTickets.ReadOnly = true;
            this.textBoxNumberOfTickets.Size = new System.Drawing.Size(80, 20);
            this.textBoxNumberOfTickets.TabIndex = 33;
            // 
            // labelNumberOfTickets
            // 
            this.labelNumberOfTickets.AutoSize = true;
            this.labelNumberOfTickets.Location = new System.Drawing.Point(167, 307);
            this.labelNumberOfTickets.Name = "labelNumberOfTickets";
            this.labelNumberOfTickets.Size = new System.Drawing.Size(70, 13);
            this.labelNumberOfTickets.TabIndex = 32;
            this.labelNumberOfTickets.Text = "# of Tickets: ";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 626);
            this.Controls.Add(this.textBoxNumberOfTickets);
            this.Controls.Add(this.labelNumberOfTickets);
            this.Controls.Add(this.textBoxSelectedMovie);
            this.Controls.Add(this.labelSelectedMovie);
            this.Controls.Add(this.labelSelectedSnacks);
            this.Controls.Add(this.labelMovieList);
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
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.Label labelMovieList;
        private System.Windows.Forms.Label labelSelectedSnacks;
        private System.Windows.Forms.Label labelSelectedMovie;
        private System.Windows.Forms.TextBox textBoxSelectedMovie;
        private System.Windows.Forms.TextBox textBoxNumberOfTickets;
        private System.Windows.Forms.Label labelNumberOfTickets;
    }
}