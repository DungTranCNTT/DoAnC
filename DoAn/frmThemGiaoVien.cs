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
    public partial class frmThemGiaoVien : Form
    {
        public frmThemGiaoVien()
        {
            InitializeComponent();
        }

        GiaoVien gv = new GiaoVien();
        GiaoVienXML gvXML = new GiaoVienXML();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "" && txtTen.Text != null && txtDiachi.Text != null && txtSdt.Text != null && txtQue.Text != null && txtEmail.Text != null && mtbNgaysinh.Text != null)
            {
                gv.Mgv = gvXML.createMgv().ToString();
                gv.Hoten = txtTen.Text;
                gv.Ngaysinh = mtbNgaysinh.Text;
                gv.Que = txtQue.Text;
                gv.Diachi = txtDiachi.Text;
                gv.Email = txtEmail.Text;
                gv.Sdt = txtSdt.Text;
                if (rbtNam.Checked)
                {
                    gv.Gioitinh = "Nam";
                }
                if (rbtNu.Checked)
                {
                    gv.Gioitinh = "Nữ";
                }
                gvXML.Them(gv);


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
