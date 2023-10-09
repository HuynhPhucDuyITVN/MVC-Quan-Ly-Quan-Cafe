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
using System.Text.RegularExpressions;

namespace PhanMemQuanLyQuanCafe.Forms
{
    public partial class frmKhachHang : Form
    {
        string makh="";
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void tat()
        {
            btnthemlkh.Enabled = false;
            btnxoalkh.Enabled = false;
            sualkh.Enabled = false;
            txttenlkh.Enabled = false;
            txtgiamgia.Enabled = false;
        }
        public void tatkh()
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtsdtkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtdiemtl.Enabled = false;
        }
        
        public void xoa()
        {
            txtmalkh.Text = "";
            txttenlkh.Text = "";
            txtgiamgia.Text = "";
            tat();
        }
        public void xoakh()
        {
            txttenkh.Text = "";
            txtsdtkh.Text = "";
            txtdiachi.Text = "";
            txtdiemtl.Text = "";
            cboloaikh.SelectedIndex = 0;
            tatkh();
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
        public void HienThiLichSuGiaoDichKhachHang(int makh)
        {
            List<LSGiaoDich_DTO> lsvlsgd = LSGiaoDich_BUS.LayLSGDKhachHang(makh);
            dglsgiaodich.DataSource = lsvlsgd;
            dglsgiaodich.Columns["Mahd"].HeaderText = "Mã hóa đơn";
            dglsgiaodich.Columns["Tenkh"].HeaderText = "Khách hàng";
            dglsgiaodich.Columns["Manv"].HeaderText = "Mã nhân viên";
            dglsgiaodich.Columns["Tenban"].HeaderText = "Bàn";
            dglsgiaodich.Columns["Ngayhd"].HeaderText = "Ngày hóa đơn";
            dglsgiaodich.Columns["Ngaytt"].HeaderText = "Ngày thanh toán";
            dglsgiaodich.Columns["Tenhh"].HeaderText = "Món";
            dglsgiaodich.Columns["Soluong"].HeaderText = "Số lượng";
            dglsgiaodich.Columns["Tongthanhtien"].HeaderText = "Tổng tiền hóa đơn";
            dglsgiaodich.Columns["Mahd"].Width = 100;
            dglsgiaodich.Columns["Tenkh"].Width = 150;
            dglsgiaodich.Columns["Manv"].Width = 100;
            dglsgiaodich.Columns["Tenban"].Width = 50;
            dglsgiaodich.Columns["Ngayhd"].Width = 200;
            dglsgiaodich.Columns["Ngaytt"].Width = 200;
            dglsgiaodich.Columns["Tenhh"].Width = 100;
            dglsgiaodich.Columns["Soluong"].Width = 100;
            dglsgiaodich.Columns["Tennv"].Visible = false;

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
        public void HienThiDanhSachLoaiKhachHang()
        {
            List<LoaiKH_DTO> lslkh = LoaiKH_BUS.LayDSLoaiKH();
            dgdslkh.DataSource = lslkh;
            dgdslkh.Columns["Malkh"].HeaderText = "Mã loại khách hàng";
            dgdslkh.Columns["Tenlkh"].HeaderText = "Tên loại khách hàng";
            dgdslkh.Columns["Giamgia"].HeaderText = "Phần trăm giảm giá";
            dgdslkh.Columns["Malkh"].Width = 150;
            dgdslkh.Columns["Tenlkh"].Width = 150;
            dgdslkh.Columns["Giamgia"].Width = 150;
        }
        public void HienThiDanhSachKhachHangCombobox()
        {
            List<LoaiKH_DTO> lslkh = LoaiKH_BUS.LayDSLoaiKH();
            cboloaikh.DataSource = lslkh;
            cboloaikh.DisplayMember = "Tenlkh";
            cboloaikh.ValueMember = "Malkh";
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
            HienThiDanhSachKhachHangCombobox();
            HienThiDanhSachLoaiKhachHang();
            tat();
            tatkh();
            
        }

        private void btnthemlkh_Click(object sender, EventArgs e)
        {
            LoaiKH_DTO lkh = new LoaiKH_DTO();
            lkh.Malkh = txtmalkh.Text.Trim().ToUpper();
            lkh.Tenlkh = txttenlkh.Text.Trim();
            lkh.Giamgia = int.Parse(txtgiamgia.Text);
            if (lkh.Malkh == "" || LoaiKH_BUS.TimLoaiKhachHangTheoMa(lkh.Malkh) != null)
            {
                MessageBox.Show("Mã loại khách hàng đã tồn tại vui lòng chỉnh lại mã loại khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (LoaiKH_BUS.ThemLoaiKhachHang(lkh) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDanhSachKhachHangCombobox();
                HienThiDanhSachLoaiKhachHang();
                MessageBox.Show("Đã thêm loại khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoa();
            }
        }

        private void btnxoalkh_Click(object sender, EventArgs e)
        {
            LoaiKH_DTO lkh = new LoaiKH_DTO();
            lkh.Malkh = txtmalkh.Text.Trim().ToUpper();
            if (LoaiKH_BUS.TimLoaiKhachHangTheoMa(lkh.Malkh) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (LoaiKH_BUS.XoaLoaiKhachHang(lkh) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    HienThiDanhSachKhachHangCombobox();
                    HienThiDanhSachLoaiKhachHang();
                    MessageBox.Show("Đã xóa loại khách hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoa();
                }
            }
            else
                MessageBox.Show("Chưa có mã loại khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void dgdslkh_Click(object sender, EventArgs e)
        {
            sualkh.Enabled = true;
            btnxoalkh.Enabled = true;
            txtmalkh.Enabled = false;
            DataGridViewRow r = new DataGridViewRow();
            r = dgdslkh.SelectedRows[0];
            txtmalkh.Text = r.Cells["Malkh"].Value.ToString();
            txttenlkh.Text = r.Cells["Tenlkh"].Value.ToString();
            txtgiamgia.Text = r.Cells["Giamgia"].Value.ToString();
        }

        private void sualkh_Click(object sender, EventArgs e)
        {
            LoaiKH_DTO lkh = new LoaiKH_DTO();
            lkh.Malkh = txtmalkh.Text.Trim().ToUpper();
            lkh.Tenlkh = txttenlkh.Text.Trim();
            lkh.Giamgia = int.Parse(txtgiamgia.Text);
            if (LoaiKH_BUS.TimLoaiKhachHangTheoMa(lkh.Malkh) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (LoaiKH_BUS.SuaLoaiKhachHang(lkh) == false)
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    HienThiDanhSachKhachHangCombobox();
                    HienThiDanhSachLoaiKhachHang();
                    MessageBox.Show("Đã sửa loại khách hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoa();
                }
            }
            else
                MessageBox.Show("Chưa có mã loại khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void lammoilkh_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void txtmalkh_TextChanged(object sender, EventArgs e)
        {
            if (txtmalkh.Text == "")
                txttenlkh.Enabled = false;
            else
                txttenlkh.Enabled = true;
        }

        private void txttenlkh_TextChanged(object sender, EventArgs e)
        {
            if (txttenlkh.Text == "")
                txtgiamgia.Enabled = false;
            else
                txtgiamgia.Enabled = true;
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txtgiamgia.Text == "")
            {
                sualkh.Enabled = false;
                btnthemlkh.Enabled = false;
                this.error1.Clear();
            }
            else
            {
                try
                {
                    int.Parse(txtgiamgia.Text);
                    this.error1.Clear();
                    btnthemlkh.Enabled = true;
                    if (int.Parse(txtgiamgia.Text) >100 || int.Parse(txtgiamgia.Text) <0)
                    {
                        this.error1.SetError(c, "Phần trăm giảm giá phải lớn hơn 0 và nhỏ hơn 100!!!");
                        btnthemlkh.Enabled = false;
                        sualkh.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        btnthemlkh.Enabled = true;
                        sualkh.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.SetError(c, "Đây không phải số !!!!");
                    btnthemlkh.Enabled = false;
                    sualkh.Enabled = false;
                }
            }
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Malkh = cboloaikh.SelectedValue.ToString();
            kh.Tenkh = txttenkh.Text.Trim();
            kh.Diachikh = txtdiachi.Text.Trim();
            kh.Sdt = txtsdtkh.Text.Trim();
            kh.Diemtl = int.Parse(txtdiemtl.Text);
            if(KhachHang_BUS.ThemKhachHang(kh)==false)
            {
                MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            HienThiDanhSachKhachHang();
            MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            xoakh();
        }

        private void dgdskh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgdskh.SelectedRows[0];
            makh = r.Cells["Makh"].Value.ToString();
            txttenkh.Text = r.Cells["Tenkh"].Value.ToString();
            cboloaikh.SelectedValue = r.Cells["Malkh"].Value;
            txtdiachi.Text = r.Cells["Diachikh"].Value.ToString();
            txtsdtkh.Text = r.Cells["Sdt"].Value.ToString();
            txtdiemtl.Text = r.Cells["Diemtl"].Value.ToString();
            HienThiLichSuGiaoDichKhachHang(int.Parse(makh));

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Makh = makh;
            if (makh != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (KhachHang_BUS.XoaKhachHang(kh) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachKhachHang();
                    MessageBox.Show("Đã xóa khách hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoakh();
                }
            }
            else
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Makh = makh;
            if (makh != "")
            {
                kh.Malkh = cboloaikh.SelectedValue.ToString();
                kh.Tenkh = txttenkh.Text.Trim();
                kh.Diachikh = txtdiachi.Text.Trim();
                kh.Sdt = txtsdtkh.Text.Trim();
                kh.Diemtl = int.Parse(txtdiemtl.Text);
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (KhachHang_BUS.SuaKhachHang(kh) == false)
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachKhachHang();
                    MessageBox.Show("Đã sửa khách hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoakh();
                }
            }
            else
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {
            if (txttenkh.Text == "")
                txtsdtkh.Enabled = false;
            else
                txtsdtkh.Enabled = true;
        }

        private void txtsdtkh_TextChanged(object sender, EventArgs e)
        {
            string sdt = @"^\(?(0[0-9]{2})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";//dạng dữ liệu sđt khi nhập vào
            Control c = (Control)sender;
            if (txtsdtkh.Text == "")
                txtdiachi.Enabled = false;
            else
            {
                try
                {
                    if (char.IsLetter(c.Text[c.Text.Length - 1]))
                    {
                        this.error1.SetError(c, "Đang có chữ trong sđt !!!");
                        txtdiachi.Enabled = false;
                    }
                    else if (Regex.IsMatch(txtsdtkh.Text, sdt) == false)
                    {
                        this.error1.SetError(c, "Đây không phải số điện thoại !!!");
                        txtdiachi.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        txtdiachi.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.Clear();
                    txtdiachi.Enabled = true;
                }
            }
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "")
                txtdiemtl.Enabled = false;
            else
                txtdiemtl.Enabled = true;
        }

        private void txtdiemtl_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txtdiemtl.Text == "")
            {
                btnsua.Enabled = false;
                btnthem.Enabled = false;
                this.error1.Clear();
            }
            else
            {
                try
                {
                    int.Parse(txtdiemtl.Text);
                    this.error1.Clear();
                    btnthem.Enabled = true;
                    if (int.Parse(txtdiemtl.Text) < 0)
                    {
                        this.error1.SetError(c, "Điểm tích lũy không được bé hơn 0!!!");
                        btnthem.Enabled = false;
                        btnsua.Enabled = false;
                        btnthem.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.SetError(c, "Đây không phải số !!!!");
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                }
            }
        }

        private void btnlammoi2_Click(object sender, EventArgs e)
        {
            xoakh();
        }

        private void dgdskh_SizeChanged(object sender, EventArgs e)
        {
        }

        private void frmKhachHang_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1180 && this.Size.Height > 670)
            {
                dgdslkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dglsgiaodich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgdslkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dglsgiaodich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
    }
}
