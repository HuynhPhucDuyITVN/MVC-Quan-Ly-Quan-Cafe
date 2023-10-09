
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmHangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlammoi2 = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txttenlh = new System.Windows.Forms.TextBox();
            this.txtmalh = new System.Windows.Forms.TextBox();
            this.btncapnhatlh = new System.Windows.Forms.Button();
            this.btnxoalh = new System.Windows.Forms.Button();
            this.btnthemlh = new System.Windows.Forms.Button();
            this.dgloaihang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbloaihang = new System.Windows.Forms.ComboBox();
            this.btnlammoihh = new System.Windows.Forms.Button();
            this.dghanghoa = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaihang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnlammoi2);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txttenlh);
            this.groupBox1.Controls.Add(this.txtmalh);
            this.groupBox1.Controls.Add(this.btncapnhatlh);
            this.groupBox1.Controls.Add(this.btnxoalh);
            this.groupBox1.Controls.Add(this.btnthemlh);
            this.groupBox1.Controls.Add(this.dgloaihang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Hàng";
            // 
            // btnlammoi2
            // 
            this.btnlammoi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlammoi2.FlatAppearance.BorderSize = 0;
            this.btnlammoi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoi2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi2.ForeColor = System.Drawing.Color.Tomato;
            this.btnlammoi2.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnrefesh;
            this.btnlammoi2.Location = new System.Drawing.Point(315, 167);
            this.btnlammoi2.Name = "btnlammoi2";
            this.btnlammoi2.Size = new System.Drawing.Size(43, 36);
            this.btnlammoi2.TabIndex = 16;
            this.btnlammoi2.UseVisualStyleBackColor = true;
            this.btnlammoi2.Click += new System.EventHandler(this.btnlammoi2_Click);
            // 
            // txtmota
            // 
            this.txtmota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmota.Location = new System.Drawing.Point(145, 106);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(198, 22);
            this.txtmota.TabIndex = 21;
            this.txtmota.TextChanged += new System.EventHandler(this.txtmota_TextChanged);
            // 
            // txttenlh
            // 
            this.txttenlh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenlh.Location = new System.Drawing.Point(145, 67);
            this.txttenlh.Name = "txttenlh";
            this.txttenlh.Size = new System.Drawing.Size(198, 22);
            this.txttenlh.TabIndex = 21;
            this.txttenlh.TextChanged += new System.EventHandler(this.txttenlh_TextChanged);
            // 
            // txtmalh
            // 
            this.txtmalh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmalh.Location = new System.Drawing.Point(145, 32);
            this.txtmalh.Name = "txtmalh";
            this.txtmalh.Size = new System.Drawing.Size(198, 22);
            this.txtmalh.TabIndex = 21;
            this.txtmalh.TextChanged += new System.EventHandler(this.txtmalh_TextChanged);
            // 
            // btncapnhatlh
            // 
            this.btncapnhatlh.FlatAppearance.BorderSize = 0;
            this.btncapnhatlh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhatlh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhatlh.ForeColor = System.Drawing.Color.Tomato;
            this.btncapnhatlh.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnsua;
            this.btncapnhatlh.Location = new System.Drawing.Point(206, 151);
            this.btncapnhatlh.Name = "btncapnhatlh";
            this.btncapnhatlh.Size = new System.Drawing.Size(73, 68);
            this.btncapnhatlh.TabIndex = 18;
            this.btncapnhatlh.UseVisualStyleBackColor = true;
            this.btncapnhatlh.Click += new System.EventHandler(this.btncapnhatlh_Click);
            // 
            // btnxoalh
            // 
            this.btnxoalh.FlatAppearance.BorderSize = 0;
            this.btnxoalh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoalh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoalh.ForeColor = System.Drawing.Color.Tomato;
            this.btnxoalh.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnxoa;
            this.btnxoalh.Location = new System.Drawing.Point(102, 151);
            this.btnxoalh.Name = "btnxoalh";
            this.btnxoalh.Size = new System.Drawing.Size(98, 68);
            this.btnxoalh.TabIndex = 19;
            this.btnxoalh.UseVisualStyleBackColor = true;
            this.btnxoalh.Click += new System.EventHandler(this.btnxoalh_Click);
            // 
            // btnthemlh
            // 
            this.btnthemlh.FlatAppearance.BorderSize = 0;
            this.btnthemlh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemlh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemlh.ForeColor = System.Drawing.Color.Tomato;
            this.btnthemlh.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthem;
            this.btnthemlh.Location = new System.Drawing.Point(25, 151);
            this.btnthemlh.Name = "btnthemlh";
            this.btnthemlh.Size = new System.Drawing.Size(71, 68);
            this.btnthemlh.TabIndex = 20;
            this.btnthemlh.UseVisualStyleBackColor = true;
            this.btnthemlh.Click += new System.EventHandler(this.btnthemlh_Click);
            // 
            // dgloaihang
            // 
            this.dgloaihang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgloaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgloaihang.Location = new System.Drawing.Point(6, 225);
            this.dgloaihang.Name = "dgloaihang";
            this.dgloaihang.RowHeadersWidth = 51;
            this.dgloaihang.RowTemplate.Height = 24;
            this.dgloaihang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgloaihang.Size = new System.Drawing.Size(352, 301);
            this.dgloaihang.TabIndex = 1;
            this.dgloaihang.Click += new System.EventHandler(this.dgloaihang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.cbloaihang);
            this.groupBox2.Controls.Add(this.btnlammoihh);
            this.groupBox2.Controls.Add(this.dghanghoa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtgia);
            this.groupBox2.Controls.Add(this.txttenhh);
            this.groupBox2.Controls.Add(this.txtmahh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(376, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 532);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàng Hóa";
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Tomato;
            this.btnsua.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnsua;
            this.btnsua.Location = new System.Drawing.Point(511, 157);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(73, 68);
            this.btnsua.TabIndex = 23;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Tomato;
            this.btnxoa.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnxoa;
            this.btnxoa.Location = new System.Drawing.Point(498, 83);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 68);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Tomato;
            this.btnthem.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnthem;
            this.btnthem.Location = new System.Drawing.Point(511, 9);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 68);
            this.btnthem.TabIndex = 25;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbloaihang
            // 
            this.cbloaihang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbloaihang.FormattingEnabled = true;
            this.cbloaihang.Location = new System.Drawing.Point(123, 30);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(349, 24);
            this.cbloaihang.TabIndex = 22;
            // 
            // btnlammoihh
            // 
            this.btnlammoihh.FlatAppearance.BorderSize = 0;
            this.btnlammoihh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoihh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoihh.ForeColor = System.Drawing.Color.Tomato;
            this.btnlammoihh.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.btnrefesh;
            this.btnlammoihh.Location = new System.Drawing.Point(21, 180);
            this.btnlammoihh.Name = "btnlammoihh";
            this.btnlammoihh.Size = new System.Drawing.Size(43, 36);
            this.btnlammoihh.TabIndex = 16;
            this.btnlammoihh.UseVisualStyleBackColor = true;
            this.btnlammoihh.Click += new System.EventHandler(this.btnlammoihh_Click);
            // 
            // dghanghoa
            // 
            this.dghanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dghanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghanghoa.Location = new System.Drawing.Point(6, 226);
            this.dghanghoa.Name = "dghanghoa";
            this.dghanghoa.RowHeadersWidth = 51;
            this.dghanghoa.RowTemplate.Height = 24;
            this.dghanghoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dghanghoa.Size = new System.Drawing.Size(586, 300);
            this.dghanghoa.TabIndex = 0;
            this.dghanghoa.Click += new System.EventHandler(this.dghanghoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá:";
            // 
            // txtgia
            // 
            this.txtgia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgia.Location = new System.Drawing.Point(123, 148);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(349, 22);
            this.txtgia.TabIndex = 21;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            // 
            // txttenhh
            // 
            this.txttenhh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenhh.Location = new System.Drawing.Point(123, 107);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(349, 22);
            this.txttenhh.TabIndex = 21;
            this.txttenhh.TextChanged += new System.EventHandler(this.txttenhh_TextChanged);
            // 
            // txtmahh
            // 
            this.txtmahh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmahh.Location = new System.Drawing.Point(123, 68);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(349, 22);
            this.txtmahh.TabIndex = 21;
            this.txtmahh.TextChanged += new System.EventHandler(this.txtmahh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên hàng hóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã hàng hóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên loại hàng:";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.SizeChanged += new System.EventHandler(this.frmHangHoa_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaihang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgloaihang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txttenlh;
        private System.Windows.Forms.TextBox txtmalh;
        private System.Windows.Forms.Button btncapnhatlh;
        private System.Windows.Forms.Button btnxoalh;
        private System.Windows.Forms.Button btnthemlh;
        private System.Windows.Forms.Button btnlammoi2;
        private System.Windows.Forms.Button btnlammoihh;
        private System.Windows.Forms.DataGridView dghanghoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbloaihang;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ErrorProvider error1;
    }
}