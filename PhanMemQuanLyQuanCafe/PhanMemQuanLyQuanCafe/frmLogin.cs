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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void buttonesc_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                frmFlashScreen f = new frmFlashScreen();
                string manv = txtmanv.Text.Trim().ToUpper();
                string mk = txtmk.Text.Trim();
                f.nhanvien = new NhanVien_DTO();
                f.nhanvien = NhanVien_BUS.LayTKDangNhap(manv, mk);
                if (f.nhanvien!=null)
                {
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmanv.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void lblhien_Click(object sender, EventArgs e)
        {
            if (lblhien.Text == "Hiện mật khẩu")
            {
                txtmk.UseSystemPasswordChar = false;
                lblhien.Text = "Ẩn mật khẩu";
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
                lblhien.Text = "Hiện mật khẩu";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtmanv.Focus();
            txtmk.UseSystemPasswordChar = true;
            if (txtmk.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {
            if (txtmk.Text == "")
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }
    }
}
