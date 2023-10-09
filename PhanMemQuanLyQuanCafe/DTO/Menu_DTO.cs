using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Menu_DTO
    {
        private string tenhh;
        private int soluong;
        private int gia;
        private decimal thanhtien =0;

        public string Tenhh { get => tenhh; set => tenhh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
        public decimal Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
