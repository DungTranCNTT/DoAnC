using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        public string email = "";
        public void GetData()
        {
            string fileName = @"..\..\Data\GiaoVien.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("teacher").Where
                                (x => (String)x.Element("Email") == txtEmail.Text)
                                select new
                                {
                                    XMLemail = x.Element("Email").Value,
                                };
            foreach (var x in selected_user)
            {
                email = x.XMLemail;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (!String.IsNullOrEmpty(txtTen.Text) && !String.IsNullOrEmpty(txtDiachi.Text) && !String.IsNullOrEmpty(txtEmail.Text) &&
                !String.IsNullOrEmpty(txtQue.Text) && !String.IsNullOrEmpty(txtSdt.Text) && rbtNam.Checked || rbtNu.Checked)
            {
                if (reg.IsMatch(txtEmail.Text))
                {
                    GetData();
                    if (email.ToUpper().Contains(txtEmail.Text.ToUpper()))
                    {
                        MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
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
                }
                else
                {
                    MessageBox.Show("Sai định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtSdt.Text = frmQLGiaoVien.SetValue8;
            txtEmail.Text = frmQLGiaoVien.SetValue7;
            mtbNgaysinh.Text = frmQLGiaoVien.SetValue3;

        }

        private void frmSuaSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số 0-9", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
