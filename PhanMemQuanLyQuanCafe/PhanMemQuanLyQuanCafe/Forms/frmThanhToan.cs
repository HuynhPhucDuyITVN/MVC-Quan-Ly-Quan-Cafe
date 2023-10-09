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
using System.Globalization;

namespace PhanMemQuanLyQuanCafe.Forms
{
    public partial class frmThanhToan : Form
    {
        private int maban;
        private string tenban;
        private int mahd;
        private string manv;
        private string makh;
        private decimal tongtien;
        private decimal tongtienvoigiamgia = 0;
        private int diemtl=0;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        public frmThanhToan(int maban, string tenban, int mahd, string manv, string makh, decimal tongtien)
        {
            this.maban = maban;
            this.tenban = tenban;
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.tongtien = tongtien;
            InitializeComponent();
        }
        public void LayPhanTramGiamGia(string makh)
        {
            if (makh == "null")
                txtgiamgia.Text = "0";
            else
            {
                KhachHang_DTO kh = KhachHang_BUS.LayKhachHangTheoMa(int.Parse(makh));
                LoaiKH_DTO lkh = LoaiKH_BUS.TimLoaiKhachHangTheoMa(kh.Malkh);
                txtgiamgia.Text = lkh.Giamgia.ToString();
            }
        }
        public void HienThiHoaDon(int idban)
        {
            lsvchitiet.Items.Clear();
            decimal tongtien = 0;
            if (Menu_BUS.LayDSMenu(idban) != null)
            {

                foreach (Menu_DTO menu in Menu_BUS.LayDSMenu(idban))
                {
                    ListViewItem lsvitem = new ListViewItem(menu.Tenhh);
                    lsvitem.SubItems.Add(menu.Soluong.ToString());
                    lsvitem.SubItems.Add(menu.Gia.ToString());
                    lsvitem.SubItems.Add(menu.Thanhtien.ToString());
                    tongtien += menu.Thanhtien;
                    lsvchitiet.Items.Add(lsvitem);
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                //Thread.CurrentThread.CurrentCulture = culture;
                lbltongtien.Text = tongtien.ToString("c", culture);
            }
            else
                lbltongtien.Text = "0";
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lbltenban.Text = tenban;
            lblmakh.Text = makh;
            lbmahd.Text = mahd.ToString();
            lbmanv.Text = manv;
            HienThiHoaDon(maban);
            LayPhanTramGiamGia(makh);
            decimal giamgia = decimal.Parse(txtgiamgia.Text) / 100;
            tongtienvoigiamgia=tongtien-tongtien*giamgia;
            CultureInfo culture = new CultureInfo("vi-VN");
            lbltongtien.Text = tongtienvoigiamgia.ToString("c",culture);
            if (makh != "null")
            {
                diemtl = int.Parse(Math.Round(tongtienvoigiamgia / 10000).ToString());
                lbldiemtl.Text = diemtl.ToString();
            }
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            if(makh=="null")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (HoaDon_BUS.SuaHoaDon(mahd,tongtienvoigiamgia) == false)
                    {
                        MessageBox.Show("Thanh toán không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Đã Thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Ban_DTO ban = new Ban_DTO();
                    ban.Maban = maban;
                    ban.Tenban = tenban;
                    ban.Trangthai = "Trống";
                    Ban_BUS.SuaBan(ban);
                    this.Close();
                }
            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (HoaDon_BUS.SuaHoaDonVoiMaKH(mahd,int.Parse(makh),tongtienvoigiamgia) == false)
                    {
                        MessageBox.Show("Thanh toán không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Đã Thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    KhachHang_DTO kh = KhachHang_BUS.LayKhachHangTheoMa(int.Parse(makh));
                    kh.Diemtl += diemtl;
                    KhachHang_BUS.SuaKhachHang(kh);
                    Ban_DTO ban = new Ban_DTO();
                    ban.Maban = maban;
                    ban.Tenban = tenban;
                    ban.Trangthai = "Trống";
                    Ban_BUS.SuaBan(ban);
                    this.Close();
                }
            }
        }

        private void btninhd_Click(object sender, EventArgs e)
        {
            frmInHD f = new frmInHD(maban, string.Format("{0}", tenban.ToString()), string.Format("{0}", mahd.ToString()), string.Format("{0}", manv.ToString()), string.Format("{0}", makh.ToString()), string.Format("{0}", txtgiamgia.Text), string.Format("{0}", tongtienvoigiamgia.ToString()));
            f.ShowDialog();
  
        }
    }
}
