﻿namespace DoAn
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
            this.btnQuanly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanly
            // 
            this.btnQuanly.Location = new System.Drawing.Point(23, 13);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Size = new System.Drawing.Size(92, 46);
            this.btnQuanly.TabIndex = 0;
            this.btnQuanly.Text = "Quản lý tài khoản";
            this.btnQuanly.UseVisualStyleBackColor = true;
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuanly);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanly;
    }
}