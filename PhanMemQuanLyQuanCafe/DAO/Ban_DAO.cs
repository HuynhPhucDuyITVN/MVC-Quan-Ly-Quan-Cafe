using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Ban_DAO
    {
        static SqlConnection conn;

        public static List<Ban_DTO> LayBan()
        {
            string struyvan = "select * from ban";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<Ban_DTO> lsvban = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count;i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.Maban = int.Parse(dt.Rows[i]["maban"].ToString());
                ban.Tenban = dt.Rows[i]["tenban"].ToString();
                ban.Trangthai = dt.Rows[i]["trangthai"].ToString();
                lsvban.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lsvban;
        }
        public static List<Ban_DTO> LayBanTrong()
        {
            string struyvan ="select * from ban where trangthai=N'Trống'";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<Ban_DTO> lsvban = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.Maban = int.Parse(dt.Rows[i]["maban"].ToString());
                ban.Tenban = dt.Rows[i]["tenban"].ToString();
                ban.Trangthai = dt.Rows[i]["trangthai"].ToString();
                lsvban.Add(ban);
            }
            DataProvider.DongKetNoi(conn);
            return lsvban;
        }
        public static bool ThemBan(Ban_DTO ban)
        {
            string struyvan = string.Format(@"insert into ban values(N'{0}',N'{1}')",ban.Tenban,ban.Trangthai);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaBan(Ban_DTO ban)
        {
            string struyvan = string.Format(@"update ban set tenban=N'{0}',trangthai=N'{1}' where maban='{2}'", ban.Tenban, ban.Trangthai,ban.Maban);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaBan(Ban_DTO ban)
        {
            string struyvan = string.Format(@"delete from ban where maban='{0}'", ban.Maban);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool DoiBan(int maban1,int maban2,string manv)
        {
            string struyvan = string.Format(@"exec usp_doiban {0},{1},'{2}'", maban1, maban2, manv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
