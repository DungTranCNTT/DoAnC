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
        private void frmDoiMk_Load(object sender, EventArgs e)
        {
            txtUser.Text = frmLogin.check2.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
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
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                pass = x.XMLpwd;
                type = x.XMLtype;
                owner = x.XMLowner;
                day = x.XMLday;
            }
            if (users.Contains(txtUser.Text))
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
                MessageBox.Show("Cập nhập thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thông tin không thành công");
            }
        }
    }
}
