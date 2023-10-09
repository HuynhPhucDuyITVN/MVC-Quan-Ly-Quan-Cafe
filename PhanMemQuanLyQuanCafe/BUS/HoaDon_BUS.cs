using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static int LayMaHoaDonChuaThanhToanTheoBan(int idban)
        {
            return HoaDon_DAO.LayMaHoaDonChuaThanhToanTheoBan(idban);
        }
        public static bool ThemHoaDon(HoaDon_DTO hd)
        {
            return HoaDon_DAO.ThemHoaDon(hd);
        }
        public static int LayMaHDMoiNhat()
        {
            return HoaDon_DAO.LayMaHDMoiNhat();
        }
        public static bool XoaHoaDon(int mahd)
        {
            return HoaDon_DAO.XoaHoaDon(mahd);
        }
        public static bool SuaHoaDon(int mahd, decimal tongthanhtien)
        {
            return HoaDon_DAO.SuaHoaDon(mahd,tongthanhtien);
        }
        public static bool SuaHoaDonVoiMaKH(int mahd, int makh, decimal tongthanhtien)
        {
            return HoaDon_DAO.SuaHoaDonVoiMaKH(mahd, makh,tongthanhtien);
        }
    }
}
