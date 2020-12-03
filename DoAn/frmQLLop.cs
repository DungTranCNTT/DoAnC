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
        private void dgvClass_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            cboGv.Enabled = true;
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cboKhoa.Enabled = true;
            txtTenLop.Focus();
            check1 = true;
            check2 = false;
            check3 = false;
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            cboGv.Enabled = true;
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cboKhoa.Enabled = true;
            txtTenLop.Focus();
            check1 = false;
            check2 = true;
            check3 = false;
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            if (check1 == true && txtTenLop.Text.Trim() != "")
            {
                lop.MaLop = txtMaLop.Text;
                lop.TenLop = txtTenLop.Text;
                lop.Khoa = cboKhoa.Text;
                lop.GVChuNhiem = cboGv.Text;
                lopXML.TaoLop(lop);
                Reload();
            }
            if(check2 == true && txtTenLop.Text.Trim() != "")
            {
                lop.MaLop = txtMaLop.Text;
                lop.TenLop = txtTenLop.Text;
                lop.Khoa = cboKhoa.Text;
                lop.GVChuNhiem = cboGv.Text;
                lopXML.SuaLop(lop);
                dgvClass.Rows.Clear();
                lopXML.HienThiLop(dgvClass);
            }
            if(check3 == true && txtTenLop.Text.Trim() != "")
            {
                lop.TenLop = txtTenLop.Text;
                lopXML.XoaLop(lop);
                Reload();
            }
            txtMaLop.Clear();
            txtTenLop.Clear();
            cboKhoa.SelectedIndex = -1;
            cboGv.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cboKhoa.SelectedIndex = -1;
            cboGv.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLop.Text = dgvClass.CurrentRow.Cells[2].Value.ToString();
            txtMaLop.Text = dgvClass.CurrentRow.Cells[1].Value.ToString();
            cboGv.Text = dgvClass.CurrentRow.Cells[3].Value.ToString();
            cboKhoa.Text = dgvClass.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            cboGv.Enabled = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = true;
            cboKhoa.Enabled = false;
            txtTenLop.Focus();
            check1 = false;
            check2 = false;
            check3 = true;
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            lopXML.HienThiLopDS(dgvClass);
            lopXML.getDSKhoa(cboKhoa);
            lopXML.getDSGiaoVien(cboGv);
        }
    }
}
