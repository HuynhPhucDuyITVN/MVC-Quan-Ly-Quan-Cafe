
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmBanHang
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
            this.flowBan = new System.Windows.Forms.FlowLayoutPanel();
            this.grbhoadon = new System.Windows.Forms.GroupBox();
            this.dtpngayhd = new System.Windows.Forms.DateTimePicker();
            this.lblmanv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.cbchuyenban = new System.Windows.Forms.ComboBox();
            this.btnchuyenban = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltenban = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.cbhanghoa = new System.Windows.Forms.ComboBox();
            this.cbloaihang = new System.Windows.Forms.ComboBox();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvchitiet = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgdskh = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbhoadon.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdskh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowBan
            // 
            this.flowBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowBan.AutoScroll = true;
            this.flowBan.BackColor = System.Drawing.Color.Pink;
            this.flowBan.Location = new System.Drawing.Point(2, 1);
            this.flowBan.Name = "flowBan";
            this.flowBan.Size = new System.Drawing.Size(246, 627);
            this.flowBan.TabIndex = 0;
            // 
            // grbhoadon
            // 
            this.grbhoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbhoadon.Controls.Add(this.pictureBox1);
            this.grbhoadon.Controls.Add(this.dtpngayhd);
            this.grbhoadon.Controls.Add(this.lblmanv);
            this.grbhoadon.Controls.Add(this.label3);
            this.grbhoadon.Controls.Add(this.label2);
            this.grbhoadon.Controls.Add(this.lbtenkh);
            this.grbhoadon.Controls.Add(this.label9);
            this.grbhoadon.Controls.Add(this.label10);
            this.grbhoadon.Controls.Add(this.lbmakh);
            this.grbhoadon.Location = new System.Drawing.Point(253, 3);
            this.grbhoadon.Name = "grbhoadon";
            this.grbhoadon.Size = new System.Drawing.Size(352, 157);
            this.grbhoadon.TabIndex = 1;
            this.grbhoadon.TabStop = false;
            this.grbhoadon.Text = "Hóa Đơn";
            // 
            // dtpngayhd
            // 
            this.dtpngayhd.Enabled = false;
            this.dtpngayhd.Location = new System.Drawing.Point(9, 48);
            this.dtpngayhd.Name = "dtpngayhd";
            this.dtpngayhd.Size = new System.Drawing.Size(200, 22);
            this.dtpngayhd.TabIndex = 0;
            this.dtpngayhd.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(110, 77);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(93, 17);
            this.lblmanv.TabIndex = 0;
            this.lblmanv.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày hóa đơn:";
            // 
            // lbtenkh
            // 
            this.lbtenkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtenkh.AutoSize = true;
            this.lbtenkh.Location = new System.Drawing.Point(76, 120);
            this.lbtenkh.Name = "lbtenkh";
            this.lbtenkh.Size = new System.Drawing.Size(0, 17);
            this.lbtenkh.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã khách hàng:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "-";
            // 
            // lbmakh
            // 
            this.lbmakh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(8, 120);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(30, 17);
            this.lbmakh.TabIndex = 0;
            this.lbmakh.Text = "null";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.btnthanhtoan);
            this.panel5.Controls.Add(this.cbchuyenban);
            this.panel5.Controls.Add(this.btnchuyenban);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbltenban);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(612, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 157);
            this.panel5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbltongtien);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 51);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(258, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "VNĐ";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.ForeColor = System.Drawing.Color.Red;
            this.lbltongtien.Location = new System.Drawing.Point(12, 14);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(27, 29);
            this.lbltongtien.TabIndex = 23;
            this.lbltongtien.Text = "0";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(235, 77);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(117, 74);
            this.btnthanhtoan.TabIndex = 2;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // cbchuyenban
            // 
            this.cbchuyenban.FormattingEnabled = true;
            this.cbchuyenban.Location = new System.Drawing.Point(121, 117);
            this.cbchuyenban.Name = "cbchuyenban";
            this.cbchuyenban.Size = new System.Drawing.Size(89, 24);
            this.cbchuyenban.TabIndex = 3;
            // 
            // btnchuyenban
            // 
            this.btnchuyenban.Location = new System.Drawing.Point(20, 79);
            this.btnchuyenban.Name = "btnchuyenban";
            this.btnchuyenban.Size = new System.Drawing.Size(94, 72);
            this.btnchuyenban.TabIndex = 2;
            this.btnchuyenban.Text = "Chuyển Bàn";
            this.btnchuyenban.UseVisualStyleBackColor = true;
            this.btnchuyenban.Click += new System.EventHandler(this.btnchuyenban_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bàn:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chọn bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền:";
            // 
            // lbltenban
            // 
            this.lbltenban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltenban.AutoSize = true;
            this.lbltenban.Location = new System.Drawing.Point(181, 6);
            this.lbltenban.Name = "lbltenban";
            this.lbltenban.Size = new System.Drawing.Size(62, 17);
            this.lbltenban.TabIndex = 0;
            this.lbltenban.Text = "Tên Bàn";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "---";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.numsl);
            this.panel6.Controls.Add(this.cbhanghoa);
            this.panel6.Controls.Add(this.cbloaihang);
            this.panel6.Controls.Add(this.btnthemmon);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(254, 322);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(721, 65);
            this.panel6.TabIndex = 3;
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(479, 29);
            this.numsl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(107, 22);
            this.numsl.TabIndex = 4;
            this.numsl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbhanghoa
            // 
            this.cbhanghoa.FormattingEnabled = true;
            this.cbhanghoa.Location = new System.Drawing.Point(87, 33);
            this.cbhanghoa.Name = "cbhanghoa";
            this.cbhanghoa.Size = new System.Drawing.Size(385, 24);
            this.cbhanghoa.TabIndex = 3;
            // 
            // cbloaihang
            // 
            this.cbloaihang.FormattingEnabled = true;
            this.cbloaihang.Location = new System.Drawing.Point(87, 3);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(385, 24);
            this.cbloaihang.TabIndex = 3;
            this.cbloaihang.SelectedIndexChanged += new System.EventHandler(this.cbloaihang_SelectedIndexChanged);
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(592, 6);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(118, 51);
            this.btnthemmon.TabIndex = 2;
            this.btnthemmon.Text = "Thêm Món";
            this.btnthemmon.UseVisualStyleBackColor = true;
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên món:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại món:";
            // 
            // lsvchitiet
            // 
            this.lsvchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvchitiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvchitiet.FullRowSelect = true;
            this.lsvchitiet.GridLines = true;
            this.lsvchitiet.HideSelection = false;
            this.lsvchitiet.Location = new System.Drawing.Point(252, 393);
            this.lsvchitiet.MultiSelect = false;
            this.lsvchitiet.Name = "lsvchitiet";
            this.lsvchitiet.Size = new System.Drawing.Size(721, 235);
            this.lsvchitiet.TabIndex = 0;
            this.lsvchitiet.UseCompatibleStateImageBehavior = false;
            this.lsvchitiet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món";
            this.columnHeader3.Width = 260;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá tiền";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 170;
            // 
            // dgdskh
            // 
            this.dgdskh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdskh.Location = new System.Drawing.Point(252, 195);
            this.dgdskh.Name = "dgdskh";
            this.dgdskh.RowHeadersWidth = 51;
            this.dgdskh.RowTemplate.Height = 24;
            this.dgdskh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdskh.Size = new System.Drawing.Size(721, 121);
            this.dgdskh.TabIndex = 5;
            this.dgdskh.Click += new System.EventHandler(this.dgdskh_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiem.Location = new System.Drawing.Point(413, 166);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(442, 22);
            this.txttimkiem.TabIndex = 7;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tìm kiếm khách hàng:";
            // 
            // btnthemkh
            // 
            this.btnthemkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthemkh.Location = new System.Drawing.Point(861, 165);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(112, 24);
            this.btnthemkh.TabIndex = 8;
            this.btnthemkh.Text = "Thêm Khách ";
            this.btnthemkh.UseVisualStyleBackColor = true;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.iconhd;
            this.pictureBox1.Location = new System.Drawing.Point(236, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.btnthemkh);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgdskh);
            this.Controls.Add(this.lsvchitiet);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.grbhoadon);
            this.Controls.Add(this.flowBan);
            this.Name = "frmBanHang";
            this.Text = " Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.grbhoadon.ResumeLayout(false);
            this.grbhoadon.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdskh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowBan;
        private System.Windows.Forms.GroupBox grbhoadon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpngayhd;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnchuyenban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.ComboBox cbhanghoa;
        private System.Windows.Forms.ComboBox cbloaihang;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsvchitiet;
        private System.Windows.Forms.DataGridView dgdskh;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltenban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbchuyenban;
        private System.Windows.Forms.Label label13;
    }
}