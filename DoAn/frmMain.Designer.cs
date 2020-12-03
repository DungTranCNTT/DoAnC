namespace DoAn
{
    partial class frmMain
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
            this.btnQLLop = new System.Windows.Forms.Button();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.btnQLKhoa = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
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
            // btnQLLop
            // 
            this.btnQLLop.Location = new System.Drawing.Point(143, 13);
            this.btnQLLop.Name = "btnQLLop";
            this.btnQLLop.Size = new System.Drawing.Size(92, 46);
            this.btnQLLop.TabIndex = 1;
            this.btnQLLop.Text = "Quản Lý Lớp";
            this.btnQLLop.UseVisualStyleBackColor = true;
            this.btnQLLop.Click += new System.EventHandler(this.btnQLLop_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Location = new System.Drawing.Point(250, 13);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(92, 46);
            this.btnPhanLop.TabIndex = 2;
            this.btnPhanLop.Text = "Phân Lớp";
            this.btnPhanLop.UseVisualStyleBackColor = true;
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // btnQLKhoa
            // 
            this.btnQLKhoa.Location = new System.Drawing.Point(357, 13);
            this.btnQLKhoa.Name = "btnQLKhoa";
            this.btnQLKhoa.Size = new System.Drawing.Size(92, 46);
            this.btnQLKhoa.TabIndex = 3;
            this.btnQLKhoa.Text = "Quản Lý khoa";
            this.btnQLKhoa.UseVisualStyleBackColor = true;
            this.btnQLKhoa.Click += new System.EventHandler(this.btnQLKhoa_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Location = new System.Drawing.Point(455, 13);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(92, 46);
            this.btnQLSV.TabIndex = 4;
            this.btnQLSV.Text = "Quản Lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLSV);
            this.Controls.Add(this.btnQLKhoa);
            this.Controls.Add(this.btnPhanLop);
            this.Controls.Add(this.btnQLLop);
            this.Controls.Add(this.btnQuanly);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanly;
        private System.Windows.Forms.Button btnQLLop;
        private System.Windows.Forms.Button btnPhanLop;
        private System.Windows.Forms.Button btnQLKhoa;
        private System.Windows.Forms.Button btnQLSV;
    }
}