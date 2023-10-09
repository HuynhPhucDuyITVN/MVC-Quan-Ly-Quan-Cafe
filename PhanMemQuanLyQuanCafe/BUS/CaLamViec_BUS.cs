using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CaLamViec_BUS
    {
        public static List<CaLamViec_DTO> LayCaLamViec()
        {
            return CaLamViec_DAO.LayCaLamViec();
        }
        public static CaLamViec_DTO TimCaLamViecTheoMa(string ma)
        {
            return CaLamViec_DAO.TimCaLamViecTheoMa(ma);
        }
        public static bool ThemCa(CaLamViec_DTO clv)
        {
            return CaLamViec_DAO.ThemCa(clv);
        }
        public static bool XoaCa(CaLamViec_DTO clv)
        {
            return CaLamViec_DAO.XoaCa(clv);
        }
        public static bool SuaCa(CaLamViec_DTO clv)
        {
            return CaLamViec_DAO.SuaCa(clv);
        }

    }
}
