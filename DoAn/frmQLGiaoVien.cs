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
    public partial class frmQLGiaoVien : Form
    {
        public frmQLGiaoVien()
        {
            InitializeComponent();
        }
        GiaoVienXML giaoVienxml = new GiaoVienXML();
        GiaoVien giaoVien = new GiaoVien();
        public void Reload()
        {
            dgvGiaoVien.Rows.Clear();
            giaoVienxml.Reload(dgvGiaoVien);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien frmThemGiaovien = new frmThemGiaoVien();
            frmThemGiaovien.ShowDialog();
            Reload();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            giaoVienxml.HienThi(dgvGiaoVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kích đúp giáo viên muốn sửa", "Thông báo");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
        public static string SetValue1 = "";
        public static string SetValue2 = "";
        public static string SetValue3 = "";
        public static string SetValue4 = "";
        public static string SetValue5 = "";
        public static string SetValue6 = "";
        public static string SetValue7 = "";
        public static string SetValue8 = "";
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSuaGiaoVien frmSuaGiaoVien = new frmSuaGiaoVien();
            if (dgvGiaoVien.CurrentRow.Cells[0].Value != null)
            {
                SetValue1 = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
                SetValue2 = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
                SetValue3 = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
                if (dgvGiaoVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    SetValue4 = "Nam";
                }
                else
                {
                    SetValue4 = "Nu";
                }
                SetValue5 = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
                SetValue6 = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
                SetValue7 = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
                SetValue8 = dgvGiaoVien.CurrentRow.Cells[7].Value.ToString();
                frmSuaGiaoVien.ShowDialog();
                Reload();
            }
            else
            {
                frmThemGiaoVien frmThem = new frmThemGiaoVien();
                frmThem.ShowDialog();
                Reload();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaGiaoVien frmXoa = new frmXoaGiaoVien();
            frmXoa.ShowDialog();
            dgvGiaoVien.Rows.Clear();
            giaoVienxml.Reload(dgvGiaoVien);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() != "")
            {
                giaoVien.Mgv = txtTim.Text;

                giaoVienxml.TimKiem(giaoVien, dgvGiaoVien);
            }
        }
        Bitmap bitmap;
        private void btnSave_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void iSave()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DanhSachGiaoVien";

            for (int i = 1; i < dgvGiaoVien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvGiaoVien.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvGiaoVien.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvGiaoVien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvGiaoVien.Rows[i].Cells[j].Value.ToString();
                }
            }


        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0, 850, dgvGiaoVien.Height);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvGiaoVien.Height;
            dgvGiaoVien.Height = dgvGiaoVien.RowCount * dgvGiaoVien.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvGiaoVien.Width, dgvGiaoVien.Height);
            dgvGiaoVien.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvGiaoVien.Width, dgvGiaoVien.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvGiaoVien.Height = height;
        }

    }
}
