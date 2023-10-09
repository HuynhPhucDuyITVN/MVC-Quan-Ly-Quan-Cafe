using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection conn;
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QuanLyQuanCafe(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QuanLyQuanCafe TO DISK = N'" + sDuongDan + sTen + "'";
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }
        public static bool KhoiPhucDuLieu(string sDuongDan)
        {
            string sql = "alter database QuanLyQuanCafe set offline with rollback immediate; restore database QuanLyQuanCafe from disk = N'" + sDuongDan + "' With replace";
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }
    }
}
