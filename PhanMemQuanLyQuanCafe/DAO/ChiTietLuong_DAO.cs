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
    public class ChiTietLuong_DAO
    {
        static SqlConnection conn;
        public static List<ChiTietLuong_DTO> LayDSCTLuong()
        {
            string struyvan = "select clv.tenclv,nv.tennv,ct.* from (chitietluong ct join calamviec clv on ct.maclv=clv.maclv)join nhanvien nv on nv.manv=ct.manv";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChiTietLuong_DTO> lsvctluong = new List<ChiTietLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietLuong_DTO ctluong = new ChiTietLuong_DTO();
                ctluong.Tenclv = dt.Rows[i]["tenclv"].ToString();
                ctluong.Tennv = dt.Rows[i]["tennv"].ToString();
                ctluong.Maclv = dt.Rows[i]["maclv"].ToString();
                ctluong.Manv = dt.Rows[i]["manv"].ToString();
                ctluong.Ngaylam = dt.Rows[i]["ngaylam"].ToString();
                ctluong.Thanhtien = int.Parse(dt.Rows[i]["thanhtien"].ToString());
                lsvctluong.Add(ctluong);
            }
            DataProvider.DongKetNoi(conn);
            return lsvctluong;
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNV(string manv,string ngaylam)
        {
            string struyvan =string.Format( @"select clv.tenclv,nv.tennv,ct.* from (chitietluong ct join calamviec clv on ct.maclv=clv.maclv)join nhanvien nv on nv.manv=ct.manv where ct.manv='{0}' and ct.ngaylam='{1}'",manv,ngaylam);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChiTietLuong_DTO> lsvctluong = new List<ChiTietLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietLuong_DTO ctluong = new ChiTietLuong_DTO();
                ctluong.Tenclv = dt.Rows[i]["tenclv"].ToString();
                ctluong.Tennv = dt.Rows[i]["tennv"].ToString();
                ctluong.Maclv = dt.Rows[i]["maclv"].ToString();
                ctluong.Manv = dt.Rows[i]["manv"].ToString();
                ctluong.Ngaylam = dt.Rows[i]["ngaylam"].ToString();
                ctluong.Thanhtien = int.Parse(dt.Rows[i]["thanhtien"].ToString());
                lsvctluong.Add(ctluong);
            }
            DataProvider.DongKetNoi(conn);
            return lsvctluong;
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNgayVaMaNhanVien(string ngaybd,string ngaykt,string manv)
        {
            string struyvan = string.Format(@"select clv.tenclv,nv.tennv,ct.* from (chitietluong ct join calamviec clv on ct.maclv=clv.maclv)join nhanvien nv on nv.manv=ct.manv 
            where ct.ngaylam>='{0}' and ct.ngaylam <='{1}' and ct.manv= '{2}'",ngaybd,ngaykt,manv);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChiTietLuong_DTO> lsvctluong = new List<ChiTietLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietLuong_DTO ctluong = new ChiTietLuong_DTO();
                ctluong.Tenclv = dt.Rows[i]["tenclv"].ToString();
                ctluong.Tennv = dt.Rows[i]["tennv"].ToString();
                ctluong.Maclv = dt.Rows[i]["maclv"].ToString();
                ctluong.Manv = dt.Rows[i]["manv"].ToString();
                ctluong.Ngaylam = dt.Rows[i]["ngaylam"].ToString();
                ctluong.Thanhtien = int.Parse(dt.Rows[i]["thanhtien"].ToString());
                lsvctluong.Add(ctluong);
            }
            DataProvider.DongKetNoi(conn);
            return lsvctluong;
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNgay(string ngaybd, string ngaykt)
        {
            string struyvan = string.Format(@"select clv.tenclv,nv.tennv,ct.* from (chitietluong ct join calamviec clv on ct.maclv=clv.maclv)join nhanvien nv on nv.manv=ct.manv 
            where ct.ngaylam>='{0}' and ct.ngaylam <='{1}'", ngaybd, ngaykt);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChiTietLuong_DTO> lsvctluong = new List<ChiTietLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietLuong_DTO ctluong = new ChiTietLuong_DTO();
                ctluong.Tenclv = dt.Rows[i]["tenclv"].ToString();
                ctluong.Tennv = dt.Rows[i]["tennv"].ToString();
                ctluong.Maclv = dt.Rows[i]["maclv"].ToString();
                ctluong.Manv = dt.Rows[i]["manv"].ToString();
                ctluong.Ngaylam = dt.Rows[i]["ngaylam"].ToString();
                ctluong.Thanhtien = int.Parse(dt.Rows[i]["thanhtien"].ToString());
                lsvctluong.Add(ctluong);
            }
            DataProvider.DongKetNoi(conn);
            return lsvctluong;
        }
        public static ChiTietLuong_DTO TimCTL(string maclv,string manv, string ngaylam)
        {
            string struyvan = string.Format(@"select * from chitietluong where maclv='{0}' and manv='{1}' and ngaylam='{2}'", maclv, manv, ngaylam);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            ChiTietLuong_DTO ctluong = new ChiTietLuong_DTO();
            ctluong.Maclv = dt.Rows[0]["maclv"].ToString();
            ctluong.Manv = dt.Rows[0]["manv"].ToString();
            ctluong.Ngaylam = dt.Rows[0]["ngaylam"].ToString();
            ctluong.Thanhtien = int.Parse(dt.Rows[0]["thanhtien"].ToString());
            DataProvider.DongKetNoi(conn);
            return ctluong;
        }
        public static bool ThemCTL(ChiTietLuong_DTO ctl)
        {
            string struyvan = string.Format(@"insert into chitietluong values('{0}','{1}','{2}','{3}')",ctl.Maclv,ctl.Manv,ctl.Ngaylam,ctl.Thanhtien);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaCTL(ChiTietLuong_DTO ctl)
        {
            string struyvan = string.Format(@"delete from chitietluong where maclv='{0}' and manv='{1}' and ngaylam='{2}'", ctl.Maclv,ctl.Manv,ctl.Ngaylam);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
