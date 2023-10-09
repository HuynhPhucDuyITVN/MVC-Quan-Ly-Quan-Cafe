
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.btnlammoi2 = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.chkql = new System.Windows.Forms.CheckBox();
            this.chkadmin = new System.Windows.Forms.CheckBox();
            this.datevaolam = new System.Windows.Forms.DateTimePicker();
            this.grgt = new System.Windows.Forms.GroupBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.lammoiban = new System.Windows.Forms.Button();
            this.btnsuaban = new System.Windows.Forms.Button();
            this.btnxoaban = new System.Windows.Forms.Button();
            this.dgban = new System.Windows.Forms.DataGridView();
            this.btnthemban = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttenban = new System.Windows.Forms.TextBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnlammoicv = new System.Windows.Forms.Button();
            this.btnsuacv = new System.Windows.Forms.Button();
            this.btnxoacv = new System.Windows.Forms.Button();
            this.btnthemcv = new System.Windows.Forms.Button();
            this.dgchucvu = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgnhanvien)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgchucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbchucvu);
            this.groupBox1.Controls.Add(this.btnlammoi2);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.chkql);
            this.groupBox1.Controls.Add(this.chkadmin);
            this.groupBox1.Controls.Add(this.datevaolam);
            this.groupBox1.Controls.Add(this.grgt);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 603);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cbchucvu
            // 
            this.cbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(144, 246);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(274, 24);
            this.cbchucvu.TabIndex = 18;
            // 
            // btnlammoi2
            // 
            this.btnlammoi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlammoi2.FlatAppearance.BorderSize = 0;
            this.btnlammoi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoi2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi2.ForeColor = System.Drawing.Color.Tomato;
            this.btnlammoi2.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnrefesh;
            this.btnlammoi2.Location = new System.Drawing.Point(392, 545);
            this.btnlammoi2.Name = "btnlammoi2";
            this.btnlammoi2.Size = new System.Drawing.Size(43, 36);
            this.btnlammoi2.TabIndex = 17;
            this.btnlammoi2.UseVisualStyleBackColor = true;
            this.btnlammoi2.Click += new System.EventHandler(this.btnlammoi2_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Tomato;
            this.btnsua.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnsua;
            this.btnsua.Location = new System.Drawing.Point(191, 529);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(73, 68);
            this.btnsua.TabIndex = 12;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Tomato;
            this.btnxoa.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnxoa;
            this.btnxoa.Location = new System.Drawing.Point(87, 529);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 68);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Tomato;
            this.btnthem.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthem;
            this.btnthem.Location = new System.Drawing.Point(10, 529);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 68);
            this.btnthem.TabIndex = 14;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // chkql
            // 
            this.chkql.AutoSize = true;
            this.chkql.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkql.Location = new System.Drawing.Point(229, 400);
            this.chkql.Name = "chkql";
            this.chkql.Size = new System.Drawing.Size(79, 21);
            this.chkql.TabIndex = 10;
            this.chkql.Text = "Quản lý";
            this.chkql.UseVisualStyleBackColor = true;
            this.chkql.CheckedChanged += new System.EventHandler(this.chkql_CheckedChanged);
            // 
            // chkadmin
            // 
            this.chkadmin.AutoSize = true;
            this.chkadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkadmin.Location = new System.Drawing.Point(144, 400);
            this.chkadmin.Name = "chkadmin";
            this.chkadmin.Size = new System.Drawing.Size(69, 21);
            this.chkadmin.TabIndex = 10;
            this.chkadmin.Text = "Admin";
            this.chkadmin.UseVisualStyleBackColor = true;
            this.chkadmin.CheckedChanged += new System.EventHandler(this.chkadmin_CheckedChanged);
            // 
            // datevaolam
            // 
            this.datevaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datevaolam.Location = new System.Drawing.Point(144, 285);
            this.datevaolam.MaxDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.datevaolam.Name = "datevaolam";
            this.datevaolam.Size = new System.Drawing.Size(274, 22);
            this.datevaolam.TabIndex = 9;
            this.datevaolam.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            // 
            // grgt
            // 
            this.grgt.Controls.Add(this.radnam);
            this.grgt.Controls.Add(this.radnu);
            this.grgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grgt.Location = new System.Drawing.Point(178, 190);
            this.grgt.Name = "grgt";
            this.grgt.Size = new System.Drawing.Size(207, 40);
            this.grgt.TabIndex = 1;
            this.grgt.TabStop = false;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnam.Location = new System.Drawing.Point(122, 13);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(58, 21);
            this.radnam.TabIndex = 1;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            this.radnam.CheckedChanged += new System.EventHandler(this.radnam_CheckedChanged);
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnu.Location = new System.Drawing.Point(22, 13);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(47, 21);
            this.radnu.TabIndex = 1;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            this.radnu.CheckedChanged += new System.EventHandler(this.radnu_CheckedChanged);
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodienthoai.Location = new System.Drawing.Point(144, 360);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(274, 22);
            this.txtsodienthoai.TabIndex = 5;
            this.txtsodienthoai.TextChanged += new System.EventHandler(this.txtsodienthoai_TextChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(144, 323);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(274, 22);
            this.txtdiachi.TabIndex = 5;
            this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(145, 162);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(273, 22);
            this.txttennv.TabIndex = 5;
            this.txttennv.TextChanged += new System.EventHandler(this.txttennv_TextChanged);
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(145, 121);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(273, 22);
            this.txtmanv.TabIndex = 5;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(102, 53);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(316, 22);
            this.txttimkiem.TabIndex = 5;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quyền truy cập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày vào làm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dgnhanvien
            // 
            this.dgnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnhanvien.Location = new System.Drawing.Point(469, 213);
            this.dgnhanvien.Name = "dgnhanvien";
            this.dgnhanvien.RowHeadersWidth = 51;
            this.dgnhanvien.RowTemplate.Height = 24;
            this.dgnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgnhanvien.Size = new System.Drawing.Size(349, 401);
            this.dgnhanvien.TabIndex = 1;
            this.dgnhanvien.Click += new System.EventHandler(this.dgnhanvien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbtrangthai);
            this.groupBox3.Controls.Add(this.lammoiban);
            this.groupBox3.Controls.Add(this.btnsuaban);
            this.groupBox3.Controls.Add(this.btnxoaban);
            this.groupBox3.Controls.Add(this.dgban);
            this.groupBox3.Controls.Add(this.btnthemban);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txttenban);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(459, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bàn";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.cbtrangthai.Location = new System.Drawing.Point(458, 65);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(243, 24);
            this.cbtrangthai.TabIndex = 22;
            // 
            // lammoiban
            // 
            this.lammoiban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lammoiban.FlatAppearance.BorderSize = 0;
            this.lammoiban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lammoiban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lammoiban.ForeColor = System.Drawing.Color.Tomato;
            this.lammoiban.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnrefesh;
            this.lammoiban.Location = new System.Drawing.Point(658, 122);
            this.lammoiban.Name = "lammoiban";
            this.lammoiban.Size = new System.Drawing.Size(43, 36);
            this.lammoiban.TabIndex = 21;
            this.lammoiban.UseVisualStyleBackColor = true;
            this.lammoiban.Click += new System.EventHandler(this.lammoiban_Click);
            // 
            // btnsuaban
            // 
            this.btnsuaban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsuaban.FlatAppearance.BorderSize = 0;
            this.btnsuaban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuaban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuaban.ForeColor = System.Drawing.Color.Tomato;
            this.btnsuaban.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnsua;
            this.btnsuaban.Location = new System.Drawing.Point(562, 106);
            this.btnsuaban.Name = "btnsuaban";
            this.btnsuaban.Size = new System.Drawing.Size(73, 68);
            this.btnsuaban.TabIndex = 18;
            this.btnsuaban.UseVisualStyleBackColor = true;
            this.btnsuaban.Click += new System.EventHandler(this.btnsuaban_Click);
            // 
            // btnxoaban
            // 
            this.btnxoaban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoaban.FlatAppearance.BorderSize = 0;
            this.btnxoaban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoaban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaban.ForeColor = System.Drawing.Color.Tomato;
            this.btnxoaban.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnxoa;
            this.btnxoaban.Location = new System.Drawing.Point(458, 106);
            this.btnxoaban.Name = "btnxoaban";
            this.btnxoaban.Size = new System.Drawing.Size(98, 68);
            this.btnxoaban.TabIndex = 19;
            this.btnxoaban.UseVisualStyleBackColor = true;
            this.btnxoaban.Click += new System.EventHandler(this.btnxoaban_Click);
            // 
            // dgban
            // 
            this.dgban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgban.Location = new System.Drawing.Point(10, 21);
            this.dgban.Name = "dgban";
            this.dgban.RowHeadersWidth = 51;
            this.dgban.RowTemplate.Height = 24;
            this.dgban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgban.Size = new System.Drawing.Size(349, 167);
            this.dgban.TabIndex = 3;
            this.dgban.Click += new System.EventHandler(this.dgban_Click);
            // 
            // btnthemban
            // 
            this.btnthemban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthemban.FlatAppearance.BorderSize = 0;
            this.btnthemban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemban.ForeColor = System.Drawing.Color.Tomato;
            this.btnthemban.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthem;
            this.btnthemban.Location = new System.Drawing.Point(381, 106);
            this.btnthemban.Name = "btnthemban";
            this.btnthemban.Size = new System.Drawing.Size(71, 68);
            this.btnthemban.TabIndex = 20;
            this.btnthemban.UseVisualStyleBackColor = true;
            this.btnthemban.Click += new System.EventHandler(this.btnthemban_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên bàn:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(375, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng thái:";
            // 
            // txttenban
            // 
            this.txttenban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenban.Location = new System.Drawing.Point(458, 21);
            this.txttenban.Name = "txttenban";
            this.txttenban.Size = new System.Drawing.Size(243, 22);
            this.txttenban.TabIndex = 5;
            this.txttenban.TextChanged += new System.EventHandler(this.txttenban_TextChanged);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnlammoicv);
            this.groupBox4.Controls.Add(this.btnsuacv);
            this.groupBox4.Controls.Add(this.btnxoacv);
            this.groupBox4.Controls.Add(this.btnthemcv);
            this.groupBox4.Controls.Add(this.dgchucvu);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txttencv);
            this.groupBox4.Controls.Add(this.txtmacv);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(824, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 401);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức vụ";
            // 
            // btnlammoicv
            // 
            this.btnlammoicv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlammoicv.FlatAppearance.BorderSize = 0;
            this.btnlammoicv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoicv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoicv.ForeColor = System.Drawing.Color.Tomato;
            this.btnlammoicv.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnrefesh;
            this.btnlammoicv.Location = new System.Drawing.Point(293, 111);
            this.btnlammoicv.Name = "btnlammoicv";
            this.btnlammoicv.Size = new System.Drawing.Size(43, 36);
            this.btnlammoicv.TabIndex = 21;
            this.btnlammoicv.UseVisualStyleBackColor = true;
            this.btnlammoicv.Click += new System.EventHandler(this.btnlammoicv_Click);
            // 
            // btnsuacv
            // 
            this.btnsuacv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsuacv.FlatAppearance.BorderSize = 0;
            this.btnsuacv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuacv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuacv.ForeColor = System.Drawing.Color.Tomato;
            this.btnsuacv.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnsua;
            this.btnsuacv.Location = new System.Drawing.Point(197, 95);
            this.btnsuacv.Name = "btnsuacv";
            this.btnsuacv.Size = new System.Drawing.Size(73, 68);
            this.btnsuacv.TabIndex = 18;
            this.btnsuacv.UseVisualStyleBackColor = true;
            this.btnsuacv.Click += new System.EventHandler(this.btnsuacv_Click);
            // 
            // btnxoacv
            // 
            this.btnxoacv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoacv.FlatAppearance.BorderSize = 0;
            this.btnxoacv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoacv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoacv.ForeColor = System.Drawing.Color.Tomato;
            this.btnxoacv.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnxoa;
            this.btnxoacv.Location = new System.Drawing.Point(93, 95);
            this.btnxoacv.Name = "btnxoacv";
            this.btnxoacv.Size = new System.Drawing.Size(98, 68);
            this.btnxoacv.TabIndex = 19;
            this.btnxoacv.UseVisualStyleBackColor = true;
            this.btnxoacv.Click += new System.EventHandler(this.btnxoacv_Click);
            // 
            // btnthemcv
            // 
            this.btnthemcv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthemcv.FlatAppearance.BorderSize = 0;
            this.btnthemcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemcv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemcv.ForeColor = System.Drawing.Color.Tomato;
            this.btnthemcv.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthem;
            this.btnthemcv.Location = new System.Drawing.Point(16, 95);
            this.btnthemcv.Name = "btnthemcv";
            this.btnthemcv.Size = new System.Drawing.Size(71, 68);
            this.btnthemcv.TabIndex = 20;
            this.btnthemcv.UseVisualStyleBackColor = true;
            this.btnthemcv.Click += new System.EventHandler(this.btnthemcv_Click);
            // 
            // dgchucvu
            // 
            this.dgchucvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgchucvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgchucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgchucvu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgchucvu.Location = new System.Drawing.Point(7, 169);
            this.dgchucvu.Name = "dgchucvu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgchucvu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgchucvu.RowHeadersWidth = 51;
            this.dgchucvu.RowTemplate.Height = 24;
            this.dgchucvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgchucvu.Size = new System.Drawing.Size(329, 226);
            this.dgchucvu.TabIndex = 3;
            this.dgchucvu.Click += new System.EventHandler(this.dgchucvu_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã chức vụ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên chức vụ:";
            // 
            // txttencv
            // 
            this.txttencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Location = new System.Drawing.Point(112, 67);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(224, 22);
            this.txttencv.TabIndex = 5;
            this.txttencv.TextChanged += new System.EventHandler(this.txttencv_TextChanged);
            // 
            // txtmacv
            // 
            this.txtmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Location = new System.Drawing.Point(112, 23);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(224, 22);
            this.txtmacv.TabIndex = 5;
            this.txtmacv.TextChanged += new System.EventHandler(this.txtmacv_TextChanged);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1175, 627);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgnhanvien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grgt.ResumeLayout(false);
            this.grgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgnhanvien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgchucvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkadmin;
        private System.Windows.Forms.DateTimePicker datevaolam;
        private System.Windows.Forms.GroupBox grgt;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.DataGridView dgnhanvien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlammoi2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lammoiban;
        private System.Windows.Forms.Button btnsuaban;
        private System.Windows.Forms.Button btnxoaban;
        private System.Windows.Forms.Button btnthemban;
        private System.Windows.Forms.DataGridView dgban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttenban;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.CheckBox chkql;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnlammoicv;
        private System.Windows.Forms.Button btnsuacv;
        private System.Windows.Forms.Button btnxoacv;
        private System.Windows.Forms.Button btnthemcv;
        private System.Windows.Forms.DataGridView dgchucvu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.TextBox txtmacv;
    }
}