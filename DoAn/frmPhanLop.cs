using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.XML;
using DoAn.Service;

namespace DoAn
{
    public partial class frmPhanLop : Form
    {
        public frmPhanLop()
        {
            InitializeComponent();
        }

        ClassXML classxml = new ClassXML();
        SinhVien sinhvien = new SinhVien();
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            classxml.HienThiLop(dgvSinhVien);
            classxml.getDSLop(cboLop);
            classxml.getDSKhoa(cboKhoa);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void Reload()
        {
            dgvSinhVien.Rows.Clear();
            classxml.HienThiLop(dgvSinhVien);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSinhVien.CurrentRow.Cells[0].Value != null)
            {
                lblMsv.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
                lblTen.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
                lblNgaySinh.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
                lblGioiTinh.Text = dgvSinhVien.CurrentRow.Cells[3].Value.ToString();
                cboLop.Text = dgvSinhVien.CurrentRow.Cells[4].Value.ToString();
                cboKhoa.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
                lblDiaChi.Text = dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
                lblQue.Text = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
                lblEmail.Text = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
                lblSdt.Text = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sinhvien.Msv = lblMsv.Text;
            sinhvien.Hoten = lblTen.Text;
            sinhvien.Ngaysinh = lblNgaySinh.Text;
            sinhvien.Gioitinh = lblGioiTinh.Text;
            sinhvien.Lop = cboLop.Text;
            sinhvien.Khoa = cboKhoa.Text;
            sinhvien.Diachi = lblDiaChi.Text;
            sinhvien.Que = lblQue.Text;
            sinhvien.Email = lblEmail.Text;
            sinhvien.Sdt = lblSdt.Text;
            classxml.ThemLop(sinhvien);
            Reload();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sinhvien.Msv = lblMsv.Text;
            sinhvien.Hoten = lblTen.Text;
            sinhvien.Ngaysinh = lblNgaySinh.Text;
            sinhvien.Gioitinh = lblGioiTinh.Text;
            sinhvien.Lop = cboLop.Text;
            sinhvien.Khoa = cboKhoa.Text;
            sinhvien.Diachi = lblDiaChi.Text;
            sinhvien.Que = lblQue.Text;
            sinhvien.Email = lblEmail.Text;
            sinhvien.Sdt = lblSdt.Text;
            classxml.ChuyenLop(sinhvien);
            Reload();
        }
    }
}
