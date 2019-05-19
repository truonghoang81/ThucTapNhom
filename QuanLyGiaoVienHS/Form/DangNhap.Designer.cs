namespace QuanLyGiaoVienHS
{
    partial class DangNhap
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
            this.txtMatKhauDN = new System.Windows.Forms.TextBox();
            this.llbQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.btThoatDN = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu";
            // 
            // txtMatKhauDN
            // 
            this.txtMatKhauDN.Location = new System.Drawing.Point(141, 89);
            this.txtMatKhauDN.Name = "txtMatKhauDN";
            this.txtMatKhauDN.Size = new System.Drawing.Size(230, 20);
            this.txtMatKhauDN.TabIndex = 1;
            // 
            // llbQuenMatKhau
            // 
            this.llbQuenMatKhau.AutoSize = true;
            this.llbQuenMatKhau.Location = new System.Drawing.Point(180, 132);
            this.llbQuenMatKhau.Name = "llbQuenMatKhau";
            this.llbQuenMatKhau.Size = new System.Drawing.Size(82, 13);
            this.llbQuenMatKhau.TabIndex = 3;
            this.llbQuenMatKhau.TabStop = true;
            this.llbQuenMatKhau.Text = "Quên Mật Khẩu";
            this.llbQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQuenMatKhau_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(141, 43);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(230, 20);
            this.txtTenDN.TabIndex = 1;
            // 
            // btThoatDN
            // 
            this.btThoatDN.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btThoatDN.Location = new System.Drawing.Point(231, 192);
            this.btThoatDN.Name = "btThoatDN";
            this.btThoatDN.Size = new System.Drawing.Size(75, 39);
            this.btThoatDN.TabIndex = 2;
            this.btThoatDN.Text = "Thoát";
            this.btThoatDN.UseVisualStyleBackColor = true;
            this.btThoatDN.Click += new System.EventHandler(this.btThoatDN_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btDangNhap.Location = new System.Drawing.Point(108, 192);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 39);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 268);
            this.Controls.Add(this.llbQuenMatKhau);
            this.Controls.Add(this.btThoatDN);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhauDN);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauDN;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.LinkLabel llbQuenMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btThoatDN;
    }
}