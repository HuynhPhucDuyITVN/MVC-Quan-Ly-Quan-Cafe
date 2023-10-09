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
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }
        public void tatkh()
        {
            btnthem.Enabled = false;
            txtsdtkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtdiemtl.Enabled = false;
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
        public void HienThiDanhSachKhachHangCombobox()
        {
            List<LoaiKH_DTO> lslkh = LoaiKH_BUS.LayDSLoaiKH();
            cboloaikh.DataSource = lslkh;
            cboloaikh.DisplayMember = "Tenlkh";
            cboloaikh.ValueMember = "Malkh";
        }
        private void frmThemKH_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHangCombobox();
            cboloaikh.SelectedValue = "MOI";
            cboloaikh.Enabled = false;
            tatkh();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Malkh = cboloaikh.SelectedValue.ToString();
            kh.Tenkh = txttenkh.Text.Trim();
            kh.Diachikh = txtdiachi.Text.Trim();
            kh.Sdt = txtsdtkh.Text.Trim();
            kh.Diemtl = int.Parse(txtdiemtl.Text);
            if (KhachHang_BUS.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Thêm không thành công!!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            xoakh();
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
                btnthem.Enabled = false;
            else
                btnthem.Enabled = true;
        }

        private void txtdiemtl_TextChanged(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (txtdiemtl.Text == "")
            {
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
                    }
                    else
                    {
                        this.error1.Clear();
                        btnthem.Enabled = true;
                    }
                }
                catch
                {
                    this.error1.SetError(c, "Đây không phải số !!!!");
                    btnthem.Enabled = false;
                }
            }
        }

        private void btnlammoi2_Click(object sender, EventArgs e)
        {
            xoakh();
        }
    }
}
