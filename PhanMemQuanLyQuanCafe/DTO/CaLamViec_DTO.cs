using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLamViec_DTO
    {
        private string maclv;
        private string tenclv;
        private TimeSpan giobd;
        private TimeSpan giokt;
        private int sotien;

        public string Maclv { get => maclv; set => maclv = value; }
        public string Tenclv { get => tenclv; set => tenclv = value; }
        public TimeSpan Giobd { get => giobd; set => giobd = value; }
        public TimeSpan Giokt { get => giokt; set => giokt = value; }
        public int Sotien { get => sotien; set => sotien = value; }
    }
}
