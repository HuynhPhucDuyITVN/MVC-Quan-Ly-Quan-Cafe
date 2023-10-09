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
    public partial class frmFlashScreen : Form
    {
        public NhanVien_DTO nhanvien;
        public frmFlashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 1277)
            {
                timer1.Stop();
                frmMain f = new frmMain();
                f.nhanvien = new NhanVien_DTO();
                f.nhanvien = nhanvien;
                f.Show();
                this.Hide();
            }
        }
    }
}
