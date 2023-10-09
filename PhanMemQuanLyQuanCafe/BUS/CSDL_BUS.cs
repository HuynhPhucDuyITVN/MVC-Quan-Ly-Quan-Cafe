using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class CSDL_BUS
    {
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            return CSDL_DAO.SaoLuuDuLieu(sDuongDan);
        }
        public static bool KhoiPhucDuLieu(string sDuongDan)
        {
            return CSDL_DAO.KhoiPhucDuLieu(sDuongDan);
        }
    }
}
