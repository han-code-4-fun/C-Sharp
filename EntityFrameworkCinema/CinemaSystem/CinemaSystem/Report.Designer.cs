namespace CinemaSystem
{
    partial class Report
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
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.listBoxMovie = new System.Windows.Forms.ListBox();
            this.button7Days = new System.Windows.Forms.Button();
            this.button30Days = new System.Windows.Forms.Button();
            this.buttonAllTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report ";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(138, 492);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowTemplate.Height = 46;
            this.dataGridViewReport.Size = new System.Drawing.Size(940, 440);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // listBoxMovie
            // 
            this.listBoxMovie.FormattingEnabled = true;
            this.listBoxMovie.ItemHeight = 37;
            this.listBoxMovie.Location = new System.Drawing.Point(138, 147);
            this.listBoxMovie.Name = "listBoxMovie";
            this.listBoxMovie.Size = new System.Drawing.Size(368, 300);
            this.listBoxMovie.TabIndex = 2;
            // 
            // button7Days
            // 
            this.button7Days.Location = new System.Drawing.Point(721, 147);
            this.button7Days.Name = "button7Days";
            this.button7Days.Size = new System.Drawing.Size(357, 91);
            this.button7Days.TabIndex = 3;
            this.button7Days.Text = "7 Days";
            this.button7Days.UseVisualStyleBackColor = true;
            // 
            // button30Days
            // 
            this.button30Days.Location = new System.Drawing.Point(721, 265);
            this.button30Days.Name = "button30Days";
            this.button30Days.Size = new System.Drawing.Size(357, 91);
            this.button30Days.TabIndex = 4;
            this.button30Days.Text = "30 Days";
            this.button30Days.UseVisualStyleBackColor = true;
            // 
            // buttonAllTime
            // 
            this.buttonAllTime.Location = new System.Drawing.Point(721, 373);
            this.buttonAllTime.Name = "buttonAllTime";
            this.buttonAllTime.Size = new System.Drawing.Size(357, 91);
            this.buttonAllTime.TabIndex = 5;
            this.buttonAllTime.Text = "All Time";
            this.buttonAllTime.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 1076);
            this.Controls.Add(this.buttonAllTime);
            this.Controls.Add(this.button30Days);
            this.Controls.Add(this.button7Days);
            this.Controls.Add(this.listBoxMovie);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.ListBox listBoxMovie;
        private System.Windows.Forms.Button button7Days;
        private System.Windows.Forms.Button button30Days;
        private System.Windows.Forms.Button buttonAllTime;
    }
}