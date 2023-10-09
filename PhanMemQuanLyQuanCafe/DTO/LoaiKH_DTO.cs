using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKH_DTO
    {
        private string malkh;
        private string tenlkh;
        private int giamgia;

        public string Malkh { get => malkh; set => malkh = value; }
        public string Tenlkh { get => tenlkh; set => tenlkh = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
    }
}
