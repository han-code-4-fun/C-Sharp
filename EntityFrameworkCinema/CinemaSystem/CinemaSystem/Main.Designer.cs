namespace CinemaSystem
{
    partial class Main
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonSnack = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(238, 457);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(258, 158);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Customer Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            // 
            // buttonTicket
            // 
            this.buttonTicket.Location = new System.Drawing.Point(238, 114);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(258, 158);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Ticket";
            this.buttonTicket.UseVisualStyleBackColor = true;
            // 
            // buttonSnack
            // 
            this.buttonSnack.Location = new System.Drawing.Point(602, 114);
            this.buttonSnack.Name = "buttonSnack";
            this.buttonSnack.Size = new System.Drawing.Size(258, 158);
            this.buttonSnack.TabIndex = 2;
            this.buttonSnack.Text = "Snack";
            this.buttonSnack.UseVisualStyleBackColor = true;
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(602, 457);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(258, 158);
            this.buttonAddMovie.TabIndex = 3;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(238, 763);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(622, 158);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 1304);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonSnack);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonSnack;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonReport;
    }
}

