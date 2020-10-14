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

namespace DoAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "admin" && txtPass.Text == "123")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else if (users.Contains(txtID.Text) && pass.Contains(txtPass.Text))
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                txtID.ResetText();
                txtPass.ResetText();
                txtID.Focus();
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
            StreamReader sr = new StreamReader("login.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray() , StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
        }

    }
}
