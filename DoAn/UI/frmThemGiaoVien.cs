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

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
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
