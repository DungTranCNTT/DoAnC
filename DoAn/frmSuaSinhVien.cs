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
    public partial class frmSuaSinhVien : Form
    {
        public frmSuaSinhVien()
        {
            InitializeComponent();
        }
        SinhVien sv1 = new SinhVien();
        SinhVienXML svXML = new SinhVienXML();

        private void btnRs_Click(object sender, EventArgs e)
        {
            txtDiachi.Clear();
            txtEmail.Clear();
            txtQue.Clear();
            txtSdt.Clear();
            txtTen.Clear();
            mtbNgaysinh.Clear();
            txtTen.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMsv.Text.Trim() != "" && txtTen.Text != null && txtDiachi.Text != null && txtSdt.Text != null && txtQue.Text != null && txtEmail.Text != null && mtbNgaysinh.Text != null)
            {
                sv1.Msv = txtMsv.Text;
                sv1.Hoten = txtTen.Text;
                sv1.Ngaysinh = mtbNgaysinh.Text;
                sv1.Que = txtQue.Text;
                sv1.Diachi = txtDiachi.Text;
                sv1.Email = txtEmail.Text;
                sv1.Sdt = txtSdt.Text;
                if (rbtNam.Checked)
                {
                    sv1.Gioitinh = "Nam";
                }
                if (rbtNu.Checked)
                {
                    sv1.Gioitinh = "Nữ";
                }
                svXML.Sua(sv1);

                if (MessageBox.Show("Sửa thành công bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    txtDiachi.Clear();
                    txtEmail.Clear();
                    txtQue.Clear();
                    txtSdt.Clear();
                    txtTen.Clear();
                    mtbNgaysinh.Clear();
                    txtTen.Focus();
                }
            }else
            {
                MessageBox.Show("Sữa thất bại ");
            }
        }

        private void frmSuaSinhVien_Load(object sender, EventArgs e)
        {
            txtMsv.Text = frmQLSinhVien.SetValue1;
            txtTen.Text = frmQLSinhVien.SetValue2;
            if (frmQLSinhVien.SetValue4 == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            txtDiachi.Text = frmQLSinhVien.SetValue5;
            txtQue.Text = frmQLSinhVien.SetValue6;
            txtSdt.Text = frmQLSinhVien.SetValue7;
            txtEmail.Text = frmQLSinhVien.SetValue8;
            mtbNgaysinh.Text = frmQLSinhVien.SetValue3;

        }

        private void frmSuaSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
