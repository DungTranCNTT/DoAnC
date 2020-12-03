using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using DoAn.Service;

namespace DoAn.XML
{
    class ClassXML
    {
        XmlDocument doc = new XmlDocument();
        XmlDocument doc1 = new XmlDocument();
        XmlDocument doc2 = new XmlDocument();
        XmlDocument doc3 = new XmlDocument();
        XmlElement goc;
        XmlElement goc1;
        XmlElement goc2;
        XmlElement goc3;
        string fileName = @"..\..\Data\Class.xml";
        string fileName1 = @"..\..\Data\SinhVien.xml";
        string fileName2 = @"..\..\Data\Khoa.xml";
        string fileName3 = @"..\..\Data\GiaoVien.xml";
        public ClassXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;

            doc1.Load(fileName1);
            goc1 = doc1.DocumentElement;

            doc2.Load(fileName2);
            goc2 = doc2.DocumentElement;

            doc3.Load(fileName3);
            goc3 = doc3.DocumentElement;
        }

        public void TaoLop(Class taoClass)
        {
            XmlNode lop = doc.CreateElement("class");

            XmlElement tenlop = doc.CreateElement("TenLop");
            tenlop.InnerText = taoClass.TenLop.ToString();
            lop.AppendChild(tenlop);

            XmlElement malop = doc.CreateElement("MaLop");
            malop.InnerText = taoClass.MaLop.ToString();
            lop.AppendChild(malop);

            XmlElement gvchunhiem = doc.CreateElement("GVChuNhiem");
            gvchunhiem.InnerText = taoClass.GVChuNhiem.ToString();
            lop.AppendChild(gvchunhiem);

            XmlElement khoa = doc.CreateElement("Khoa");
            khoa.InnerText = taoClass.Khoa.ToString();
            lop.AppendChild(khoa);
            goc.AppendChild(lop);
            doc.Save(fileName);
        }

        public void SuaLop(Class suaClass)
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

        public void XoaLop(Class xoaClass)
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

