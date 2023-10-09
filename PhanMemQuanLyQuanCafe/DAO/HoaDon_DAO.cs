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
    public class HoaDon_DAO
    {
        static SqlConnection conn;
        public static int LayMaHoaDonChuaThanhToanTheoBan(int idban)
        {
            string struyvan = string.Format(@"select * from hoadon where maban={0} and trangthai=0",idban);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return -1;
            HoaDon_DTO hd = new HoaDon_DTO();
            hd.Mahd = int.Parse(dt.Rows[0]["mahd"].ToString());
            hd.Manv =dt.Rows[0]["manv"].ToString();
            hd.Maban = int.Parse(dt.Rows[0]["maban"].ToString());
            hd.Ngayhd = DateTime.Parse(dt.Rows[0]["ngayhd"].ToString());
            if(dt.Rows[0]["ngaytt"].ToString()!="")
                hd.Ngaytt = DateTime.Parse(dt.Rows[0]["ngaytt"].ToString());
            hd.Trangthai = int.Parse(dt.Rows[0]["trangthai"].ToString());
            if(dt.Rows[0]["makh"].ToString()!="")
                hd.Makh = int.Parse(dt.Rows[0]["makh"].ToString());
            DataProvider.DongKetNoi(conn);
            return hd.Mahd;
        }
        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            string struyvan = string.Format(@"insert into hoadon(manv,maban,ngaytt,trangthai) values('{0}',{1},null,0)", hd.Manv,hd.Maban);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static int LayMaHDMoiNhat()
        {
            string struyvan = "select max(mahd) as maxmahd from hoadon";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return 1;
            return int.Parse(dt.Rows[0]["maxmahd"].ToString()); 
        }
        public static bool XoaHoaDon(int mahd)
        {
            string struyvan = string.Format(@"delete from hoadon where mahd={0}",mahd);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaHoaDon(int mahd,decimal tongthanhtien)
        {
            string struyvan = string.Format(@"update hoadon set trangthai=1, ngaytt=getdate(),tongthanhtien={0}  where mahd={1}",tongthanhtien,mahd);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaHoaDonVoiMaKH(int mahd,int makh, decimal tongthanhtien)
        {
            string struyvan = string.Format(@"update hoadon set trangthai=1, ngaytt=getdate(),tongthanhtien={0}, makh={1} where mahd={2}",tongthanhtien, makh,mahd);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
