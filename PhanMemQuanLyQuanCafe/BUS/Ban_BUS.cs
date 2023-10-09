using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Ban_BUS
    {
        public static List<Ban_DTO> LayDSBan()
        {
            return Ban_DAO.LayBan();
        }
        public static List<Ban_DTO> LayBanTrong()
        {
            return Ban_DAO.LayBanTrong();
        }
        public static bool ThemBan(Ban_DTO ban)
        {
            return Ban_DAO.ThemBan(ban);
        }
        public static bool SuaBan(Ban_DTO ban)
        {
            return Ban_DAO.SuaBan(ban);
        }
        public static bool XoaBan(Ban_DTO ban)
        {
            return Ban_DAO.XoaBan(ban);
        }
        public static bool DoiBan(int maban1, int maban2, string manv)
        {
            return Ban_DAO.DoiBan(maban1, maban2, manv);
        }
    }
}
