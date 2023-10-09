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
    public class KhachHang_DAO
    {
        static SqlConnection conn;
        public static List<KhachHang_DTO> LayKhachHang()
        {
            string struyvan = "select kh.* ,lkh.tenlkh from khachhang kh,loaikhachhang lkh where kh.malkh=lkh.malkh";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<KhachHang_DTO> lskhachhang = new List<KhachHang_DTO>();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Malkh = dt.Rows[i]["malkh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Diachikh = dt.Rows[i]["diachikh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Diemtl =int.Parse(dt.Rows[i]["diemtl"].ToString());
                kh.Tenlkh = dt.Rows[i]["tenlkh"].ToString();
                lskhachhang.Add(kh);
            }
            return lskhachhang;
        }
        public static KhachHang_DTO LayKhachHangTheoMa(int makh)
        {
            string struyvan =string.Format(@"select kh.* ,lkh.tenlkh from khachhang kh,loaikhachhang lkh where kh.malkh=lkh.malkh and makh={0}",makh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Makh = dt.Rows[0]["makh"].ToString();
            kh.Malkh = dt.Rows[0]["malkh"].ToString();
            kh.Tenkh = dt.Rows[0]["tenkh"].ToString();
            kh.Diachikh = dt.Rows[0]["diachikh"].ToString();
            kh.Sdt = dt.Rows[0]["sdt"].ToString();
            kh.Diemtl = int.Parse(dt.Rows[0]["diemtl"].ToString());
            kh.Tenlkh = dt.Rows[0]["tenlkh"].ToString();
            return kh;
        }
        public static List<KhachHang_DTO> LayKhachHangTheoTen(string ten)
        {
            string struyvan = string.Format(@"select kh.* ,lkh.tenlkh from khachhang kh,loaikhachhang lkh where kh.malkh=lkh.malkh and tenkh like N'%{0}%'",ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<KhachHang_DTO> lskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Malkh = dt.Rows[i]["malkh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Diachikh = dt.Rows[i]["diachikh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Diemtl = int.Parse(dt.Rows[i]["diemtl"].ToString());
                kh.Tenlkh = dt.Rows[i]["tenlkh"].ToString();
                lskhachhang.Add(kh);
            }
            return lskhachhang;
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            if (kh.Diemtl >= 100)
                kh.Malkh = "VIP";
            else if (kh.Diemtl >= 50)
                kh.Malkh = "THUONG";
            else
                kh.Malkh = "MOI";
            string struyvan = string.Format(@"insert into khachhang values('{0}',N'{1}',N'{2}','{3}','{4}')",kh.Malkh, kh.Tenkh,kh.Diachikh, kh.Sdt, kh.Diemtl);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            string struyvan = string.Format(@"delete from khachhang where makh='{0}'",kh.Makh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            if (kh.Diemtl >= 100)
                kh.Malkh = "VIP";
            else if (kh.Diemtl >= 50)
                kh.Malkh = "THUONG";
            else
                kh.Malkh = "MOI";
            string struyvan = string.Format(@"update khachhang set malkh='{0}',tenkh=N'{1}',diachikh=N'{2}',sdt='{3}',diemtl='{4}' where makh='{5}'", kh.Malkh, kh.Tenkh, kh.Diachikh, kh.Sdt, kh.Diemtl,kh.Makh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
