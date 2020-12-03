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
    public partial class frmSuaGiaoVien : Form
    {
        public frmSuaGiaoVien()
        {
            InitializeComponent();
        }
        GiaoVien gv1 = new GiaoVien();
        GiaoVienXML gvXML = new GiaoVienXML();

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
                gv1.Mgv = txtMsv.Text;
                gv1.Hoten = txtTen.Text;
                gv1.Ngaysinh = mtbNgaysinh.Text;
                gv1.Que = txtQue.Text;
                gv1.Diachi = txtDiachi.Text;
                gv1.Email = txtEmail.Text;
                gv1.Sdt = txtSdt.Text;
                if (rbtNam.Checked)
                {
                    gv1.Gioitinh = "Nam";
                }
                if (rbtNu.Checked)
                {
                    gv1.Gioitinh = "Nữ";
                }
                gvXML.Sua(gv1);

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
            }
            else
            {
                MessageBox.Show("Sữa thất bại ");
            }
        }

        private void frmSuaSinhVien_Load(object sender, EventArgs e)
        {
            txtMsv.Text = frmQLGiaoVien.SetValue1;
            txtTen.Text = frmQLGiaoVien.SetValue2;
            if (frmQLGiaoVien.SetValue4 == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            txtDiachi.Text = frmQLGiaoVien.SetValue5;
            txtQue.Text = frmQLGiaoVien.SetValue6;
            txtSdt.Text = frmQLGiaoVien.SetValue7;
            txtEmail.Text = frmQLGiaoVien.SetValue8;
            mtbNgaysinh.Text = frmQLGiaoVien.SetValue3;

        }

        private void frmSuaSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
