namespace QuanLyGiaoVienHS
{
    partial class TongHop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSXTiet = new System.Windows.Forms.RadioButton();
            this.rdbSXLuong = new System.Windows.Forms.RadioButton();
            this.rdbThongKeLuong = new System.Windows.Forms.RadioButton();
            this.rdbSXDiem = new System.Windows.Forms.RadioButton();
            this.rdbTopDiem = new System.Windows.Forms.RadioButton();
            this.rdbThongKeDiem = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.btThoatTongHop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbChucVu = new System.Windows.Forms.RadioButton();
            this.rdbBoMon = new System.Windows.Forms.RadioButton();
            this.rdbHanhKiem = new System.Windows.Forms.RadioButton();
            this.rdbHocLuc = new System.Windows.Forms.RadioButton();
            this.rdbKhenThuong = new System.Windows.Forms.RadioButton();
            this.rdbKyLuat = new System.Windows.Forms.RadioButton();
            this.btTruycapChung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdbThongKeLuong);
            this.groupBox1.Controls.Add(this.rdbSXLuong);
            this.groupBox1.Controls.Add(this.rdbSXTiet);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giáo Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rdbThongKeDiem);
            this.groupBox2.Controls.Add(this.rdbSXDiem);
            this.groupBox2.Controls.Add(this.rdbTopDiem);
            this.groupBox2.Location = new System.Drawing.Point(3, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 172);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Học Sinh";
            // 
            // rdbSXTiet
            // 
            this.rdbSXTiet.AutoSize = true;
            this.rdbSXTiet.Location = new System.Drawing.Point(36, 34);
            this.rdbSXTiet.Name = "rdbSXTiet";
            this.rdbSXTiet.Size = new System.Drawing.Size(164, 17);
            this.rdbSXTiet.TabIndex = 0;
            this.rdbSXTiet.TabStop = true;
            this.rdbSXTiet.Text = "Sắp Xếp Theo Số Lượng Tiết";
            this.rdbSXTiet.UseVisualStyleBackColor = true;
            // 
            // rdbSXLuong
            // 
            this.rdbSXLuong.AutoSize = true;
            this.rdbSXLuong.Location = new System.Drawing.Point(36, 68);
            this.rdbSXLuong.Name = "rdbSXLuong";
            this.rdbSXLuong.Size = new System.Drawing.Size(127, 17);
            this.rdbSXLuong.TabIndex = 0;
            this.rdbSXLuong.TabStop = true;
            this.rdbSXLuong.Text = "Sắp Xếp Theo Lương";
            this.rdbSXLuong.UseVisualStyleBackColor = true;
            // 
            // rdbThongKeLuong
            // 
            this.rdbThongKeLuong.AutoSize = true;
            this.rdbThongKeLuong.Location = new System.Drawing.Point(36, 106);
            this.rdbThongKeLuong.Name = "rdbThongKeLuong";
            this.rdbThongKeLuong.Size = new System.Drawing.Size(219, 17);
            this.rdbThongKeLuong.TabIndex = 0;
            this.rdbThongKeLuong.TabStop = true;
            this.rdbThongKeLuong.Text = "Thống Kê Lương Giáo Viên Toàn Trường";
            this.rdbThongKeLuong.UseVisualStyleBackColor = true;
            // 
            // rdbSXDiem
            // 
            this.rdbSXDiem.AutoSize = true;
            this.rdbSXDiem.Location = new System.Drawing.Point(36, 32);
            this.rdbSXDiem.Name = "rdbSXDiem";
            this.rdbSXDiem.Size = new System.Drawing.Size(168, 17);
            this.rdbSXDiem.TabIndex = 0;
            this.rdbSXDiem.TabStop = true;
            this.rdbSXDiem.Text = "Sắp Xếp Học Sinh Theo Điểm";
            this.rdbSXDiem.UseVisualStyleBackColor = true;
            // 
            // rdbTopDiem
            // 
            this.rdbTopDiem.AutoSize = true;
            this.rdbTopDiem.Location = new System.Drawing.Point(36, 73);
            this.rdbTopDiem.Name = "rdbTopDiem";
            this.rdbTopDiem.Size = new System.Drawing.Size(165, 17);
            this.rdbTopDiem.TabIndex = 0;
            this.rdbTopDiem.TabStop = true;
            this.rdbTopDiem.Text = "Tốp 5 Điểm Cao Nhất Trường";
            this.rdbTopDiem.UseVisualStyleBackColor = true;
            // 
            // rdbThongKeDiem
            // 
            this.rdbThongKeDiem.AutoSize = true;
            this.rdbThongKeDiem.Location = new System.Drawing.Point(36, 110);
            this.rdbThongKeDiem.Name = "rdbThongKeDiem";
            this.rdbThongKeDiem.Size = new System.Drawing.Size(157, 17);
            this.rdbThongKeDiem.TabIndex = 0;
            this.rdbThongKeDiem.TabStop = true;
            this.rdbThongKeDiem.Text = "Thống Kê Điểm của Trường";
            this.rdbThongKeDiem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.button2.Location = new System.Drawing.Point(268, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Truy Cập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.button1.Location = new System.Drawing.Point(268, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Truy Cập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(342, 3);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.Size = new System.Drawing.Size(421, 350);
            this.dgvTongHop.TabIndex = 3;
            // 
            // btThoatTongHop
            // 
            this.btThoatTongHop.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btThoatTongHop.Location = new System.Drawing.Point(688, 404);
            this.btThoatTongHop.Name = "btThoatTongHop";
            this.btThoatTongHop.Size = new System.Drawing.Size(65, 52);
            this.btThoatTongHop.TabIndex = 1;
            this.btThoatTongHop.Text = "Thoat";
            this.btThoatTongHop.UseVisualStyleBackColor = true;
            this.btThoatTongHop.Click += new System.EventHandler(this.btThoatTongHop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btTruycapChung);
            this.groupBox3.Controls.Add(this.rdbKyLuat);
            this.groupBox3.Controls.Add(this.rdbHanhKiem);
            this.groupBox3.Controls.Add(this.rdbKhenThuong);
            this.groupBox3.Controls.Add(this.rdbHocLuc);
            this.groupBox3.Controls.Add(this.rdbChucVu);
            this.groupBox3.Controls.Add(this.rdbBoMon);
            this.groupBox3.Location = new System.Drawing.Point(3, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chung";
            // 
            // rdbChucVu
            // 
            this.rdbChucVu.AutoSize = true;
            this.rdbChucVu.Location = new System.Drawing.Point(27, 70);
            this.rdbChucVu.Name = "rdbChucVu";
            this.rdbChucVu.Size = new System.Drawing.Size(66, 17);
            this.rdbChucVu.TabIndex = 0;
            this.rdbChucVu.TabStop = true;
            this.rdbChucVu.Text = "Chuc Vụ";
            this.rdbChucVu.UseVisualStyleBackColor = true;
            // 
            // rdbBoMon
            // 
            this.rdbBoMon.AutoSize = true;
            this.rdbBoMon.Location = new System.Drawing.Point(27, 29);
            this.rdbBoMon.Name = "rdbBoMon";
            this.rdbBoMon.Size = new System.Drawing.Size(62, 17);
            this.rdbBoMon.TabIndex = 0;
            this.rdbBoMon.TabStop = true;
            this.rdbBoMon.Text = "Bộ Môn";
            this.rdbBoMon.UseVisualStyleBackColor = true;
            // 
            // rdbHanhKiem
            // 
            this.rdbHanhKiem.AutoSize = true;
            this.rdbHanhKiem.Location = new System.Drawing.Point(27, 107);
            this.rdbHanhKiem.Name = "rdbHanhKiem";
            this.rdbHanhKiem.Size = new System.Drawing.Size(77, 17);
            this.rdbHanhKiem.TabIndex = 0;
            this.rdbHanhKiem.TabStop = true;
            this.rdbHanhKiem.Text = "Hạnh Kiểm";
            this.rdbHanhKiem.UseVisualStyleBackColor = true;
            // 
            // rdbHocLuc
            // 
            this.rdbHocLuc.AutoSize = true;
            this.rdbHocLuc.Location = new System.Drawing.Point(268, 29);
            this.rdbHocLuc.Name = "rdbHocLuc";
            this.rdbHocLuc.Size = new System.Drawing.Size(66, 17);
            this.rdbHocLuc.TabIndex = 0;
            this.rdbHocLuc.TabStop = true;
            this.rdbHocLuc.Text = "Học Lực";
            this.rdbHocLuc.UseVisualStyleBackColor = true;
            // 
            // rdbKhenThuong
            // 
            this.rdbKhenThuong.AutoSize = true;
            this.rdbKhenThuong.Location = new System.Drawing.Point(268, 70);
            this.rdbKhenThuong.Name = "rdbKhenThuong";
            this.rdbKhenThuong.Size = new System.Drawing.Size(90, 17);
            this.rdbKhenThuong.TabIndex = 0;
            this.rdbKhenThuong.TabStop = true;
            this.rdbKhenThuong.Text = "Khen Thưởng";
            this.rdbKhenThuong.UseVisualStyleBackColor = true;
            // 
            // rdbKyLuat
            // 
            this.rdbKyLuat.AutoSize = true;
            this.rdbKyLuat.Location = new System.Drawing.Point(268, 107);
            this.rdbKyLuat.Name = "rdbKyLuat";
            this.rdbKyLuat.Size = new System.Drawing.Size(61, 17);
            this.rdbKyLuat.TabIndex = 0;
            this.rdbKyLuat.TabStop = true;
            this.rdbKyLuat.Text = "Kỷ Luật";
            this.rdbKyLuat.UseVisualStyleBackColor = true;
            // 
            // btTruycapChung
            // 
            this.btTruycapChung.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btTruycapChung.Location = new System.Drawing.Point(514, 57);
            this.btTruycapChung.Name = "btTruycapChung";
            this.btTruycapChung.Size = new System.Drawing.Size(65, 46);
            this.btTruycapChung.TabIndex = 1;
            this.btTruycapChung.Text = "Truy Cập";
            this.btTruycapChung.UseVisualStyleBackColor = true;
            this.btTruycapChung.Click += new System.EventHandler(this.btTruyCapChung_Click);
            // 
            // TongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btThoatTongHop);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TongHop";
            this.Text = "TongHop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbThongKeLuong;
        private System.Windows.Forms.RadioButton rdbSXLuong;
        private System.Windows.Forms.RadioButton rdbSXTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbThongKeDiem;
        private System.Windows.Forms.RadioButton rdbSXDiem;
        private System.Windows.Forms.RadioButton rdbTopDiem;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Button btThoatTongHop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTruycapChung;
        private System.Windows.Forms.RadioButton rdbKyLuat;
        private System.Windows.Forms.RadioButton rdbHanhKiem;
        private System.Windows.Forms.RadioButton rdbKhenThuong;
        private System.Windows.Forms.RadioButton rdbHocLuc;
        private System.Windows.Forms.RadioButton rdbChucVu;
        private System.Windows.Forms.RadioButton rdbBoMon;
    }
}