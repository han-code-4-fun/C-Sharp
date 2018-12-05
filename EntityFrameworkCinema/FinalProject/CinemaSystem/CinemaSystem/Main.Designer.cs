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
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(602, 114);
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
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(238, 396);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(258, 158);
            this.buttonAddMovie.TabIndex = 3;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(28, 52);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(258, 158);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBackup);
            this.groupBox1.Controls.Add(this.buttonReport);
            this.groupBox1.Location = new System.Drawing.Point(238, 681);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adminstrator Function";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(358, 52);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(258, 158);
            this.buttonBackup.TabIndex = 5;
            this.buttonBackup.Text = "Back Up";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(602, 396);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(252, 158);
            this.buttonSwitch.TabIndex = 6;
            this.buttonSwitch.Text = "Switch to Administrator";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 1122);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonSwitch;
    }
}

