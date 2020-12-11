using DoAn.Service;
using DoAn.XML;
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

namespace DoAn
{
    public partial class frmCapNhapTT : Form
    {
        public frmCapNhapTT()
        {
            InitializeComponent();
        }

        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanXML taiKhoanXML = new TaiKhoanXML();
        public string users = "";
        public string pass = "";
        public string type = "";
        public string owner = "";
        public string day = "";
        public string email = "";
        public string sdt = "";
        public string sbm = "";
        public string checkemail = "";
        private void frmDoiMk_Load(object sender, EventArgs e)
        {
            GetData();
            txtUser.Text = frmLogin.check2.ToString();
            txtEmail.Text = email.ToString();
            txtSDT.Text = sdt.ToString();
            txtSn.Text = sbm.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetData()
        {
            string fileName = @"..\..\Data\user.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == frmLogin.check2)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpwd = x.Element("pwd").Value,
                                    XMLtype = x.Element("type").Value,
                                    XMLowner = x.Element("owner").Value,
                                    XMLday = x.Element("day").Value,
                                    XMLEmail = x.Element("Email").Value,
                                    XMLSdt = x.Element("SDT").Value,
                                    XMLSbm = x.Element("SBM").Value,
                                };
            var selected_email = from y in doc.Descendants("users").Where
                                 (y => (String)y.Element("Email") == txtEmail.Text)
                                 select new
                                 {
                                     xmlemail = y.Element("Email").Value,
                                 };
            foreach (var y in selected_email)
            {
                checkemail = y.xmlemail;
            }
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                pass = x.XMLpwd;
                type = x.XMLtype;
                owner = x.XMLowner;
                day = x.XMLday;
                email = x.XMLEmail;
                sdt = x.XMLSdt;
                sbm = x.XMLSbm;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            GetData();
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (reg.IsMatch(txtEmail.Text))
            {
                    if (checkemail.ToUpper().Contains(txtEmail.Text.ToUpper()))
                    {
                        MessageBox.Show("Email đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        taikhoan.TenDangNhap = txtUser.Text;
                        taikhoan.MatKhau = pass.ToString();
                        taikhoan.TrangThai = type.ToString();
                        taikhoan.owner = owner.ToString();
                        taikhoan.Day = day.ToString();
                        taikhoan.Email = txtEmail.Text;
                        taikhoan.Sdt = txtSDT.Text;
                        taikhoan.Sobimat = txtSn.Text;
                        taiKhoanXML.DoiMK(taikhoan);
                        MessageBox.Show("Cập nhập thông tin thành công", "Thông Báo", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("Email sai định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    MessageBox.Show("Chỉ được nhập số 0-9" ,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void txtSn_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    MessageBox.Show("Chỉ được nhập số 0-9", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}
