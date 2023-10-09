
namespace PhanMemQuanLyQuanCafe.Forms
{
    partial class frmCaLam
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
            this.ngaylam = new System.Windows.Forms.DateTimePicker();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgluong = new System.Windows.Forms.DataGridView();
            this.bnttim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgluong)).BeginInit();
            this.SuspendLayout();
            // 
            // ngaylam
            // 
            this.ngaylam.Location = new System.Drawing.Point(3, 5);
            this.ngaylam.Name = "ngaylam";
            this.ngaylam.Size = new System.Drawing.Size(454, 22);
            this.ngaylam.TabIndex = 2;
            this.ngaylam.Value = new System.DateTime(2023, 5, 1, 15, 27, 0, 0);
            this.ngaylam.ValueChanged += new System.EventHandler(this.ngaylam_ValueChanged);
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(463, 4);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(216, 24);
            this.cbnhanvien.TabIndex = 28;
            this.cbnhanvien.SelectedIndexChanged += new System.EventHandler(this.cbnhanvien_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnttim);
            this.panel1.Controls.Add(this.cbnhanvien);
            this.panel1.Controls.Add(this.ngaylam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 31);
            this.panel1.TabIndex = 29;
            // 
            // dgluong
            // 
            this.dgluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgluong.Location = new System.Drawing.Point(0, 31);
            this.dgluong.Name = "dgluong";
            this.dgluong.RowHeadersWidth = 51;
            this.dgluong.RowTemplate.Height = 24;
            this.dgluong.Size = new System.Drawing.Size(763, 440);
            this.dgluong.TabIndex = 30;
            // 
            // bnttim
            // 
            this.bnttim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnttim.Location = new System.Drawing.Point(685, 5);
            this.bnttim.Name = "bnttim";
            this.bnttim.Size = new System.Drawing.Size(75, 23);
            this.bnttim.TabIndex = 29;
            this.bnttim.Text = "Tìm";
            this.bnttim.UseVisualStyleBackColor = true;
            this.bnttim.Click += new System.EventHandler(this.bnttim_Click);
            // 
            // frmCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 471);
            this.Controls.Add(this.dgluong);
            this.Controls.Add(this.panel1);
            this.Name = "frmCaLam";
            this.Text = "Ca Làm";
            this.Load += new System.EventHandler(this.frmCaLam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngaylam;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgluong;
        private System.Windows.Forms.Button bnttim;
    }
}