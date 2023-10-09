using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang_DTO
    {
        private string malh;
        private string tenlh;
        private string mota;

        public string Malh { get => malh; set => malh = value; }
        public string Tenlh { get => tenlh; set => tenlh = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}
