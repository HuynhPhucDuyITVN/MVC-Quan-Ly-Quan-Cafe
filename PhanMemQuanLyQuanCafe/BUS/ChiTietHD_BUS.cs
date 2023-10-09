using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public class ChiTietHD_BUS
    {
        public static List<ChiTietHD_DTO> LayDSChiTietHDTheoMa(int mahd)
        {
            return ChiTietHD_DAO.LayDSChiTietHDTheoMa(mahd);
        }
        public static bool ThemCTHoaDon(ChiTietHD_DTO ct)
        {
            return ChiTietHD_DAO.ThemCTHoaDon(ct);
        }
        public static ChiTietHD_DTO TimChiTietHDTheoMahdvaMahh(int mahd, string mahh)
        {
            return ChiTietHD_DAO.TimChiTietHDTheoMahdvaMahh(mahd, mahh);
        }
        public static ChiTietHD_DTO TimChiTietHDTheoMahdvaMahh(int mahd)
        {
            return ChiTietHD_DAO.TimChiTietHDTheoMahdvaMahh(mahd);
        }
        public static bool SuaCTHoaDon(ChiTietHD_DTO ct)
        {
            return ChiTietHD_DAO.SuaCTHoaDon(ct);
        }
        public static bool XoaCTHoaDon(ChiTietHD_DTO ct)
        {
            return ChiTietHD_DAO.XoaCTHoaDon(ct);
        }
    }
}
