using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string makh;
        private string malkh;
        private string tenkh;
        private string tenlkh;
        private string diachikh;
        private string sdt;
        private int diemtl;
        public string Makh { get => makh; set => makh = value; }
        public string Malkh { get => malkh; set => malkh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Tenlkh { get => tenlkh; set => tenlkh = value; }
        public string Diachikh { get => diachikh; set => diachikh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        
    }
}
