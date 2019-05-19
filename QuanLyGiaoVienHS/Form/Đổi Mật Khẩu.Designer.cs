namespace QuanLyGiaoVienHS
{
    partial class Đổi_Mật_Khẩu
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
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btThoatDoiMK = new System.Windows.Forms.Button();
            this.btXacNhanMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(170, 13);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(229, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(170, 160);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(229, 20);
            this.txtXacNhanMK.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu Cũ";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(170, 60);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(229, 20);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(170, 112);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(229, 20);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // btThoatDoiMK
            // 
            this.btThoatDoiMK.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btThoatDoiMK.Location = new System.Drawing.Point(278, 219);
            this.btThoatDoiMK.Name = "btThoatDoiMK";
            this.btThoatDoiMK.Size = new System.Drawing.Size(75, 43);
            this.btThoatDoiMK.TabIndex = 2;
            this.btThoatDoiMK.Text = "Thoát";
            this.btThoatDoiMK.UseVisualStyleBackColor = true;
            this.btThoatDoiMK.Click += new System.EventHandler(this.btThoatDoiMK_Click);
            // 
            // btXacNhanMK
            // 
            this.btXacNhanMK.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btXacNhanMK.Location = new System.Drawing.Point(162, 219);
            this.btXacNhanMK.Name = "btXacNhanMK";
            this.btXacNhanMK.Size = new System.Drawing.Size(75, 43);
            this.btXacNhanMK.TabIndex = 2;
            this.btXacNhanMK.Text = "Xác Nhận";
            this.btXacNhanMK.UseVisualStyleBackColor = true;
            this.btXacNhanMK.Click += new System.EventHandler(this.btXacNhanMK_Click);
            // 
            // Đổi_Mật_Khẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 308);
            this.Controls.Add(this.btThoatDoiMK);
            this.Controls.Add(this.btXacNhanMK);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "Đổi_Mật_Khẩu";
            this.Text = "Đổi_Mật_Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Button btXacNhanMK;
        private System.Windows.Forms.Button btThoatDoiMK;
    }
}