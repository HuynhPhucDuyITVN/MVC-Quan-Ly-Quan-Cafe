using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PhanMemQuanLyQuanCafe
{
    public partial class frmMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public string isThoat;
        private Form activeform;
        public  NhanVien_DTO nhanvien;
        frmDoiMatKhau fDMK;



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmMain()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Openchildform(Form childform, object btndenser)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.pnlfrmcon.Controls.Add(childform);
            this.pnlfrmcon.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labeltitle.Text = childform.Text;
        }
        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnltitle.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control prebutton in pnlchucnang.Controls)
            {
                if (prebutton.GetType() == typeof(Button))
                {
                    prebutton.BackColor = System.Drawing.Color.FromArgb(229, 238, 193);
                    prebutton.ForeColor = System.Drawing.Color.FromArgb(65, 67, 106);
                    prebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void QuyenTruyCap()
        {
            int quyen = int.Parse(nhanvien.Phanquyen.ToString());
            switch (quyen)
            {
                case 1:
                    btnbanhang.Visible = true;
                    btnbaocao.Visible = true;
                    btnhanghoa.Visible = true;
                    btnkhachhang.Visible = true;
                    btnluongnv.Visible = true;
                    btnnhanvien.Visible = true;
                    break;
                case 2:
                    btnbanhang.Visible = true;
                    btnbaocao.Visible = false;
                    btnhanghoa.Visible = true;
                    btnkhachhang.Visible = true;
                    btnluongnv.Visible = false;
                    btnnhanvien.Visible = false;
                    break;
                default:
                    btnbanhang.Visible = true;
                    btnbaocao.Visible = false;
                    btnhanghoa.Visible = false;
                    btnkhachhang.Visible = false;
                    btnluongnv.Visible = false;
                    btnnhanvien.Visible = false;
                    break;
            }
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            //kiểm tra xem cửa sổ đang thu nhỏ hay phóng to
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pnlfrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            //thay điổi trạng thái để tránh trường hợp lỗi của form
            if (WindowState == FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        


        

        private void btndangxuat_Click(object sender, EventArgs e)
        {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    //isThoat = false;
                    this.Close();
                    frmLogin n = new frmLogin();
                    n.Show();
                }
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmBanHang(nhanvien.Manv), sender);
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmKhachHang(), sender);
            
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmNhanVien(nhanvien.Manv), sender);
        }

        private void btnluongnv_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmLuongNhanVien(), sender);
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmHangHoa(), sender);
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmBaoCaoThongKe(), sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbltaikhoan.Text = nhanvien.Manv;
            lbtennv.Text = nhanvien.Tennv;
            QuyenTruyCap();
        }

        

        private void lbldoimk_Click(object sender, EventArgs e)
        {
            if (fDMK == null || fDMK.IsDisposed)
            {
                fDMK = new frmDoiMatKhau(nhanvien.Tennv,nhanvien.Manv);
                fDMK.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlfrmcon.Controls.Remove(activeform);
            labeltitle.Text = "HOME";
            pnltitle.BackColor= System.Drawing.Color.FromArgb(151, 64, 99);
            DisableButton();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string dirname = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, dirname + @"\HelpUs\HelpUs.chm");
            pictureBox1_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Openchildform(new Forms.frmCaLam(), sender);
        }
    }
}
