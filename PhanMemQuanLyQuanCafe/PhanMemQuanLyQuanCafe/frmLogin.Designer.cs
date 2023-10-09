
namespace PhanMemQuanLyQuanCafe
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblhien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.buttonesc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblhien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 165);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(304, 43);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(121, 64);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblhien
            // 
            this.lblhien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblhien.AutoSize = true;
            this.lblhien.ForeColor = System.Drawing.Color.White;
            this.lblhien.Location = new System.Drawing.Point(177, 129);
            this.lblhien.Name = "lblhien";
            this.lblhien.Size = new System.Drawing.Size(99, 17);
            this.lblhien.TabIndex = 22;
            this.lblhien.Text = "Hiện mật khẩu";
            this.lblhien.Click += new System.EventHandler(this.lblhien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(12, 95);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(264, 22);
            this.txtmk.TabIndex = 1;
            this.txtmk.Text = "abc123";
            this.txtmk.TextChanged += new System.EventHandler(this.txtmk_TextChanged);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(12, 35);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(264, 22);
            this.txtmanv.TabIndex = 1;
            this.txtmanv.Text = "nv001";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.buttonesc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 353);
            this.panel2.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PhanMemQuanLyQuanCafe.Properties.Resources.logochinh1;
            this.picLogo.Location = new System.Drawing.Point(80, 81);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(270, 197);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 19;
            this.picLogo.TabStop = false;
            // 
            // buttonesc
            // 
            this.buttonesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.buttonesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonesc.ForeColor = System.Drawing.Color.White;
            this.buttonesc.Location = new System.Drawing.Point(400, 0);
            this.buttonesc.Name = "buttonesc";
            this.buttonesc.Size = new System.Drawing.Size(37, 30);
            this.buttonesc.TabIndex = 18;
            this.buttonesc.Text = "X";
            this.buttonesc.UseVisualStyleBackColor = false;
            this.buttonesc.Click += new System.EventHandler(this.buttonesc_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(437, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblhien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button buttonesc;
        private System.Windows.Forms.Button btnLogin;
    }
}

