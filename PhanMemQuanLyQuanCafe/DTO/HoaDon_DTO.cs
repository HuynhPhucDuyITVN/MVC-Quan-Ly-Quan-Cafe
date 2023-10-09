using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int mahd;
        private string manv;
        private int maban;
        private DateTime ngayhd;
        private DateTime? ngaytt;
        private int trangthai;
        private int? makh;
        private decimal tongthanhtien;

        public int Mahd { get => mahd; set => mahd = value; }
        public string Manv { get => manv; set => manv = value; }
        public int Maban { get => maban; set => maban = value; }
        public DateTime Ngayhd { get => ngayhd; set => ngayhd = value; }
        public DateTime? Ngaytt { get => ngaytt; set => ngaytt = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public int? Makh { get => makh; set => makh = value; }
        public decimal Tongthanhtien { get => tongthanhtien; set => tongthanhtien = value; }
    }
}
