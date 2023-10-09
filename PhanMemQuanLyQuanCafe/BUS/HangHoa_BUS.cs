using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HangHoa_BUS
    {
        public static List<HangHoa_DTO> LayDSHangHoa()
        {
            return HangHoa_DAO.LayHangHoa();
        }
        public static List<HangHoa_DTO> LayHangHoaTheoMaLH(string malh)
        {
            return HangHoa_DAO.LayHangHoaTheoMaLH(malh);
        }
        public static HangHoa_DTO TimHangHoaTheoMa(string ma)
        {
            return HangHoa_DAO.TimHangHoaTheoMa(ma);
        }
        public static bool ThemHangHoa(HangHoa_DTO hh)
        {
            return HangHoa_DAO.ThemHangHoa(hh);
        }
        public static bool SuaHangHoa(HangHoa_DTO hh)
        {
            return HangHoa_DAO.SuaHangHoa(hh);
        }
        public static bool XoaHangHoa(HangHoa_DTO hh)
        {
            return HangHoa_DAO.XoaHangHoa(hh);
        }
    }
}
