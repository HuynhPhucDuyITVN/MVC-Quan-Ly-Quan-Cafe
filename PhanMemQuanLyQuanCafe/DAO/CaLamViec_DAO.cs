using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CaLamViec_DAO
    {
        static SqlConnection conn;
        public static List<CaLamViec_DTO> LayCaLamViec()
        {
            string struyvan = "select * from calamviec";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<CaLamViec_DTO> lsclv = new List<CaLamViec_DTO>();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                CaLamViec_DTO clv = new CaLamViec_DTO();
                clv.Maclv = dt.Rows[i]["maclv"].ToString();
                clv.Tenclv = dt.Rows[i]["tenclv"].ToString();
                clv.Giobd = DateTime.Parse(dt.Rows[i]["giobd"].ToString()).TimeOfDay;
                clv.Giokt = DateTime.Parse(dt.Rows[i]["giokt"].ToString()).TimeOfDay;
                clv.Sotien = int.Parse(dt.Rows[i]["sotien"].ToString());
                lsclv.Add(clv);
            }
            DataProvider.DongKetNoi(conn);
            return lsclv;
        }
        public static CaLamViec_DTO TimCaLamViecTheoMa(string ma)
        {
            string struyvan =string.Format("select * from calamviec where maclv ='{0}'",ma);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            CaLamViec_DTO clv = new CaLamViec_DTO();
            clv.Maclv = dt.Rows[0]["maclv"].ToString();
            clv.Tenclv = dt.Rows[0]["tenclv"].ToString();
            clv.Giobd = DateTime.Parse(dt.Rows[0]["giobd"].ToString()).TimeOfDay;
            clv.Giokt = DateTime.Parse(dt.Rows[0]["giokt"].ToString()).TimeOfDay;
            clv.Sotien = int.Parse(dt.Rows[0]["sotien"].ToString());
            DataProvider.DongKetNoi(conn);
            return clv;
        }
        public static bool ThemCa(CaLamViec_DTO clv)
        {
            string struyvan = string.Format(@"insert into calamviec values('{0}',N'{1}','{2}','{3}','{4}')", clv.Maclv, clv.Tenclv, clv.Giobd, clv.Giokt,clv.Sotien);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaCa(CaLamViec_DTO clv)
        {
            string struyvan = string.Format(@"delete from calamviec where maclv='{0}'", clv.Maclv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
        public static bool SuaCa(CaLamViec_DTO clv)
        {
            string struyvan = string.Format(@"update calamviec set tenclv=N'{0}',giobd='{1}',giokt='{2}',sotien='{3}' where maclv='{4}'", clv.Tenclv, clv.Giobd, clv.Giokt, clv.Sotien, clv.Maclv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
