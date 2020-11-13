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
using System.Xml.Linq;

namespace DoAn
{
    public partial class frmThemSinhVien : Form
    {
        public frmThemSinhVien()
        {
            InitializeComponent();
        }
        SinhVien sv = new SinhVien();
        SinhVienXML svXML = new SinhVienXML();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "" && txtTen.Text != null && txtDiachi.Text != null && txtSdt.Text !=null && txtQue.Text != null && txtEmail.Text != null && mtbNgaysinh.Text != null)
            {

                sv.Msv = svXML.createMSV();
                sv.Hoten = txtTen.Text;
                sv.Ngaysinh = mtbNgaysinh.Text;
                sv.Que = txtQue.Text;
                sv.Diachi = txtDiachi.Text;
                sv.Email = txtEmail.Text;
                sv.Sdt = txtSdt.Text;
                if (rbtNam.Checked)
                {
                    sv.Gioitinh = "Nam";
                }
                if (rbtNu.Checked)
                {
                    sv.Gioitinh = "Nữ";
                }
                svXML.Them(sv);
                

                if (MessageBox.Show("Thêm thành công tiếp tục thêm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtDiachi.Clear();
                    txtEmail.Clear();
                    txtQue.Clear();
                    txtSdt.Clear();
                    txtTen.Clear();
                    mtbNgaysinh.Clear();
                    txtTen.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin");
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSdt.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số 0-9");
                txtSdt.Text = txtSdt.Text.Remove(txtSdt.Text.Length - 1);
            }
        }

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

        private void frmThemSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
