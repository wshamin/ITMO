﻿namespace WinFormsApp1
{
    partial class Form2
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
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(12, 57);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(307, 39);
            this.textBoxF22.TabIndex = 0;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(12, 102);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(307, 39);
            this.textBoxF23.TabIndex = 1;
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(12, 12);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(307, 39);
            this.textBoxF21.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxF21);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF22);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxF22;
        private TextBox textBoxF23;
        private TextBox textBoxF21;
        private Button button1;
    }
}