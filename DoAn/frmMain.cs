using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            frmQLTK ql = new frmQLTK();
            ql.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Close();
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
    }
}
