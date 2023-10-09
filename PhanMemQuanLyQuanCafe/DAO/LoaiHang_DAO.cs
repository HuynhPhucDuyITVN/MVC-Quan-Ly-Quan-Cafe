using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiHang_DAO
    {
        static SqlConnection conn;

        //Lấy danh sách loại hàng
        public static List<LoaiHang_DTO> LayLoaiHang()
        {
            string struyvan = "select * from loaihanghoa";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<LoaiHang_DTO> lstloaihang = new List<LoaiHang_DTO>();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                LoaiHang_DTO lh = new LoaiHang_DTO();
                lh.Malh = dt.Rows[i]["malh"].ToString();
                lh.Tenlh = dt.Rows[i]["tenlh"].ToString();
                lh.Mota = dt.Rows[i]["mota"].ToString();
                lstloaihang.Add(lh);
            }
            DataProvider.DongKetNoi(conn);
            return lstloaihang;
        }
        //Tìm nhân viên theo mã
        public static LoaiHang_DTO TimLoaiHangTheoMa(string ma)
        {
            string struyvan = string.Format("select * from loaihanghoa where malh ='{0}'", ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LoaiHang_DTO lh = new LoaiHang_DTO();
            lh.Malh = dt.Rows[0]["malh"].ToString();
            lh.Tenlh = dt.Rows[0]["tenlh"].ToString();
            lh.Mota = dt.Rows[0]["mota"].ToString();
            DataProvider.DongKetNoi(conn);
            return lh;
        }
        //Lấy loại hàng theo mã
        public static string LayTenLoaiHangTheoMa(string ma)
        {
            string struyvan = string.Format("select tenlh from loaihanghoa where malh ='{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            DataProvider.DongKetNoi(conn);
            return dt.Rows[0]["tenlh"].ToString();
        }
        //Thêm loại hàng
        public static bool ThemLoaiHang(LoaiHang_DTO lh)
        {
            string struyvan = string.Format(@"insert into loaihanghoa values('{0}',N'{1}',N'{2}')",lh.Malh, lh.Tenlh, lh.Mota);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        //Sửa loại hàng
        public static bool SuaLoaiHang(LoaiHang_DTO lh)
        {
            string struyvan = string.Format(@"update loaihanghoa set tenlh=N'{0}',mota=N'{1}' where malh='{2}'",lh.Tenlh, lh.Mota, lh.Malh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        //Xóa loại hàng
        public static bool XoaLoaiHang(LoaiHang_DTO lh)
        {
            string struyvan = string.Format(@"delete from loaihanghoa where malh ='{0}'", lh.Malh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
