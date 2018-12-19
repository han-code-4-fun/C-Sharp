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
            this.dataGridViewMovie.Size = new System.Drawing.Size(1454, 495);
            this.dataGridViewMovie.TabIndex = 5;
            // 
            // textBoxMoviePrice
            // 
            this.textBoxMoviePrice.Location = new System.Drawing.Point(1235, 1443);
            this.textBoxMoviePrice.Name = "textBoxMoviePrice";
            this.textBoxMoviePrice.ReadOnly = true;
            this.textBoxMoviePrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxMoviePrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1229, 1403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subtotal Movies:";
            // 
            // textBoxSnackPrice
            // 
            this.textBoxSnackPrice.Location = new System.Drawing.Point(86, 1443);
            this.textBoxSnackPrice.Name = "textBoxSnackPrice";
            this.textBoxSnackPrice.ReadOnly = true;
            this.textBoxSnackPrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxSnackPrice.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 1403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Subtotal Snacks:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(1235, 1557);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(286, 44);
            this.textBoxTotalPrice.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1229, 1503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Price:";
            // 
            // seatsButton
            // 
            this.seatsButton.Location = new System.Drawing.Point(76, 797);
            this.seatsButton.Name = "seatsButton";
            this.seatsButton.Size = new System.Drawing.Size(193, 68);
            this.seatsButton.TabIndex = 23;
            this.seatsButton.Text = "Seat Map";
            this.seatsButton.UseVisualStyleBackColor = true;
            // 
            // snackButton
            // 
            this.snackButton.Location = new System.Drawing.Point(86, 1537);
            this.snackButton.Name = "snackButton";
            this.snackButton.Size = new System.Drawing.Size(557, 68);
            this.snackButton.TabIndex = 24;
            this.snackButton.Text = "Snacks";
            this.snackButton.UseVisualStyleBackColor = true;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Location = new System.Drawing.Point(519, 1679);
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
            this.dataGridViewCart.Location = new System.Drawing.Point(76, 1005);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowTemplate.Height = 46;
            this.dataGridViewCart.Size = new System.Drawing.Size(1454, 370);
            this.dataGridViewCart.TabIndex = 27;
            // 
            // labelMovieList
            // 
            this.labelMovieList.AutoSize = true;
            this.labelMovieList.Location = new System.Drawing.Point(89, 216);
            this.labelMovieList.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelMovieList.Name = "labelMovieList";
            this.labelMovieList.Size = new System.Drawing.Size(159, 37);
            this.labelMovieList.TabIndex = 28;
            this.labelMovieList.Text = "Movie List";
            this.labelMovieList.UseWaitCursor = true;
            // 
            // labelSelectedSnacks
            // 
            this.labelSelectedSnacks.AutoSize = true;
            this.labelSelectedSnacks.Location = new System.Drawing.Point(79, 965);
            this.labelSelectedSnacks.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelSelectedSnacks.Name = "labelSelectedSnacks";
            this.labelSelectedSnacks.Size = new System.Drawing.Size(253, 37);
            this.labelSelectedSnacks.TabIndex = 29;
            this.labelSelectedSnacks.Text = "Selected Snacks";
            this.labelSelectedSnacks.UseWaitCursor = true;
            // 
            // labelSelectedMovie
            // 
            this.labelSelectedMovie.AutoSize = true;
            this.labelSelectedMovie.Location = new System.Drawing.Point(529, 797);
            this.labelSelectedMovie.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelSelectedMovie.Name = "labelSelectedMovie";
            this.labelSelectedMovie.Size = new System.Drawing.Size(240, 37);
            this.labelSelectedMovie.TabIndex = 30;
            this.labelSelectedMovie.Text = "Selected Movie:";
            // 
            // textBoxSelectedMovie
            // 
            this.textBoxSelectedMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSelectedMovie.Location = new System.Drawing.Point(823, 791);
            this.textBoxSelectedMovie.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxSelectedMovie.Name = "textBoxSelectedMovie";
            this.textBoxSelectedMovie.ReadOnly = true;
            this.textBoxSelectedMovie.Size = new System.Drawing.Size(673, 44);
            this.textBoxSelectedMovie.TabIndex = 31;
            // 
            // textBoxNumberOfTickets
            // 
            this.textBoxNumberOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumberOfTickets.Location = new System.Drawing.Point(823, 868);
            this.textBoxNumberOfTickets.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxNumberOfTickets.Name = "textBoxNumberOfTickets";
            this.textBoxNumberOfTickets.ReadOnly = true;
            this.textBoxNumberOfTickets.Size = new System.Drawing.Size(249, 44);
            this.textBoxNumberOfTickets.TabIndex = 33;
            // 
            // labelNumberOfTickets
            // 
            this.labelNumberOfTickets.AutoSize = true;
            this.labelNumberOfTickets.Location = new System.Drawing.Point(529, 874);
            this.labelNumberOfTickets.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelNumberOfTickets.Name = "labelNumberOfTickets";
            this.labelNumberOfTickets.Size = new System.Drawing.Size(199, 37);
            this.labelNumberOfTickets.TabIndex = 32;
            this.labelNumberOfTickets.Text = "# of Tickets: ";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 1782);
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