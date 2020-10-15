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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            QuanLyTK ql = new QuanLyTK();
            ql.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Close();
        }
    }
}