        public void HienThiLopDS(DataGridView dgv)
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
        public void ReloadLop(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            DataSet ds = new DataSet();
            ds.ReadXml(fileName);
            int dong = 0;
            foreach (DataRow item in ds.Tables["class"].Rows)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item["Khoa"].ToString();
                dgv.Rows[dong].Cells[1].Value = item["MaLop"].ToString();
                dgv.Rows[dong].Cells[2].Value = item["TenLop"].ToString();
                dgv.Rows[dong].Cells[3].Value = item["GVChuNhiem"].ToString();
                dong++;
            }
        }

        public void TimKiemLop(Class timClass, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode lopCanTim = goc.SelectSingleNode("class[TenLop= '" + timClass.TenLop + "']");
            if (lopCanTim != null)
            {
                dgv.ColumnCount = 4;
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

        public void ThemLop(SinhVien themLop)
        {
            XmlNode oldChild = goc1.SelectSingleNode("student[MSV ='" + themLop.Msv + "']");
            doc1.DocumentElement.RemoveChild(oldChild);
            XmlNode student = doc1.CreateElement("student");

            XmlElement msv = doc1.CreateElement("MSV");
            msv.InnerText = themLop.Msv.ToString();
            student.AppendChild(msv);

            XmlElement ten = doc1.CreateElement("Ten");
            ten.InnerText = themLop.Hoten;
            student.AppendChild(ten);

            XmlElement ngaysinh = doc1.CreateElement("NgaySinh");
            ngaysinh.InnerText = themLop.Ngaysinh;
            student.AppendChild(ngaysinh);

            XmlElement gioitinh = doc1.CreateElement("GioiTinh");
            gioitinh.InnerText = themLop.Gioitinh;
            student.AppendChild(gioitinh);

            XmlElement diachi = doc1.CreateElement("DiaChi");
            diachi.InnerText = themLop.Diachi;
            student.AppendChild(diachi);

            XmlElement que = doc1.CreateElement("Que");
            que.InnerText = themLop.Que;
            student.AppendChild(que);

            XmlElement email = doc1.CreateElement("Email");
            email.InnerText = themLop.Email;
            student.AppendChild(email);

            XmlElement sdt = doc1.CreateElement("SDT");
            sdt.InnerText = themLop.Sdt;
            student.AppendChild(sdt);

            XmlElement lop = doc1.CreateElement("Lop");
            lop.InnerText = themLop.Lop;
            student.AppendChild(lop);

            XmlElement khoa = doc1.CreateElement("Khoa");
            khoa.InnerText = themLop.Khoa;
            student.AppendChild(khoa);

            goc1.AppendChild(student);
            doc1.Save(fileName1);
        }
        public void ChuyenLop(SinhVien chuyenLop)
        {
            XmlNode lopCu = goc1.SelectSingleNode("student[MSV ='" + chuyenLop.Msv + "']");
            if (lopCu != null)
            {
                XmlNode lopMoi = doc1.CreateElement("student");

                XmlElement msv = doc1.CreateElement("MSV");
                msv.InnerText = chuyenLop.Msv.ToString();
                lopMoi.AppendChild(msv);

                XmlElement ten = doc1.CreateElement("Ten");
                ten.InnerText = chuyenLop.Hoten;
                lopMoi.AppendChild(ten);

                XmlElement ngaysinh = doc1.CreateElement("NgaySinh");
                ngaysinh.InnerText = chuyenLop.Ngaysinh;
                lopMoi.AppendChild(ngaysinh);

                XmlElement gioitinh = doc1.CreateElement("GioiTinh");
                gioitinh.InnerText = chuyenLop.Gioitinh;
                lopMoi.AppendChild(gioitinh);

                XmlElement diachi = doc1.CreateElement("DiaChi");
                diachi.InnerText = chuyenLop.Diachi;
                lopMoi.AppendChild(diachi);

                XmlElement que = doc1.CreateElement("Que");
                que.InnerText = chuyenLop.Que;
                lopMoi.AppendChild(que);

                XmlElement email = doc1.CreateElement("Email");
                email.InnerText = chuyenLop.Email;
                lopMoi.AppendChild(email);

                XmlElement sdt = doc1.CreateElement("SDT");
                sdt.InnerText = chuyenLop.Sdt;
                lopMoi.AppendChild(sdt);

                XmlElement lop = doc1.CreateElement("Lop");
                lop.InnerText = chuyenLop.Lop;
                lopMoi.AppendChild(lop);

                XmlElement khoa = doc1.CreateElement("Khoa");
                khoa.InnerText = chuyenLop.Khoa;
                lopMoi.AppendChild(khoa);

                //tạo xong nút user thêm vào gốc
                goc1.ReplaceChild(lopMoi, lopCu);
                doc1.Save(fileName1);
            }
        }

        public void HienThiLop(DataGridView dgv)
        {
            dgv.ColumnCount = 10;
            XmlNodeList ds = goc1.SelectNodes("student");

            int dong = 0;
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item.SelectSingleNode("MSV").InnerText;
                dgv.Rows[dong].Cells[1].Value = item.SelectSingleNode("Ten").InnerText;
                dgv.Rows[dong].Cells[2].Value = item.SelectSingleNode("NgaySinh").InnerText;
                dgv.Rows[dong].Cells[3].Value = item.SelectSingleNode("GioiTinh").InnerText;
                dgv.Rows[dong].Cells[4].Value = item.SelectSingleNode("Lop").InnerText;
                dgv.Rows[dong].Cells[5].Value = item.SelectSingleNode("Khoa").InnerText;
                dgv.Rows[dong].Cells[6].Value = item.SelectSingleNode("DiaChi").InnerText;
                dgv.Rows[dong].Cells[7].Value = item.SelectSingleNode("Que").InnerText;
                dgv.Rows[dong].Cells[8].Value = item.SelectSingleNode("Email").InnerText;
                dgv.Rows[dong].Cells[9].Value = item.SelectSingleNode("SDT").InnerText;
                dong++;

            }
        }

        public void TimKiemDSSV(SinhVien timSinhVien, DataGridView dgv)
        {
        }

        public void getDSLop(ComboBox cbo)
        {
            XmlNodeList ds = goc.SelectNodes("class");
            foreach(XmlNode item in ds)
            {
                cbo.Items.Add(item.SelectSingleNode("TenLop").InnerText);
            }
        }

        public void getDSKhoa(ComboBox cbo)
        {
            XmlNodeList ds = goc2.SelectNodes("faculty");
            foreach(XmlNode item in ds)
            {
                cbo.Items.Add(item.SelectSingleNode("TenKhoa").InnerText);
            }
        }

        public void getDSGiaoVien(ComboBox cbo)
        {
            XmlNodeList ds = goc3.SelectNodes("teacher");
            foreach(XmlNode item in ds)
            {
                cbo.Items.Add(item.SelectSingleNode("Ten").InnerText);
            }
        }
    }
}
