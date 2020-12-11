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
using DoAn.Service;
using DoAn.XML;
namespace DoAn
{
    public partial class frmQLKhoa : Form
    {
        public frmQLKhoa()
        {
            InitializeComponent();
        }
        Khoa khoa = new Khoa();
        KhoaXML khoaXML = new KhoaXML();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLKhoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.Rows.Clear();
            khoaXML.ReloadKhoa(dgvKhoa);
        }

        private void Reload()
        {
            dgvKhoa.Rows.Clear();
            khoaXML.ReloadKhoa(dgvKhoa);
        }

        bool check1, check2, check3;

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtMa.Focus();
            check1 = false;
            check2 = true;
            check3 = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtTen.Focus();
            check1 = false;
            check2 = false;
            check3 = true;
        }
        public string tenkhoa = "";
        public string makhoa = "";

        public void GetDataTenKhoa()
        {
            string fileName = @"..\..\Data\Khoa.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("faculty").Where
                                (x => (String)x.Element("TenKhoa") == txtTen.Text.ToUpper())
                                select new
                                {
                                    XMLtenkhoa = x.Element("TenKhoa").Value,
                                };
            foreach (var x in selected_user)
            {
                tenkhoa = x.XMLtenkhoa;
            }
        }

        public void GetDataMaKhoa()
        {
            string fileName = @"..\..\Data\Khoa.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_user = from x in doc.Descendants("faculty").Where
                                (x => (String)x.Element("MaKhoa") == txtMa.Text.ToUpper())
                                select new
                                {
                                    XMLmakhoa = x.Element("MaKhoa").Value,
                                };
            foreach (var x in selected_user)
            {
                makhoa = x.XMLmakhoa;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            GetDataMaKhoa();
            GetDataTenKhoa();
            if (check1 == true && !String.IsNullOrEmpty(txtMa.Text) && !String.IsNullOrEmpty(txtTen.Text))
            {
                if (tenkhoa.ToUpper().Contains(txtTen.Text.ToUpper()))
                {
                    MessageBox.Show("Tên khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (makhoa.ToUpper().Contains(txtMa.Text.ToUpper()))
                    {
                        MessageBox.Show("Mã khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        khoa.TenKhoa = txtTen.Text;
                        khoa.MaKhoa = txtMa.Text;
                        khoaXML.TaoKhoa(khoa);
                        Reload();
                        txtMa.Clear();
                        txtTen.Clear();
                    }
                }
            }
            else if (check3 == true && !String.IsNullOrEmpty(txtMa.Text) && !String.IsNullOrEmpty(txtTen.Text))
            {
                khoa.TenKhoa = txtTen.Text;
                khoaXML.XoaKhoa(khoa);
                Reload();
                txtMa.Clear();
                txtTen.Clear();
            }
            else
            {
                MessageBox.Show("Mời nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtMa.Clear();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txtTen.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtTen.Focus();
            check1 = true;
            check2 = false;
            check3 = false;
        }

        public void Check()
        {
            check1 = false;
            check2 = false;
            check3 = false;
        }

        
    }
}
