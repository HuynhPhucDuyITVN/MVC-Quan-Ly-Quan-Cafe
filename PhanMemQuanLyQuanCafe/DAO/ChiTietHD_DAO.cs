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
    public class ChiTietHD_DAO
    {
        static SqlConnection conn;
        public static List<ChiTietHD_DTO> LayDSChiTietHDTheoMa(int mahd)
        {
            string struyvan = string.Format(@"select * from chitiethoadon where mahd='{0}'",mahd);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChiTietHD_DTO> lsvcthd = new List<ChiTietHD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHD_DTO cthd = new ChiTietHD_DTO();
                cthd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                cthd.Mahh = dt.Rows[i]["mahh"].ToString();
                cthd.Sl = int.Parse(dt.Rows[i]["soluong"].ToString());
                lsvcthd.Add(cthd);
            }
            DataProvider.DongKetNoi(conn);
            return lsvcthd;
        }
        public static ChiTietHD_DTO TimChiTietHDTheoMahdvaMahh(int mahd,string mahh)
        {
            string struyvan = string.Format(@"select * from chitiethoadon where mahd={0} and mahh='{1}'",mahd,mahh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChiTietHD_DTO cthd = new ChiTietHD_DTO();
            cthd.Mahd = int.Parse(dt.Rows[0]["mahd"].ToString());
            cthd.Mahh = dt.Rows[0]["mahh"].ToString();
            cthd.Sl = int.Parse(dt.Rows[0]["soluong"].ToString());
            DataProvider.DongKetNoi(conn);
            return cthd;
        }
        public static ChiTietHD_DTO TimChiTietHDTheoMahdvaMahh(int mahd)
        {
            string struyvan = string.Format(@"select * from chitiethoadon where mahd={0}", mahd);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChiTietHD_DTO cthd = new ChiTietHD_DTO();
            cthd.Mahd = int.Parse(dt.Rows[0]["mahd"].ToString());
            cthd.Mahh = dt.Rows[0]["mahh"].ToString();
            cthd.Sl = int.Parse(dt.Rows[0]["soluong"].ToString());
            DataProvider.DongKetNoi(conn);
            return cthd;
        }

        public static bool ThemCTHoaDon(ChiTietHD_DTO ct)
        {
            string struyvan = string.Format(@"insert into chitiethoadon values({0},'{1}',{2})", ct.Mahd,ct.Mahh,ct.Sl);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaCTHoaDon(ChiTietHD_DTO ct)
        {
            string struyvan = string.Format(@"update chitiethoadon set soluong={0} where mahd={1} and mahh='{2}'", ct.Sl,ct.Mahd, ct.Mahh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaCTHoaDon(ChiTietHD_DTO ct)
        {
            string struyvan = string.Format(@"delete from chitiethoadon where mahd={0} and mahh='{1}'", ct.Mahd, ct.Mahh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
