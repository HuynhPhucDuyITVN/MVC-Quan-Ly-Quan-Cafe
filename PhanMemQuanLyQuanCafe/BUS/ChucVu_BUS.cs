using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayDSCV()
        {
            return ChucVu_DAO.LayDSCV();
        }
        public static ChucVu_DTO TimCVTheoMa(string ma)
        {
            return ChucVu_DAO.TimCVTheoMa(ma);
        }
        public static bool ThemCV(ChucVu_DTO cv)
        {
            return ChucVu_DAO.ThemCV(cv);
        }
        public static bool XoaCV(ChucVu_DTO cv)
        {
            return ChucVu_DAO.XoaCV(cv);
        }
        public static bool SuaCV(ChucVu_DTO cv)
        {
            return ChucVu_DAO.SuaCV(cv);
        }

    }
}
