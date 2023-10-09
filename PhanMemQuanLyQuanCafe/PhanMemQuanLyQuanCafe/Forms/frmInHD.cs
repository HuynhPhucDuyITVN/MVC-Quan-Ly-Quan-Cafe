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

namespace PhanMemQuanLyQuanCafe.Forms
{

    public partial class frmInHD : Form
    {
        private int maban;
        private string tenban;
        private string mahd;
        private string manv;
        private string makh = "Trống";
        private string giamgia="0";
        private string thanhtien = "0";
        public frmInHD()
        {
            InitializeComponent();
        }
        public frmInHD(int maban, string tenban, string mahd, string manv, string makh, string giamgia, string thanhtien)
        {
            InitializeComponent();
            this.maban = maban;
            this.tenban = tenban;
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.giamgia = giamgia;
            this.thanhtien = thanhtien;
        }

        private void test_Load(object sender, EventArgs e)
        {
            Menu_DTOBindingSource.DataSource = Menu_BUS.LayDSMenu(maban);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("TenBan",tenban),
                new Microsoft.Reporting.WinForms.ReportParameter("MaHD",mahd),
                new Microsoft.Reporting.WinForms.ReportParameter("MaKH",makh),
                new Microsoft.Reporting.WinForms.ReportParameter("MaNV",manv),
                new Microsoft.Reporting.WinForms.ReportParameter("GiamGia",giamgia),
                new Microsoft.Reporting.WinForms.ReportParameter("Ngay",DateTime.Now.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("TongTien",thanhtien)

        };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
