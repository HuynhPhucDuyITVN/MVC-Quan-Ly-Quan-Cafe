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
    public partial class frmLuongNhanVien : Form
    {
        public frmLuongNhanVien()
        {
            InitializeComponent();
        }
        public void tat()
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txttenca.Enabled = false;
            txtluong.Enabled = false;
        }
        
        public void xoa()
        {
            txtmaca.Text = "";
            txttenca.Text = "";
            txtluong.Text = "";
            tat();
        }
        public void HienNVLenCombobox()
        {
            List<NhanVien_DTO> lsvnv = NhanVien_BUS.LayDSNhanVien();
            cbnhanvien.DataSource = lsvnv;
            cbnhanvien.DisplayMember = "Tennv";
            cbnhanvien.ValueMember = "Manv";
        }
        public void HienCaLamViecCombobox()
        {
            List<CaLamViec_DTO> lsvclv = CaLamViec_BUS.LayCaLamViec();
            cbcalv.DataSource = lsvclv;
            cbcalv.DisplayMember = "Tenclv";
            cbcalv.ValueMember = "Maclv";
            cbcalv.SelectedIndex = 0;
        }
        public void HienThiDSCaLamViec()
        {
            List<CaLamViec_DTO> lsvclv = CaLamViec_BUS.LayCaLamViec();
            dgcalamviec.DataSource = lsvclv;
            dgcalamviec.Columns["Maclv"].HeaderText = "Mã ca làm việc";
            dgcalamviec.Columns["Tenclv"].HeaderText = "Ca làm việc";
            dgcalamviec.Columns["Giobd"].HeaderText = "Giờ bắt đầu";
            dgcalamviec.Columns["Giokt"].HeaderText = "Giờ kết thúc";
            dgcalamviec.Columns["SoTien"].HeaderText = "Số tiền";
            dgcalamviec.Columns["Maclv"].Width = 150;
            dgcalamviec.Columns["Tenclv"].Width = 250;
            dgcalamviec.Columns["Giobd"].Width = 150;
            dgcalamviec.Columns["Giokt"].Width = 150;
            dgcalamviec.Columns["Sotien"].Width = 150;
        }
        public void HienThiChiTietLuong()
        {
            List<ChiTietLuong_DTO> lsvct = ChiTietLuong_BUS.LayDSCTLuong();
            dgluong.DataSource = lsvct;
            dgluong.Columns["Maclv"].HeaderText = "Mã ca làm việc";
            dgluong.Columns["Tenclv"].HeaderText = "Ca làm việc";
            dgluong.Columns["Manv"].HeaderText = "Mã nhân viên";
            dgluong.Columns["Tennv"].HeaderText = "Nhân viên";
            dgluong.Columns["Ngaylam"].HeaderText = "Ngày làm";
            dgluong.Columns["Thanhtien"].HeaderText = "Lương theo ca";
            dgluong.Columns["Maclv"].Visible=false;
            dgluong.Columns["Manv"].Visible=false;
            dgluong.Columns["Tenclv"].Width = 150;
            dgluong.Columns["Tennv"].Width = 200;
            dgluong.Columns["Ngaylam"].Width = 150;
            dgluong.Columns["Thanhtien"].Width = 150;

        }
        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
            txtluongca.ReadOnly = true;
            datengaylamvc.MaxDate = DateTime.Now;
            datengaylamvc.Value = datengaylamvc.MaxDate;
            btnxoaluong.Enabled = false;
            HienCaLamViecCombobox();
            HienNVLenCombobox();
            HienThiDSCaLamViec();
            HienThiChiTietLuong();
            cbcalv.SelectedIndex = 0;
            txtluongca.Text = CaLamViec_BUS.TimCaLamViecTheoMa(cbcalv.SelectedValue.ToString()).Sotien.ToString();
            xoa();
        }
        private void dgcalamviec_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtmaca.Enabled = false;
            DataGridViewRow r = new DataGridViewRow();
            r = dgcalamviec.SelectedRows[0];
            txtmaca.Text = r.Cells["Maclv"].Value.ToString();
            txttenca.Text = r.Cells["Tenclv"].Value.ToString();
            giobd.Value = DateTime.Parse(r.Cells["Giobd"].Value.ToString());
            giokt.Value = DateTime.Parse(r.Cells["Giokt"].Value.ToString());
            txtluong.Text = r.Cells["Sotien"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            CaLamViec_DTO clv = new CaLamViec_DTO();
            clv.Maclv = txtmaca.Text.ToUpper().Trim();
            clv.Tenclv = txttenca.Text.Trim();
            clv.Giobd = giobd.Value.TimeOfDay;
            clv.Giokt = giokt.Value.TimeOfDay;
            clv.Sotien = int.Parse(txtluong.Text.Trim());
            if(clv.Maclv==""||CaLamViec_BUS.TimCaLamViecTheoMa(clv.Maclv)!=null)
            {
                MessageBox.Show("Mã ca làm việc đã tồn tại vui lòng chỉnh lại mã ca làm việc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(CaLamViec_BUS.ThemCa(clv)==false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDSCaLamViec();
                MessageBox.Show("Đã thêm ca", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoa();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            CaLamViec_DTO clv = new CaLamViec_DTO();
            clv.Maclv = txtmaca.Text.ToUpper().Trim();
            if (CaLamViec_BUS.TimCaLamViecTheoMa(clv.Maclv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (CaLamViec_BUS.XoaCa(clv) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDSCaLamViec();
                    MessageBox.Show("Đã xóa ca bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoa();
                }
            }
            else
                MessageBox.Show("Chưa có mã ca", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            CaLamViec_DTO clv = new CaLamViec_DTO();
            clv.Maclv = txtmaca.Text.ToUpper().Trim();
            clv.Tenclv = txttenca.Text.Trim();
            clv.Giobd = giobd.Value.TimeOfDay;
            clv.Giokt = giokt.Value.TimeOfDay;
            clv.Sotien = int.Parse(txtluong.Text.Trim());
            if (CaLamViec_BUS.TimCaLamViecTheoMa(clv.Maclv) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (CaLamViec_BUS.SuaCa(clv) == false)
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDSCaLamViec();
                    MessageBox.Show("Đã sửa ca bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoa();
                }
            }
            else
                MessageBox.Show("Chưa có mã ca", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void txtmaca_TextChanged(object sender, EventArgs e)
        {
            if (txtmaca.Text == "")
                txttenca.Enabled = false;
            else
                txttenca.Enabled = true;
        }

        private void txttenca_TextChanged(object sender, EventArgs e)
        {
            if (txttenca.Text == "")
                txtluong.Enabled = false;
            else
                txtluong.Enabled = true;
        }

        private void txtluong_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txtluong.Text == "")
            {
                btnsua.Enabled = false;
                btnthem.Enabled = false;
                this.error1.Clear();
            }
            else
            {
                try
                {
                    int.Parse(txtluong.Text);
                    this.error1.Clear();
                    btnthem.Enabled = true;
                    if (int.Parse(txtluong.Text) < 20000)
                    {
                        this.error1.SetError(c, "Số tiền tối thiểu phải trên 20.000vnd!!!");
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

        private void btnlammoi1_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void cbcalv_SelectionChangeCommitted(object sender, EventArgs e)
        {
           txtluongca.Text= CaLamViec_BUS.TimCaLamViecTheoMa(cbcalv.SelectedValue.ToString()).Sotien.ToString();
        }

        private void btnthemluong_Click(object sender, EventArgs e)
        {
            ChiTietLuong_DTO ctl = new ChiTietLuong_DTO();
            ctl.Maclv = cbcalv.SelectedValue.ToString();
            ctl.Manv = cbnhanvien.SelectedValue.ToString();
            ctl.Ngaylam = datengaylamvc.Value.ToString("yyyy/MM/dd");
            ctl.Thanhtien = int.Parse(txtluongca.Text);
            if (ChiTietLuong_BUS.TimCTL(ctl.Maclv,ctl.Manv,ctl.Ngaylam) != null)
            {
                MessageBox.Show("Nhân viên đã đăng ký ca làm vào ngày này rồi!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (ChiTietLuong_BUS.ThemCTL(ctl) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiChiTietLuong();
                MessageBox.Show("Đã thêm buổi làm!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void dgluong_Click(object sender, EventArgs e)
        {
            btnxoaluong.Enabled = true;
            btnthemluong.Enabled = false;
            DataGridViewRow r = new DataGridViewRow();
            r = dgluong.SelectedRows[0];
            cbcalv.SelectedValue = r.Cells["Maclv"].Value;
            cbnhanvien.SelectedValue = r.Cells["Manv"].Value;
            datengaylamvc.Text = DateTime.Parse(r.Cells["Ngaylam"].Value.ToString()).ToString("dd/MM/yyyy");
            txtluongca.Text = r.Cells["Thanhtien"].Value.ToString();
            cbcalv.Enabled = false;
            cbnhanvien.Enabled = false;
            datengaylamvc.Enabled = false;
        }

        private void btnxoaluong_Click(object sender, EventArgs e)
        {
            ChiTietLuong_DTO ctl = new ChiTietLuong_DTO();
            ctl.Maclv = cbcalv.SelectedValue.ToString();
            ctl.Manv = cbnhanvien.SelectedValue.ToString();
            ctl.Ngaylam = datengaylamvc.Value.ToString("yyyy/dd/MM");
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (ChiTietLuong_BUS.XoaCTL(ctl) == false)
                {
                    MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiChiTietLuong();
                MessageBox.Show("Đã xóa ca làm bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                btnxoaluong.Enabled = false;
                btnthemluong.Enabled = true;
                cbcalv.Enabled = true;
                cbnhanvien.Enabled = true;
                datengaylamvc.Enabled = true;
            }
        }

        private void btnlammoi2_Click(object sender, EventArgs e)
        {
            btnxoaluong.Enabled = false;
            btnthemluong.Enabled = true;
            cbnhanvien.Enabled = true;
            cbcalv.Enabled = true;
            datengaylamvc.Enabled = true;
            
        }

        private void frmLuongNhanVien_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1180 && this.Size.Height > 670)
            {
                dgluong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgluong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                HienThiChiTietLuong();
            }
        }
    }
}
