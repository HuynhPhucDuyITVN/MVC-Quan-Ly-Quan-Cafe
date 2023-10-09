using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PhanMemQuanLyQuanCafe
{
    public partial class frmDoiMatKhau : Form
    {
        private string tennv;
        private string manv;
        public frmDoiMatKhau(string tennv, string manv)
        {
            InitializeComponent();
            this.tennv = tennv;
            this.manv = manv;
        }
        public void tat()
        {
            txtMatKhau.Focus();
            txtNewMK.Enabled = false;
            txtXNMK.Enabled = false;
            btndoimk.Enabled = false;
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            tat();
            lblmanv.Text = manv;
            lbltennv.Text = tennv;
            txtNewMK.UseSystemPasswordChar = true;
            txtXNMK.UseSystemPasswordChar = true;
        }

        private void buttonesc_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void lblhien_Click(object sender, EventArgs e)
        {
            if (lblhien.Text == "Hiện mật khẩu")
            {
                txtNewMK.UseSystemPasswordChar = false;
                txtXNMK.UseSystemPasswordChar = false;
                lblhien.Text = "Ẩn mật khẩu";
            }
            else
            {
                txtNewMK.UseSystemPasswordChar = true;
                txtXNMK.UseSystemPasswordChar = true;
                lblhien.Text = "Hiện mật khẩu";
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                txtNewMK.Enabled = false;
            else
                txtNewMK.Enabled = true;
        }

        private void txtNewMK_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMK.Text == "")
                txtXNMK.Enabled = false;
            else
                txtXNMK.Enabled = true;
        }

        private void txtXNMK_TextChanged(object sender, EventArgs e)
        {
            if (txtXNMK.Text == "")
                btndoimk.Enabled = false;
            else
                btndoimk.Enabled = true;
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            // xác nhận mật khẩu cũ
            if(NhanVien_BUS.LayTKDangNhap(lblmanv.Text,txtMatKhau.Text)==null)
            {
                MessageBox.Show("Mật khẩu không đúng.");
                return;
            }
            if(txtNewMK.Text != txtXNMK.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = lblmanv.Text;
            nv.Matkhau = txtMatKhau.Text;
            //ghi nhận mật khẩu mới
            if(NhanVien_BUS.DoiMatKhau(nv,txtNewMK.Text)==false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            MessageBox.Show("Đã thay đổi mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();

        }
    }
}
