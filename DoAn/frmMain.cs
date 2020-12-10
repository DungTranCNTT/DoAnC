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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string users = "";
        public string day = "";
        public string type = "";
        private void btnQuanly_Click(object sender, EventArgs e)
        {
            frmQLTK ql = new frmQLTK();
            ql.ShowDialog();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (frmLogin.check1 == "Giáo Viên")
            {
                string fileName = @"..\..\Data\User.xml";
                XDocument doc = XDocument.Load(fileName);
                var selected_user = from x in doc.Descendants("users").Where
                                    (x => (String)x.Element("username") == frmLogin.check2)
                                    select new
                                    {
                                        XMLuser = x.Element("username").Value,
                                        XMLday = x.Element("day").Value,
                                        XMLtype = x.Element("type").Value,
                                    };
                foreach (var x in selected_user)
                {
                    users = x.XMLuser;
                    type = x.XMLtype;
                    day = x.XMLday;
                }

                lblTen.Text = users.ToString();
                lblDate.Text = day.ToString();
                lblLoai.Text = type.ToString();

                btnQLGiaoVien.Enabled = false;
                btnQLKhoa.Enabled = false;
                btnQLLop.Enabled = false;
                btnQuanly.Enabled = false;
                frmLogin.check1 = "";
            }
            else
            {
                string fileName = @"..\..\Data\User.xml";
                XDocument doc = XDocument.Load(fileName);
                var selected_user = from x in doc.Descendants("users").Where
                                    (x => (String)x.Element("username") == frmLogin.check2)
                                    select new
                                    {
                                        XMLuser = x.Element("username").Value,
                                        XMLday = x.Element("day").Value,
                                        XMLtype = x.Element("type").Value,
                                    };
                foreach (var x in selected_user)
                {
                    users = x.XMLuser;
                    type = x.XMLtype;
                    day = x.XMLday;
                }

                lblTen.Text = users.ToString();
                lblDate.Text = day.ToString();
                lblLoai.Text = type.ToString();
                frmLogin.check1 = "";
            }
        }

        public void checkInfo(string user)
        {
            string fileName = @"..\..\Data\User.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (String)x.Element("username") == user)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLday = x.Element("day").Value,
                                    XMLtype = x.Element("type").Value,
                                };
            foreach (var x in selected_user)
            {
                users = x.XMLuser;
                type = x.XMLtype;
                day = x.XMLday;
            }

            lblTen.Text = users.ToString();
            lblDate.Text = day.ToString();
            lblLoai.Text = type.ToString();
        }
        private void btnQLLop_Click(object sender, EventArgs e)
        {
            frmQLLop lop = new frmQLLop();
            lop.ShowDialog();
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            frmPhanLop phanlop = new frmPhanLop();
            phanlop.ShowDialog();
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            frmQLKhoa khoa = new frmQLKhoa();
            khoa.ShowDialog();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            frmQLSinhVien qlsv = new frmQLSinhVien();
            qlsv.ShowDialog();
        }

        private void btnQLGiaoVien_Click(object sender, EventArgs e)
        {
            frmQLGiaoVien qlgv = new frmQLGiaoVien();
            qlgv.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMk doimk = new frmDoiMk();
            doimk.ShowDialog();
        }

        private void btnQuanly_Click_1(object sender, EventArgs e)
        {
            frmQLTK qltk = new frmQLTK();
            qltk.ShowDialog();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            frmCapNhapTT cntt = new frmCapNhapTT();
            cntt.ShowDialog();
        }
    }
}
