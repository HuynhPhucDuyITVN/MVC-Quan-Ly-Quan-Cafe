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
using PhanMemQuanLyQuanCafe.Properties;
using System.Globalization;
using System.Threading;

namespace PhanMemQuanLyQuanCafe.Forms
{
    public partial class frmBanHang : Form
    {
        private string manv;
        private decimal tongthanhtien=0;

        public frmBanHang()
        {
            InitializeComponent();
        }
        public frmBanHang(string Manv)
        {
            this.manv = Manv;
            InitializeComponent();
        }
        public void tat()
        {
            btnchuyenban.Enabled = false;
            btnthanhtoan.Enabled = false;
            btnthemmon.Enabled = false;
        }
        public void xoa()
        {
            lbltongtien.Text = "0";
            lbmakh.Text = "null";
            lbtenkh.Text = "";
            lbltenban.Text = "Tên Bàn";
            tat();
        }

        public void HienThiDanhSachKhachHang()
        {
            List<KhachHang_DTO> lskh = KhachHang_BUS.LayDSKhachHang();
            dgdskh.DataSource = lskh;
            dgdskh.Columns["Makh"].HeaderText = "Mã khách hàng";
            dgdskh.Columns["Malkh"].HeaderText = "Mã loại khách hàng";
            dgdskh.Columns["Tenkh"].HeaderText = "Tên khách hàng";
            dgdskh.Columns["Diachikh"].HeaderText = "Địa chỉ khách hàng";
            dgdskh.Columns["Sdt"].HeaderText = "Số điện thoại khách hàng";
            dgdskh.Columns["Diemtl"].HeaderText = "Điểm tích lũy";
            dgdskh.Columns["Tenlkh"].HeaderText = "Loại khách hàng";
            dgdskh.Columns["Makh"].Width = 150;
            dgdskh.Columns["Malkh"].Width = 150;
            dgdskh.Columns["Tenkh"].Width = 150;
            dgdskh.Columns["Diachikh"].Width = 350;
            dgdskh.Columns["Sdt"].Width = 190;
            dgdskh.Columns["Diemtl"].Width = 150;
            dgdskh.Columns["Tenlkh"].Width = 150;
            dgdskh.Columns["Malkh"].Visible = false;
            dgdskh.Columns["Makh"].Visible = false;
        }
        public void HienThiDanhSachKhachHangTheoTen(string ten)
        {
            List<KhachHang_DTO> lskh = KhachHang_BUS.LayKhachHangTheoTen(ten);
            dgdskh.DataSource = lskh;
            dgdskh.Columns["Makh"].HeaderText = "Mã khách hàng";
            dgdskh.Columns["Malkh"].HeaderText = "Mã loại khách hàng";
            dgdskh.Columns["Tenkh"].HeaderText = "Tên khách hàng";
            dgdskh.Columns["Diachikh"].HeaderText = "Địa chỉ khách hàng";
            dgdskh.Columns["Sdt"].HeaderText = "Số điện thoại khách hàng";
            dgdskh.Columns["Diemtl"].HeaderText = "Điểm tích lũy";
            dgdskh.Columns["Tenlkh"].HeaderText = "Loại khách hàng";
            dgdskh.Columns["Makh"].Width = 150;
            dgdskh.Columns["Malkh"].Width = 150;
            dgdskh.Columns["Tenkh"].Width = 150;
            dgdskh.Columns["Diachikh"].Width = 350;
            dgdskh.Columns["Sdt"].Width = 190;
            dgdskh.Columns["Diemtl"].Width = 150;
            dgdskh.Columns["Tenlkh"].Width = 150;
            dgdskh.Columns["Malkh"].Visible = false;
        }
        public void LoadBan()
        {
            HienThiBanLenCombobox();
            flowBan.Controls.Clear();
            List<Ban_DTO> lsvban = Ban_BUS.LayDSBan();
            foreach(Ban_DTO ban in lsvban)
            {
                Button btn = new Button() { Width = 70, Height = 70 };
                btn.Text = ban.Tenban +"\n" +ban.Trangthai;
                btn.Image= ((System.Drawing.Image)(Resources.iconban));
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Click += Btn_Click;
                btn.Tag = ban;
                switch (ban.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(255, 224, 230);
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(199, 220, 91);
                        break;

                }
                flowBan.Controls.Add(btn);
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
                tongthanhtien = tongtien;
                CultureInfo culture = new CultureInfo("vi-VN");
                //Thread.CurrentThread.CurrentCulture = culture;
                lbltongtien.Text = tongtien.ToString("c", culture);
            }
            else
            {
                lbltongtien.Text = "0";
                tongthanhtien = 0;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            lbmakh.Text = "null";
            lbtenkh.Text = "";
            btnthanhtoan.Enabled = true;
            btnthemmon.Enabled = true;
            btnchuyenban.Enabled = true;
            lbltenban.Text = ((sender as Button).Tag as Ban_DTO).Tenban;
            numsl.Value = 1;
            int maban =((sender as Button).Tag as Ban_DTO).Maban;
            lsvchitiet.Tag = (sender as Button).Tag;
            HienThiHoaDon(maban);
        }

        private void HienThiLoaiHangLenCombobox()
        {
            List<LoaiHang_DTO> lsloaihang = LoaiHang_BUS.LayDSLoaiHang();
            cbloaihang.DataSource = lsloaihang;
            cbloaihang.DisplayMember = "Tenlh";
            cbloaihang.ValueMember = "Malh";
        }
        private void HienThiBanLenCombobox()
        {
            List<Ban_DTO> lsban = Ban_BUS.LayBanTrong();
            cbchuyenban.DataSource = lsban;
            cbchuyenban.DisplayMember = "Tenban";
            cbchuyenban.ValueMember = "Maban";
        }
        private void HienThiHangHoaLenCombobox(string malh)
        {
            List<HangHoa_DTO> lshanghoa = HangHoa_BUS.LayHangHoaTheoMaLH(malh);
            cbhanghoa.DataSource = lshanghoa;
            cbhanghoa.DisplayMember = "Tenhh";
            cbhanghoa.ValueMember = "Mahh";
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            xoa();
            dtpngayhd.MaxDate = DateTime.Now;
            dtpngayhd.Value = dtpngayhd.MaxDate;
            HienThiDanhSachKhachHang();
            HienThiLoaiHangLenCombobox();
            HienThiBanLenCombobox();
            LoadBan();
            cbloaihang.SelectedIndex = 0;
            HienThiHangHoaLenCombobox(cbloaihang.SelectedValue.ToString());
            lblmanv.Text = manv;
        }

        private void cbloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiHangHoaLenCombobox(cbloaihang.SelectedValue.ToString());
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txttimkiem.Text == "")
                HienThiDanhSachKhachHang();
            else
            {
                if (KhachHang_BUS.LayKhachHangTheoTen(txttimkiem.Text) == null)
                    error1.SetError(c, "Không có khách hàng trong danh sách");
                else
                {
                    HienThiDanhSachKhachHangTheoTen(txttimkiem.Text);
                    error1.Clear();
                }
            }
        }

