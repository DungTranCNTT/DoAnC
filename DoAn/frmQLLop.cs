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
    public partial class frmQLLop : Form
    {
        public frmQLLop()
        {
            InitializeComponent();
        }
        Class lop = new Class();
        ClassXML lopXML = new ClassXML();
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvClass.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void Reload()
        {
            dgvClass.Rows.Clear();
            lopXML.ReloadLop(dgvClass);
        }

        bool check1, check2, check3;

        public void Check()
        {
            check1 = false;
            check2 = false;
            check3 = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGV.Enabled = true;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            cboKhoa.Enabled = true;
            txtTen.Focus();
            check1 = true;
            check2 = false;
            check3 = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtGV.Enabled = true;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            cboKhoa.Enabled = true;
            txtTen.Focus();
            check1 = false;
            check2 = true;
            check3 = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (check1 == true && txtTen.Text.Trim() != "")
            {
                lop.MaLop = txtMa.Text;
                lop.TenLop = txtTen.Text;
                lop.Khoa = cboKhoa.Text;
                lop.GVChuNhiem = txtGV.Text;
                lopXML.TaoLop(lop);
                Reload();
            }
            if(check2 == true && txtTen.Text.Trim() != "")
            {
                lop.MaLop = txtMa.Text;
                lop.TenLop = txtTen.Text;
                lop.Khoa = cboKhoa.Text;
                lop.GVChuNhiem = txtGV.Text;
                lopXML.SuaLop(lop);
                Reload();
            }
            if(check3 == true && txtTen.Text.Trim() != "")
            {
                lop.TenLop = txtTen.Text;
                lopXML.XoaLop(lop);
                Reload();
            }
            txtGV.Clear();
            txtMa.Clear();
            txtTen.Clear();
            cboKhoa.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGV.Clear();
            txtMa.Clear();
            txtTen.Clear();
            cboKhoa.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvClass.CurrentRow.Cells[2].Value.ToString();
            txtMa.Text = dgvClass.CurrentRow.Cells[1].Value.ToString();
            txtGV.Text = dgvClass.CurrentRow.Cells[3].Value.ToString();
            cboKhoa.Text = dgvClass.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtGV.Enabled = false;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            cboKhoa.Enabled = false;
            txtTen.Focus();
            check1 = false;
            check2 = false;
            check3 = true;
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            lopXML.HienThiLopDS(dgvClass);
        }
    }
}
