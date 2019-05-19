namespace QuanLyGiaoVienHS
{
    partial class GiaoVien
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
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVuMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoMonMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbGhuChuGV = new System.Windows.Forms.RichTextBox();
            this.ptbAnhGV = new System.Windows.Forms.PictureBox();
            this.cbbKyLuatGV = new System.Windows.Forms.ComboBox();
            this.cbbKhenThuongGV = new System.Windows.Forms.ComboBox();
            this.cbbLopGiangDay = new System.Windows.Forms.ComboBox();
            this.cbbChucVuGV = new System.Windows.Forms.ComboBox();
            this.cbbBoMon = new System.Windows.Forms.ComboBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dtpGiaoVien = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.txtSoTietDay = new System.Windows.Forms.TextBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTimKiemGV = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.txtSoGVNu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoGVNam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongSoGV = new System.Windows.Forms.TextBox();
            this.btThoatGV = new System.Windows.Forms.Button();
            this.btHuyGV = new System.Windows.Forms.Button();
            this.btLuuGV = new System.Windows.Forms.Button();
            this.btXoaGV = new System.Windows.Forms.Button();
            this.btSuaGV = new System.Windows.Forms.Button();
            this.bttThemGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Giáo Viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.Luong,
            this.SoTietDay,
            this.ghichu,
            this.LopMa,
            this.ChucVuMa,
            this.BoMonMa,
            this.KTMa,
            this.KLMa});
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 41);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(361, 377);
            this.dgvGiaoVien.TabIndex = 1;
            this.dgvGiaoVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_RowEnter);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngay Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // SoTietDay
            // 
            this.SoTietDay.DataPropertyName = "SoTietDay";
            this.SoTietDay.HeaderText = "Số Tiết Dạy";
            this.SoTietDay.Name = "SoTietDay";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            // 
            // LopMa
            // 
            this.LopMa.DataPropertyName = "LopMa";
            this.LopMa.HeaderText = "Lớp";
            this.LopMa.Name = "LopMa";
            // 
            // ChucVuMa
            // 
            this.ChucVuMa.DataPropertyName = "ChucVuMa";
            this.ChucVuMa.HeaderText = "Chức Vụ";
            this.ChucVuMa.Name = "ChucVuMa";
            // 
            // BoMonMa
            // 
            this.BoMonMa.DataPropertyName = "BoMonMa";
            this.BoMonMa.HeaderText = "Bộ Môn";
            this.BoMonMa.Name = "BoMonMa";
            // 
            // KTMa
            // 
            this.KTMa.DataPropertyName = "KTMa";
            this.KTMa.HeaderText = "Khen Thưởng";
            this.KTMa.Name = "KTMa";
            // 
            // KLMa
            // 
            this.KLMa.DataPropertyName = "KLMa";
            this.KLMa.HeaderText = "Kỷ Luật";
            this.KLMa.Name = "KLMa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGhuChuGV);
            this.groupBox1.Controls.Add(this.ptbAnhGV);
            this.groupBox1.Controls.Add(this.cbbKyLuatGV);
            this.groupBox1.Controls.Add(this.cbbKhenThuongGV);
            this.groupBox1.Controls.Add(this.cbbLopGiangDay);
            this.groupBox1.Controls.Add(this.cbbChucVuGV);
            this.groupBox1.Controls.Add(this.cbbBoMon);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.dtpGiaoVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.txtSoTietDay);
            this.groupBox1.Controls.Add(this.txtDiaChiGV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtSDTGV);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTenGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(370, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 377);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // rtbGhuChuGV
            // 
            this.rtbGhuChuGV.Location = new System.Drawing.Point(388, 9);
            this.rtbGhuChuGV.Name = "rtbGhuChuGV";
            this.rtbGhuChuGV.Size = new System.Drawing.Size(130, 93);
            this.rtbGhuChuGV.TabIndex = 6;
            this.rtbGhuChuGV.Text = "";
            // 
            // ptbAnhGV
            // 
            this.ptbAnhGV.Location = new System.Drawing.Point(524, 9);
            this.ptbAnhGV.Name = "ptbAnhGV";
            this.ptbAnhGV.Size = new System.Drawing.Size(118, 137);
            this.ptbAnhGV.TabIndex = 5;
            this.ptbAnhGV.TabStop = false;
            // 
            // cbbKyLuatGV
            // 
            this.cbbKyLuatGV.FormattingEnabled = true;
            this.cbbKyLuatGV.Location = new System.Drawing.Point(445, 319);
            this.cbbKyLuatGV.Name = "cbbKyLuatGV";
            this.cbbKyLuatGV.Size = new System.Drawing.Size(197, 21);
            this.cbbKyLuatGV.TabIndex = 4;
            // 
            // cbbKhenThuongGV
            // 
            this.cbbKhenThuongGV.FormattingEnabled = true;
            this.cbbKhenThuongGV.Location = new System.Drawing.Point(445, 281);
            this.cbbKhenThuongGV.Name = "cbbKhenThuongGV";
            this.cbbKhenThuongGV.Size = new System.Drawing.Size(197, 21);
            this.cbbKhenThuongGV.TabIndex = 4;
            // 
            // cbbLopGiangDay
            // 
            this.cbbLopGiangDay.FormattingEnabled = true;
            this.cbbLopGiangDay.Location = new System.Drawing.Point(445, 245);
            this.cbbLopGiangDay.Name = "cbbLopGiangDay";
            this.cbbLopGiangDay.Size = new System.Drawing.Size(197, 21);
            this.cbbLopGiangDay.TabIndex = 4;
            // 
            // cbbChucVuGV
            // 
            this.cbbChucVuGV.FormattingEnabled = true;
            this.cbbChucVuGV.Location = new System.Drawing.Point(445, 165);
            this.cbbChucVuGV.Name = "cbbChucVuGV";
            this.cbbChucVuGV.Size = new System.Drawing.Size(197, 21);
            this.cbbChucVuGV.TabIndex = 4;
            // 
            // cbbBoMon
            // 
            this.cbbBoMon.FormattingEnabled = true;
            this.cbbBoMon.Location = new System.Drawing.Point(445, 206);
            this.cbbBoMon.Name = "cbbBoMon";
            this.cbbBoMon.Size = new System.Drawing.Size(197, 21);
            this.cbbBoMon.TabIndex = 4;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(186, 149);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nu";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(100, 147);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dtpGiaoVien
            // 
            this.dtpGiaoVien.Location = new System.Drawing.Point(100, 112);
            this.dtpGiaoVien.Name = "dtpGiaoVien";
            this.dtpGiaoVien.Size = new System.Drawing.Size(200, 20);
            this.dtpGiaoVien.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gioi Tính";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(354, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Kỷ Luật";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Sinh";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Khen thưởng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(351, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Chức Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp Giảng Dạy";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(351, 206);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(44, 13);
            this.c.TabIndex = 0;
            this.c.Text = "Bộ Môn";
            // 
            // txtSoTietDay
            // 
            this.txtSoTietDay.Location = new System.Drawing.Point(103, 327);
            this.txtSoTietDay.Name = "txtSoTietDay";
            this.txtSoTietDay.Size = new System.Drawing.Size(197, 20);
            this.txtSoTietDay.TabIndex = 1;
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(100, 235);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(197, 20);
            this.txtDiaChiGV.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số Tiết Dạy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(103, 281);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(197, 20);
            this.txtLuong.TabIndex = 1;
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(100, 189);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(197, 20);
            this.txtSDTGV.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lương";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ghi Chu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện Thoại";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(100, 67);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(197, 20);
            this.txtHoTenGV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ho Tên Giáo Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(100, 27);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(197, 20);
            this.txtMaGV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma Giáo Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTimKiemGV);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTimKiemGV);
            this.groupBox2.Controls.Add(this.txtSoGVNu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSoGVNam);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTongSoGV);
            this.groupBox2.Location = new System.Drawing.Point(3, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // btTimKiemGV
            // 
            this.btTimKiemGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btTimKiemGV.Location = new System.Drawing.Point(891, 12);
            this.btTimKiemGV.Name = "btTimKiemGV";
            this.btTimKiemGV.Size = new System.Drawing.Size(58, 26);
            this.btTimKiemGV.TabIndex = 4;
            this.btTimKiemGV.Text = "Tìm Kiếm";
            this.btTimKiemGV.UseVisualStyleBackColor = true;
            this.btTimKiemGV.Click += new System.EventHandler(this.btTimKiemGV_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(516, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nu";
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Location = new System.Drawing.Point(719, 12);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(166, 20);
            this.txtTimKiemGV.TabIndex = 1;
            // 
            // txtSoGVNu
            // 
            this.txtSoGVNu.Location = new System.Drawing.Point(543, 16);
            this.txtSoGVNu.Name = "txtSoGVNu";
            this.txtSoGVNu.Size = new System.Drawing.Size(64, 20);
            this.txtSoGVNu.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nam";
            // 
            // txtSoGVNam
            // 
            this.txtSoGVNam.Location = new System.Drawing.Point(343, 16);
            this.txtSoGVNam.Name = "txtSoGVNam";
            this.txtSoGVNam.Size = new System.Drawing.Size(64, 20);
            this.txtSoGVNam.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tong Số";
            // 
            // txtTongSoGV
            // 
            this.txtTongSoGV.Location = new System.Drawing.Point(122, 16);
            this.txtTongSoGV.Name = "txtTongSoGV";
            this.txtTongSoGV.Size = new System.Drawing.Size(64, 20);
            this.txtTongSoGV.TabIndex = 1;
            this.txtTongSoGV.TextChanged += new System.EventHandler(this.txtTongSoGV_TextChanged);
            // 
            // btThoatGV
            // 
            this.btThoatGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btThoatGV.Location = new System.Drawing.Point(758, 474);
            this.btThoatGV.Name = "btThoatGV";
            this.btThoatGV.Size = new System.Drawing.Size(75, 38);
            this.btThoatGV.TabIndex = 4;
            this.btThoatGV.Text = "Thoát";
            this.btThoatGV.UseVisualStyleBackColor = true;
            this.btThoatGV.Click += new System.EventHandler(this.btThoatGV_Click);
            // 
            // btHuyGV
            // 
            this.btHuyGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyGV.Location = new System.Drawing.Point(632, 474);
            this.btHuyGV.Name = "btHuyGV";
            this.btHuyGV.Size = new System.Drawing.Size(75, 38);
            this.btHuyGV.TabIndex = 4;
            this.btHuyGV.Text = "Hủy";
            this.btHuyGV.UseVisualStyleBackColor = true;
            this.btHuyGV.Click += new System.EventHandler(this.btHuyGV_Click);
            // 
            // btLuuGV
            // 
            this.btLuuGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuGV.Location = new System.Drawing.Point(508, 474);
            this.btLuuGV.Name = "btLuuGV";
            this.btLuuGV.Size = new System.Drawing.Size(75, 38);
            this.btLuuGV.TabIndex = 4;
            this.btLuuGV.Text = "Luu";
            this.btLuuGV.UseVisualStyleBackColor = true;
            this.btLuuGV.Click += new System.EventHandler(this.btLuuGV_Click);
            // 
            // btXoaGV
            // 
            this.btXoaGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaGV.Location = new System.Drawing.Point(380, 474);
            this.btXoaGV.Name = "btXoaGV";
            this.btXoaGV.Size = new System.Drawing.Size(75, 38);
            this.btXoaGV.TabIndex = 4;
            this.btXoaGV.Text = "Xoa";
            this.btXoaGV.UseVisualStyleBackColor = true;
            this.btXoaGV.Click += new System.EventHandler(this.btXoaGV_Click);
            // 
            // btSuaGV
            // 
            this.btSuaGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaGV.Location = new System.Drawing.Point(256, 474);
            this.btSuaGV.Name = "btSuaGV";
            this.btSuaGV.Size = new System.Drawing.Size(75, 38);
            this.btSuaGV.TabIndex = 4;
            this.btSuaGV.Text = "Sửa";
            this.btSuaGV.UseVisualStyleBackColor = true;
            this.btSuaGV.Click += new System.EventHandler(this.btSuaGV_Click);
            // 
            // bttThemGV
            // 
            this.bttThemGV.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.bttThemGV.Location = new System.Drawing.Point(130, 474);
            this.bttThemGV.Name = "bttThemGV";
            this.bttThemGV.Size = new System.Drawing.Size(75, 38);
            this.bttThemGV.TabIndex = 4;
            this.bttThemGV.Text = "Thêm";
            this.bttThemGV.UseVisualStyleBackColor = true;
            this.bttThemGV.Click += new System.EventHandler(this.bttThemGV_Click);
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 513);
            this.Controls.Add(this.btThoatGV);
            this.Controls.Add(this.btHuyGV);
            this.Controls.Add(this.btLuuGV);
            this.Controls.Add(this.btXoaGV);
            this.Controls.Add(this.btSuaGV);
            this.Controls.Add(this.bttThemGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "GiaoVien";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GiaoVien_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbAnhGV;
        private System.Windows.Forms.ComboBox cbbLopGiangDay;
        private System.Windows.Forms.ComboBox cbbBoMon;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpGiaoVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoGVNu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoGVNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongSoGV;
        private System.Windows.Forms.Button bttThemGV;
        private System.Windows.Forms.Button btSuaGV;
        private System.Windows.Forms.Button btXoaGV;
        private System.Windows.Forms.Button btLuuGV;
        private System.Windows.Forms.Button btHuyGV;
        private System.Windows.Forms.Button btThoatGV;
        private System.Windows.Forms.RichTextBox rtbGhuChuGV;
        private System.Windows.Forms.ComboBox cbbKyLuatGV;
        private System.Windows.Forms.ComboBox cbbKhenThuongGV;
        private System.Windows.Forms.ComboBox cbbChucVuGV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSoTietDay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btTimKiemGV;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVuMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoMonMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLMa;
    }
}