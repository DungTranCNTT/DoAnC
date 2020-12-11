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

        public string email = "";
        public void GetData()
        {
            string fileName = @"..\..\Data\Sinhvien.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("student").Where
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
