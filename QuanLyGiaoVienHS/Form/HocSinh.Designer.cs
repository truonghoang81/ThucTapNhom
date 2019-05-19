namespace QuanLyGiaoVienHS
{
    partial class HocSinh
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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.rdbNuHS = new System.Windows.Forms.RadioButton();
            this.rdbNamHS = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinhHS = new System.Windows.Forms.DateTimePicker();
            this.cbbKyLuatHS = new System.Windows.Forms.ComboBox();
            this.cbbKhenThuongHS = new System.Windows.Forms.ComboBox();
            this.cbbHanhKiem = new System.Windows.Forms.ComboBox();
            this.cbbHocLuc = new System.Windows.Forms.ComboBox();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.txtTenMeHS = new System.Windows.Forms.TextBox();
            this.txtTenBoHS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChiHS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtHoTenHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemHS = new System.Windows.Forms.TextBox();
            this.txtSoNuHS = new System.Windows.Forms.TextBox();
            this.txtSoNamHS = new System.Windows.Forms.TextBox();
            this.txtSoLuongHS = new System.Windows.Forms.TextBox();
            this.btHuyHS = new System.Windows.Forms.Button();
            this.btSuaHS = new System.Windows.Forms.Button();
            this.btThoatHS = new System.Windows.Forms.Button();
            this.btLuuHS = new System.Windows.Forms.Button();
            this.btXoaHS = new System.Windows.Forms.Button();
            this.btThemHS = new System.Windows.Forms.Button();
            this.btTimKiemHS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHocMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLucMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiemMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KyLuatMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhenThuongMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.TenHS,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.TenBo,
            this.TenMe,
            this.DiemTB,
            this.LopHocMa,
            this.HocLucMa,
            this.HanhKiemMa,
            this.KyLuatMa,
            this.KhenThuongMa});
            this.dgvHocSinh.Location = new System.Drawing.Point(2, 45);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(305, 366);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGhiChu);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rdbNuHS);
            this.groupBox1.Controls.Add(this.rdbNamHS);
            this.groupBox1.Controls.Add(this.dtpNgaySinhHS);
            this.groupBox1.Controls.Add(this.cbbKyLuatHS);
            this.groupBox1.Controls.Add(this.cbbKhenThuongHS);
            this.groupBox1.Controls.Add(this.cbbHanhKiem);
            this.groupBox1.Controls.Add(this.cbbHocLuc);
            this.groupBox1.Controls.Add(this.cbbTenLop);
            this.groupBox1.Controls.Add(this.txtTenMeHS);
            this.groupBox1.Controls.Add(this.txtTenBoHS);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChiHS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtHoTenHS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(313, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ Sơ Học Sinh";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(423, 65);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(126, 58);
            this.rtbGhiChu.TabIndex = 6;
            this.rtbGhiChu.Text = "";
            // 
            // rdbNuHS
            // 
            this.rdbNuHS.AutoSize = true;
            this.rdbNuHS.Location = new System.Drawing.Point(198, 186);
            this.rdbNuHS.Name = "rdbNuHS";
            this.rdbNuHS.Size = new System.Drawing.Size(39, 17);
            this.rdbNuHS.TabIndex = 4;
            this.rdbNuHS.TabStop = true;
            this.rdbNuHS.Text = "Nu";
            this.rdbNuHS.UseVisualStyleBackColor = true;
            // 
            // rdbNamHS
            // 
            this.rdbNamHS.AutoSize = true;
            this.rdbNamHS.Location = new System.Drawing.Point(117, 186);
            this.rdbNamHS.Name = "rdbNamHS";
            this.rdbNamHS.Size = new System.Drawing.Size(47, 17);
            this.rdbNamHS.TabIndex = 4;
            this.rdbNamHS.TabStop = true;
            this.rdbNamHS.Text = "Nam";
            this.rdbNamHS.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinhHS
            // 
            this.dtpNgaySinhHS.Location = new System.Drawing.Point(117, 148);
            this.dtpNgaySinhHS.Name = "dtpNgaySinhHS";
            this.dtpNgaySinhHS.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinhHS.TabIndex = 3;
            // 
            // cbbKyLuatHS
            // 
            this.cbbKyLuatHS.FormattingEnabled = true;
            this.cbbKyLuatHS.Location = new System.Drawing.Point(442, 311);
            this.cbbKyLuatHS.Name = "cbbKyLuatHS";
            this.cbbKyLuatHS.Size = new System.Drawing.Size(200, 21);
            this.cbbKyLuatHS.TabIndex = 2;
            // 
            // cbbKhenThuongHS
            // 
            this.cbbKhenThuongHS.FormattingEnabled = true;
            this.cbbKhenThuongHS.Location = new System.Drawing.Point(442, 269);
            this.cbbKhenThuongHS.Name = "cbbKhenThuongHS";
            this.cbbKhenThuongHS.Size = new System.Drawing.Size(200, 21);
            this.cbbKhenThuongHS.TabIndex = 2;
            // 
            // cbbHanhKiem
            // 
            this.cbbHanhKiem.FormattingEnabled = true;
            this.cbbHanhKiem.Location = new System.Drawing.Point(442, 200);
            this.cbbHanhKiem.Name = "cbbHanhKiem";
            this.cbbHanhKiem.Size = new System.Drawing.Size(200, 21);
            this.cbbHanhKiem.TabIndex = 2;
            // 
            // cbbHocLuc
            // 
            this.cbbHocLuc.FormattingEnabled = true;
            this.cbbHocLuc.Location = new System.Drawing.Point(442, 232);
            this.cbbHocLuc.Name = "cbbHocLuc";
            this.cbbHocLuc.Size = new System.Drawing.Size(200, 21);
            this.cbbHocLuc.TabIndex = 2;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(117, 101);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(200, 21);
            this.cbbTenLop.TabIndex = 2;
            // 
            // txtTenMeHS
            // 
            this.txtTenMeHS.Location = new System.Drawing.Point(117, 293);
            this.txtTenMeHS.Name = "txtTenMeHS";
            this.txtTenMeHS.Size = new System.Drawing.Size(200, 20);
            this.txtTenMeHS.TabIndex = 1;
            // 
            // txtTenBoHS
            // 
            this.txtTenBoHS.Location = new System.Drawing.Point(117, 258);
            this.txtTenBoHS.Name = "txtTenBoHS";
            this.txtTenBoHS.Size = new System.Drawing.Size(200, 20);
            this.txtTenBoHS.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ Tên Mẹ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(442, 163);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 1;
            // 
            // txtDiaChiHS
            // 
            this.txtDiaChiHS.Location = new System.Drawing.Point(117, 219);
            this.txtDiaChiHS.Name = "txtDiaChiHS";
            this.txtDiaChiHS.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChiHS.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Họ Tên Bố";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(117, 333);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(200, 20);
            this.txtDiem.TabIndex = 1;
            // 
            // txtHoTenHS
            // 
            this.txtHoTenHS.Location = new System.Drawing.Point(117, 62);
            this.txtHoTenHS.Name = "txtHoTenHS";
            this.txtHoTenHS.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenHS.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ghi Chú";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(377, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kỷ Luật";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(362, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "So Dien Thoai";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Khen Thưởng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(362, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Hạnh Kiểm";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(117, 24);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(200, 20);
            this.txtMaHS.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Điểm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Học Lực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Học Sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btTimKiemHS);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTimKiemHS);
            this.groupBox2.Controls.Add(this.txtSoNuHS);
            this.groupBox2.Controls.Add(this.txtSoNamHS);
            this.groupBox2.Controls.Add(this.txtSoLuongHS);
            this.groupBox2.Location = new System.Drawing.Point(2, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nữ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Lượng";
            // 
            // txtTimKiemHS
            // 
            this.txtTimKiemHS.Location = new System.Drawing.Point(715, 18);
            this.txtTimKiemHS.Name = "txtTimKiemHS";
            this.txtTimKiemHS.Size = new System.Drawing.Size(131, 20);
            this.txtTimKiemHS.TabIndex = 1;
            // 
            // txtSoNuHS
            // 
            this.txtSoNuHS.Location = new System.Drawing.Point(578, 18);
            this.txtSoNuHS.Name = "txtSoNuHS";
            this.txtSoNuHS.Size = new System.Drawing.Size(70, 20);
            this.txtSoNuHS.TabIndex = 1;
            // 
            // txtSoNamHS
            // 
            this.txtSoNamHS.Location = new System.Drawing.Point(359, 19);
            this.txtSoNamHS.Name = "txtSoNamHS";
            this.txtSoNamHS.Size = new System.Drawing.Size(70, 20);
            this.txtSoNamHS.TabIndex = 1;
            // 
            // txtSoLuongHS
            // 
            this.txtSoLuongHS.Location = new System.Drawing.Point(151, 13);
            this.txtSoLuongHS.Name = "txtSoLuongHS";
            this.txtSoLuongHS.Size = new System.Drawing.Size(70, 20);
            this.txtSoLuongHS.TabIndex = 1;
            // 
            // btHuyHS
            // 
            this.btHuyHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyHS.Location = new System.Drawing.Point(629, 467);
            this.btHuyHS.Name = "btHuyHS";
            this.btHuyHS.Size = new System.Drawing.Size(75, 41);
            this.btHuyHS.TabIndex = 3;
            this.btHuyHS.Text = "Hủy";
            this.btHuyHS.UseVisualStyleBackColor = true;
            this.btHuyHS.Click += new System.EventHandler(this.btHuyHS_Click);
            // 
            // btSuaHS
            // 
            this.btSuaHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaHS.Location = new System.Drawing.Point(239, 467);
            this.btSuaHS.Name = "btSuaHS";
            this.btSuaHS.Size = new System.Drawing.Size(75, 41);
            this.btSuaHS.TabIndex = 3;
            this.btSuaHS.Text = "Sửa";
            this.btSuaHS.UseVisualStyleBackColor = true;
            this.btSuaHS.Click += new System.EventHandler(this.btSuaHS_Click);
            // 
            // btThoatHS
            // 
            this.btThoatHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btThoatHS.Location = new System.Drawing.Point(755, 467);
            this.btThoatHS.Name = "btThoatHS";
            this.btThoatHS.Size = new System.Drawing.Size(75, 41);
            this.btThoatHS.TabIndex = 3;
            this.btThoatHS.Text = "Thoát";
            this.btThoatHS.UseVisualStyleBackColor = true;
            this.btThoatHS.Click += new System.EventHandler(this.btThoatHS_Click);
            // 
            // btLuuHS
            // 
            this.btLuuHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuHS.Location = new System.Drawing.Point(502, 467);
            this.btLuuHS.Name = "btLuuHS";
            this.btLuuHS.Size = new System.Drawing.Size(75, 41);
            this.btLuuHS.TabIndex = 3;
            this.btLuuHS.Text = "Lưu";
            this.btLuuHS.UseVisualStyleBackColor = true;
            this.btLuuHS.Click += new System.EventHandler(this.btLuuHS_Click);
            // 
            // btXoaHS
            // 
            this.btXoaHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaHS.Location = new System.Drawing.Point(367, 467);
            this.btXoaHS.Name = "btXoaHS";
            this.btXoaHS.Size = new System.Drawing.Size(75, 41);
            this.btXoaHS.TabIndex = 3;
            this.btXoaHS.Text = "Xóa";
            this.btXoaHS.UseVisualStyleBackColor = true;
            this.btXoaHS.Click += new System.EventHandler(this.btXoaHS_Click);
            // 
            // btThemHS
            // 
            this.btThemHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemHS.Location = new System.Drawing.Point(122, 467);
            this.btThemHS.Name = "btThemHS";
            this.btThemHS.Size = new System.Drawing.Size(75, 41);
            this.btThemHS.TabIndex = 3;
            this.btThemHS.Text = "Thêm";
            this.btThemHS.UseVisualStyleBackColor = true;
            this.btThemHS.Click += new System.EventHandler(this.btThemHS_Click);
            // 
            // btTimKiemHS
            // 
            this.btTimKiemHS.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btTimKiemHS.Location = new System.Drawing.Point(866, 16);
            this.btTimKiemHS.Name = "btTimKiemHS";
            this.btTimKiemHS.Size = new System.Drawing.Size(75, 22);
            this.btTimKiemHS.TabIndex = 3;
            this.btTimKiemHS.Text = "Tìm Kiếm";
            this.btTimKiemHS.UseVisualStyleBackColor = true;
            this.btTimKiemHS.Click += new System.EventHandler(this.btTimKiemHS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 127);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = global::QuanLyGiaoVienHS.Properties.Resources._120px_128px_Nuvola_man_icon;
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Học Sinh";
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.Name = "MaHS";
            // 
            // TenHS
            // 
            this.TenHS.DataPropertyName = "TenHS";
            this.TenHS.HeaderText = "Tên Học Sinh";
            this.TenHS.Name = "TenHS";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
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
            this.SDT.DataPropertyName = "DienThoai";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // TenBo
            // 
            this.TenBo.DataPropertyName = "TenBo";
            this.TenBo.HeaderText = "Tên Bố";
            this.TenBo.Name = "TenBo";
            // 
            // TenMe
            // 
            this.TenMe.DataPropertyName = "TenMe";
            this.TenMe.HeaderText = "Tên Mẹ";
            this.TenMe.Name = "TenMe";
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm ";
            this.DiemTB.Name = "DiemTB";
            // 
            // LopHocMa
            // 
            this.LopHocMa.DataPropertyName = "LopHocMa";
            this.LopHocMa.HeaderText = "Lớp Học";
            this.LopHocMa.Name = "LopHocMa";
            // 
            // HocLucMa
            // 
            this.HocLucMa.DataPropertyName = "HocLucMa";
            this.HocLucMa.HeaderText = "Học Lực";
            this.HocLucMa.Name = "HocLucMa";
            // 
            // HanhKiemMa
            // 
            this.HanhKiemMa.DataPropertyName = "HanhKiemMa";
            this.HanhKiemMa.HeaderText = "Hạnh Kiểm";
            this.HanhKiemMa.Name = "HanhKiemMa";
            // 
            // KyLuatMa
            // 
            this.KyLuatMa.DataPropertyName = "KyLuatMa";
            this.KyLuatMa.HeaderText = "Kỳ Luật";
            this.KyLuatMa.Name = "KyLuatMa";
            // 
            // KhenThuongMa
            // 
            this.KhenThuongMa.DataPropertyName = "KhenThuongMa";
            this.KhenThuongMa.HeaderText = "Khen Thưởng";
            this.KhenThuongMa.Name = "KhenThuongMa";
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 513);
            this.Controls.Add(this.btHuyHS);
            this.Controls.Add(this.btSuaHS);
            this.Controls.Add(this.btThoatHS);
            this.Controls.Add(this.btLuuHS);
            this.Controls.Add(this.btXoaHS);
            this.Controls.Add(this.btThemHS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "HocSinh";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.HocSinh_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HocSinh_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbNuHS;
        private System.Windows.Forms.RadioButton rdbNamHS;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhHS;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.TextBox txtTenMeHS;
        private System.Windows.Forms.TextBox txtTenBoHS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiaChiHS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHoTenHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoNuHS;
        private System.Windows.Forms.TextBox txtSoNamHS;
        private System.Windows.Forms.TextBox txtSoLuongHS;
        private System.Windows.Forms.Button btThemHS;
        private System.Windows.Forms.Button btXoaHS;
        private System.Windows.Forms.Button btSuaHS;
        private System.Windows.Forms.Button btLuuHS;
        private System.Windows.Forms.Button btThoatHS;
        private System.Windows.Forms.Button btHuyHS;
        private System.Windows.Forms.ComboBox cbbKyLuatHS;
        private System.Windows.Forms.ComboBox cbbKhenThuongHS;
        private System.Windows.Forms.ComboBox cbbHanhKiem;
        private System.Windows.Forms.ComboBox cbbHocLuc;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btTimKiemHS;
        private System.Windows.Forms.TextBox txtTimKiemHS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHocMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLucMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiemMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KyLuatMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhenThuongMa;
    }
}