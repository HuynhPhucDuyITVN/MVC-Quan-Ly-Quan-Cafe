using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string manv;
        private string tennv;
        private string gioitinh;
        private string chucvu;
        private string tencv;
        private string ngayvaolam;
        private string diachi;
        private string sdt;
        private int phanquyen;
        private string matkhau;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public string Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Phanquyen { get => phanquyen; set => phanquyen = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
