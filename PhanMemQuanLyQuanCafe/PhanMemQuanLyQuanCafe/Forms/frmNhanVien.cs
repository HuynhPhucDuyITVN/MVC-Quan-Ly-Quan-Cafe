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
    public partial class frmNhanVien : Form
    {
        private string maban;
        private string manv;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public frmNhanVien(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public void tat()
        {
            btnthemban.Enabled = false;
            btnsuaban.Enabled = false;
            btnxoaban.Enabled = false;
        }
        public void tatcv()
        {
            txtmacv.Focus();
            txttencv.Enabled = false;
            btnthemcv.Enabled = false;
            btnxoacv.Enabled = false;
            btnsuacv.Enabled = false;
        }
        private void tatnv()
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txttennv.Enabled = false;
            grgt.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodienthoai.Enabled = false;
        }
        private void xoanv()
        {
            txtmanv.Enabled = true;
            txtmanv.Text = "";
            txttennv.Text = "";
            radnam.Checked = false;
            radnu.Checked = false;
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
            tatnv();
        }
        public void xoa()
        {
            txttenban.Text = "";
            cbtrangthai.SelectedIndex = 0;
            tat();
        }
        public void xoacv()
        {
            txtmacv.Enabled = true;
            txttencv.Text = "";
            txtmacv.Text = "";
            tat();
        }
        private void HienThiDSBan()
        {
            List<Ban_DTO> lsvban = Ban_BUS.LayDSBan();
            dgban.DataSource = lsvban;
            dgban.Columns["Maban"].HeaderText = "Mã bàn";
            dgban.Columns["Tenban"].HeaderText = "Ten bàn";
            dgban.Columns["Trangthai"].HeaderText = "Trạng thái bàn";
            dgban.Columns["Maban"].Width = 50;
            dgban.Columns["Tenban"].Width = 100;
            dgban.Columns["Trangthai"].Width = 100;
            dgban.Columns["Maban"].Visible = false;
        }
        private void HienThiDanhSachNhanVien()
        {
            List<NhanVien_DTO> lsvnv = NhanVien_BUS.LayDSNhanVien();
            dgnhanvien.DataSource = lsvnv;
            dgnhanvien.Columns["Manv"].HeaderText = "Mã nhân viên";
            dgnhanvien.Columns["Tennv"].HeaderText = "Tên nhân viên";
            dgnhanvien.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgnhanvien.Columns["Chucvu"].HeaderText = " Mã Chức vụ";
            dgnhanvien.Columns["Tencv"].HeaderText = "Chức vụ";
            dgnhanvien.Columns["Ngayvaolam"].HeaderText = "Ngày vào làm";
            dgnhanvien.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgnhanvien.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgnhanvien.Columns["Phanquyen"].HeaderText = "Quyền";
            dgnhanvien.Columns["Matkhau"].HeaderText = "Mật khẩu";
            dgnhanvien.Columns["Manv"].Width = 50;
            dgnhanvien.Columns["Tennv"].Width = 150;
            dgnhanvien.Columns["Gioitinh"].Width = 70;
            dgnhanvien.Columns["Chucvu"].Width = 100;
            dgnhanvien.Columns["Chucvu"].Visible = false;
            dgnhanvien.Columns["Tencv"].Width = 100;
            dgnhanvien.Columns["Ngayvaolam"].Width = 100;
            dgnhanvien.Columns["Diachi"].Width = 250;
            dgnhanvien.Columns["Sdt"].Width = 100;
            dgnhanvien.Columns["Phanquyen"].Width = 50;
            dgnhanvien.Columns["Matkhau"].Visible=false;
        }
        private void HienThiDanhSachNhanVien(string ten)
        {
            List<NhanVien_DTO> lsvnv = NhanVien_BUS.LayDSNhanVienTheoTen(ten);
            dgnhanvien.DataSource = lsvnv;
            dgnhanvien.Columns["Manv"].HeaderText = "Mã nhân viên";
            dgnhanvien.Columns["Tennv"].HeaderText = "Tên nhân viên";
            dgnhanvien.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgnhanvien.Columns["Chucvu"].HeaderText = " Mã Chức vụ";
            dgnhanvien.Columns["Tencv"].HeaderText = "Chức vụ";
            dgnhanvien.Columns["Ngayvaolam"].HeaderText = "Ngày vào làm";
            dgnhanvien.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgnhanvien.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgnhanvien.Columns["Phanquyen"].HeaderText = "Quyền";
            dgnhanvien.Columns["Matkhau"].HeaderText = "Mật khẩu";
            dgnhanvien.Columns["Manv"].Width = 50;
            dgnhanvien.Columns["Tennv"].Width = 150;
            dgnhanvien.Columns["Gioitinh"].Width = 70;
            dgnhanvien.Columns["Chucvu"].Width = 100;
            dgnhanvien.Columns["Chucvu"].Visible = false;
            dgnhanvien.Columns["Tencv"].Width = 100;
            dgnhanvien.Columns["Ngayvaolam"].Width = 100;
            dgnhanvien.Columns["Diachi"].Width = 250;
            dgnhanvien.Columns["Sdt"].Width = 100;
            dgnhanvien.Columns["Phanquyen"].Width = 50;
            dgnhanvien.Columns["Matkhau"].Visible = false;
        }
        private void HienThiDSChucVu()
        {
            List<ChucVu_DTO> lsvcv = ChucVu_BUS.LayDSCV();
            dgchucvu.DataSource = lsvcv;
            dgchucvu.Columns["Macv"].HeaderText = "Mã chức vụ";
            dgchucvu.Columns["Tencv"].HeaderText = "Chức vụ";
            dgchucvu.Columns["Macv"].Width = 50;
            dgchucvu.Columns["Tencv"].Width = 150;
        }
        private void HienChucVuLenCombobox()
        {
            List<ChucVu_DTO> lsvcv = ChucVu_BUS.LayDSCV();
            cbchucvu.DataSource = lsvcv;
            cbchucvu.DisplayMember = "Tencv";
            cbchucvu.ValueMember = "Macv";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            datevaolam.MaxDate = DateTime.Now;
            tat();
            tatcv();
            tatnv();
            cbtrangthai.SelectedIndex = 0;
            HienThiDSBan();
            HienThiDanhSachNhanVien();
            HienChucVuLenCombobox();
            HienThiDSChucVu();
        }

        private void btnthemban_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = new Ban_DTO();
            ban.Tenban = txttenban.Text.ToUpper();
            ban.Trangthai = cbtrangthai.SelectedItem.ToString().Trim();
            if(Ban_BUS.ThemBan(ban)==false)
            {
                MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã thêm bàn thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            HienThiDSBan();
            xoa();
        }

        private void dgban_Click(object sender, EventArgs e)

        {
            btnsuaban.Enabled = true;
            btnxoaban.Enabled = true;
            DataGridViewRow r = new DataGridViewRow();
            r = dgban.SelectedRows[0];
            maban = r.Cells[0].Value.ToString();
            txttenban.Text = r.Cells[1].Value.ToString();
            cbtrangthai.SelectedItem = r.Cells[2].Value.ToString();
        }

        private void btnxoaban_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = new Ban_DTO();
            ban.Maban = int.Parse(maban);
            ban.Tenban = txttenban.Text.ToUpper();
            ban.Trangthai = cbtrangthai.SelectedItem.ToString().Trim();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (Ban_BUS.XoaBan(ban) == false)
                {
                    MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDSBan();
                MessageBox.Show("Đã xóa bàn bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoa();
            }
        }

        private void btnsuaban_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = new Ban_DTO();
            ban.Maban = int.Parse(maban);
            ban.Tenban = txttenban.Text.ToUpper();
            ban.Trangthai = cbtrangthai.SelectedItem.ToString().Trim();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (Ban_BUS.SuaBan(ban) == false)
                {
                    MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDSBan();
                MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoa();
            }
        }

        private void txttenban_TextChanged(object sender, EventArgs e)
        {
            String maban = @"^\(?([a-zA-Z]{1})\)?[-. ]?([0-9]{2})$";//dạng dữ liệu mã số ban 1 ký tự đầu là chữ và 2 ký tự số;
            Control c = (Control)sender;
            if (txttenban.Text == "")
            {
                btnthemban.Enabled = false;
                btnxoaban.Enabled = false;
                btnsuaban.Enabled = false;
            }
            else
            {
                try
                {
                    if (Regex.IsMatch(txttenban.Text, maban) == false)
                    {
                        this.error1.SetError(c, "Đây không phải mã bàn, mã bàn gồn 1 chữ cái đầu và 2 số cuối!!!");
                        btnthemban.Enabled = false;
                        btnxoaban.Enabled = false;
                        btnsuaban.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        btnthemban.Enabled = true;
                        btnxoaban.Enabled = true;
                        btnsuaban.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.Clear();
                    btnthemban.Enabled = true;
                    btnxoaban.Enabled = true;
                    btnsuaban.Enabled = true;
                }
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txttimkiem.Text == "")
            {
                HienThiDanhSachNhanVien();
            }
            else
            {
                if (NhanVien_BUS.LayDSNhanVienTheoTen(txttimkiem.Text) == null)
                    error1.SetError(c, "Không có nhân viên trong danh sách");
                else
                {
                    HienThiDanhSachNhanVien(txttimkiem.Text);
                    error1.Clear();
                }
            }
        }

        private void btnthemcv_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Macv = txtmacv.Text.Trim().ToUpper();
            cv.Tencv = txttencv.Text.Trim();
            if (cv.Macv == "" || ChucVu_BUS.TimCVTheoMa(cv.Macv) != null)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại vui lòng chỉnh lại mã chức vụ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (ChucVu_BUS.ThemCV(cv) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDSChucVu();
                HienChucVuLenCombobox();
                MessageBox.Show("Đã thêm loại chức vụ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoacv();
            }
        }

        private void btnxoacv_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Macv = txtmacv.Text.Trim().ToUpper();
            if (ChucVu_BUS.TimCVTheoMa(cv.Macv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (ChucVu_BUS.XoaCV(cv) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDSChucVu();
                    HienChucVuLenCombobox();
                    MessageBox.Show("Đã xóa chức vụ bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoacv();
                }
            }
            else
                MessageBox.Show("Chưa có mã chức vụ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnsuacv_Click(object sender, EventArgs e)
        {
            ChucVu_DTO cv = new ChucVu_DTO();
            cv.Macv = txtmacv.Text.Trim().ToUpper();
            cv.Tencv = txttencv.Text.Trim();
            if (ChucVu_BUS.TimCVTheoMa(cv.Macv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (ChucVu_BUS.SuaCV(cv) == false)
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDSChucVu();
                    HienChucVuLenCombobox();
                    MessageBox.Show("Đã sửa chức vụ bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoacv();
                }
            }
            else
                MessageBox.Show("Chưa có mã chức vụ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void dgchucvu_Click(object sender, EventArgs e)
        {
            txtmacv.Enabled = false;
            btnxoacv.Enabled = true;
            btnsuacv.Enabled = true;
            DataGridViewRow r = new DataGridViewRow();
            r = dgchucvu.SelectedRows[0];
            txtmacv.Text = r.Cells["Macv"].Value.ToString();
            txttencv.Text = r.Cells["Tencv"].Value.ToString();
        }

        private void btnlammoicv_Click(object sender, EventArgs e)
        {
            xoacv();
        }

        private void txtmacv_TextChanged(object sender, EventArgs e)
        {
            if (txtmacv.Text == "")
                txttencv.Enabled = false;
            else
                txttencv.Enabled = true;
        }

        private void txttencv_TextChanged(object sender, EventArgs e)
        {
            if (txttencv.Text == "")
                btnthemcv.Enabled = false;
            else
                btnthemcv.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtmanv.Text.Trim().ToUpper();
            nv.Tennv = txttennv.Text.Trim();
            if (radnam.Checked == true)
                nv.Gioitinh = "Nam";
            else
                nv.Gioitinh = "Nữ";
            nv.Chucvu = cbchucvu.SelectedValue.ToString();
            nv.Ngayvaolam = datevaolam.Value.ToString("yyyy/MM/dd");
            nv.Diachi = txtdiachi.Text.Trim();
            nv.Sdt = txtsodienthoai.Text.Trim();
            if (chkadmin.Checked == true)
                nv.Phanquyen = 1;
            else if (chkql.Checked == true)
                nv.Phanquyen = 2;
            else
                nv.Phanquyen = 0;
            if (nv.Manv == "" || NhanVien_BUS.TimNhanVienTheoMa(nv.Manv) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại vui lòng chỉnh lại mã nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (NhanVien_BUS.ThemNV(nv) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDanhSachNhanVien();
                MessageBox.Show("Đã thêm nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoanv();
            }
        }

        private void dgnhanvien_Click(object sender, EventArgs e)
        {
            txtmanv.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            DataGridViewRow r = new DataGridViewRow();
            r = dgnhanvien.SelectedRows[0];
            txtmanv.Text = r.Cells["Manv"].Value.ToString();
            txttennv.Text = r.Cells["Tennv"].Value.ToString();
            if (r.Cells["Gioitinh"].Value.ToString() == "Nam")
                radnam.Checked = true;
            else
                radnu.Checked = true;
            cbchucvu.SelectedValue = r.Cells["Chucvu"].Value;
            datevaolam.Text = DateTime.Parse(r.Cells["Ngayvaolam"].Value.ToString()).ToString("dd,MM,yyyy");
            txtdiachi.Text = r.Cells["Diachi"].Value.ToString();
            txtsodienthoai.Text = r.Cells["Sdt"].Value.ToString();
            if (int.Parse(r.Cells["Phanquyen"].Value.ToString()) == 1)
            {
                chkadmin.Checked = true;
                chkql.Checked = false;
            }
            else if (int.Parse(r.Cells["Phanquyen"].Value.ToString()) == 2)
            {
                chkql.Checked = true;
                chkadmin.Checked = false;
            }
            else
            {
                chkadmin.Checked = false;
                chkql.Checked = false;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtmanv.Text.Trim().ToUpper();
            if (chkadmin.Checked == true)
                nv.Phanquyen = 1;
            else if (chkql.Checked == true)
                nv.Phanquyen = 2;
            else
                nv.Phanquyen = 0;
            if (NhanVien_BUS.TimNhanVienTheoMa(nv.Manv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if(nv.Manv==manv)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Tài khoản đang được sử dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else if (nv.Phanquyen == 1)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Nhân viên đang cùng cấp bậc ADMIN với bạn hãy chỉnh sửa lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    else if (NhanVien_BUS.XoaNV(nv) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachNhanVien();
                    MessageBox.Show("Đã xóa nhân viên bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoanv();
                }
            }
            else
                MessageBox.Show("Chưa có mã nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtmanv.Text.Trim().ToUpper();
            nv.Tennv = txttennv.Text.Trim();
            if (radnam.Checked == true)
                nv.Gioitinh = "Nam";
            else
                nv.Gioitinh = "Nữ";
            nv.Chucvu = cbchucvu.SelectedValue.ToString();
            nv.Ngayvaolam = datevaolam.Value.ToString("yyyy/MM/dd");
            nv.Diachi = txtdiachi.Text.Trim();
            nv.Sdt = txtsodienthoai.Text.Trim();
            if (chkadmin.Checked == true)
                nv.Phanquyen = 1;
            else if (chkql.Checked == true)
                nv.Phanquyen = 2;
            else
                nv.Phanquyen = 0;
            if (NhanVien_BUS.TimNhanVienTheoMa(nv.Manv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (NhanVien_BUS.SuaNV(nv) == false)
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachNhanVien();
                    MessageBox.Show("Đã sửa nhân viên bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoanv();
                }
            }
            else
                MessageBox.Show("Chưa có mã nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
                txttennv.Enabled = false;
            else
                txttennv.Enabled = true;
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            if (txttennv.Text == "")
                grgt.Enabled = false;
            else
                grgt.Enabled = true;
        }

        private void radnu_CheckedChanged(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;
        }

        private void radnam_CheckedChanged(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "")
                txtsodienthoai.Enabled = false;
            else
                txtsodienthoai.Enabled = true;
        }

        private void txtsodienthoai_TextChanged(object sender, EventArgs e)
        {
            string sdt = @"^\(?(0[0-9]{2})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";//dạng dữ liệu sđt khi nhập vào
            Control c = (Control)sender;
            if (txtsodienthoai.Text == "")
            {
                btnthem.Enabled = false;
                btnsua.Enabled = false;
            }
            else
            {
                try
                {
                    if (char.IsLetter(c.Text[c.Text.Length - 1]))
                    {
                        this.error1.SetError(c, "Đang có chữ trong sđt !!!");
                        btnthem.Enabled = false;
                        btnsua.Enabled = false;
                    }
                    else if (Regex.IsMatch(txtsodienthoai.Text, sdt) == false)
                    {
                        this.error1.SetError(c, "Đây không phải số điện thoại !!!");
                        btnthem.Enabled = false;
                        btnsua.Enabled = false;
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
                    this.error1.Clear();
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                }
            }
        }

        private void chkql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkadmin.Checked == true && chkql.Checked == true)
                chkql.Checked = false;
        }

        private void chkadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkadmin.Checked == true && chkql.Checked == true)
                chkadmin.Checked = false;
        }

        private void btnlammoi2_Click(object sender, EventArgs e)
        {
            
            xoanv();
        }

        private void lammoiban_Click(object sender, EventArgs e)
        {
            xoa();
        }
    }
}
