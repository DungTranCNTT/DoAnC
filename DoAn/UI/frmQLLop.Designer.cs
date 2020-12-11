namespace DoAn
{
    partial class frmQLLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(173, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 67);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản Lý Lớp";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.btnThemLop);
            this.panel6.Controls.Add(this.btnSuaLop);
            this.panel6.Controls.Add(this.btnXoaLop);
            this.panel6.Location = new System.Drawing.Point(-5, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 527);
            this.panel6.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 18;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor2 = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.Location = new System.Drawing.Point(21, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.BorderRadius = 20;
            this.btnExit.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(149, 43);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.icons8_books_50;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BorderRadius = 18;
            this.btnThemLop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnThemLop.CheckedState.Parent = this.btnThemLop;
            this.btnThemLop.CustomImages.Parent = this.btnThemLop;
            this.btnThemLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemLop.FillColor2 = System.Drawing.Color.Aqua;
            this.btnThemLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLop.ForeColor = System.Drawing.Color.Black;
            this.btnThemLop.HoverState.Parent = this.btnThemLop;
            this.btnThemLop.Image = global::DoAn.Properties.Resources.add_user;
            this.btnThemLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemLop.Location = new System.Drawing.Point(21, 227);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.ShadowDecoration.BorderRadius = 20;
            this.btnThemLop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnThemLop.ShadowDecoration.Parent = this.btnThemLop;
            this.btnThemLop.Size = new System.Drawing.Size(149, 44);
            this.btnThemLop.TabIndex = 15;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BorderRadius = 18;
            this.btnSuaLop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSuaLop.CheckedState.Parent = this.btnSuaLop;
            this.btnSuaLop.CustomImages.Parent = this.btnSuaLop;
            this.btnSuaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuaLop.FillColor2 = System.Drawing.Color.Aqua;
            this.btnSuaLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaLop.ForeColor = System.Drawing.Color.Black;
            this.btnSuaLop.HoverState.Parent = this.btnSuaLop;
            this.btnSuaLop.Image = global::DoAn.Properties.Resources.edit;
            this.btnSuaLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaLop.Location = new System.Drawing.Point(21, 286);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.ShadowDecoration.BorderRadius = 20;
            this.btnSuaLop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSuaLop.ShadowDecoration.Parent = this.btnSuaLop;
            this.btnSuaLop.Size = new System.Drawing.Size(149, 43);
            this.btnSuaLop.TabIndex = 16;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BorderRadius = 18;
            this.btnXoaLop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnXoaLop.CheckedState.Parent = this.btnXoaLop;
            this.btnXoaLop.CustomImages.Parent = this.btnXoaLop;
            this.btnXoaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoaLop.FillColor2 = System.Drawing.Color.Aqua;
            this.btnXoaLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoaLop.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLop.HoverState.Parent = this.btnXoaLop;
            this.btnXoaLop.Image = global::DoAn.Properties.Resources.delete_user;
            this.btnXoaLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaLop.Location = new System.Drawing.Point(21, 346);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.ShadowDecoration.BorderRadius = 20;
            this.btnXoaLop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnXoaLop.ShadowDecoration.Parent = this.btnXoaLop;
            this.btnXoaLop.Size = new System.Drawing.Size(149, 43);
            this.btnXoaLop.TabIndex = 17;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHuyAdd);
            this.groupBox1.Controls.Add(this.btnAddLop);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(180, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 459);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cboGv
            // 
            this.cboGv.Enabled = false;
            this.cboGv.FormattingEnabled = true;
            this.cboGv.Location = new System.Drawing.Point(192, 241);
            this.cboGv.Name = "cboGv";
            this.cboGv.Size = new System.Drawing.Size(165, 21);
            this.cboGv.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nhập thông tin lớp";
            // 
            // btnHuyAdd
            // 
            this.btnHuyAdd.BorderRadius = 18;
            this.btnHuyAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnHuyAdd.CheckedState.Parent = this.btnHuyAdd;
            this.btnHuyAdd.CustomImages.Parent = this.btnHuyAdd;
            this.btnHuyAdd.FillColor2 = System.Drawing.Color.Silver;
            this.btnHuyAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuyAdd.ForeColor = System.Drawing.Color.Black;
            this.btnHuyAdd.HoverState.Parent = this.btnHuyAdd;
            this.btnHuyAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuyAdd.Location = new System.Drawing.Point(208, 341);
            this.btnHuyAdd.Name = "btnHuyAdd";
            this.btnHuyAdd.ShadowDecoration.BorderRadius = 20;
            this.btnHuyAdd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHuyAdd.ShadowDecoration.Parent = this.btnHuyAdd;
            this.btnHuyAdd.Size = new System.Drawing.Size(149, 44);
            this.btnHuyAdd.TabIndex = 21;
            this.btnHuyAdd.Text = "Hủy";
            this.btnHuyAdd.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnAddLop
            // 
            this.btnAddLop.BorderRadius = 18;
            this.btnAddLop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddLop.CheckedState.Parent = this.btnAddLop;
            this.btnAddLop.CustomImages.Parent = this.btnAddLop;
            this.btnAddLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddLop.FillColor2 = System.Drawing.Color.Aqua;
            this.btnAddLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddLop.ForeColor = System.Drawing.Color.Black;
            this.btnAddLop.HoverState.Parent = this.btnAddLop;
            this.btnAddLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddLop.Location = new System.Drawing.Point(40, 341);
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.ShadowDecoration.BorderRadius = 20;
            this.btnAddLop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddLop.ShadowDecoration.Parent = this.btnAddLop;
            this.btnAddLop.Size = new System.Drawing.Size(149, 44);
            this.btnAddLop.TabIndex = 20;
            this.btnAddLop.Text = "OK";
            this.btnAddLop.Click += new System.EventHandler(this.btnAddLop_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.Enabled = false;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(192, 289);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(165, 21);
            this.cboKhoa.TabIndex = 7;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(192, 193);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(165, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(192, 145);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(165, 20);
            this.txtTenLop.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gv Chủ Nhiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClass);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(619, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 459);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvClass
            // 
            this.dgvClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClass.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.Location = new System.Drawing.Point(6, 14);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowHeadersWidth = 30;
            this.dgvClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClass.Size = new System.Drawing.Size(438, 439);
            this.dgvClass.TabIndex = 14;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Khoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Lớp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 109;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Lớp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gv Chủ Nhiệm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 109;
            // 
            // frmQLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1070, 527);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.frmQLLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemLop;
        private Guna.UI2.WinForms.Guna2GradientButton btnSuaLop;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuyAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGv;
    }
}