using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietLuong_BUS
    {
        public static List<ChiTietLuong_DTO> LayDSCTLuong()
        {
            return ChiTietLuong_DAO.LayDSCTLuong();
        }
        public static ChiTietLuong_DTO TimCTL(string maclv, string manv, string ngaylam)
        {
            return ChiTietLuong_DAO.TimCTL(maclv, manv, ngaylam);
        }
        public static bool ThemCTL(ChiTietLuong_DTO ctl)
        {
            return ChiTietLuong_DAO.ThemCTL(ctl);
        }
        public static bool XoaCTL(ChiTietLuong_DTO ctl)
        {
            return ChiTietLuong_DAO.XoaCTL(ctl);
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNgayVaMaNhanVien(string ngaybd, string ngaykt, string manv)
        {
            return ChiTietLuong_DAO.LayDSCTLuongTheoNgayVaMaNhanVien(ngaybd, ngaykt, manv);
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNgay(string ngaybd, string ngaykt)
        {
            return ChiTietLuong_DAO.LayDSCTLuongTheoNgay(ngaybd, ngaykt);
        }
        public static List<ChiTietLuong_DTO> LayDSCTLuongTheoNV(string manv,string ngaylam)
        {
            return ChiTietLuong_DAO.LayDSCTLuongTheoNV(manv,ngaylam);
        }
    }
}
