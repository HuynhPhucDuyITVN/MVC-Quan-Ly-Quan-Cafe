using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LSGiaoDich_DTO
    {
        private int mahd;
        private string tenkh="Khách hàng";
        private string manv;
        private string tenban;
        private DateTime ngayhd;
        private DateTime ngaytt;
        private string tenhh = "Món";
        private int soluong = 0;
        private string tennv = "NhanVien";
        private decimal tongthanhtien=0;

        public int Mahd { get => mahd; set => mahd = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public DateTime Ngayhd { get => ngayhd; set => ngayhd = value; }
        public DateTime Ngaytt { get => ngaytt; set => ngaytt = value; }
        public string Tenhh { get => tenhh; set => tenhh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public decimal Tongthanhtien { get => tongthanhtien; set => tongthanhtien = value; }
    }
}
