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
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }
        SinhVienXML sinhVienxml = new SinhVienXML();

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmThemSinhvien = new frmThemSinhVien();
            frmThemSinhvien.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            sinhVienxml.HienThi(dgvSinhVien);
        }
    }
}
