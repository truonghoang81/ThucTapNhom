namespace QuanLyGiaoVienHS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hócinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuRiêngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợIupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHợpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.kiểmTraToolStripMenuItem,
            this.trợIupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáoViênToolStripMenuItem,
            this.hócinhToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.giáoViênToolStripMenuItem.Text = "Giáo Viên";
            this.giáoViênToolStripMenuItem.Click += new System.EventHandler(this.giáoViênToolStripMenuItem_Click);
            // 
            // hócinhToolStripMenuItem
            // 
            this.hócinhToolStripMenuItem.Name = "hócinhToolStripMenuItem";
            this.hócinhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.hócinhToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.hócinhToolStripMenuItem.Text = "Học Sinh";
            this.hócinhToolStripMenuItem.Click += new System.EventHandler(this.hócinhToolStripMenuItem_Click);
            // 
            // kiểmTraToolStripMenuItem
            // 
            this.kiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dữLiệuChungToolStripMenuItem,
            this.dữLiệuRiêngToolStripMenuItem});
            this.kiểmTraToolStripMenuItem.Name = "kiểmTraToolStripMenuItem";
            this.kiểmTraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.kiểmTraToolStripMenuItem.Text = "Kiểm Tra";
            // 
            // dữLiệuChungToolStripMenuItem
            // 
            this.dữLiệuChungToolStripMenuItem.Name = "dữLiệuChungToolStripMenuItem";
            this.dữLiệuChungToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.dữLiệuChungToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dữLiệuChungToolStripMenuItem.Text = "Dữ Liệu Chung";
            this.dữLiệuChungToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuChungToolStripMenuItem_Click);
            // 
            // dữLiệuRiêngToolStripMenuItem
            // 
            this.dữLiệuRiêngToolStripMenuItem.Name = "dữLiệuRiêngToolStripMenuItem";
            this.dữLiệuRiêngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.dữLiệuRiêngToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dữLiệuRiêngToolStripMenuItem.Text = "Dữ Liệu Riêng";
            this.dữLiệuRiêngToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuRiêngToolStripMenuItem_Click);
            // 
            // trợIupsToolStripMenuItem
            // 
            this.trợIupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huoToolStripMenuItem,
            this.tổngHợpToolStripMenuItem});
            this.trợIupsToolStripMenuItem.Name = "trợIupsToolStripMenuItem";
            this.trợIupsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợIupsToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // huoToolStripMenuItem
            // 
            this.huoToolStripMenuItem.Name = "huoToolStripMenuItem";
            this.huoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.huoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.huoToolStripMenuItem.Text = "Hướng Dẫn";
            this.huoToolStripMenuItem.Click += new System.EventHandler(this.huoToolStripMenuItem_Click);
            // 
            // tổngHợpToolStripMenuItem
            // 
            this.tổngHợpToolStripMenuItem.Name = "tổngHợpToolStripMenuItem";
            this.tổngHợpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tổngHợpToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tổngHợpToolStripMenuItem.Text = "Tổng Hợp";
            this.tổngHợpToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyGiaoVienHS.Properties.Resources.IMG_3518;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 474);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hócinhToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợIupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuRiêngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpToolStripMenuItem;

    }
}

