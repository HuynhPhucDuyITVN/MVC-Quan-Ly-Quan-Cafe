
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.lbltenban = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.lsvchitiet = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lbldiemtl = new System.Windows.Forms.Label();
            this.btninhd = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thanh Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(337, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tổng tiền:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.ForeColor = System.Drawing.Color.Red;
            this.lbltongtien.Location = new System.Drawing.Point(40, 150);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(27, 29);
            this.lbltongtien.TabIndex = 22;
            this.lbltongtien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(337, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 90);
            this.label9.TabIndex = 22;
            this.label9.Text = "*Ghi chú:\r\n-Cách tích lũy điểm:\r\n=> 10.000 VNĐ = 1 điểm\r\n*Trên 50 điểm sẽ được th" +
    "ăng cấp lên khách hàng thường xuyên\r\n*Trên 100 điểm sẽ được thăng cấp lên thành " +
    "viên vip*\r\n\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(335, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Giảm giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(423, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Enabled = false;
            this.txtgiamgia.ForeColor = System.Drawing.Color.White;
            this.txtgiamgia.Location = new System.Drawing.Point(340, 157);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.ReadOnly = true;
            this.txtgiamgia.Size = new System.Drawing.Size(77, 22);
            this.txtgiamgia.TabIndex = 25;
            this.txtgiamgia.Text = "0";
            // 
            // lbltenban
            // 
            this.lbltenban.AutoSize = true;
            this.lbltenban.ForeColor = System.Drawing.Color.White;
            this.lbltenban.Location = new System.Drawing.Point(116, 57);
            this.lbltenban.Name = "lbltenban";
            this.lbltenban.Size = new System.Drawing.Size(61, 17);
            this.lbltenban.TabIndex = 22;
            this.lbltenban.Text = "Tên bàn";
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.ForeColor = System.Drawing.Color.White;
            this.lblmakh.Location = new System.Drawing.Point(157, 83);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(20, 17);
            this.lblmakh.TabIndex = 22;
            this.lblmakh.Text = "...";
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.ForeColor = System.Drawing.Color.White;
            this.lbmahd.Location = new System.Drawing.Point(439, 57);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(20, 17);
            this.lbmahd.TabIndex = 22;
            this.lbmahd.Text = "...";
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.ForeColor = System.Drawing.Color.White;
            this.lbmanv.Location = new System.Drawing.Point(439, 83);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(20, 17);
            this.lbmanv.TabIndex = 22;
            this.lbmanv.Text = "...";
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
            this.lsvchitiet.Location = new System.Drawing.Point(12, 295);
            this.lsvchitiet.Name = "lsvchitiet";
            this.lsvchitiet.Size = new System.Drawing.Size(714, 251);
            this.lsvchitiet.TabIndex = 26;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(489, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Điểm tích lũy:";
            // 
            // lbldiemtl
            // 
            this.lbldiemtl.AutoSize = true;
            this.lbldiemtl.ForeColor = System.Drawing.Color.White;
            this.lbldiemtl.Location = new System.Drawing.Point(587, 57);
            this.lbldiemtl.Name = "lbldiemtl";
            this.lbldiemtl.Size = new System.Drawing.Size(20, 17);
            this.lbldiemtl.TabIndex = 22;
            this.lbldiemtl.Text = "...";
            // 
            // btninhd
            // 
            this.btninhd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btninhd.FlatAppearance.BorderSize = 0;
            this.btninhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninhd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninhd.ForeColor = System.Drawing.Color.Tomato;
            this.btninhd.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.inhd;
            this.btninhd.Location = new System.Drawing.Point(499, 112);
            this.btninhd.Name = "btninhd";
            this.btninhd.Size = new System.Drawing.Size(189, 107);
            this.btninhd.TabIndex = 28;
            this.btninhd.UseVisualStyleBackColor = true;
            this.btninhd.Click += new System.EventHandler(this.btninhd_Click);
            // 
            // btntt
            // 
            this.btntt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntt.FlatAppearance.BorderSize = 0;
            this.btntt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.ForeColor = System.Drawing.Color.Tomato;
            this.btntt.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.icontinhtien;
            this.btntt.Location = new System.Drawing.Point(76, 182);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(189, 107);
            this.btntt.TabIndex = 27;
            this.btntt.UseVisualStyleBackColor = true;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(738, 558);
            this.Controls.Add(this.btninhd);
            this.Controls.Add(this.btntt);
            this.Controls.Add(this.lsvchitiet);
            this.Controls.Add(this.txtgiamgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldiemtl);
            this.Controls.Add(this.lbmanv);
            this.Controls.Add(this.lbmahd);
            this.Controls.Add(this.lblmakh);
            this.Controls.Add(this.lbltenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.Label lbltenban;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.ListView lsvchitiet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldiemtl;
        private System.Windows.Forms.Button btninhd;
    }
}