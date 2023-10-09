using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace PhanMemQuanLyQuanCafe.Forms
{
    public partial class frmCaLam : Form
    {
        public frmCaLam()
        {
            InitializeComponent();
        }
        public void HienDSNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lsvnv = NhanVien_BUS.LayDSNhanVien();
            cbnhanvien.DataSource = lsvnv;
            cbnhanvien.DisplayMember = "Tennv";
            cbnhanvien.ValueMember = "Manv";
        }
        public void HienThiChiTietCaLam()
        {
            List<ChiTietLuong_DTO> lsvct = ChiTietLuong_BUS.LayDSCTLuong();
            dgluong.DataSource = lsvct;
            dgluong.Columns["Maclv"].HeaderText = "Mã ca làm việc";
            dgluong.Columns["Tenclv"].HeaderText = "Ca làm việc";
            dgluong.Columns["Manv"].HeaderText = "Mã nhân viên";
            dgluong.Columns["Tennv"].HeaderText = "Nhân viên";
            dgluong.Columns["Ngaylam"].HeaderText = "Ngày làm";
            dgluong.Columns["Thanhtien"].HeaderText = "Lương theo ca";
            dgluong.Columns["Maclv"].Visible = false;
            dgluong.Columns["Manv"].Visible = false;
            dgluong.Columns["Tenclv"].Width = 150;
            dgluong.Columns["Tennv"].Width = 200;
            dgluong.Columns["Ngaylam"].Width = 150;
            dgluong.Columns["Thanhtien"].Width = 150;
        }
        public void HienThiCaLamTheoNhanVien(string manv,string ngaylam)
        {
            List<ChiTietLuong_DTO> lsvct = ChiTietLuong_BUS.LayDSCTLuongTheoNV(manv,ngaylam);
            NhanVien_DTO nv = NhanVien_BUS.TimNhanVienTheoMa(manv);
            if (lsvct != null)
            {
                dgluong.DataSource = lsvct;
                dgluong.Columns["Maclv"].HeaderText = "Mã ca làm việc";
                dgluong.Columns["Tenclv"].HeaderText = "Ca làm việc";
                dgluong.Columns["Manv"].HeaderText = "Mã nhân viên";
                dgluong.Columns["Tennv"].HeaderText = "Nhân viên";
                dgluong.Columns["Ngaylam"].HeaderText = "Ngày làm";
                dgluong.Columns["Thanhtien"].HeaderText = "Lương theo ca";
                dgluong.Columns["Maclv"].Visible = false;
                dgluong.Columns["Manv"].Visible = false;
                dgluong.Columns["Tenclv"].Width = 150;
                dgluong.Columns["Tennv"].Width = 200;
                dgluong.Columns["Ngaylam"].Width = 150;
                dgluong.Columns["Thanhtien"].Width = 150;
            }
            else
            {
                MessageBox.Show(string.Format("Không có ca làm của nhân viên {0} trong ngày {1}",nv.Tennv, ngaylam), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                HienThiChiTietCaLam();
            }

        }
        private void frmCaLam_Load(object sender, EventArgs e)
        {
            ngaylam.Value = DateTime.Now;
            HienDSNhanVienLenCombobox();
            cbnhanvien.SelectedIndex = 0;
            HienThiChiTietCaLam();
        }

        private void ngaylam_ValueChanged(object sender, EventArgs e)
        {
            //HienThiCaLamTheoNhanVien(cbnhanvien.SelectedValue.ToString(), ngaylam.Value.ToString("yyyy/MM/dd"));
        }

        private void cbnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HienThiCaLamTheoNhanVien(cbnhanvien.SelectedValue.ToString(), ngaylam.Value.ToString("yyyy/MM/dd"));
        }

        private void bnttim_Click(object sender, EventArgs e)
        {
            HienThiCaLamTheoNhanVien(cbnhanvien.SelectedValue.ToString(), ngaylam.Value.ToString("yyyy/MM/dd"));
        }
    }
}
