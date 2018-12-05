﻿namespace CinemaSystem
{
    partial class AddMovie
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.textBoxMovieDirector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMovieDescription = new System.Windows.Forms.TextBox();
            this.textBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMoviePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Movie Name:";
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(158, 70);
            this.textBoxMovieName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(93, 20);
            this.textBoxMovieName.TabIndex = 2;
            // 
            // textBoxMovieDirector
            // 
            this.textBoxMovieDirector.Location = new System.Drawing.Point(158, 110);
            this.textBoxMovieDirector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMovieDirector.Name = "textBoxMovieDirector";
            this.textBoxMovieDirector.Size = new System.Drawing.Size(93, 20);
            this.textBoxMovieDirector.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Movie Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Movie Description:";
            // 
            // textBoxMovieDescription
            // 
            this.textBoxMovieDescription.Location = new System.Drawing.Point(56, 178);
            this.textBoxMovieDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMovieDescription.Multiline = true;
            this.textBoxMovieDescription.Name = "textBoxMovieDescription";
            this.textBoxMovieDescription.Size = new System.Drawing.Size(195, 96);
            this.textBoxMovieDescription.TabIndex = 6;
            // 
            // textBoxMovieDuration
            // 
            this.textBoxMovieDuration.Location = new System.Drawing.Point(158, 300);
            this.textBoxMovieDuration.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMovieDuration.Name = "textBoxMovieDuration";
            this.textBoxMovieDuration.Size = new System.Drawing.Size(93, 20);
            this.textBoxMovieDuration.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Movie Duration:";
            // 
            // textBoxMoviePrice
            // 
            this.textBoxMoviePrice.Location = new System.Drawing.Point(158, 331);
            this.textBoxMoviePrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxMoviePrice.Name = "textBoxMoviePrice";
            this.textBoxMoviePrice.Size = new System.Drawing.Size(93, 20);
            this.textBoxMoviePrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter Movie Price:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 364);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 36);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add movie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 418);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMoviePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMovieDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMovieDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMovieDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AddMovie";
            this.Text = "*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxMovieDirector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMovieDescription;
        private System.Windows.Forms.TextBox textBoxMovieDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMoviePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
    }
}