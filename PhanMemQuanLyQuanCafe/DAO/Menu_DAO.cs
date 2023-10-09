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
    public class Menu_DAO
    {
        static SqlConnection conn;
        public static List<Menu_DTO> LayDSMenu(int idban)
        {
            string struyvan = string.Format(@"select hh.tenhh,ct.soluong,hh.giasp,hh.giasp*ct.soluong as thanhtien from 
                                            (chitiethoadon ct join hoadon hd on hd.mahd=ct.mahd)join hanghoa hh on hh.mahh=ct.mahh 
                                                where hd.maban={0} and hd.trangthai=0",idban);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<Menu_DTO> lsvmenu = new List<Menu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Menu_DTO menu = new Menu_DTO();
                menu.Tenhh = dt.Rows[i]["tenhh"].ToString();
                menu.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                menu.Gia = int.Parse(dt.Rows[i]["giasp"].ToString());
                menu.Thanhtien = decimal.Parse(dt.Rows[i]["thanhtien"].ToString());
                lsvmenu.Add(menu);
            }
            DataProvider.DongKetNoi(conn);
            return lsvmenu;
        }
    }
}
