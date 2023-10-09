using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        private string mahh;
        private string tenhh;
        private string malh;
        private int giahh;
        private string tenlh;

        public string Mahh { get => mahh; set => mahh = value; }
        public string Tenhh { get => tenhh; set => tenhh = value; }
        public string Malh { get => malh; set => malh = value; }
        public int Giahh { get => giahh; set => giahh = value; }
        public string Tenlh { get => tenlh; set => tenlh = value; }
    }
}
