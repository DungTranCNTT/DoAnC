using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DoAn.Service;
namespace DoAn.XML
{
    class KhoaXML
    {
        XmlDocument doc = new XmlDocument();
        XmlElement goc;
        string fileName = @"..\..\Data\Khoa.xml";
        public KhoaXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;
        }

        public void TaoKhoa(Khoa taoKhoa)
        {
            XmlNode khoa = doc.CreateElement("faculty");

            XmlElement tenkhoa = doc.CreateElement("TenKhoa");
            tenkhoa.InnerText = taoKhoa.TenKhoa.ToString();
            khoa.AppendChild(tenkhoa);

            XmlElement makhoa = doc.CreateElement("MaKhoa");
            makhoa.InnerText = taoKhoa.TenKhoa.ToString();
            khoa.AppendChild(makhoa);

            goc.AppendChild(khoa);
            doc.Save(fileName);
        }

        public void SuaKhoa(Khoa suaKhoa)
        {
            XmlNode khoaCu = goc.SelectSingleNode("faculty[TenKhoa ='" + suaKhoa.TenKhoa + "']");
            if (suaKhoa != null)
            {
                XmlNode khoa = doc.CreateElement("faculty");

                XmlElement tenkhoa = doc.CreateElement("TenKhoa");
                tenkhoa.InnerText = suaKhoa.TenKhoa.ToString();
                khoa.AppendChild(tenkhoa);

                XmlElement makhoa = doc.CreateElement("MaKhoa");
                makhoa.InnerText = suaKhoa.TenKhoa.ToString();
                khoa.AppendChild(makhoa);
                //tạo xong nút user thêm vào gốc
                goc.ReplaceChild(khoa,khoaCu);
                doc.Save(fileName);
            }
        }

        public void XoaKhoa(Khoa xoaKhoa)
        {
            XmlNode khoaXoa = goc.SelectSingleNode("faculty[TenKhoa = '" + xoaKhoa.TenKhoa + "']");
            if (xoaKhoa != null)
            {
                goc.RemoveChild(khoaXoa);
                doc.Save(fileName);
            }
            else
            {
                if (MessageBox.Show("Mã Lớp không tồn tại tạo mới?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
            }
        }

        public void HienThiDSKhoa(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            XmlNodeList ds = goc.SelectNodes("faculty");

            int dong = 0;
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item.SelectSingleNode("TenKhoa").InnerText;
                dgv.Rows[dong].Cells[1].Value = item.SelectSingleNode("MaKhoa").InnerText;
                dong++;

            }
        }
        public void ReloadKhoa(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            DataSet ds = new DataSet();
            ds.ReadXml(fileName);
            int dong = 0;
            foreach (DataRow item in ds.Tables["faculty"].Rows)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item["TenKhoa"].ToString();
                dgv.Rows[dong].Cells[1].Value = item["MaKhoa"].ToString();
                dong++;
            }
        }

        public void TimKiemKhoa(Khoa timKhoa, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode khoaCanTim = goc.SelectSingleNode("class[TenLop= '" + timKhoa.TenKhoa + "']");
            if (khoaCanTim != null)
            {
                dgv.ColumnCount = 4;
                dgv.Rows.Add();

                XmlNode tenlop = khoaCanTim.SelectSingleNode("TenKhoa");
                dgv.Rows[0].Cells[0].Value = tenlop.InnerText;
                XmlNode malop = khoaCanTim.SelectSingleNode("MaKhoa");
                dgv.Rows[0].Cells[1].Value = malop.InnerText;
            }
            else
            {
                MessageBox.Show("Mã lớp hoặc tên lớp không tồn tại", "Thông báo");
            }
        }
    }
}
