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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtTK.Text.Trim() != "")
            {
                // gán dữ liệu
                taiKhoan.TenDangNhap = txtTK.Text;
                taiKhoan.MatKhau = txtMK.Text;
                taiKhoan.TrangThai = cbType.Text;
                taiKhoan.owner = txtOwer.Text;
                //gọi hàm thực hiện thêm tài khoản
                taiKhoanXml.Them(taiKhoan);
                taiKhoanXml.HienThi(dgvUser);//load lại bảng 
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtTK.Text.Trim() !="")
            {
                taiKhoan.TenDangNhap = txtTK.Text;

                taiKhoanXml.Xoa(taiKhoan);
                taiKhoanXml.HienThi(dgvUser);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
