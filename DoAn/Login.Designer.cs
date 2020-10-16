namespace DoAn
{
    partial class Login
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbShowpass = new System.Windows.Forms.CheckBox();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(89, 210);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Username";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.MouseEnter += new System.EventHandler(this.txtID_MouseEnter);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(89, 263);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(183, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Password";
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.MouseEnter += new System.EventHandler(this.txtPass_MouseEnter);
            // 
            // cbShowpass
            // 
            this.cbShowpass.AutoSize = true;
            this.cbShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbShowpass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowpass.ForeColor = System.Drawing.Color.White;
            this.cbShowpass.Location = new System.Drawing.Point(55, 301);
            this.cbShowpass.Name = "cbShowpass";
            this.cbShowpass.Size = new System.Drawing.Size(103, 19);
            this.cbShowpass.TabIndex = 6;
            this.cbShowpass.Text = "Hiện mật khẩu";
            this.cbShowpass.UseVisualStyleBackColor = true;
            this.cbShowpass.CheckedChanged += new System.EventHandler(this.btnShowpass_CheckedChanged);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.DisabledLinkColor = System.Drawing.Color.White;
            this.lnkForgot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgot.ForeColor = System.Drawing.Color.White;
            this.lnkForgot.LinkColor = System.Drawing.Color.White;
            this.lnkForgot.Location = new System.Drawing.Point(192, 304);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(91, 15);
            this.lnkForgot.TabIndex = 9;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Quên mật khẩu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(89, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(89, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 1);
            this.panel3.TabIndex = 15;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongBao.Location = new System.Drawing.Point(52, 174);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(67, 15);
            this.lblThongBao.TabIndex = 16;
            this.lblThongBao.Text = "Thông báo:";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongBao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(102, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 461);
            this.panel1.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Location = new System.Drawing.Point(328, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 461);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aqua;
            this.panel5.ForeColor = System.Drawing.Color.Aqua;
            this.panel5.Location = new System.Drawing.Point(0, 456);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 5);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aqua;
            this.panel6.ForeColor = System.Drawing.Color.Aqua;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 5);
            this.panel6.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAn.Properties.Resources.icons8_unlock_80;
            this.pictureBox3.Location = new System.Drawing.Point(55, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAn.Properties.Resources.icons8_user_male_3_80;
            this.pictureBox2.Location = new System.Drawing.Point(55, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.icons8_cloud_account_login_male_100;
            this.pictureBox1.Location = new System.Drawing.Point(123, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.Aqua;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(55, 336);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 20;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(216, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 18;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor2 = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(56, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.BorderRadius = 20;
            this.btnExit.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(216, 34);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(333, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkForgot);
            this.Controls.Add(this.cbShowpass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox cbShowpass;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
    }
}

