using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Security.Cryptography;

namespace BUS
{
    public class NhanVien_BUS
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            return NhanVien_DAO.LayDSNhanVien();
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }
        public static NhanVien_DTO LayTKDangNhap(string manv, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhau);
            return NhanVien_DAO.LayTKDangNhap(manv, matkhau_mahoa);
        }
        public static bool DoiMatKhau(NhanVien_DTO nv,string mkmoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, mkmoi);
            nv.Matkhau = matkhau_mahoa;
            return NhanVien_DAO.DoiMatKhau(nv);
        }
        public static List<NhanVien_DTO> LayDSNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.LayDSNhanVienTheoTen(ten);
        }
        public static bool ThemNV(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNV(nv);
        }
        public static bool XoaNV(NhanVien_DTO nv)
        {
            return NhanVien_DAO.XoaNV(nv);
        }
        public static bool SuaNV(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNV(nv);
        }
    }
}
