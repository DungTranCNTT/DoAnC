using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            khoaXML.HienThiDSKhoa(dgvKhoa);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (check1 == true && txtMa.Text.Trim() != "")
            {
                khoa.TenKhoa = txtMa.Text;
                khoa.MaKhoa = txtMa.Text;
                khoaXML.TaoKhoa(khoa);
                Reload();
            }
            if (check2 == true && txtMa.Text.Trim() != "")
            {
                khoa.TenKhoa = txtMa.Text;
                khoa.MaKhoa = txtMa.Text;
                khoaXML.SuaKhoa(khoa);
                Reload();
            }
            if (check3 == true && txtMa.Text.Trim() != "")
            {
                khoa.TenKhoa = txtMa.Text;
                khoaXML.XoaKhoa(khoa);
                Reload();
            }
            txtMa.Clear();
            txtTen.Clear();
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
            txtMa.Focus();
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
