using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            txtTK.Enabled = true;
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


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (txtTK.Text.Trim() != "")
                {
                    
                        // gán dữ liệu
                        taiKhoan.TenDangNhap = txtTK.Text;
                        taiKhoan.MatKhau = txtMK.Text;
                        taiKhoan.TrangThai = cbType.Text;
                        taiKhoan.owner = txtOwer.Text;
                        taiKhoan.Day = DateTime.Now.ToString("dd/mm/yy");
                        //gọi hàm thực hiện thêm tài khoản
                        taiKhoanXml.Them(taiKhoan);
                        Reload() ;//load lại bảng 
                    txtTK.Clear();
                    txtMK.Clear();
                    txtOwer.Clear();
                    cbType.SelectedIndex = -1;
                }
            }
            if (check2 == true)
            {
                if (txtTK.Text.Trim() != "")
                {

                    // gán dữ liệu
                    taiKhoan.TenDangNhap = txtTK.Text;
                    taiKhoan.MatKhau = txtMK.Text;
                    taiKhoan.TrangThai = cbType.Text;
                    taiKhoan.owner = txtOwer.Text;
                    //gọi hàm thực hiện thêm tài khoản
                    taiKhoanXml.Sua(taiKhoan);
                    dgvUser.Rows.Clear();
                    taiKhoanXml.HienThi(dgvUser);//load lại bảng 
                }
            }
            if (check3 == true)
            {
                if (txtTK.Text.Trim() != "")
                {

                    taiKhoan.TenDangNhap = txtTK.Text;
                    taiKhoanXml.Xoa(taiKhoan);
                    Reload();
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
