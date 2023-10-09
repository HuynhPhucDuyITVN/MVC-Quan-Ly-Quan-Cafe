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
    public class LSGiaoDich_DAO
    {
        static SqlConnection conn;
        public static List<LSGiaoDich_DTO> LayLSGDKhachHang(int makh)
        {
            string struyvan = string.Format(@"select hd.tongthanhtien,hd.mahd,kh.tenkh,hd.manv,b.tenban,hd.ngayhd,hd.ngaytt,hh.tenhh,ct.soluong 
            from (((hoadon hd join ban b on b.maban=hd.maban )join chitiethoadon ct on ct.mahd=hd.mahd)join hanghoa hh on ct.mahh=hh.mahh)join khachhang kh on hd.makh=kh.makh 
            where hd.trangthai=1 and kh.makh={0}", makh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<LSGiaoDich_DTO> lsvlsgd = new List<LSGiaoDich_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSGiaoDich_DTO lsgd = new LSGiaoDich_DTO();
                lsgd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                lsgd.Tenkh = dt.Rows[i]["tenkh"].ToString();
                lsgd.Manv = dt.Rows[i]["manv"].ToString();
                lsgd.Tenban = dt.Rows[i]["tenban"].ToString();
                lsgd.Ngayhd = DateTime.Parse(dt.Rows[i]["ngayhd"].ToString());
                lsgd.Ngaytt = DateTime.Parse(dt.Rows[i]["ngaytt"].ToString());
                lsgd.Tenhh = dt.Rows[i]["tenhh"].ToString();
                lsgd.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lsgd.Tongthanhtien = decimal.Parse(dt.Rows[i]["tongthanhtien"].ToString());
                lsvlsgd.Add(lsgd);
            }
            DataProvider.DongKetNoi(conn);
            return lsvlsgd;
        }

        public static List<LSGiaoDich_DTO> LayLSGDHoaDonTheoNgay(string ngaybd,string ngaykt)
        {
            string struyvan = string.Format(@"select hd.mahd,kh.tenkh,hd.manv,b.tenban,hd.ngayhd,hd.ngaytt,hh.tenhh,ct.soluong 
            from (((hoadon hd join ban b on b.maban=hd.maban )join chitiethoadon ct on ct.mahd=hd.mahd)join hanghoa hh on ct.mahh=hh.mahh)join khachhang kh on hd.makh=kh.makh 
            where hd.trangthai=1 and hd.ngayhd >='{0}' and hd.ngaytt<='{1}'",ngaybd,ngaykt);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<LSGiaoDich_DTO> lsvlsgd = new List<LSGiaoDich_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSGiaoDich_DTO lsgd = new LSGiaoDich_DTO();
                lsgd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                lsgd.Tenkh = dt.Rows[i]["tenkh"].ToString();
                lsgd.Manv = dt.Rows[i]["manv"].ToString();
                lsgd.Tenban = dt.Rows[i]["tenban"].ToString();
                lsgd.Ngayhd = DateTime.Parse(dt.Rows[i]["ngayhd"].ToString());
                lsgd.Ngaytt = DateTime.Parse(dt.Rows[i]["ngaytt"].ToString());
                lsgd.Tenhh = dt.Rows[i]["tenhh"].ToString();
                lsgd.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lsvlsgd.Add(lsgd);
            }
            DataProvider.DongKetNoi(conn);
            return lsvlsgd;
        }
        public static List<LSGiaoDich_DTO> LayLSGDHoaDonTheoNgay2(string ngaybd, string ngaykt)
        {
            string struyvan = string.Format(@"select hd.tongthanhtien,hd.mahd,nv.tennv,hd.manv,b.tenban,hd.ngayhd,hd.ngaytt 
            from (hoadon hd join ban b on b.maban=hd.maban) join nhanvien nv on nv.manv=hd.manv
            where hd.trangthai=1 and hd.ngayhd >='{0}' and hd.ngaytt<='{1}'", ngaybd, ngaykt);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(struyvan, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<LSGiaoDich_DTO> lsvlsgd = new List<LSGiaoDich_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSGiaoDich_DTO lsgd = new LSGiaoDich_DTO();
                lsgd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                lsgd.Tennv = dt.Rows[i]["tennv"].ToString();
                lsgd.Manv = dt.Rows[i]["manv"].ToString();
                lsgd.Tenban = dt.Rows[i]["tenban"].ToString();
                lsgd.Ngayhd = DateTime.Parse(dt.Rows[i]["ngayhd"].ToString());
                lsgd.Ngaytt = DateTime.Parse(dt.Rows[i]["ngaytt"].ToString());
                lsgd.Tongthanhtien = decimal.Parse(dt.Rows[i]["tongthanhtien"].ToString());
                lsvlsgd.Add(lsgd);
            }
            DataProvider.DongKetNoi(conn);
            return lsvlsgd;
        }
    }
}
