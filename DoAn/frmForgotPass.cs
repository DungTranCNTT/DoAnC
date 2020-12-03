using DoAn.Service;
using DoAn.XML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAn
{
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
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

        public void checkLength()
        {
            if(txtSn.TextLength > 7)
            {
                MessageBox.Show("Số bí mật không được quá 7 số");
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string fileName = @"..\..\Data\user.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == txtUser.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpwd = x.Element("pwd").Value,
                                    XMLtype = x.Element("type").Value,
                                    XMLowner = x.Element("owner").Value,
                                    XMLday = x.Element("day").Value,
                                    XMLemail = x.Element("Email").Value,
                                    XMLsdt = x.Element("SDT").Value,
                                    XMLsbm = x.Element("SBM").Value,
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                pass = x.XMLpwd;
                type = x.XMLtype;
                owner = x.XMLowner;
                day = x.XMLday;
                email = x.XMLemail;
                sdt = x.XMLsdt;
                sbm = x.XMLsbm;
            }
            if (users.Contains(txtUser.Text) && sbm.Contains(txtSn.Text))
            {
                taikhoan.TenDangNhap = txtUser.Text;
                taikhoan.MatKhau = txtNewPass.Text;
                taikhoan.TrangThai = type.ToString();
                taikhoan.owner = owner.ToString();
                taikhoan.Day = day.ToString();
                taikhoan.Email = email.ToString();
                taikhoan.Sdt = sdt.ToString();
                taikhoan.Sobimat = txtSn.Text;
                taiKhoanXML.DoiMK(taikhoan);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc số bí mật ");
            }
        }

        private void txtSn_TextChanged(object sender, EventArgs e)
        {
            checkLength();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
