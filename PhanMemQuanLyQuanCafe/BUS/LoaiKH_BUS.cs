using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiKH_BUS
    {
        public static List<LoaiKH_DTO> LayDSLoaiKH()
        {
            return LoaiKH_DAO.LayLoaiKH();
        }
        public static LoaiKH_DTO TimLoaiKhachHangTheoMa(string ma)
        {
            return LoaiKH_DAO.TimLoaiKhachHangTheoMa(ma);
        }
        public static bool ThemLoaiKhachHang(LoaiKH_DTO lkh)
        {
            return LoaiKH_DAO.ThemLoaiKhachHang(lkh);
        }
        public static bool XoaLoaiKhachHang(LoaiKH_DTO lkh)
        {
            return LoaiKH_DAO.XoaLoaiKhachHang(lkh);
        }
        public static bool SuaLoaiKhachHang(LoaiKH_DTO lkh)
        {
            return LoaiKH_DAO.SuaLoaiKhachHang(lkh);
        }
    }
}
