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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        public void tatlh()
        {
            txtmalh.Enabled = true;
            txttenlh.Enabled = false;
            txtmota.Enabled = false;
            btnthemlh.Enabled = false;
            btnxoalh.Enabled = false;
            btncapnhatlh.Enabled = false;
        }
        public void tathh()
        {
            txtmahh.Enabled = true;
            txttenhh.Enabled = false;
            txtgia.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }
        public void xoahh()
        {
            txtmahh.Text = "";
            txttenhh.Text = "";
            txtgia.Text = "";
            tathh();
        }
        public void xoalh()
        {
            txtmalh.Text = "";
            txttenlh.Text = "";
            txtmota.Text = "";
            tatlh();
        }
        private void HienThiDanhSachHangHoaLenBang()
        {
            List<HangHoa_DTO> lshanghoa = HangHoa_BUS.LayDSHangHoa();
            dghanghoa.DataSource = lshanghoa;
            dghanghoa.Columns["Mahh"].HeaderText = "Mã hàng hóa";
            dghanghoa.Columns["Tenhh"].HeaderText = "Tên hàng hóa";
            dghanghoa.Columns["Malh"].HeaderText = "Mã loại hàng";
            dghanghoa.Columns["Giahh"].HeaderText = "Giá tiền";
            dghanghoa.Columns["Tenlh"].HeaderText = "Tên loại hàng";
            dghanghoa.Columns["Mahh"].Width = 100;
            dghanghoa.Columns["Tenhh"].Width = 150;
            dghanghoa.Columns["Malh"].Width = 100;
            dghanghoa.Columns["Giahh"].Width = 100;
            dghanghoa.Columns["Tenlh"].Width = 250;
            dghanghoa.Columns["Malh"].Visible = false;

        }
        private void HienThiDanhSachLoaiHangLenBang()
        {
            List<LoaiHang_DTO> lsloaihang = LoaiHang_BUS.LayDSLoaiHang();
            dgloaihang.DataSource = lsloaihang;
            dgloaihang.Columns["Malh"].HeaderText = "Mã loại hàng";
            dgloaihang.Columns["Tenlh"].HeaderText = "Tên loại hàng";
            dgloaihang.Columns["Mota"].HeaderText = "Mô tả";
            dgloaihang.Columns["Malh"].Width = 100;
            dgloaihang.Columns["Tenlh"].Width = 150;
            dgloaihang.Columns["Mota"].Width = 250;

        }
        private void HienThiLoaiHangLenCombobox()
        {
            List<LoaiHang_DTO> lsloaihang = LoaiHang_BUS.LayDSLoaiHang();
            cbloaihang.DataSource = lsloaihang;
            cbloaihang.DisplayMember = "Tenlh";
            cbloaihang.ValueMember = "Malh";
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHangHoaLenBang();
            HienThiDanhSachLoaiHangLenBang();
            HienThiLoaiHangLenCombobox();
            xoalh();
            xoahh();

        }

        private void btnthemlh_Click(object sender, EventArgs e)
        {
            LoaiHang_DTO lh = new LoaiHang_DTO();
            lh.Malh = txtmalh.Text.Trim().ToUpper();
            lh.Tenlh = txttenlh.Text.Trim();
            lh.Mota = txtmota.Text.Trim();
            if (lh.Malh ==""||LoaiHang_BUS.TimLoaiHangTheoMa(lh.Malh)!=null)
            {
                MessageBox.Show("Mã loại hàng đã tồn tại vui lòng chỉnh lại mã loại hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (LoaiHang_BUS.ThemLoaiHang(lh) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDanhSachLoaiHangLenBang();
                HienThiLoaiHangLenCombobox();
                MessageBox.Show("Đã thêm loại hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoalh();
            }   
            
        }

        private void dgloaihang_Click(object sender, EventArgs e)
        {
            btnxoalh.Enabled = true;
            btncapnhatlh.Enabled = true;
            DataGridViewRow r = new DataGridViewRow();
            r = dgloaihang.SelectedRows[0];
            txtmalh.Text = r.Cells["Malh"].Value.ToString();
            txttenlh.Text = r.Cells["Tenlh"].Value.ToString();
            txtmota.Text = r.Cells["Mota"].Value.ToString();
            txtmalh.Enabled = false;
        }

        private void btnxoalh_Click(object sender, EventArgs e)
        {
            LoaiHang_DTO lh = new LoaiHang_DTO();
            lh.Malh = txtmalh.Text.Trim();
            if (LoaiHang_BUS.TimLoaiHangTheoMa(lh.Malh)!=null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (LoaiHang_BUS.XoaLoaiHang(lh) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachLoaiHangLenBang();
                    MessageBox.Show("Đã xóa loại hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoalh();
                }
            }
            else
                MessageBox.Show("Chưa có mã loại hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btncapnhatlh_Click(object sender, EventArgs e)
        {
            LoaiHang_DTO lh = new LoaiHang_DTO();
            lh.Malh = txtmalh.Text.Trim();
            lh.Tenlh = txttenlh.Text.Trim();
            lh.Mota = txtmota.Text.Trim();
            if (LoaiHang_BUS.TimLoaiHangTheoMa(lh.Malh) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa loại hàng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (LoaiHang_BUS.SuaLoaiHang(lh) == true)
                    {
                        HienThiDanhSachLoaiHangLenBang();
                        MessageBox.Show("Đã sửa loại hàng bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        xoalh();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
            else
                MessageBox.Show("Chưa có mã loại hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
        }

        private void txtmalh_TextChanged(object sender, EventArgs e)
        {
            String malh = @"^\(?([a-zA-Z]{2})\)?[-. ]?([0-9]{3})$";//dạng dữ liệu mã số KH 2 ký tự đầu là chữ và 3 ký tự số;
            Control c = (Control)sender;
            if (txtmalh.Text == "")
            {
                txttenlh.Enabled = false;
            }
            else
            {
                try
                {
                    if (Regex.IsMatch(txtmalh.Text, malh) == false)
                    {
                        this.error1.SetError(c, "Đây không phải mã loại hàng, mã loại hàng hàng gồn 2 chữ cái đầu và 3 số cuối!!!");
                        txttenlh.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        txttenlh.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.Clear();
                    txttenlh.Enabled = true;
                }
            }
        }

        private void txttenlh_TextChanged(object sender, EventArgs e)
        {
            if (txttenlh.Text == "")
                txtmota.Enabled = false;
            else
                txtmota.Enabled = true;
        }

        private void txtmota_TextChanged(object sender, EventArgs e)
        {
            if (txtmota.Text == "")
                btnthemlh.Enabled = false;
            else if (btncapnhatlh.Enabled == true)
                btnthemlh.Enabled = false;
            else
                btnthemlh.Enabled = true;
        }

        private void btnlammoi2_Click(object sender, EventArgs e)
        {
            xoalh();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.Mahh = txtmahh.Text.Trim().ToUpper();
            hh.Tenhh = txttenhh.Text.Trim();
            hh.Malh = cbloaihang.SelectedValue.ToString();
            hh.Giahh =int.Parse( txtgia.Text.Trim());
            if(hh.Mahh==""||HangHoa_BUS.TimHangHoaTheoMa(hh.Mahh)!=null)
                MessageBox.Show("Mã hàng hóa đã tồn tại vui lòng chỉnh lại mã hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                if (HangHoa_BUS.ThemHangHoa(hh) == false)
                {
                    MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                HienThiDanhSachHangHoaLenBang();
                MessageBox.Show("Đã thêm hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                xoahh();
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.Mahh = txtmahh.Text.Trim().ToUpper();
            if (HangHoa_BUS.TimHangHoaTheoMa(hh.Mahh) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (HangHoa_BUS.XoaHangHoa(hh) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachHangHoaLenBang();
                    MessageBox.Show("Đã xóa hàng hóa bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoahh();
                }
            }
            else
                MessageBox.Show("Chưa có mã hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            HangHoa_DTO hh = new HangHoa_DTO();
            hh.Mahh = txtmahh.Text.Trim().ToUpper();
            hh.Tenhh = txttenhh.Text.Trim();
            hh.Malh = cbloaihang.SelectedValue.ToString();
            hh.Giahh = int.Parse(txtgia.Text.Trim());
            if (HangHoa_BUS.TimHangHoaTheoMa(hh.Mahh) != null)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn sửa dòng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    if (HangHoa_BUS.SuaHangHoa(hh) == false)
                    {
                        MessageBox.Show("Xóa không thành công!!!! Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    HienThiDanhSachHangHoaLenBang();
                    MessageBox.Show("Đã sửa hàng hóa bạn chọn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    xoahh();
                }
            }
            else
                MessageBox.Show("Chưa có mã hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void dghanghoa_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            DataGridViewRow r = new DataGridViewRow();
            r = dghanghoa.SelectedRows[0];
            txtmahh.Text = r.Cells["Mahh"].Value.ToString();
            txttenhh.Text = r.Cells["Tenhh"].Value.ToString();
            cbloaihang.SelectedValue = r.Cells["Malh"].Value;
            txtgia.Text= r.Cells["Giahh"].Value.ToString();
            txtmahh.Enabled = false;
        }

        private void txtmahh_TextChanged(object sender, EventArgs e)
        {
            String mahh = @"^\(?([a-zA-Z]{2})\)?[-. ]?([0-9]{5})$";//dạng dữ liệu mã số KH 3 ký tự đầu là chữ và 3 ký tự số;
            Control c = (Control)sender;
            if (txtmahh.Text == "")
            {
                txttenhh.Enabled = false;
            }
            else
            {
                try
                {
                    if (Regex.IsMatch(txtmahh.Text, mahh) == false)
                    {
                        this.error1.SetError(c, "Đây không phải hàng hóa, mã hàng hóa gồn 2 chữ cái đầu và 5 số cuối!!!");
                        txttenhh.Enabled = false;
                    }
                    else
                    {
                        this.error1.Clear();
                        txttenhh.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.Clear();
                    txttenhh.Enabled = true;
                }
            }
        }

        private void txttenhh_TextChanged(object sender, EventArgs e)
        {
            if (txttenhh.Text == "")
                txtgia.Enabled = false;
            else
                txtgia.Enabled = true;
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txtgia.Text == "")
            {
                btnsua.Enabled = false;
                btnthem.Enabled = false;
                this.error1.Clear();
            }
            else
            {
                try
                {
                    int.Parse(txtgia.Text);
                    this.error1.Clear();
                    btnthem.Enabled = true;
                    if (int.Parse(txtgia.Text) < 10000)
                    {
                        this.error1.SetError(c, "Số tiền tối thiểu của hàng hóa phải trên 10.000vnd!!!");
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

        private void btnlammoihh_Click(object sender, EventArgs e)
        {
            xoahh();
        }

        private void frmHangHoa_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1071 && this.Size.Height > 630)
            {
                dghanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dghanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                HienThiDanhSachHangHoaLenBang();
            }
        }
    }
}
