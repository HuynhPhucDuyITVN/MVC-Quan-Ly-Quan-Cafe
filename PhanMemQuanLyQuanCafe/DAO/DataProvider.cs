using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        
        public static SqlConnection MoKetNoi()
        {
            string pcName = System.Environment.MachineName;
            string s = "Data Source="+pcName+@"\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }
        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
