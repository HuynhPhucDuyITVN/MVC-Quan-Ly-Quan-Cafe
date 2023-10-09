
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmBaoCaoThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoanhthu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dglsgiaodich = new System.Windows.Forms.DataGridView();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateketthuc = new System.Windows.Forms.DateTimePicker();
            this.datebatdau = new System.Windows.Forms.DateTimePicker();
            this.dgluong = new System.Windows.Forms.DataGridView();
            this.btnthongkeluong = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabReportLuong = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltongdoanhthu = new System.Windows.Forms.Label();
            this.ChiTietLuong_DTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSGiaoDichDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDoanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglsgiaodich)).BeginInit();
            this.tabLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgluong)).BeginInit();
            this.tabReport.SuspendLayout();
            this.tabReportLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietLuong_DTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSGiaoDichDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDoanhthu);
            this.tabControl1.Controls.Add(this.tabLuong);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabReportLuong);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 572);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabDoanhthu
            // 
            this.tabDoanhthu.BackColor = System.Drawing.Color.White;
            this.tabDoanhthu.Controls.Add(this.label7);
            this.tabDoanhthu.Controls.Add(this.lbltongdoanhthu);
            this.tabDoanhthu.Controls.Add(this.label2);
            this.tabDoanhthu.Controls.Add(this.label1);
            this.tabDoanhthu.Controls.Add(this.btnKhoiPhuc);
            this.tabDoanhthu.Controls.Add(this.btnSaoLuu);
            this.tabDoanhthu.Controls.Add(this.btnthongke);
            this.tabDoanhthu.Controls.Add(this.dateTo);
            this.tabDoanhthu.Controls.Add(this.datefrom);
            this.tabDoanhthu.Controls.Add(this.dglsgiaodich);
            this.tabDoanhthu.Location = new System.Drawing.Point(4, 25);
            this.tabDoanhthu.Name = "tabDoanhthu";
            this.tabDoanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhthu.Size = new System.Drawing.Size(878, 543);
            this.tabDoanhthu.TabIndex = 0;
            this.tabDoanhthu.Text = "Doanh Thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "From:";
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnKhoiPhuc.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.iconkhoiphuc;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(716, 4);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(156, 71);
            this.btnKhoiPhuc.TabIndex = 20;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaoLuu.FlatAppearance.BorderSize = 0;
            this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaoLuu.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.iconsaoluu;
            this.btnSaoLuu.Location = new System.Drawing.Point(547, 6);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(144, 69);
            this.btnSaoLuu.TabIndex = 20;
            this.btnSaoLuu.Text = "Sao Lưu";
            this.btnSaoLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.FlatAppearance.BorderSize = 0;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongke.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.Color.Tomato;
            this.btnthongke.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthongke;
            this.btnthongke.Location = new System.Drawing.Point(262, 9);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(258, 66);
            this.btnthongke.TabIndex = 20;
            this.btnthongke.Text = "Thống kê Doanh thu";
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(56, 46);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 1;
            this.dateTo.Value = new System.DateTime(2023, 5, 30, 15, 27, 0, 0);
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(56, 11);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(200, 22);
            this.datefrom.TabIndex = 1;
            this.datefrom.Value = new System.DateTime(2023, 5, 1, 15, 27, 0, 0);
            // 
            // dglsgiaodich
            // 
            this.dglsgiaodich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dglsgiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglsgiaodich.Location = new System.Drawing.Point(6, 120);
            this.dglsgiaodich.Name = "dglsgiaodich";
            this.dglsgiaodich.RowHeadersWidth = 51;
            this.dglsgiaodich.RowTemplate.Height = 24;
            this.dglsgiaodich.Size = new System.Drawing.Size(866, 417);
            this.dglsgiaodich.TabIndex = 0;
            // 
            // tabLuong
            // 
            this.tabLuong.Controls.Add(this.label6);
            this.tabLuong.Controls.Add(this.lbltongtien);
            this.tabLuong.Controls.Add(this.cbnhanvien);
            this.tabLuong.Controls.Add(this.label3);
            this.tabLuong.Controls.Add(this.label5);
            this.tabLuong.Controls.Add(this.label4);
            this.tabLuong.Controls.Add(this.dateketthuc);
            this.tabLuong.Controls.Add(this.datebatdau);
            this.tabLuong.Controls.Add(this.dgluong);
            this.tabLuong.Controls.Add(this.btnthongkeluong);
            this.tabLuong.Location = new System.Drawing.Point(4, 25);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.Size = new System.Drawing.Size(878, 543);
            this.tabLuong.TabIndex = 1;
            this.tabLuong.Text = "Lương Nhân Viên";
            this.tabLuong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tổng Tiền:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.ForeColor = System.Drawing.Color.Red;
            this.lbltongtien.Location = new System.Drawing.Point(251, 35);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(27, 29);
            this.lbltongtien.TabIndex = 28;
            this.lbltongtien.Text = "0";
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(6, 39);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(226, 24);
            this.cbnhanvien.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Chọn nhân viên cần thống kê:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "From:";
            // 
            // dateketthuc
            // 
            this.dateketthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateketthuc.Location = new System.Drawing.Point(499, 42);
            this.dateketthuc.Name = "dateketthuc";
            this.dateketthuc.Size = new System.Drawing.Size(200, 22);
            this.dateketthuc.TabIndex = 22;
            // 
            // datebatdau
            // 
            this.datebatdau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datebatdau.Location = new System.Drawing.Point(499, 14);
            this.datebatdau.Name = "datebatdau";
            this.datebatdau.Size = new System.Drawing.Size(200, 22);
            this.datebatdau.TabIndex = 23;
            // 
            // dgluong
            // 
            this.dgluong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgluong.Location = new System.Drawing.Point(6, 80);
            this.dgluong.Name = "dgluong";
            this.dgluong.RowHeadersWidth = 51;
            this.dgluong.RowTemplate.Height = 24;
            this.dgluong.Size = new System.Drawing.Size(866, 457);
            this.dgluong.TabIndex = 21;
            // 
            // btnthongkeluong
            // 
            this.btnthongkeluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthongkeluong.FlatAppearance.BorderSize = 0;
            this.btnthongkeluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongkeluong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongkeluong.ForeColor = System.Drawing.Color.Tomato;
            this.btnthongkeluong.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btntkluong;
            this.btnthongkeluong.Location = new System.Drawing.Point(705, 6);
            this.btnthongkeluong.Name = "btnthongkeluong";
            this.btnthongkeluong.Size = new System.Drawing.Size(170, 68);
            this.btnthongkeluong.TabIndex = 24;
            this.btnthongkeluong.Text = "Lương";
            this.btnthongkeluong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongkeluong.UseVisualStyleBackColor = true;
            this.btnthongkeluong.Click += new System.EventHandler(this.btnthongkeluong_Click);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.reportViewer1);
            this.tabReport.Location = new System.Drawing.Point(4, 25);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(878, 543);
            this.tabReport.TabIndex = 2;
            this.tabReport.Text = "Report Doanh Thu";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.lSGiaoDichDTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyQuanCafe.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(872, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabReportLuong
            // 
            this.tabReportLuong.Controls.Add(this.reportViewer2);
            this.tabReportLuong.Location = new System.Drawing.Point(4, 25);
            this.tabReportLuong.Name = "tabReportLuong";
            this.tabReportLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportLuong.Size = new System.Drawing.Size(878, 543);
            this.tabReportLuong.TabIndex = 3;
            this.tabReportLuong.Text = "Report Lương";
            this.tabReportLuong.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.ChiTietLuong_DTOBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyQuanCafe.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(872, 537);
            this.reportViewer2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tổng Doanh thu:";
            // 
            // lbltongdoanhthu
            // 
            this.lbltongdoanhthu.AutoSize = true;
            this.lbltongdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongdoanhthu.ForeColor = System.Drawing.Color.Red;
            this.lbltongdoanhthu.Location = new System.Drawing.Point(142, 80);
            this.lbltongdoanhthu.Name = "lbltongdoanhthu";
            this.lbltongdoanhthu.Size = new System.Drawing.Size(27, 29);
            this.lbltongdoanhthu.TabIndex = 30;
            this.lbltongdoanhthu.Text = "0";
            // 
            // ChiTietLuong_DTOBindingSource
            // 
            this.ChiTietLuong_DTOBindingSource.DataSource = typeof(DTO.ChiTietLuong_DTO);
            // 
            // lSGiaoDichDTOBindingSource
            // 
            this.lSGiaoDichDTOBindingSource.DataSource = typeof(DTO.LSGiaoDich_DTO);
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(890, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.SizeChanged += new System.EventHandler(this.frmBaoCaoThongKe_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabDoanhthu.ResumeLayout(false);
            this.tabDoanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglsgiaodich)).EndInit();
            this.tabLuong.ResumeLayout(false);
            this.tabLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgluong)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tabReportLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietLuong_DTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSGiaoDichDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoanhthu;
        private System.Windows.Forms.DataGridView dglsgiaodich;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnthongkeluong;
        private System.Windows.Forms.DateTimePicker dateketthuc;
        private System.Windows.Forms.DateTimePicker datebatdau;
        private System.Windows.Forms.DataGridView dgluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabReportLuong;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ChiTietLuong_DTOBindingSource;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltongdoanhthu;
        private System.Windows.Forms.BindingSource lSGiaoDichDTOBindingSource;
    }
}