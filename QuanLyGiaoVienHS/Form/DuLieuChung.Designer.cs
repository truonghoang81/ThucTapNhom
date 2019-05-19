namespace QuanLyGiaoVienHS
{
    partial class DuLieuChung
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhenThuong = new System.Windows.Forms.TextBox();
            this.txtTenKhenThuong = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvKyLuat = new System.Windows.Forms.DataGridView();
            this.MaKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKyLuat = new System.Windows.Forms.TextBox();
            this.txtTenKyLuat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaKL = new System.Windows.Forms.Button();
            this.buLuuKL = new System.Windows.Forms.Button();
            this.btThemKL = new System.Windows.Forms.Button();
            this.btSuaKL = new System.Windows.Forms.Button();
            this.btHuyKL = new System.Windows.Forms.Button();
            this.btThoatChung = new System.Windows.Forms.Button();
            this.btXoaKT = new System.Windows.Forms.Button();
            this.btLuuKT = new System.Windows.Forms.Button();
            this.btThemKT = new System.Windows.Forms.Button();
            this.btSuaKT = new System.Windows.Forms.Button();
            this.btHuyKT = new System.Windows.Forms.Button();
            this.btLuuLop = new System.Windows.Forms.Button();
            this.btXoaLop = new System.Windows.Forms.Button();
            this.btSuaLop = new System.Windows.Forms.Button();
            this.btHuyLop = new System.Windows.Forms.Button();
            this.btThemLop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Controls.Add(this.btLuuLop);
            this.groupBox1.Controls.Add(this.btXoaLop);
            this.groupBox1.Controls.Add(this.btSuaLop);
            this.groupBox1.Controls.Add(this.btHuyLop);
            this.groupBox1.Controls.Add(this.btThemLop);
            this.groupBox1.Controls.Add(this.txtKhoaHoc);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Location = new System.Drawing.Point(1, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khóa Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.KhoaHoc});
            this.dgvLop.Location = new System.Drawing.Point(0, 175);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(307, 239);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.DataPropertyName = "KhoaHoc";
            this.KhoaHoc.HeaderText = "Khóa Học";
            this.KhoaHoc.Name = "KhoaHoc";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(80, 94);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(205, 20);
            this.txtKhoaHoc.TabIndex = 0;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(80, 59);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(205, 20);
            this.txtTenLop.TabIndex = 0;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(80, 19);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(205, 20);
            this.txtMaLop.TabIndex = 0;
            this.txtMaLop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKhenThuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btXoaKT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btLuuKT);
            this.groupBox2.Controls.Add(this.btThemKT);
            this.groupBox2.Controls.Add(this.btSuaKT);
            this.groupBox2.Controls.Add(this.txtMaKhenThuong);
            this.groupBox2.Controls.Add(this.btHuyKT);
            this.groupBox2.Controls.Add(this.txtTenKhenThuong);
            this.groupBox2.Location = new System.Drawing.Point(308, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 414);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khen Thưởng";
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKT,
            this.TenKT});
            this.dgvKhenThuong.Location = new System.Drawing.Point(0, 175);
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.Size = new System.Drawing.Size(251, 239);
            this.dgvKhenThuong.TabIndex = 2;
            this.dgvKhenThuong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhenThuong_RowEnter);
            // 
            // MaKT
            // 
            this.MaKT.DataPropertyName = "MaKT";
            this.MaKT.HeaderText = "Mã Khen Thưởng";
            this.MaKT.Name = "MaKT";
            // 
            // TenKT
            // 
            this.TenKT.DataPropertyName = "TenKT";
            this.TenKT.HeaderText = "Tên Khen Thưởng";
            this.TenKT.Name = "TenKT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Khen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Khen";
            // 
            // txtMaKhenThuong
            // 
            this.txtMaKhenThuong.Location = new System.Drawing.Point(60, 26);
            this.txtMaKhenThuong.Name = "txtMaKhenThuong";
            this.txtMaKhenThuong.Size = new System.Drawing.Size(183, 20);
            this.txtMaKhenThuong.TabIndex = 0;
            this.txtMaKhenThuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenKhenThuong
            // 
            this.txtTenKhenThuong.Location = new System.Drawing.Point(60, 66);
            this.txtTenKhenThuong.Name = "txtTenKhenThuong";
            this.txtTenKhenThuong.Size = new System.Drawing.Size(183, 20);
            this.txtTenKhenThuong.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvKyLuat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btXoaKL);
            this.groupBox3.Controls.Add(this.txtMaKyLuat);
            this.groupBox3.Controls.Add(this.buLuuKL);
            this.groupBox3.Controls.Add(this.btThemKL);
            this.groupBox3.Controls.Add(this.txtTenKyLuat);
            this.groupBox3.Controls.Add(this.btSuaKL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btHuyKL);
            this.groupBox3.Location = new System.Drawing.Point(557, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 414);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kỷ Luật";
            // 
            // dgvKyLuat
            // 
            this.dgvKyLuat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKL,
            this.TenKL});
            this.dgvKyLuat.Location = new System.Drawing.Point(0, 175);
            this.dgvKyLuat.Name = "dgvKyLuat";
            this.dgvKyLuat.Size = new System.Drawing.Size(257, 239);
            this.dgvKyLuat.TabIndex = 2;
            this.dgvKyLuat.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyLuat_RowEnter);
            // 
            // MaKL
            // 
            this.MaKL.DataPropertyName = "MaKL";
            this.MaKL.HeaderText = "Mã Kỷ Luật";
            this.MaKL.Name = "MaKL";
            // 
            // TenKL
            // 
            this.TenKL.DataPropertyName = "TenKL";
            this.TenKL.HeaderText = "Tên Kỷ Luật";
            this.TenKL.Name = "TenKL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên Kỷ Luật";
            // 
            // txtMaKyLuat
            // 
            this.txtMaKyLuat.Location = new System.Drawing.Point(78, 26);
            this.txtMaKyLuat.Name = "txtMaKyLuat";
            this.txtMaKyLuat.Size = new System.Drawing.Size(170, 20);
            this.txtMaKyLuat.TabIndex = 0;
            this.txtMaKyLuat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenKyLuat
            // 
            this.txtTenKyLuat.Location = new System.Drawing.Point(78, 66);
            this.txtTenKyLuat.Name = "txtTenKyLuat";
            this.txtTenKyLuat.Size = new System.Drawing.Size(170, 20);
            this.txtTenKyLuat.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Kỷ Luật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(251, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp-Khen Thưởng-Kỷ Luật";
            // 
            // btXoaKL
            // 
            this.btXoaKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaKL.Location = new System.Drawing.Point(99, 130);
            this.btXoaKL.Name = "btXoaKL";
            this.btXoaKL.Size = new System.Drawing.Size(37, 39);
            this.btXoaKL.TabIndex = 1;
            this.btXoaKL.Text = "Xóa";
            this.btXoaKL.UseVisualStyleBackColor = true;
            this.btXoaKL.Click += new System.EventHandler(this.btXoaKL_Click);
            // 
            // buLuuKL
            // 
            this.buLuuKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.buLuuKL.Location = new System.Drawing.Point(145, 130);
            this.buLuuKL.Name = "buLuuKL";
            this.buLuuKL.Size = new System.Drawing.Size(36, 39);
            this.buLuuKL.TabIndex = 1;
            this.buLuuKL.Text = "Lưu";
            this.buLuuKL.UseVisualStyleBackColor = true;
            this.buLuuKL.Click += new System.EventHandler(this.btLuuKL_Click);
            // 
            // btThemKL
            // 
            this.btThemKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemKL.Location = new System.Drawing.Point(8, 130);
            this.btThemKL.Name = "btThemKL";
            this.btThemKL.Size = new System.Drawing.Size(42, 39);
            this.btThemKL.TabIndex = 1;
            this.btThemKL.Text = "Thêm";
            this.btThemKL.UseVisualStyleBackColor = true;
            this.btThemKL.Click += new System.EventHandler(this.btThemKL_Click);
            // 
            // btSuaKL
            // 
            this.btSuaKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaKL.Location = new System.Drawing.Point(56, 130);
            this.btSuaKL.Name = "btSuaKL";
            this.btSuaKL.Size = new System.Drawing.Size(37, 39);
            this.btSuaKL.TabIndex = 1;
            this.btSuaKL.Text = "Sửa";
            this.btSuaKL.UseVisualStyleBackColor = true;
            this.btSuaKL.Click += new System.EventHandler(this.btSuaKL_Click);
            // 
            // btHuyKL
            // 
            this.btHuyKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyKL.Location = new System.Drawing.Point(187, 130);
            this.btHuyKL.Name = "btHuyKL";
            this.btHuyKL.Size = new System.Drawing.Size(36, 39);
            this.btHuyKL.TabIndex = 1;
            this.btHuyKL.Text = "Hủy";
            this.btHuyKL.UseVisualStyleBackColor = true;
            this.btHuyKL.Click += new System.EventHandler(this.btHuyKL_Click);
            // 
            // btThoatChung
            // 
            this.btThoatChung.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btThoatChung.Location = new System.Drawing.Point(727, 467);
            this.btThoatChung.Name = "btThoatChung";
            this.btThoatChung.Size = new System.Drawing.Size(78, 43);
            this.btThoatChung.TabIndex = 1;
            this.btThoatChung.Text = "Thoát";
            this.btThoatChung.UseVisualStyleBackColor = true;
            this.btThoatChung.Click += new System.EventHandler(this.btThoatChung_Click);
            // 
            // btXoaKT
            // 
            this.btXoaKT.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaKT.Location = new System.Drawing.Point(114, 130);
            this.btXoaKT.Name = "btXoaKT";
            this.btXoaKT.Size = new System.Drawing.Size(40, 39);
            this.btXoaKT.TabIndex = 1;
            this.btXoaKT.Text = "Xóa";
            this.btXoaKT.UseVisualStyleBackColor = true;
            this.btXoaKT.Click += new System.EventHandler(this.btXoaKT_Click);
            // 
            // btLuuKT
            // 
            this.btLuuKT.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuKT.Location = new System.Drawing.Point(156, 130);
            this.btLuuKT.Name = "btLuuKT";
            this.btLuuKT.Size = new System.Drawing.Size(36, 39);
            this.btLuuKT.TabIndex = 1;
            this.btLuuKT.Text = "Lưu";
            this.btLuuKT.UseVisualStyleBackColor = true;
            this.btLuuKT.Click += new System.EventHandler(this.btLuuKT_Click);
            // 
            // btThemKT
            // 
            this.btThemKT.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemKT.Location = new System.Drawing.Point(19, 130);
            this.btThemKT.Name = "btThemKT";
            this.btThemKT.Size = new System.Drawing.Size(41, 39);
            this.btThemKT.TabIndex = 1;
            this.btThemKT.Text = "Thêm";
            this.btThemKT.UseVisualStyleBackColor = true;
            this.btThemKT.Click += new System.EventHandler(this.btThemKT_Click);
            // 
            // btSuaKT
            // 
            this.btSuaKT.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaKT.Location = new System.Drawing.Point(66, 130);
            this.btSuaKT.Name = "btSuaKT";
            this.btSuaKT.Size = new System.Drawing.Size(42, 39);
            this.btSuaKT.TabIndex = 1;
            this.btSuaKT.Text = "Sửa";
            this.btSuaKT.UseVisualStyleBackColor = true;
            this.btSuaKT.Click += new System.EventHandler(this.btSuaKT_Click);
            // 
            // btHuyKT
            // 
            this.btHuyKT.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyKT.Location = new System.Drawing.Point(198, 130);
            this.btHuyKT.Name = "btHuyKT";
            this.btHuyKT.Size = new System.Drawing.Size(36, 39);
            this.btHuyKT.TabIndex = 1;
            this.btHuyKT.Text = "Hủy";
            this.btHuyKT.UseVisualStyleBackColor = true;
            this.btHuyKT.Click += new System.EventHandler(this.btHuyKT_Click);
            // 
            // btLuuLop
            // 
            this.btLuuLop.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuLop.Location = new System.Drawing.Point(173, 130);
            this.btLuuLop.Name = "btLuuLop";
            this.btLuuLop.Size = new System.Drawing.Size(36, 39);
            this.btLuuLop.TabIndex = 1;
            this.btLuuLop.Text = "Lưu";
            this.btLuuLop.UseVisualStyleBackColor = true;
            this.btLuuLop.Click += new System.EventHandler(this.btLuuLop_Click);
            // 
            // btXoaLop
            // 
            this.btXoaLop.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaLop.Location = new System.Drawing.Point(120, 130);
            this.btXoaLop.Name = "btXoaLop";
            this.btXoaLop.Size = new System.Drawing.Size(36, 39);
            this.btXoaLop.TabIndex = 1;
            this.btXoaLop.Text = "Xóa";
            this.btXoaLop.UseVisualStyleBackColor = true;
            this.btXoaLop.Click += new System.EventHandler(this.btHuyLop_Click);
            // 
            // btSuaLop
            // 
            this.btSuaLop.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaLop.Location = new System.Drawing.Point(72, 130);
            this.btSuaLop.Name = "btSuaLop";
            this.btSuaLop.Size = new System.Drawing.Size(42, 39);
            this.btSuaLop.TabIndex = 1;
            this.btSuaLop.Text = "Sửa";
            this.btSuaLop.UseVisualStyleBackColor = true;
            this.btSuaLop.Click += new System.EventHandler(this.btSuaLop_Click);
            // 
            // btHuyLop
            // 
            this.btHuyLop.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyLop.Location = new System.Drawing.Point(224, 130);
            this.btHuyLop.Name = "btHuyLop";
            this.btHuyLop.Size = new System.Drawing.Size(36, 39);
            this.btHuyLop.TabIndex = 1;
            this.btHuyLop.Text = "Hủy";
            this.btHuyLop.UseVisualStyleBackColor = true;
            this.btHuyLop.Click += new System.EventHandler(this.btXoaLop_Click);
            // 
            // btThemLop
            // 
            this.btThemLop.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemLop.Location = new System.Drawing.Point(26, 130);
            this.btThemLop.Name = "btThemLop";
            this.btThemLop.Size = new System.Drawing.Size(40, 39);
            this.btThemLop.TabIndex = 1;
            this.btThemLop.Text = "Thêm ";
            this.btThemLop.UseVisualStyleBackColor = true;
            this.btThemLop.Click += new System.EventHandler(this.btThemLop_Click);
            // 
            // DuLieuChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btThoatChung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DuLieuChung";
            this.Text = "DuLieuChung";
            this.Load += new System.EventHandler(this.DuLieuChung_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DuLieuChung_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btXoaLop;
        private System.Windows.Forms.Button btSuaLop;
        private System.Windows.Forms.Button btThemLop;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhenThuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoaKT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThemKT;
        private System.Windows.Forms.Button btSuaKT;
        private System.Windows.Forms.TextBox txtMaKhenThuong;
        private System.Windows.Forms.TextBox txtTenKhenThuong;
        private System.Windows.Forms.DataGridView dgvKyLuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btXoaKL;
        private System.Windows.Forms.TextBox txtMaKyLuat;
        private System.Windows.Forms.Button btThemKL;
        private System.Windows.Forms.TextBox txtTenKyLuat;
        private System.Windows.Forms.Button btSuaKL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btHuyLop;
        private System.Windows.Forms.Button btLuuLop;
        private System.Windows.Forms.Button btThoatChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKL;
        private System.Windows.Forms.Button btLuuKT;
        private System.Windows.Forms.Button btHuyKT;
        private System.Windows.Forms.Button buLuuKL;
        private System.Windows.Forms.Button btHuyKL;
    }
}