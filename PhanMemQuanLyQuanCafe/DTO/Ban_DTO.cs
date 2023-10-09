using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        private int maban;
        private string tenban;
        private string trangthai;

        public int Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
