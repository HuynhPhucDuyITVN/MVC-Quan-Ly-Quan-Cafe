using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            return KhachHang_DAO.LayKhachHang();
        }
        public static List<KhachHang_DTO> LayKhachHangTheoTen(string ten)
        {
            return KhachHang_DAO.LayKhachHangTheoTen(ten);
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.ThemKhachHang(kh);
        }
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.XoaKhachHang(kh);
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SuaKhachHang(kh);
        }
        public static KhachHang_DTO LayKhachHangTheoMa(int makh)
        {
            return KhachHang_DAO.LayKhachHangTheoMa(makh);
        }
    }
}
