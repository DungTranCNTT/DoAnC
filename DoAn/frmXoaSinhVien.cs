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
    public partial class frmXoaSinhVien : Form
    {
        public frmXoaSinhVien()
        {
            InitializeComponent();
        }

        SinhVien sv = new SinhVien();
        SinhVienXML svXML = new SinhVienXML();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            sv.Msv = int.Parse(txtMsv.Text);

            svXML.Xoa(sv);
        }
    }
}