        private void dgdskh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgdskh.SelectedRows[0];
            lbmakh.Text = r.Cells["Makh"].Value.ToString();
            lbtenkh.Text = r.Cells["Tenkh"].Value.ToString();
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            frmThemKH themkh = new frmThemKH();
            themkh.ShowDialog();
            HienThiDanhSachKhachHang();
        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = lsvchitiet.Tag as Ban_DTO;
            if(ban!=null)
            {
                int mahd = HoaDon_BUS.LayMaHoaDonChuaThanhToanTheoBan(ban.Maban);
                if (mahd == -1)
                {
                    HoaDon_DTO hd = new HoaDon_DTO();
                    hd.Maban = ban.Maban;
                    hd.Manv = manv;
                    HoaDon_BUS.ThemHoaDon(hd);
                    ChiTietHD_DTO ct = new ChiTietHD_DTO();
                    ct.Mahd = HoaDon_BUS.LayMaHDMoiNhat();
                    ct.Mahh = cbhanghoa.SelectedValue.ToString();
                    ct.Sl = int.Parse(numsl.Value.ToString());
                    if (ct.Sl < 0)
                        ct.Sl = 1;
                    ChiTietHD_BUS.ThemCTHoaDon(ct);
                    ban.Trangthai = "Có Người";
                    Ban_BUS.SuaBan(ban);
                    HienThiHoaDon(ban.Maban);
                    numsl.Value = 1;
                    LoadBan();
                }
                else
                {
                    ChiTietHD_DTO ct = new ChiTietHD_DTO();
                    ct.Mahd = mahd;
                    ct.Mahh = cbhanghoa.SelectedValue.ToString();
                    ct.Sl = int.Parse(numsl.Value.ToString());
                    int slmoi = ct.Sl;
                    if (ChiTietHD_BUS.TimChiTietHDTheoMahdvaMahh(ct.Mahd, ct.Mahh) != null)
                    {
                        int slcu = ChiTietHD_BUS.TimChiTietHDTheoMahdvaMahh(ct.Mahd, ct.Mahh).Sl;
                        int tongsl = slcu + slmoi;
                        if (tongsl < 0)
                        {
                            ct.Sl = ChiTietHD_BUS.TimChiTietHDTheoMahdvaMahh(ct.Mahd, ct.Mahh).Sl;
                            ChiTietHD_BUS.SuaCTHoaDon(ct);
                            numsl.Value = 1;
                        }
                        else if (tongsl == 0)
                        {
                            ChiTietHD_BUS.XoaCTHoaDon(ct);
                            if (ChiTietHD_BUS.TimChiTietHDTheoMahdvaMahh(ct.Mahd) == null)
                            {
                                HoaDon_BUS.XoaHoaDon(mahd);
                                ban.Trangthai = "Trống";
                                Ban_BUS.SuaBan(ban);
                                LoadBan();
                            }
                        }
                        else
                        {
                            ct.Sl = tongsl;
                            ChiTietHD_BUS.SuaCTHoaDon(ct);
                            numsl.Value = 1;
                        }
                    }
                    else
                    {
                        ct.Sl = 1;
                        ChiTietHD_BUS.ThemCTHoaDon(ct);
                        numsl.Value = 1;
                    }
                    HienThiHoaDon(ban.Maban);
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = lsvchitiet.Tag as Ban_DTO;
            if(ban!=null)
            {
                if (ban.Trangthai == "Trống")
                    MessageBox.Show("Bàn trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                else
                {
                    int mahd = HoaDon_BUS.LayMaHoaDonChuaThanhToanTheoBan(ban.Maban);
                    frmThanhToan tt = new frmThanhToan(ban.Maban, ban.Tenban, mahd, lblmanv.Text, lbmakh.Text, tongthanhtien);
                    tt.ShowDialog();
                    LoadBan();
                    HienThiDanhSachKhachHang();
                    frmBanHang_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnchuyenban_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = lsvchitiet.Tag as Ban_DTO;
            int mahd = HoaDon_BUS.LayMaHoaDonChuaThanhToanTheoBan(ban.Maban);
            if (mahd == -1)
            {
                MessageBox.Show("Bàn bạn đang chọn trống!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (ban != null)
            {
                int maban1 = (lsvchitiet.Tag as Ban_DTO).Maban;
                int mahd1 = HoaDon_BUS.LayMaHoaDonChuaThanhToanTheoBan(maban1);
                int maban2 = (cbchuyenban.SelectedItem as Ban_DTO).Maban;
                int mahd2 = HoaDon_BUS.LayMaHoaDonChuaThanhToanTheoBan(maban2);
                if (maban2 == maban1)
                {
                    MessageBox.Show("Bàn bạn đang chọn đang là bàn hiện tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show(string.Format(@"Bạn có chắc muốn chuyển bàn {0} tới bàn {1}?", (lsvchitiet.Tag as Ban_DTO).Tenban, (cbchuyenban.SelectedItem as Ban_DTO).Tenban), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (traloi == DialogResult.OK)
                    {
                        if (Ban_BUS.DoiBan(maban1, maban2, manv) == false)
                        {
                            MessageBox.Show("Chuyển không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                        HoaDon_BUS.XoaHoaDon(mahd1);
                        if (ChiTietHD_BUS.TimChiTietHDTheoMahdvaMahh(mahd) == null)
                        {
                            HoaDon_BUS.XoaHoaDon(mahd);
                            ban.Trangthai = "Trống";
                            Ban_BUS.SuaBan(ban);
                        }
                        MessageBox.Show("Chuyển thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Ban_DTO ban2 = new Ban_DTO();
                        ban2.Maban = (cbchuyenban.SelectedItem as Ban_DTO).Maban;
                        ban2.Tenban = (cbchuyenban.SelectedItem as Ban_DTO).Tenban;
                        ban2.Trangthai = "Có người";
                        Ban_BUS.SuaBan(ban2);
                        LoadBan();
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
