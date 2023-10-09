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
    public class HangHoa_DAO
    {
        static SqlConnection conn;
        //Lay ma hang hoa
        public static List<HangHoa_DTO> LayHangHoa()
        {
            string struyvan = "select hh.*,lh.tenlh from hanghoa hh,loaihanghoa lh where hh.malh=lh.malh";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<HangHoa_DTO> lsvhanghoa = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Mahh = dt.Rows[i]["mahh"].ToString();
                hh.Tenhh = dt.Rows[i]["tenhh"].ToString();
                hh.Malh = dt.Rows[i]["malh"].ToString();
                hh.Giahh = int.Parse(dt.Rows[i]["giasp"].ToString());
                hh.Tenlh = dt.Rows[i]["tenlh"].ToString();
                lsvhanghoa.Add(hh);
            }
            DataProvider.DongKetNoi(conn);
            return lsvhanghoa;
        }
        public static List<HangHoa_DTO> LayHangHoaTheoMaLH(string malh)
        {
            string struyvan =string.Format(@"select hh.*,lh.tenlh from hanghoa hh,loaihanghoa lh where hh.malh=lh.malh and hh.malh='{0}'",malh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<HangHoa_DTO> lsvhanghoa = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Mahh = dt.Rows[i]["mahh"].ToString();
                hh.Tenhh = dt.Rows[i]["tenhh"].ToString();
                hh.Malh = dt.Rows[i]["malh"].ToString();
                hh.Giahh = int.Parse(dt.Rows[i]["giasp"].ToString());
                hh.Tenlh = dt.Rows[i]["tenlh"].ToString();
                lsvhanghoa.Add(hh);
            }
            DataProvider.DongKetNoi(conn);
            return lsvhanghoa;
        }
        //Tìm hàng hóa theo mã
        public static HangHoa_DTO TimHangHoaTheoMa(string ma)
        {
            string struyvan = string.Format("select * from hanghoa where mahh ='{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.Mahh = dt.Rows[0]["mahh"].ToString();
            hh.Tenhh = dt.Rows[0]["tenhh"].ToString();
            hh.Malh = dt.Rows[0]["malh"].ToString();
            hh.Giahh = int.Parse(dt.Rows[0]["giasp"].ToString());
            DataProvider.DongKetNoi(conn);
            return hh;
        }
        public static bool ThemHangHoa(HangHoa_DTO hh)
        {
            string struyvan = string.Format(@"insert into hanghoa values('{0}',N'{1}','{2}','{3}')",hh.Mahh,hh.Tenhh,hh.Malh,hh.Giahh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaHangHoa(HangHoa_DTO hh)
        {
            string struyvan = string.Format(@"update hanghoa set tenhh=N'{0}',malh=N'{1}',giasp='{2}' where mahh='{3}'", hh.Tenhh,hh.Malh,hh.Giahh,hh.Mahh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        //Xóa loại hàng
        public static bool XoaHangHoa(HangHoa_DTO hh)
        {
            string struyvan = string.Format(@"delete from hanghoa where mahh ='{0}'", hh.Mahh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static HangHoa_DTO TimHangHoaTheoMaLH(string ma)
        {
            string struyvan = string.Format("select * from hanghoa where malh ='{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.Mahh = dt.Rows[0]["mahh"].ToString();
            hh.Tenhh = dt.Rows[0]["tenhh"].ToString();
            hh.Malh = dt.Rows[0]["malh"].ToString();
            hh.Giahh = int.Parse(dt.Rows[0]["giasp"].ToString());
            DataProvider.DongKetNoi(conn);
            return hh;
        }

    }
}
