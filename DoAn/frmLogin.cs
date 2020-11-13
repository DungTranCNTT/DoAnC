using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace DoAn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string users = "";
        public string pass = "";
        public string type = "";

        public static bool HasSpecialChar(string input)
        {
            string[] specialChar = {"@", "|", "!", "#", "$", "%", "&", "/", "(", ")", "=", "?", "»", "«", "@", "£", "§", "€", "{", "}", ".", "-", ";", "'", "<", ">", "_", "," };
            foreach (var item in specialChar)
            {
                if (input.Contains(item))
                {
                    MessageBox.Show("Tài khoản không được sử dụng ký tự đặc biệt","Cảnh báo");
                    return false;
                }
            }

            return true;
        }

        public bool CheckEmty()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Bạn chưa nhập Username";
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Bạn chưa nhập Password";
                txtPass.Focus();
                return false;
            }
            return true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                if (txtPass.Focus())
                {
                    txtPass.Clear();
                    txtPass.UseSystemPasswordChar = true;
                }
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            HasSpecialChar(txtID.Text);
        }

        private void btnShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnFogotpass_Click(object sender, EventArgs e)
        {
            Forgotpass forgot = new Forgotpass();
            forgot.Show();
        }
        private void txtID_MouseEnter(object sender, EventArgs e)
        {
            if (txtID.Text == "Username")
                txtID.Clear();
        }
        private void txtPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Clear();
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            DangNhap();
        }
        public void DangNhap()
        {
            string fileName = @"C:\Users\user\Source\Repos\setokid\DoAnC\DoAn\user.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == txtID.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpwd = x.Element("pwd").Value,
                                    XMLtype = x.Element("type").Value,
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                pass = x.XMLpwd;
                type = x.XMLtype;
            }
            if (CheckEmty())
            {
                if (HasSpecialChar(txtID.Text))
                {
                    if (users.Contains(txtID.Text) && pass.Contains(txtPass.Text) && type.Contains("Admin"))
                    {
                        this.Hide();
                        frmMain main = new frmMain();
                        main.ShowDialog();
                    }
                    else if (users.Contains(txtID.Text) && pass.Contains(txtPass.Text) && type.Contains("Giáo Viên"))
                    {
                        this.Hide();
                        frmGiaoVien giaovien = new frmGiaoVien();
                        giaovien.ShowDialog();
                    }
                    else if (users.Contains(txtID.Text) && pass.Contains(txtPass.Text) && type.Contains("Sinh Viên"))
                    {
                        this.Hide();
                    }
                    else
                    {
                        lblThongBao.Visible = true;
                        lblThongBao.Text = "Sai Tài khoản hoặc Mật khẩu";
                        txtID.ResetText();
                        txtPass.ResetText();
                        txtID.Focus();
                    }
                }
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
