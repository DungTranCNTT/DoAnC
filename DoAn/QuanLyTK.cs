using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.TK;
using DoAn.XML;

namespace DoAn
{
    public partial class QuanLyTK : Form
    {
        public QuanLyTK()
        {
            InitializeComponent();
        }
        TaiKhoanXML taiKhoanXml = new TaiKhoanXML();
        TaiKhoan taiKhoan = new TaiKhoan();

        private void QuanLyTK_Load(object sender, EventArgs e)
        {
            taiKhoanXml.HienThi(dgvUser);
        }

        bool check1, check2, check3;

        public void check()
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
            cbType.BackColor = Color.White;
            check2 = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = true;
            txtTK.BackColor = Color.White;
            txtMK.Enabled = false;
            txtMK.BackColor = Color.Silver;
            txtOwer.Enabled = false;
            txtOwer.BackColor = Color.Silver;
            cbType.Enabled = false;
            cbType.BackColor = Color.Silver;
            check3 = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

                taiKhoanXml.HienThi(dgvUser);

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
                    taiKhoan.Day = DateTime.Now.ToString("hh:mm:ss dd/mm/yy");
                    //gọi hàm thực hiện thêm tài khoản
                    taiKhoanXml.Them(taiKhoan);
                    taiKhoanXml.HienThi(dgvUser);//load lại bảng 
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
                    taiKhoanXml.HienThi(dgvUser);//load lại bảng 
                }
            }
            if (check3 == true)
            {
                if (txtTK.Text.Trim() != "")
                {

                    taiKhoan.TenDangNhap = txtTK.Text;

                    taiKhoanXml.Xoa(taiKhoan);
                    taiKhoanXml.HienThi(dgvUser);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            txtOwer.Clear();
            txtMK.Clear();
        }
    }
}
