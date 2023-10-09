using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LSGiaoDich_BUS
    {
        public static List<LSGiaoDich_DTO> LayLSGDKhachHang(int makh)
        {
            return LSGiaoDich_DAO.LayLSGDKhachHang(makh);
        }
        public static List<LSGiaoDich_DTO> LayLSGDHoaDonTheoNgay(string ngaybd, string ngaykt)
        {
            return LSGiaoDich_DAO.LayLSGDHoaDonTheoNgay(ngaybd, ngaykt);
        }
        public static List<LSGiaoDich_DTO> LayLSGDHoaDonTheoNgay2(string ngaybd, string ngaykt)
        {
            return LSGiaoDich_DAO.LayLSGDHoaDonTheoNgay2(ngaybd, ngaykt);
        }
    }
}
