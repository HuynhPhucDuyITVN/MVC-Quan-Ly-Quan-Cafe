using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietLuong_DTO
    {
        private string maclv;
        private string manv;
        private string tenclv;
        private string tennv;
        private string ngaylam;
        private int thanhtien;

        public string Maclv { get => maclv; set => maclv = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tenclv { get => tenclv; set => tenclv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaylam { get => ngaylam; set => ngaylam = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
