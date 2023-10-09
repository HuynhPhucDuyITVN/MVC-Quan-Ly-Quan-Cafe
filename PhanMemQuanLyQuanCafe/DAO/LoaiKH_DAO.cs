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

    public class LoaiKH_DAO
    {
        static SqlConnection conn;
        public static List<LoaiKH_DTO> LayLoaiKH()
        {
            string struyvan = "select * from loaikhachhang";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<LoaiKH_DTO> lsloaikh = new List<LoaiKH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiKH_DTO lkh = new LoaiKH_DTO();
                lkh.Malkh = dt.Rows[i]["malkh"].ToString();
                lkh.Tenlkh = dt.Rows[i]["tenlkh"].ToString();
                lkh.Giamgia = int.Parse(dt.Rows[i]["giamgia"].ToString());
                lsloaikh.Add(lkh);
            }
            DataProvider.DongKetNoi(conn);
            return lsloaikh;
        }
        public static LoaiKH_DTO TimLoaiKhachHangTheoMa(string ma)
        {
            string struyvan = string.Format(@"select * from loaikhachhang where malkh=N'{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            LoaiKH_DTO lkh = new LoaiKH_DTO();
            lkh.Malkh = dt.Rows[0]["malkh"].ToString();
            lkh.Tenlkh = dt.Rows[0]["tenlkh"].ToString();
            lkh.Giamgia = int.Parse(dt.Rows[0]["giamgia"].ToString());
            DataProvider.DongKetNoi(conn);
            return lkh;
        }
        public static bool ThemLoaiKhachHang(LoaiKH_DTO lkh)
        {
            string struyvan = string.Format(@"insert into loaikhachhang values(N'{0}',N'{1}','{2}')",lkh.Malkh,lkh.Tenlkh,lkh.Giamgia);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaLoaiKhachHang(LoaiKH_DTO lkh)
        {
            string struyvan = string.Format(@"update loaikhachhang set tenlkh=N'{0}',giamgia='{1}' where malkh =N'{2}'", lkh.Tenlkh, lkh.Giamgia, lkh.Malkh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaLoaiKhachHang(LoaiKH_DTO lkh)
        {
            string struyvan = string.Format(@"delete from loaikhachhang where malkh =N'{0}'",lkh.Malkh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
