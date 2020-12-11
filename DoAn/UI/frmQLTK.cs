using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DoAn.Service;
using DoAn.XML;

namespace DoAn
{
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }
        TaiKhoanXML taiKhoanXml = new TaiKhoanXML();
        TaiKhoan taiKhoan = new TaiKhoan();

        private void QuanLyTK_Load(object sender, EventArgs e)
        {
            taiKhoanXml.HienThi(dgvUser);
            cbType.Items.Add("Admin");
            cbType.Items.Add("Giáo Viên");
        }

        bool check1, check2, check3;

        public void Check()
        {
            check1 = false;
            check2 = false;
            check3 = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = true;
            txtTK.BackColor = Color.White;
            txtMK.Enabled = true;
            txtMK.BackColor = Color.White;
            txtOwer.Enabled = true;
            txtOwer.BackColor = Color.White;
            cbType.Enabled = true;
            cbType.BackColor = Color.White;
            check1 = true;
            check2 = false;
            check3 = false;
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = false;
            txtTK.BackColor = Color.White;
            txtMK.Enabled = true;
            txtMK.BackColor = Color.White;
            txtOwer.Enabled = true;
            txtOwer.BackColor = Color.White;
            cbType.Enabled = true;
            cbType.SelectedIndex = -1;
            cbType.BackColor = Color.White;
            check2 = true;
            check1 = false;
            check3 = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = true;
            txtTK.BackColor = Color.White;
            txtMK.Enabled = false;
            txtMK.Clear();
            txtMK.BackColor = Color.Silver;
            txtOwer.Enabled = false;
            txtOwer.Clear();
            txtOwer.BackColor = Color.Silver;
            cbType.Enabled = false;
            cbType.SelectedIndex = -1;
            cbType.BackColor = Color.Silver;
            check3 = true;
            check2 = false;
            check1 = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Reload();

        }

        private void Reload()
        {
            dgvUser.Rows.Clear();
            taiKhoanXml.Reload(dgvUser);
        }
        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvUser.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtMK.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            cbType.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            txtOwer.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
        }
        public string users = "";
        public void GetDataUser()
        {
            string fileName = @"..\..\Data\User.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == txtTK.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            GetDataUser();
            if (check1 == true)
            {
                if (!String.IsNullOrEmpty(txtTK.Text) && !String.IsNullOrEmpty(txtMK.Text) && !String.IsNullOrEmpty(txtOwer.Text) && cbType.SelectedIndex != -1)
                {
                    if (users.ToUpper().Contains(txtTK.Text.ToUpper()))
                    {
                        MessageBox.Show("Tài khoản đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // gán dữ liệu
                        taiKhoan.TenDangNhap = txtTK.Text;
                        taiKhoan.MatKhau = txtMK.Text;
                        taiKhoan.TrangThai = cbType.Text;
                        taiKhoan.owner = txtOwer.Text;
                        taiKhoan.Day = DateTime.Now.ToString("dd/mm/yy");
                        //gọi hàm thực hiện thêm tài khoản
                        taiKhoanXml.Them(taiKhoan);
                        Reload();//load lại bảng 
                        txtTK.Clear();
                        txtMK.Clear();
                        txtOwer.Clear();
                        cbType.SelectedIndex = -1;
                    }
                }
                else if (check2 == true)
                {
                    if (!String.IsNullOrEmpty(txtTK.Text) && !String.IsNullOrEmpty(txtMK.Text) && !String.IsNullOrEmpty(txtOwer.Text) && cbType.SelectedIndex != -1)
                    {

                        // gán dữ liệu
                        taiKhoan.TenDangNhap = txtTK.Text;
                        taiKhoan.MatKhau = txtMK.Text;
                        taiKhoan.TrangThai = cbType.Text;
                        taiKhoan.owner = txtOwer.Text;
                        taiKhoan.Day = DateTime.Now.ToString("dd/mm/yy");
                        //gọi hàm thực hiện thêm tài khoản
                        taiKhoanXml.Sua(taiKhoan);
                        dgvUser.Rows.Clear();
                        taiKhoanXml.Reload(dgvUser);//load lại bảng 
                    }
                }
                else if (check3 == true)
                {
                    if (txtTK.Text.Trim() != "")
                    {

                        taiKhoan.TenDangNhap = txtTK.Text;
                        taiKhoanXml.Xoa(taiKhoan);
                        Reload();
                    }
                }
                else
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            txtOwer.Clear();
            txtMK.Clear();
            cbType.SelectedIndex = -1;
        }
    }
}
