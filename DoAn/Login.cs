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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string users = "";
        public string pass = "";

        public static bool hasSpecialChar(string input)
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

        public bool checkEmty()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Cảnh báo");
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo");
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\user\Source\Repos\setokid\DoAnC\DoAn\user.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == txtID.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpwd = x.Element("pwd").Value,
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                pass = x.XMLpwd;
            }
            if (checkEmty())
            {
                if (hasSpecialChar(txtID.Text))
                {
                    if (users.Contains(txtID.Text) && pass.Contains(txtPass.Text) && Array.IndexOf(users.ToArray(), txtID.Text) == Array.IndexOf(pass.ToArray(), txtPass.Text))
                    {
                        this.Hide();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu","Cảnh báo");
                        txtID.ResetText();
                        txtPass.ResetText();
                        txtID.Focus();
                    }
                }
            }

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
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
            hasSpecialChar(txtID.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
