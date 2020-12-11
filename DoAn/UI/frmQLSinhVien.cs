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
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }
        SinhVienXML sinhVienxml = new SinhVienXML();
        SinhVien sinhVien = new SinhVien();

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmThem = new frmThemSinhVien();
            frmThem.ShowDialog();
            Reload();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            sinhVienxml.HienThi(dgvSinhVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kích đúp sinh viên muốn sửa", "Thông báo");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            dgvSinhVien.Rows.Clear();
            sinhVienxml.Reload(dgvSinhVien);
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
            frmSuaSinhVien frmSuaSinhVien = new frmSuaSinhVien();
            if (dgvSinhVien.CurrentRow.Cells[0].Value != null)
            {
                SetValue1 = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
                SetValue2 = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
                SetValue3 = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
                if (dgvSinhVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    SetValue4 = "Nam";
                }
                else
                {
                    SetValue4 = "Nu";
                }
                SetValue5 = dgvSinhVien.CurrentRow.Cells[4].Value.ToString();
                SetValue6 = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
                SetValue7 = dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
                SetValue8 = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
                frmSuaSinhVien.ShowDialog();
                Reload();
            }
            else
            {
                frmThemSinhVien frmThem = new frmThemSinhVien();
                frmThem.ShowDialog();
                Reload();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaSinhVien frmXoa = new frmXoaSinhVien();
            frmXoa.ShowDialog();
            dgvSinhVien.Rows.Clear();
            sinhVienxml.HienThi(dgvSinhVien);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() != "")
            {
                sinhVien.Msv = txtTim.Text;

                sinhVienxml.TimKiem(sinhVien, dgvSinhVien);
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
            worksheet.Name = "DanhSachSinhVien";

            for (int i = 1; i < dgvSinhVien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvSinhVien.Columns[i-1].HeaderText;
            }
            for (int i = 0; i < dgvSinhVien.Rows.Count - 1; i++)
            {
                for(int j = 0; j < dgvSinhVien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvSinhVien.Rows[i].Cells[j].Value.ToString();
                }
            }


        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0 , 0, 850, dgvSinhVien.Height);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvSinhVien.Height;
            dgvSinhVien.Height = dgvSinhVien.RowCount * dgvSinhVien.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvSinhVien.Width, dgvSinhVien.Height);
            dgvSinhVien.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvSinhVien.Width, dgvSinhVien.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvSinhVien.Height = height;
        }
    }
}
