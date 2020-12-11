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
            cboGv.Enabled = false;
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cboKhoa.Enabled = true;
            txtTenLop.Focus();
            check1 = false;
            check2 = true;
            check3 = false;
        }

        public string tenlop = "";
        public string malop = "";
        public string gvchunhiem = "";
        public void GetData()
        {
            string fileName = @"..\..\Data\Class.xml";
            XDocument doc = XDocument.Load(fileName);
            var selected_ten = from x in doc.Descendants("class").Where
                                (x => (String)x.Element("TenLop") == txtTenLop.Text.ToUpper())
                                select new
                                {
                                    XMLtenlop = x.Element("TenLop").Value,
                                };
            var selected_ma = from y in doc.Descendants("class").Where
                                (y => (String)y.Element("MaLop") == txtMaLop.Text.ToUpper())
                                select new
                                {
                                    XMLmalop = y.Element("MaLop").Value,
                                };
            var selected_gv = from z in doc.Descendants("class").Where
                              (z => (String)z.Element("GVChuNhiem") == cboGv.SelectedItem.ToString())
                              select new
                              {
                                  XMLgvchunhiem = z.Element("GVChuNhiem").Value,
                              };
            foreach (var x in selected_ten)
            {
                tenlop = x.XMLtenlop;
            }
            foreach (var y in selected_ma)
            {
                malop = y.XMLmalop;
            }
                    foreach (var z in selected_gv)
                    {
                        gvchunhiem = z.XMLgvchunhiem;
                    }
        }
        private void btnAddLop_Click(object sender, EventArgs e)
        {
            GetData();
            if (check1 == true && !String.IsNullOrEmpty(txtTenLop.Text)&& !String.IsNullOrEmpty(txtMaLop.Text) && cboGv.SelectedIndex !=-1 && cboKhoa.SelectedIndex != -1)
            {
                if (tenlop.ToUpper().Contains(txtTenLop.Text.ToUpper()))
                {
                    MessageBox.Show("Lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (malop.Contains(txtMaLop.Text.ToUpper()))
                    {
                        MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        if (gvchunhiem.ToUpper().Contains(cboGv.SelectedItem.ToString().ToUpper()))
                        {
                            MessageBox.Show("Giáo viên này đã chủ nhiệm lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            lop.MaLop = txtMaLop.Text;
                            lop.TenLop = txtTenLop.Text;
                            lop.Khoa = cboKhoa.Text;
                            lop.GVChuNhiem = cboGv.Text;
                            lopXML.TaoLop(lop);
                            Reload();
                            txtMaLop.Clear();
                            txtTenLop.Clear();
                            cboKhoa.SelectedIndex = -1;
                            cboGv.SelectedIndex = -1;
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else if(check2 == true && !String.IsNullOrEmpty(txtTenLop.Text) && !String.IsNullOrEmpty(txtMaLop.Text) && cboGv.SelectedIndex != -1 && cboKhoa.SelectedIndex != -1)
            {
                lop.MaLop = txtMaLop.Text;
                lop.TenLop = txtTenLop.Text;
                lop.Khoa = cboKhoa.Text;
                lop.GVChuNhiem = cboGv.Text;
                lopXML.SuaLop(lop);
                Reload();
                txtMaLop.Clear();
                txtTenLop.Clear();
                cboKhoa.SelectedIndex = -1;
                cboGv.SelectedIndex = -1;
            }
            else if(check3 == true && !String.IsNullOrEmpty(txtTenLop.Text))
            {
                lop.TenLop = txtTenLop.Text;
                lopXML.XoaLop(lop);
                Reload();
                txtMaLop.Clear();
                txtTenLop.Clear();
                cboKhoa.SelectedIndex = -1;
                cboGv.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Mời nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
