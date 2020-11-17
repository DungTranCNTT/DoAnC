using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DoAn.Service;

namespace DoAn.XML
{
    public class SinhVienXML
    {
        XmlDocument doc = new XmlDocument();
        XmlElement goc;
        string fileName = @"C:\Users\user\Source\Repos\setokid\DoAnC\DoAn\SinhVien.xml";

        public SinhVienXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;
        }

        public int createMSV()
        {
            XmlNode msvgoc = goc.SelectSingleNode("student[MSV ='" + "']");
            var nodeCount = 0;
            using( var reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if(reader.NodeType == XmlNodeType.Element && reader.Name == "MSV")
                    {
                        nodeCount++;
                    }
                }
            }

            int msv = 0;
            DateTime date = DateTime.Now;
            string s = date.Year.ToString().Substring(date.Year.ToString().Length - 2);
            if (nodeCount <10)
            {
                msv = int.Parse(s + "00000" + nodeCount++);
            }
            else if (nodeCount >=10)
            {
                msv = int.Parse(s + "0000" + nodeCount++);
            }
            else if (nodeCount >99)
            {
                msv = int.Parse(s + "000" + nodeCount++);
            }
            else if (nodeCount >999)
            {
                msv = int.Parse(s + 00 + nodeCount ++);
            }

            XmlNodeList list = goc.SelectNodes("student");
            foreach (XmlNode item in list)
            {
                if (msv.ToString() == item.SelectSingleNode("MSV").InnerText)
                {
                    msv = msv + 1;
                }
                else
                {
                    msv = msv;
                }
            }
            return msv;
            
        }
        public void Them(SinhVien themSinhVien)
        {
            XmlNode student = doc.CreateElement("student");
            XmlElement msv = doc.CreateElement("MSV");
            msv.InnerText = themSinhVien.Msv.ToString();
            student.AppendChild(msv);

            XmlElement ten = doc.CreateElement("Ten");
            ten.InnerText = themSinhVien.Hoten;
            student.AppendChild(ten);

            XmlElement ngaysinh= doc.CreateElement("NgaySinh");
            ngaysinh.InnerText = themSinhVien.Ngaysinh;
            student.AppendChild(ngaysinh);

            XmlElement gioitinh = doc.CreateElement("GioiTinh");
            gioitinh.InnerText = themSinhVien.Gioitinh;
            student.AppendChild(gioitinh);

            XmlElement que = doc.CreateElement("Que");
            que.InnerText = themSinhVien.Que;
            student.AppendChild(que);

            XmlElement diachi = doc.CreateElement("DiaChi");
            diachi.InnerText = themSinhVien.Diachi;
            student.AppendChild(diachi);

            XmlElement email = doc.CreateElement("Email");
            email.InnerText = themSinhVien.Email;
            student.AppendChild(email);

            XmlElement sdt = doc.CreateElement("SDT");
            sdt.InnerText = themSinhVien.Sdt;
            student.AppendChild(sdt);

            //tạo xong nút user thêm vào gốc
            goc.AppendChild(student);
            doc.Save(fileName);
        }

        public void Sua (SinhVien suaSinhVien)
        {
            XmlNode sinhVienCu = goc.SelectSingleNode("student[MSV ='" + suaSinhVien.Msv + "']");
            if(sinhVienCu != null)
            {
                XmlNode sinhvienmoi = doc.CreateElement("student");

                XmlElement msv = doc.CreateElement("MSV");
                msv.InnerText = suaSinhVien.Msv.ToString();
                sinhvienmoi.AppendChild(msv);

                XmlElement ten = doc.CreateElement("Ten");
                ten.InnerText = suaSinhVien.Hoten;
                sinhvienmoi.AppendChild(ten);

                XmlElement ngaysinh = doc.CreateElement("NgaySinh");
                ngaysinh.InnerText = suaSinhVien.Ngaysinh;
                sinhvienmoi.AppendChild(ngaysinh);

                XmlElement gioitinh = doc.CreateElement("GioiTinh");
                gioitinh.InnerText = suaSinhVien.Gioitinh;
                sinhvienmoi.AppendChild(gioitinh);

                XmlElement que = doc.CreateElement("Que");
                que.InnerText = suaSinhVien.Que;
                sinhvienmoi.AppendChild(que);

                XmlElement diachi = doc.CreateElement("DiaChi");
                diachi.InnerText = suaSinhVien.Diachi;
                sinhvienmoi.AppendChild(diachi);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = suaSinhVien.Email;
                sinhvienmoi.AppendChild(email);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = suaSinhVien.Sdt;
                sinhvienmoi.AppendChild(sdt);

                //tạo xong nút user thêm vào gốc
                goc.ReplaceChild(sinhvienmoi,sinhVienCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(SinhVien xoaSinhVien)
        {
            XmlNode sinhVienXoa = goc.SelectSingleNode("student[MSV = '" + xoaSinhVien.Msv + "']");
            if(sinhVienXoa != null)
            {
                goc.RemoveChild(sinhVienXoa);
                doc.Save(fileName);
            }
            else
            {
                if(MessageBox.Show("Mã Sinh viên không tồn tại tạo mới?","Lỗi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    frmThemSinhVien frmThem = new frmThemSinhVien();
                    frmThem.ShowDialog();
                }
            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            XmlNodeList ds = goc.SelectNodes("student");

            int dong = 0;
            foreach(XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item.SelectSingleNode("MSV").InnerText;
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
            foreach (DataRow item in ds.Tables["student"].Rows)
            {
                int dong = dgv.Rows.Add();
                dgv.Rows[dong].Cells[0].Value = item["MSV"].ToString();
                dgv.Rows[dong].Cells[1].Value = item["Ten"].ToString();
                dgv.Rows[dong].Cells[2].Value = item["NgaySinh"].ToString();
                dgv.Rows[dong].Cells[3].Value = item["GioiTinh"].ToString();
                dgv.Rows[dong].Cells[4].Value = item["Que"].ToString();
                dgv.Rows[dong].Cells[5].Value = item["DiaChi"].ToString();
                dgv.Rows[dong].Cells[6].Value = item["Email"].ToString();
                dgv.Rows[dong].Cells[7].Value = item["SDT"].ToString();
            }
        }

        public void TimKiem(SinhVien timSinhVien,DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode svCanTim = goc.SelectSingleNode("student[MSV = '" + timSinhVien.Msv + "']");
            if(svCanTim != null)
            {
                dgv.ColumnCount = 8;
                dgv.Rows.Add();

                XmlNode masv = svCanTim.SelectSingleNode("MSV");
                dgv.Rows[0].Cells[0].Value = masv.InnerText;
                XmlNode ten = svCanTim.SelectSingleNode("Ten");
                dgv.Rows[0].Cells[1].Value = ten.InnerText;
                XmlNode ngaysinh = svCanTim.SelectSingleNode("NgaySinh");
                dgv.Rows[0].Cells[2].Value = ngaysinh.InnerText;
                XmlNode gioitinh = svCanTim.SelectSingleNode("GioiTinh");
                dgv.Rows[0].Cells[3].Value = gioitinh.InnerText;
                XmlNode que = svCanTim.SelectSingleNode("Que");
                dgv.Rows[0].Cells[4].Value = que.InnerText;
                XmlNode diachi = svCanTim.SelectSingleNode("DiaChi");
                dgv.Rows[0].Cells[5].Value = diachi.InnerText;
                XmlNode email = svCanTim.SelectSingleNode("Email");
                dgv.Rows[0].Cells[6].Value = email.InnerText;
                XmlNode sdt = svCanTim.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[7].Value = sdt.InnerText;
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo");
            }
        }
    }
}
