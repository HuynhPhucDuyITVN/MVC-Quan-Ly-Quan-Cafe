using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        static SqlConnection conn;
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string struyvan = "select nv.*,cv.tencv from nhanvien nv join chucvu cv on cv.macv=nv.macv";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<NhanVien_DTO> lsvnv = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Gioitinh =dt.Rows[i]["gioitinh"].ToString();
                nv.Chucvu = dt.Rows[i]["macv"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                nv.Ngayvaolam = dt.Rows[i]["ngayvaolam"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Phanquyen =int.Parse(dt.Rows[i]["phanquyen"].ToString());
                nv.Matkhau = dt.Rows[i]["matkhau"].ToString();
                lsvnv.Add(nv);
            }
            DataProvider.DongKetNoi(conn);
            return lsvnv;
        }
        public static List<NhanVien_DTO> LayDSNhanVienTheoTen(string ten)
        {
            string struyvan = string.Format(@"select nv.*,cv.tencv from nhanvien nv join chucvu cv on cv.macv=nv.macv where tennv like N'%{0}%'", ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<NhanVien_DTO> lsvnv = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv.Chucvu = dt.Rows[i]["macv"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                nv.Ngayvaolam =dt.Rows[i]["ngayvaolam"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Phanquyen = int.Parse(dt.Rows[i]["phanquyen"].ToString());
                nv.Matkhau = dt.Rows[i]["matkhau"].ToString();
                lsvnv.Add(nv);
            }
            DataProvider.DongKetNoi(conn);
            return lsvnv;
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string struyvan =string.Format(@"select * from nhanvien where manv='{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = dt.Rows[0]["manv"].ToString();
            nv.Tennv = dt.Rows[0]["tennv"].ToString();
            nv.Gioitinh = dt.Rows[0]["gioitinh"].ToString();
            nv.Chucvu = dt.Rows[0]["macv"].ToString();
            nv.Ngayvaolam = dt.Rows[0]["ngayvaolam"].ToString();
            nv.Diachi = dt.Rows[0]["diachi"].ToString();
            nv.Sdt = dt.Rows[0]["sdt"].ToString();
            nv.Phanquyen = int.Parse(dt.Rows[0]["phanquyen"].ToString());
            nv.Matkhau = dt.Rows[0]["matkhau"].ToString();
            DataProvider.DongKetNoi(conn);
            return nv;
        }
        public static NhanVien_DTO LayTKDangNhap(string manv,string matkhau)
        {
            string struyvan = string.Format(@"select * from nhanvien where manv='{0}' and matkhau =N'{1}'", manv, matkhau);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = dt.Rows[0]["manv"].ToString();
            nv.Tennv = dt.Rows[0]["tennv"].ToString();
            nv.Gioitinh = dt.Rows[0]["gioitinh"].ToString();
            nv.Chucvu = dt.Rows[0]["macv"].ToString();
            nv.Ngayvaolam =dt.Rows[0]["ngayvaolam"].ToString();
            nv.Diachi = dt.Rows[0]["diachi"].ToString();
            nv.Sdt = dt.Rows[0]["sdt"].ToString();
            nv.Phanquyen = int.Parse(dt.Rows[0]["phanquyen"].ToString());
            nv.Matkhau = dt.Rows[0]["matkhau"].ToString();
            DataProvider.DongKetNoi(conn);
            return nv;
        }
        public static bool DoiMatKhau(NhanVien_DTO nv)
        {
            string struyvan = string.Format(@"update nhanvien set matkhau=N'{0}' where manv='{1}'", nv.Matkhau, nv.Manv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool ThemNV(NhanVien_DTO nv)
        {
            string struyvan = string.Format(@"insert into nhanvien(manv,tennv,gioitinh,macv,ngayvaolam,diachi,sdt,phanquyen)
            values('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}','{6}','{7}')",
            nv.Manv, nv.Tennv, nv.Gioitinh, nv.Chucvu, nv.Ngayvaolam, nv.Diachi, nv.Sdt, nv.Phanquyen);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaNV(NhanVien_DTO nv)
        {
            string struyvan = string.Format(@"delete from nhanvien where manv='{0}'", nv.Manv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaNV(NhanVien_DTO nv)
        {
            string struyvan = string.Format(@"update nhanvien set tennv=N'{0}',gioitinh=N'{1}',macv='{2}',ngayvaolam='{3}',diachi=N'{4}',sdt='{5}',phanquyen='{6}' where manv='{7}'"
                                            , nv.Tennv, nv.Gioitinh, nv.Chucvu, nv.Ngayvaolam, nv.Diachi, nv.Sdt, nv.Phanquyen, nv.Manv);

            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
