using System;
using System.Collections.Generic;
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
        public void Them(SinhVien themSinhVien)
        {
            //tạo nút user
            XmlNode student = doc.CreateElement("student");

            //tạo nút con của user là username
            XmlElement msv = doc.CreateElement("MSV");
            msv.InnerText = themSinhVien.Msv;//gán giá trị cho username
            student.AppendChild(msv);//thêm username thành con của user

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
            XmlNode sinhVienCu = doc.SelectSingleNode("student[MSV ='" + suaSinhVien.Msv + "']");
            if(sinhVienCu != null)
            {
                XmlNode student = doc.CreateElement("student");

                //tạo nút con của user là username
                XmlElement msv = doc.CreateElement("MSV");
                msv.InnerText = suaSinhVien.Msv;//gán giá trị cho username
                student.AppendChild(msv);//thêm username thành con của user

                XmlElement ten = doc.CreateElement("Ten");
                ten.InnerText = suaSinhVien.Hoten;
                student.AppendChild(ten);

                XmlElement ngaysinh = doc.CreateElement("NgaySinh");
                ngaysinh.InnerText = suaSinhVien.Ngaysinh;
                student.AppendChild(ngaysinh);

                XmlElement gioitinh = doc.CreateElement("GioiTinh");
                gioitinh.InnerText = suaSinhVien.Gioitinh;
                student.AppendChild(gioitinh);

                XmlElement que = doc.CreateElement("Que");
                que.InnerText = suaSinhVien.Que;
                student.AppendChild(que);

                XmlElement diachi = doc.CreateElement("DiaChi");
                diachi.InnerText = suaSinhVien.Diachi;
                student.AppendChild(diachi);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = suaSinhVien.Email;
                student.AppendChild(email);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = suaSinhVien.Sdt;
                student.AppendChild(sdt);

                //tạo xong nút user thêm vào gốc
                goc.AppendChild(student);
                doc.Save(fileName);
            }
        }

        public void Xoa(SinhVien xoaSinhVien)
        {
            XmlNode sinhVienXoa = goc.SelectSingleNode("studen[MSV = '" + xoaSinhVien.Msv + "']");
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
    }
}
