using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PhanMemQuanLyQuanCafe.Forms
{
    public partial class frmBaoCaoThongKe : Form
    {
        private decimal tongtien = 0;
        private decimal tongdoanhthu = 0;
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        public void LoadNgay()
        {
            DateTime today = DateTime.Now;
            datefrom.Value = new DateTime(today.Year, today.Month, 1);
            dateTo.Value = datefrom.Value.AddMonths(1).AddDays(-1);

        }
        public void LoadNgay1()
        {
            DateTime today = DateTime.Now;
            datebatdau.Value = new DateTime(today.Year, today.Month, 1);
            dateketthuc.Value = datebatdau.Value.AddMonths(1).AddDays(-1);

        }
        public void HienDSNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lsvnv = NhanVien_BUS.LayDSNhanVien();
            cbnhanvien.DataSource = lsvnv;
            cbnhanvien.DisplayMember = "Tennv";
            cbnhanvien.ValueMember = "Manv";
        }
        public void LSGD(string ngaybd, string ngaykt)
        {
            tongdoanhthu = 0;
            List<LSGiaoDich_DTO> lsvlsgd = LSGiaoDich_BUS.LayLSGDHoaDonTheoNgay2(ngaybd,ngaykt);
            if(lsvlsgd!=null)
            {
                dglsgiaodich.DataSource = lsvlsgd;
                dglsgiaodich.Columns["Mahd"].HeaderText = "Mã hóa đơn";
                dglsgiaodich.Columns["Tennv"].HeaderText = "Nhân viên";
                dglsgiaodich.Columns["Tenkh"].HeaderText = "Khách hàng";
                dglsgiaodich.Columns["Manv"].HeaderText = "Mã nhân viên";
                dglsgiaodich.Columns["Tenban"].HeaderText = "Bàn";
                dglsgiaodich.Columns["Ngayhd"].HeaderText = "Ngày hóa đơn";
                dglsgiaodich.Columns["Ngaytt"].HeaderText = "Ngày thanh toán";
                dglsgiaodich.Columns["Tenhh"].HeaderText = "Món";
                dglsgiaodich.Columns["Soluong"].HeaderText = "Số lượng";
                dglsgiaodich.Columns["Tongthanhtien"].HeaderText = "Thành tiền";
                dglsgiaodich.Columns["Mahd"].Width = 100;
                dglsgiaodich.Columns["Tennv"].Width = 150;
                dglsgiaodich.Columns["Tenkh"].Width = 150;
                dglsgiaodich.Columns["Manv"].Width = 100;
                dglsgiaodich.Columns["Tenban"].Width = 50;
                dglsgiaodich.Columns["Ngayhd"].Width = 200;
                dglsgiaodich.Columns["Ngaytt"].Width = 200;
                dglsgiaodich.Columns["Tenhh"].Width = 100;
                dglsgiaodich.Columns["Soluong"].Width = 100;
                dglsgiaodich.Columns["Tongthanhtien"].Width = 100;
                dglsgiaodich.Columns["Tenkh"].Visible = false;
                dglsgiaodich.Columns["Tenhh"].Visible = false;
                dglsgiaodich.Columns["Soluong"].Visible = false;

                foreach (LSGiaoDich_DTO lsgd in lsvlsgd)
                {
                    tongdoanhthu += decimal.Parse(lsgd.Tongthanhtien.ToString());
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                lbltongdoanhthu.Text = tongdoanhthu.ToString("c", culture);
            }
            else
                MessageBox.Show(string.Format("Không có hóa đơn trong khoản từ ngày {0} tới ngày {1}",ngaybd,ngaykt), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
        public void HienThiChiTietLuong(string ngaybd,string ngaykt,string manv)
        {
            tongtien = 0;
            List<ChiTietLuong_DTO> lsvct = ChiTietLuong_BUS.LayDSCTLuongTheoNgayVaMaNhanVien(ngaybd,ngaykt,manv);
            NhanVien_DTO nv = NhanVien_BUS.TimNhanVienTheoMa(manv);
            if(lsvct!=null)
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
                foreach (ChiTietLuong_DTO ls in lsvct)
                {
                    tongtien += decimal.Parse(ls.Thanhtien.ToString());
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                lbltongtien.Text = tongtien.ToString("c", culture);
            }
            else
                MessageBox.Show(string.Format("Không có ca làm của nhân viên {0} trong khoản từ ngày {1} tới ngày {2}",nv.Tennv, ngaybd, ngaykt), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


        }
        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            HienDSNhanVienLenCombobox();
            cbnhanvien.SelectedIndex = 0;
            LoadNgay();
            string ngaybd = datefrom.Value.ToString("yyyy/MM/dd");
            string ngaykt = dateTo.Value.ToString("yyyy/MM/dd");
            LoadNgay1();
            string ngaybd1 = datebatdau.Value.ToString("yyyy/MM/dd");
            string ngaykt1 = dateketthuc.Value.ToString("yyyy/MM/dd");
            string manv = cbnhanvien.SelectedValue.ToString();
            HienThiChiTietLuong(ngaybd1, ngaykt1, manv);
            LSGD(ngaybd, ngaykt);
            this.reportViewer2.RefreshReport();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            string ngaybd = datefrom.Value.ToString("yyyy/MM/dd");
            string ngaykt = dateTo.Value.ToString("yyyy/MM/dd");
            LSGD(ngaybd, ngaykt);
        }

        

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadNgay();
            string ngaybd = datefrom.Value.ToString("yyyy/MM/dd");
            string ngaykt = dateTo.Value.ToString("yyyy/MM/dd");
            LoadNgay1();
            string ngaybd1 = datebatdau.Value.ToString("yyyy/MM/dd");
            string ngaykt1 = dateketthuc.Value.ToString("yyyy/MM/dd");
            lSGiaoDichDTOBindingSource.DataSource = LSGiaoDich_BUS.LayLSGDHoaDonTheoNgay2(ngaybd, ngaykt);
            this.reportViewer1.RefreshReport();
            ChiTietLuong_DTOBindingSource.DataSource = ChiTietLuong_BUS.LayDSCTLuongTheoNgay(ngaybd1,ngaykt1);
            this.reportViewer2.RefreshReport();

        }

        private void frmBaoCaoThongKe_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1180 || this.Size.Height > 670)
            {
                dglsgiaodich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnthongkeluong_Click(object sender, EventArgs e)
        {
            string ngaybd1 = datebatdau.Value.ToString("yyyy/MM/dd");
            string ngaykt1 = dateketthuc.Value.ToString("yyyy/MM/dd");
            string manv = cbnhanvien.SelectedValue.ToString();
            HienThiChiTietLuong(ngaybd1, ngaykt1, manv);
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuuDuLieu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK && phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.KhoiPhucDuLieu(sDuongDan))
                    MessageBox.Show("Khôi phục dữ liệu thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
