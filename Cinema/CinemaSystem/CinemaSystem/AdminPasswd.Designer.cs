namespace CinemaSystem
{
    partial class AdminPasswd
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
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnterPasswd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(156, 203);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(291, 44);
            this.textBoxPasswd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter Administrator Password";
            // 
            // buttonEnterPasswd
            // 
            this.buttonEnterPasswd.Location = new System.Drawing.Point(206, 304);
            this.buttonEnterPasswd.Name = "buttonEnterPasswd";
            this.buttonEnterPasswd.Size = new System.Drawing.Size(181, 73);
            this.buttonEnterPasswd.TabIndex = 2;
            this.buttonEnterPasswd.Text = "Enter";
            this.buttonEnterPasswd.UseVisualStyleBackColor = true;
            this.buttonEnterPasswd.Click += new System.EventHandler(this.buttonEnterPasswd_Click);
            // 
            // AdminPasswd
            // 
            this.AcceptButton = this.buttonEnterPasswd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Controls.Add(this.buttonEnterPasswd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswd);
            this.Name = "AdminPasswd";
            this.Text = "AdminPasswd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnterPasswd;
    }
}