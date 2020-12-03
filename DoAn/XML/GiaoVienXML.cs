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
    class GiaoVienXML
    {
        XmlDocument doc = new XmlDocument();
        XmlElement goc;
        string fileName = @"..\..\Data\GiaoVien.xml";

        public GiaoVienXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;
        }

        public int createMgv()
        {
            XmlNode mgvgoc = goc.SelectSingleNode("teacher[MGV ='" + "']");
            var nodeCount = 0;
            using (var reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "MGV")
                    {
                        nodeCount++;
                    }
                }
            }

            int mgv = 0;
            XmlNodeList list = goc.SelectNodes("teacher");
            foreach (XmlNode item in list)
            {
                if (mgv.ToString() == item.SelectSingleNode("MGV").InnerText)
                {
                    mgv = mgv + 1;
                }
                else
                {
                    mgv = mgv;
                }
            }
            return mgv;

        }

        public void Them(GiaoVien themGiaoVien)
        {
            XmlNode teacher = doc.CreateElement("teacher");
            XmlElement Mgv = doc.CreateElement("MGV");
            Mgv.InnerText = themGiaoVien.Mgv.ToString();
            teacher.AppendChild(Mgv);

            XmlElement ten = doc.CreateElement("Ten");
            ten.InnerText = themGiaoVien.Hoten;
            teacher.AppendChild(ten);

            XmlElement ngaysinh = doc.CreateElement("NgaySinh");
            ngaysinh.InnerText = themGiaoVien.Ngaysinh;
            teacher.AppendChild(ngaysinh);

            XmlElement gioitinh = doc.CreateElement("GioiTinh");
            gioitinh.InnerText = themGiaoVien.Gioitinh;
            teacher.AppendChild(gioitinh);

            XmlElement que = doc.CreateElement("Que");
            que.InnerText = themGiaoVien.Que;
            teacher.AppendChild(que);

            XmlElement diachi = doc.CreateElement("DiaChi");
            diachi.InnerText = themGiaoVien.Diachi;
            teacher.AppendChild(diachi);

            XmlElement email = doc.CreateElement("Email");
            email.InnerText = themGiaoVien.Email;
            teacher.AppendChild(email);

            XmlElement sdt = doc.CreateElement("SDT");
            sdt.InnerText = themGiaoVien.Sdt;
            teacher.AppendChild(sdt);
            //tạo xong nút user thêm vào gốc
            goc.AppendChild(teacher);
            doc.Save(fileName);
        }

        public void Sua(GiaoVien suaGiaoVien)
        {
            XmlNode giaoVienCu = goc.SelectSingleNode("teacher[MGV ='" + suaGiaoVien.Mgv + "']");
            if (giaoVienCu != null)
            {
                XmlNode giaovienmoi = doc.CreateElement("teacher");

                XmlElement Mgv = doc.CreateElement("MGV");
                Mgv.InnerText = suaGiaoVien.Mgv.ToString();
                giaovienmoi.AppendChild(Mgv);

                XmlElement ten = doc.CreateElement("Ten");
                ten.InnerText = suaGiaoVien.Hoten;
                giaovienmoi.AppendChild(ten);

                XmlElement ngaysinh = doc.CreateElement("NgaySinh");
                ngaysinh.InnerText = suaGiaoVien.Ngaysinh;
                giaovienmoi.AppendChild(ngaysinh);

                XmlElement gioitinh = doc.CreateElement("GioiTinh");
                gioitinh.InnerText = suaGiaoVien.Gioitinh;
                giaovienmoi.AppendChild(gioitinh);

                XmlElement que = doc.CreateElement("Que");
                que.InnerText = suaGiaoVien.Que;
                giaovienmoi.AppendChild(que);

                XmlElement diachi = doc.CreateElement("DiaChi");
                diachi.InnerText = suaGiaoVien.Diachi;
                giaovienmoi.AppendChild(diachi);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = suaGiaoVien.Email;
                giaovienmoi.AppendChild(email);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = suaGiaoVien.Sdt;
                giaovienmoi.AppendChild(sdt);
                //tạo xong nút user thêm vào gốc
                goc.ReplaceChild(giaovienmoi, giaoVienCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(GiaoVien xoaGiaoVien)
        {
            XmlNode giaoVienXoa = goc.SelectSingleNode("teacher[MGV = '" + xoaGiaoVien.Mgv + "']");
            if (giaoVienXoa != null)
            {
                goc.RemoveChild(giaoVienXoa);
                doc.Save(fileName);
            }
            else
            {
                if (MessageBox.Show("Mã Sinh viên không tồn tại tạo mới?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmThemGiaoVien frmThem = new frmThemGiaoVien();
                    frmThem.ShowDialog();
                }
            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            XmlNodeList ds = goc.SelectNodes("teacher");

            int dong = 0;
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item.SelectSingleNode("MGV").InnerText;
                dgv.Rows[dong].Cells[1].Value = item.SelectSingleNode("Ten").InnerText;
                dgv.Rows[dong].Cells[2].Value = item.SelectSingleNode("NgaySinh").InnerText;
                dgv.Rows[dong].Cells[3].Value = item.SelectSingleNode("GioiTinh").InnerText;
                dgv.Rows[dong].Cells[4].Value = item.SelectSingleNode("Que").InnerText;
                dgv.Rows[dong].Cells[5].Value = item.SelectSingleNode("DiaChi").InnerText;
                dgv.Rows[dong].Cells[6].Value = item.SelectSingleNode("Email").InnerText;
                dgv.Rows[dong].Cells[7].Value = item.SelectSingleNode("SDT").InnerText;
                dong++;

            }
        }
        public void Reload(DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            DataSet ds = new DataSet();
            ds.ReadXml(fileName);
            foreach (DataRow item in ds.Tables["teacher"].Rows)
            {
                int dong = dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item["MGV"].ToString();
                dgv.Rows[dong].Cells[1].Value = item["Ten"].ToString();
                dgv.Rows[dong].Cells[2].Value = item["NgaySinh"].ToString();
                dgv.Rows[dong].Cells[3].Value = item["GioiTinh"].ToString();
                dgv.Rows[dong].Cells[4].Value = item["Que"].ToString();
                dgv.Rows[dong].Cells[5].Value = item["DiaChi"].ToString();
                dgv.Rows[dong].Cells[6].Value = item["Email"].ToString();
                dgv.Rows[dong].Cells[7].Value = item["SDT"].ToString();
            }
        }

        public void TimKiem(GiaoVien timGiaoVien, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode gvCanTim = goc.SelectSingleNode("teacher[MGV = '" + timGiaoVien.Mgv + "']");
            if (gvCanTim != null)
            {
                dgv.ColumnCount = 8;
                dgv.Rows.Add();

                XmlNode masv = gvCanTim.SelectSingleNode("MGV");
                dgv.Rows[0].Cells[0].Value = masv.InnerText;
                XmlNode ten = gvCanTim.SelectSingleNode("Ten");
                dgv.Rows[0].Cells[1].Value = ten.InnerText;
                XmlNode ngaysinh = gvCanTim.SelectSingleNode("NgaySinh");
                dgv.Rows[0].Cells[2].Value = ngaysinh.InnerText;
                XmlNode gioitinh = gvCanTim.SelectSingleNode("GioiTinh");
                dgv.Rows[0].Cells[3].Value = gioitinh.InnerText;
                XmlNode que = gvCanTim.SelectSingleNode("Que");
                dgv.Rows[0].Cells[4].Value = que.InnerText;
                XmlNode diachi = gvCanTim.SelectSingleNode("DiaChi");
                dgv.Rows[0].Cells[5].Value = diachi.InnerText;
                XmlNode email = gvCanTim.SelectSingleNode("Email");
                dgv.Rows[0].Cells[6].Value = email.InnerText;
                XmlNode sdt = gvCanTim.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[7].Value = sdt.InnerText;
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo");
            }
        }
    }
}
