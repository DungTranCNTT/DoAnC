using System.Data;
using System.Windows.Forms;
using System.Xml;
using DoAn.Service;
namespace DoAn.XML
{
    public class TaiKhoanXML
    {
        frmQLSinhVien gv;
        XmlDocument doc = new XmlDocument();
        XmlElement goc;
        string fileName = @"..\..\Data\User.xml";

        public TaiKhoanXML()
        {
            doc.Load(fileName);
            goc = doc.DocumentElement;
        }
        public void Them(TaiKhoan themTaiKhoan)
        {
            //tạo nút user
            XmlNode users = doc.CreateElement("users");
            
            //tạo nút con của user là username
            XmlElement username = doc.CreateElement("username");
            username.InnerText = themTaiKhoan.TenDangNhap;//gán giá trị cho username
            users.AppendChild(username);//thêm username thành con của user

            XmlElement pwd = doc.CreateElement("pwd");
            pwd.InnerText = themTaiKhoan.MatKhau;
            users.AppendChild(pwd);

            XmlElement type = doc.CreateElement("type");
            type.InnerText = themTaiKhoan.TrangThai;
            users.AppendChild(type);

            XmlElement owner = doc.CreateElement("owner");
            owner.InnerText = themTaiKhoan.owner;
            users.AppendChild(owner);

            XmlElement day = doc.CreateElement("day");
            day.InnerText = themTaiKhoan.Day;
            users.AppendChild(day);

            XmlElement email = doc.CreateElement("Email");
            email.InnerText = themTaiKhoan.Email;
            users.AppendChild(email);

            XmlElement sdt = doc.CreateElement("SDT");
            sdt.InnerText = themTaiKhoan.Sdt;
            users.AppendChild(sdt);

            XmlElement sbm = doc.CreateElement("SBM");
            sbm.InnerText = themTaiKhoan.Sobimat;
            users.AppendChild(sbm);

            //tạo xong nút user thêm vào gốc
            goc.AppendChild(users);
            doc.Save(fileName);
        }

        public void Sua(TaiKhoan suaTaiKhoan)
        {
            //lay vị trí cần sửa theo tên tài khoản đưa vào
            XmlNode userCu = goc.SelectSingleNode("users[username ='" + suaTaiKhoan.TenDangNhap + "']");
            if(userCu != null)
            {
                XmlNode taiKhoanMoi = doc.CreateElement("users");

                //tạo nút con của user là username
                XmlElement username = doc.CreateElement("username");
                username.InnerText = suaTaiKhoan.TenDangNhap;//gán giá trị cho username
                taiKhoanMoi.AppendChild(username);//thêm username thành con của user

                XmlElement pwd = doc.CreateElement("pwd");
                pwd.InnerText = suaTaiKhoan.MatKhau;
                taiKhoanMoi.AppendChild(pwd);

                XmlElement type = doc.CreateElement("type");
                type.InnerText = suaTaiKhoan.TrangThai;
                taiKhoanMoi.AppendChild(type);

                XmlElement owner = doc.CreateElement("owner");
                owner.InnerText = suaTaiKhoan.owner;
                taiKhoanMoi.AppendChild(owner);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = suaTaiKhoan.Email;
                taiKhoanMoi.AppendChild(email);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = suaTaiKhoan.Sdt;
                taiKhoanMoi.AppendChild(sdt);

                XmlElement sbm = doc.CreateElement("SBM");
                sbm.InnerText = suaTaiKhoan.Sobimat;
                taiKhoanMoi.AppendChild(sbm);
                //sửa user cũ bằng user mới
                goc.ReplaceChild(taiKhoanMoi, userCu);
                doc.Save(fileName);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }

        public void Xoa(TaiKhoan xoaTaiKhoan)
        {
            XmlNode userCanXoa = goc.SelectSingleNode("users[username ='" + xoaTaiKhoan.TenDangNhap + "']");

            if(userCanXoa != null)
            {
                goc.RemoveChild(userCanXoa);

                doc.Save(fileName);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.ColumnCount = 6;
            //lay toan bo nut trong user
            XmlNodeList ds = goc.SelectNodes("users");

            int dong = 0;

            foreach(XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[1].Value = item.SelectSingleNode("username").InnerText;
                dgv.Rows[dong].Cells[2].Value = item.SelectSingleNode("pwd").InnerText;
                dgv.Rows[dong].Cells[3].Value = item.SelectSingleNode("type").InnerText;
                dgv.Rows[dong].Cells[4].Value = item.SelectSingleNode("owner").InnerText;
                dgv.Rows[dong].Cells[5].Value = item.SelectSingleNode("day").InnerText;
                dong++;
            }
        }
        public void Reload(DataGridView dgv)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(fileName);
            int dong = 0;
            foreach (DataRow item in ds.Tables["users"].Rows)
            {
                dgv.Rows.Add();
                dgv.Rows[dong].Cells[1].Value = item["username"].ToString();
                dgv.Rows[dong].Cells[2].Value = item["pwd"].ToString();
                dgv.Rows[dong].Cells[3].Value = item["type"].ToString();
                dgv.Rows[dong].Cells[4].Value = item["owner"].ToString();
                dgv.Rows[dong].Cells[5].Value = item["day"].ToString();
                dong++;
            }
        }

        public void DoiMK(TaiKhoan doiMk)
        {
            XmlNode user = goc.SelectSingleNode("users[username ='" + doiMk.TenDangNhap + "']");
            if (user != null)
            {
                XmlNode taiKhoanMoi = doc.CreateElement("users");

                //tạo nút con của user là username
                XmlElement username = doc.CreateElement("username");
                username.InnerText = doiMk.TenDangNhap;//gán giá trị cho username
                taiKhoanMoi.AppendChild(username);//thêm username thành con của user

                XmlElement pwd = doc.CreateElement("pwd");
                pwd.InnerText = doiMk.MatKhau;
                taiKhoanMoi.AppendChild(pwd);

                XmlElement type = doc.CreateElement("type");
                type.InnerText = doiMk.TrangThai;
                taiKhoanMoi.AppendChild(type);

                XmlElement owner = doc.CreateElement("owner");
                owner.InnerText = doiMk.owner;
                taiKhoanMoi.AppendChild(owner);

                XmlElement day = doc.CreateElement("day");
                day.InnerText = doiMk.Day;
                taiKhoanMoi.AppendChild(day);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = doiMk.Email;
                taiKhoanMoi.AppendChild(email);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = doiMk.Sdt;
                taiKhoanMoi.AppendChild(sdt);

                XmlElement sbm = doc.CreateElement("SBM");
                sbm.InnerText = doiMk.Sobimat;
                taiKhoanMoi.AppendChild(sbm);

                //sửa user cũ bằng user mới
                goc.ReplaceChild(taiKhoanMoi, user);
                doc.Save(fileName);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }
    }
}
