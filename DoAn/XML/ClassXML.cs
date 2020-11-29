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
    class ClassXML
    {
        XmlDocument doc = new XmlDocument();
        XmlElement goc;
        string fileName = @"..\..\Data\Class.xml";

        public ClassXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;
        }

        public void Them(Class themClass)
        {
            XmlNode lop = doc.CreateElement("class");

            XmlElement tenlop = doc.CreateElement("TenLop");
            tenlop.InnerText = themClass.TenLop.ToString();
            lop.AppendChild(tenlop);

            XmlElement malop = doc.CreateElement("MaLop");
            malop.InnerText = themClass.MaLop.ToString();
            lop.AppendChild(malop);

            XmlElement gvchunhiem = doc.CreateElement("GVChuNhiem");
            gvchunhiem.InnerText = themClass.GVChuNhiem.ToString();
            lop.AppendChild(gvchunhiem);

            XmlElement khoa = doc.CreateElement("Khoa");
            khoa.InnerText = themClass.Khoa.ToString();
            lop.AppendChild(khoa);
            goc.AppendChild(lop);
            doc.Save(fileName);
        }

        public void Sua(Class suaClass)
        {
            XmlNode lopCu = goc.SelectSingleNode("class[TenLop ='" + suaClass.TenLop + "']");
            if (suaClass != null)
            {
                XmlNode lopmoi = doc.CreateElement("class");
                XmlElement tenlop = doc.CreateElement("TenLop");
                tenlop.InnerText = suaClass.TenLop.ToString();
                lopmoi.AppendChild(tenlop);

                XmlElement malop = doc.CreateElement("MaLop");
                malop.InnerText = suaClass.MaLop.ToString();
                lopmoi.AppendChild(malop);

                XmlElement gvchunhiem = doc.CreateElement("GVChuNhiem");
                gvchunhiem.InnerText = suaClass.GVChuNhiem.ToString();
                lopmoi.AppendChild(gvchunhiem);

                XmlElement khoa = doc.CreateElement("Khoa");
                khoa.InnerText = suaClass.Khoa.ToString();
                lopmoi.AppendChild(khoa);
                //tạo xong nút user thêm vào gốc
                goc.ReplaceChild(lopmoi, lopCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(Class xoaClass)
        {
            XmlNode lopXoa = goc.SelectSingleNode("class[TenLop = '" + xoaClass.TenLop + "']");
            if (lopXoa != null)
            {
                goc.RemoveChild(lopXoa);
                doc.Save(fileName);
            }
            else
            {
                if (MessageBox.Show("Mã Lớp không tồn tại tạo mới?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            XmlNodeList ds = goc.SelectNodes("class");

            int dong = 0;
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item.SelectSingleNode("Khoa").InnerText;
                dgv.Rows[dong].Cells[1].Value = item.SelectSingleNode("MaLop").InnerText;
                dgv.Rows[dong].Cells[2].Value = item.SelectSingleNode("TenLop").InnerText;
                dgv.Rows[dong].Cells[3].Value = item.SelectSingleNode("GVChuNhiem").InnerText;
                dong++;

            }
        }
        public void Reload(DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            DataSet ds = new DataSet();
            ds.ReadXml(fileName);
            foreach (DataRow item in ds.Tables["class"].Rows)
            {
                int dong = dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item["Khoa"].ToString();
                dgv.Rows[dong].Cells[1].Value = item["MaLop"].ToString();
                dgv.Rows[dong].Cells[2].Value = item["TenLop"].ToString();
                dgv.Rows[dong].Cells[3].Value = item["GVChuNhiem"].ToString();
            }
        }

        public void TimKiem(Class timClass, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode lopCanTim = goc.SelectSingleNode("class[TenLop= '" + timClass.TenLop + "']");
            if (lopCanTim != null)
            {
                dgv.ColumnCount =4;
                dgv.Rows.Add();

                XmlNode tenlop = lopCanTim.SelectSingleNode("TenLop");
                dgv.Rows[0].Cells[0].Value = tenlop.InnerText;
                XmlNode malop = lopCanTim.SelectSingleNode("MaLop");
                dgv.Rows[0].Cells[1].Value = malop.InnerText;
                XmlNode gvchunhiem = lopCanTim.SelectSingleNode("GVChuNhiem");
                dgv.Rows[0].Cells[2].Value = gvchunhiem.InnerText;
                XmlNode khoa = lopCanTim.SelectSingleNode("Khoa");
                dgv.Rows[0].Cells[3].Value = khoa.InnerText;
            }
            else
            {
                MessageBox.Show("Mã lớp hoặc tên lớp không tồn tại", "Thông báo");
            }
        }
    }
}
