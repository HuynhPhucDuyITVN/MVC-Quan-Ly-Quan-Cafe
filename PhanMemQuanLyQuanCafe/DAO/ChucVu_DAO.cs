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
    public class ChucVu_DAO
    {
        static SqlConnection conn;
        public static List<ChucVu_DTO> LayDSCV()
        {
            string struyvan = "select * from chucvu";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<ChucVu_DTO> lsvcv = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Macv = dt.Rows[i]["macv"].ToString();
                cv.Tencv = dt.Rows[i]["tencv"].ToString();
                lsvcv.Add(cv);
            }
            DataProvider.DongKetNoi(conn);
            return lsvcv;
        }
        public static ChucVu_DTO TimCVTheoMa(string ma)
        {
            string struyvan =string.Format(@"select * from chucvu where macv='{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Macv = dt.Rows[0]["macv"].ToString();
            cv.Tencv = dt.Rows[0]["tencv"].ToString();
            DataProvider.DongKetNoi(conn);
            return cv;
        }
        public static bool ThemCV(ChucVu_DTO cv)
        {
            string struyvan = string.Format(@"insert into chucvu values('{0}',N'{1}')",cv.Macv,cv.Tencv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaCV(ChucVu_DTO cv)
        {
            string struyvan = string.Format(@"delete from chucvu where macv='{0}'", cv.Macv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaCV(ChucVu_DTO cv)
        {
            string struyvan = string.Format(@"update chucvu set tencv=N'{0}' where macv='{1}'",cv.Tencv, cv.Macv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
