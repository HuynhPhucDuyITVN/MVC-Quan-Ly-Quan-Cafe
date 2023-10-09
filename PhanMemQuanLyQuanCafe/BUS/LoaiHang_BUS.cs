using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiHang_BUS
    {
        //Lấy danh sách loại hàng
        public static List<LoaiHang_DTO> LayDSLoaiHang()
        {
            return LoaiHang_DAO.LayLoaiHang();
        }
        public static LoaiHang_DTO TimLoaiHangTheoMa(string ma)
        {
            return LoaiHang_DAO.TimLoaiHangTheoMa(ma);
        }
        public static bool ThemLoaiHang(LoaiHang_DTO lh)
        {
            return LoaiHang_DAO.ThemLoaiHang(lh);
        }
        public static bool XoaLoaiHang(LoaiHang_DTO lh)
        {
            return LoaiHang_DAO.XoaLoaiHang(lh);
        }
        public static bool SuaLoaiHang(LoaiHang_DTO lh)
        {
            return LoaiHang_DAO.SuaLoaiHang(lh);
        }
        public static string LayTenLoaiHangTheoMa(string ma)
        {
            return LoaiHang_DAO.LayTenLoaiHangTheoMa(ma);
        }
    }
}
