namespace QuanLyGiaoVienHS
{
    partial class DuLieuRieng
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.MaHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenHK = new System.Windows.Forms.TextBox();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvBoMon = new System.Windows.Forms.DataGridView();
            this.MaBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBM = new System.Windows.Forms.TextBox();
            this.txtTenBM = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvHocLuc = new System.Windows.Forms.DataGridView();
            this.MaHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenHL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btThoatDLRieng = new System.Windows.Forms.Button();
            this.btXoaHL = new System.Windows.Forms.Button();
            this.btHuyHL = new System.Windows.Forms.Button();
            this.btLuuHL = new System.Windows.Forms.Button();
            this.btThemKL = new System.Windows.Forms.Button();
            this.btSuaHL = new System.Windows.Forms.Button();
            this.btXoaHK = new System.Windows.Forms.Button();
            this.btHuyHK = new System.Windows.Forms.Button();
            this.btLuuHK = new System.Windows.Forms.Button();
            this.btSuaHK = new System.Windows.Forms.Button();
            this.btThemHK = new System.Windows.Forms.Button();
            this.btXoaBM = new System.Windows.Forms.Button();
            this.btHuyBM = new System.Windows.Forms.Button();
            this.btSuaBM = new System.Windows.Forms.Button();
            this.btLuuBM = new System.Windows.Forms.Button();
            this.btThemBM = new System.Windows.Forms.Button();
            this.btXoaCV = new System.Windows.Forms.Button();
            this.btHuyCV = new System.Windows.Forms.Button();
            this.btSuaCV = new System.Windows.Forms.Button();
            this.btThemCV = new System.Windows.Forms.Button();
            this.btLuuCV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXoaCV);
            this.groupBox1.Controls.Add(this.btHuyCV);
            this.groupBox1.Controls.Add(this.btSuaCV);
            this.groupBox1.Controls.Add(this.btThemCV);
            this.groupBox1.Controls.Add(this.btLuuCV);
            this.groupBox1.Controls.Add(this.dgvChucVu);
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Controls.Add(this.txtMaCV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Vụ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dgvChucVu.Location = new System.Drawing.Point(0, 179);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(227, 246);
            this.dgvChucVu.TabIndex = 3;
            this.dgvChucVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_RowEnter);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(74, 72);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(145, 20);
            this.txtTenCV.TabIndex = 2;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(74, 35);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(145, 20);
            this.txtMaCV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ten Chức Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(225, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btXoaHK);
            this.groupBox3.Controls.Add(this.btHuyHK);
            this.groupBox3.Controls.Add(this.dgvHanhKiem);
            this.groupBox3.Controls.Add(this.txtTenHK);
            this.groupBox3.Controls.Add(this.btLuuHK);
            this.groupBox3.Controls.Add(this.btSuaHK);
            this.groupBox3.Controls.Add(this.txtMaHK);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btThemHK);
            this.groupBox3.Location = new System.Drawing.Point(460, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 425);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạnh Kiểm";
            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHK,
            this.TenHK});
            this.dgvHanhKiem.Location = new System.Drawing.Point(0, 179);
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.Size = new System.Drawing.Size(240, 246);
            this.dgvHanhKiem.TabIndex = 3;
            this.dgvHanhKiem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhKiem_RowEnter);
            // 
            // MaHK
            // 
            this.MaHK.DataPropertyName = "MaHK";
            this.MaHK.HeaderText = "Mã Hạnh Kiểm";
            this.MaHK.Name = "MaHK";
            // 
            // TenHK
            // 
            this.TenHK.DataPropertyName = "TenHK";
            this.TenHK.HeaderText = "Tên Hạnh Kiểm";
            this.TenHK.Name = "TenHK";
            // 
            // txtTenHK
            // 
            this.txtTenHK.Location = new System.Drawing.Point(74, 66);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(160, 20);
            this.txtTenHK.TabIndex = 2;
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(74, 29);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(161, 20);
            this.txtMaHK.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Hạnh Kiểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hạnh Kiểm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btXoaBM);
            this.groupBox5.Controls.Add(this.btHuyBM);
            this.groupBox5.Controls.Add(this.dgvBoMon);
            this.groupBox5.Controls.Add(this.btSuaBM);
            this.groupBox5.Controls.Add(this.btLuuBM);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btThemBM);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtMaBM);
            this.groupBox5.Controls.Add(this.txtTenBM);
            this.groupBox5.Location = new System.Drawing.Point(226, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 425);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bộ Môn";
            // 
            // dgvBoMon
            // 
            this.dgvBoMon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBM,
            this.TenBM});
            this.dgvBoMon.Location = new System.Drawing.Point(1, 179);
            this.dgvBoMon.Name = "dgvBoMon";
            this.dgvBoMon.Size = new System.Drawing.Size(232, 246);
            this.dgvBoMon.TabIndex = 3;
            this.dgvBoMon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_RowEnter);
            // 
            // MaBM
            // 
            this.MaBM.DataPropertyName = "MaBM";
            this.MaBM.HeaderText = "Mã Bộ Môn";
            this.MaBM.Name = "MaBM";
            // 
            // TenBM
            // 
            this.TenBM.DataPropertyName = "TenBM";
            this.TenBM.HeaderText = "Tên Bộ Môn";
            this.TenBM.Name = "TenBM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Bộ Môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ten Bộ Môn";
            // 
            // txtMaBM
            // 
            this.txtMaBM.Location = new System.Drawing.Point(75, 35);
            this.txtMaBM.Name = "txtMaBM";
            this.txtMaBM.Size = new System.Drawing.Size(145, 20);
            this.txtMaBM.TabIndex = 2;
            // 
            // txtTenBM
            // 
            this.txtTenBM.Location = new System.Drawing.Point(75, 72);
            this.txtTenBM.Name = "txtTenBM";
            this.txtTenBM.Size = new System.Drawing.Size(145, 20);
            this.txtTenBM.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btXoaHL);
            this.groupBox6.Controls.Add(this.btHuyHL);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.dgvHocLuc);
            this.groupBox6.Controls.Add(this.btLuuHL);
            this.groupBox6.Controls.Add(this.txtTenHL);
            this.groupBox6.Controls.Add(this.btThemKL);
            this.groupBox6.Controls.Add(this.btSuaHL);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtMaHL);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(701, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 425);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Học Lực";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(236, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(228, 421);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox1";
            // 
            // dgvHocLuc
            // 
            this.dgvHocLuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHocLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocLuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHL,
            this.TenHL});
            this.dgvHocLuc.Location = new System.Drawing.Point(0, 179);
            this.dgvHocLuc.Name = "dgvHocLuc";
            this.dgvHocLuc.Size = new System.Drawing.Size(240, 246);
            this.dgvHocLuc.TabIndex = 3;
            this.dgvHocLuc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocLuc_RowEnter);
            // 
            // MaHL
            // 
            this.MaHL.DataPropertyName = "MaHL";
            this.MaHL.HeaderText = "Mã Học Lực";
            this.MaHL.Name = "MaHL";
            // 
            // TenHL
            // 
            this.TenHL.DataPropertyName = "TenHK";
            this.TenHL.HeaderText = "Tên Học Lực";
            this.TenHL.Name = "TenHL";
            // 
            // txtTenHL
            // 
            this.txtTenHL.Location = new System.Drawing.Point(77, 66);
            this.txtTenHL.Name = "txtTenHL";
            this.txtTenHL.Size = new System.Drawing.Size(145, 20);
            this.txtTenHL.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Học Lực";
            // 
            // txtMaHL
            // 
            this.txtMaHL.Location = new System.Drawing.Point(77, 29);
            this.txtMaHL.Name = "txtMaHL";
            this.txtMaHL.Size = new System.Drawing.Size(145, 20);
            this.txtMaHL.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Học Lực";
            // 
            // btThoatDLRieng
            // 
            this.btThoatDLRieng.Image = global::QuanLyGiaoVienHS.Properties.Resources.tick_icon_31;
            this.btThoatDLRieng.Location = new System.Drawing.Point(852, 468);
            this.btThoatDLRieng.Name = "btThoatDLRieng";
            this.btThoatDLRieng.Size = new System.Drawing.Size(71, 41);
            this.btThoatDLRieng.TabIndex = 4;
            this.btThoatDLRieng.Text = "Thoát";
            this.btThoatDLRieng.UseVisualStyleBackColor = true;
            this.btThoatDLRieng.Click += new System.EventHandler(this.btThoatDLRieng_Click);
            // 
            // btXoaHL
            // 
            this.btXoaHL.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaHL.Location = new System.Drawing.Point(101, 120);
            this.btXoaHL.Name = "btXoaHL";
            this.btXoaHL.Size = new System.Drawing.Size(38, 42);
            this.btXoaHL.TabIndex = 4;
            this.btXoaHL.Text = "Xóa";
            this.btXoaHL.UseVisualStyleBackColor = true;
            this.btXoaHL.Click += new System.EventHandler(this.btXoaHL_Click);
            // 
            // btHuyHL
            // 
            this.btHuyHL.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyHL.Location = new System.Drawing.Point(187, 120);
            this.btHuyHL.Name = "btHuyHL";
            this.btHuyHL.Size = new System.Drawing.Size(35, 41);
            this.btHuyHL.TabIndex = 4;
            this.btHuyHL.Text = "Hủy";
            this.btHuyHL.UseVisualStyleBackColor = true;
            this.btHuyHL.Click += new System.EventHandler(this.btHuyHL_Click);
            // 
            // btLuuHL
            // 
            this.btLuuHL.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuHL.Location = new System.Drawing.Point(147, 120);
            this.btLuuHL.Name = "btLuuHL";
            this.btLuuHL.Size = new System.Drawing.Size(34, 41);
            this.btLuuHL.TabIndex = 4;
            this.btLuuHL.Text = "Lưu";
            this.btLuuHL.UseVisualStyleBackColor = true;
            this.btLuuHL.Click += new System.EventHandler(this.btLuuHL_Click);
            // 
            // btThemKL
            // 
            this.btThemKL.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemKL.Location = new System.Drawing.Point(5, 119);
            this.btThemKL.Name = "btThemKL";
            this.btThemKL.Size = new System.Drawing.Size(44, 42);
            this.btThemKL.TabIndex = 4;
            this.btThemKL.Text = "Thêm";
            this.btThemKL.UseVisualStyleBackColor = true;
            this.btThemKL.Click += new System.EventHandler(this.btThemKL_Click);
            // 
            // btSuaHL
            // 
            this.btSuaHL.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaHL.Location = new System.Drawing.Point(55, 119);
            this.btSuaHL.Name = "btSuaHL";
            this.btSuaHL.Size = new System.Drawing.Size(40, 42);
            this.btSuaHL.TabIndex = 4;
            this.btSuaHL.Text = "Sửa";
            this.btSuaHL.UseVisualStyleBackColor = true;
            this.btSuaHL.Click += new System.EventHandler(this.btSuaHL_Click);
            // 
            // btXoaHK
            // 
            this.btXoaHK.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaHK.Location = new System.Drawing.Point(104, 119);
            this.btXoaHK.Name = "btXoaHK";
            this.btXoaHK.Size = new System.Drawing.Size(37, 42);
            this.btXoaHK.TabIndex = 4;
            this.btXoaHK.Text = "Xóa";
            this.btXoaHK.UseVisualStyleBackColor = true;
            this.btXoaHK.Click += new System.EventHandler(this.btXoaHK_Click);
            // 
            // btHuyHK
            // 
            this.btHuyHK.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyHK.Location = new System.Drawing.Point(185, 119);
            this.btHuyHK.Name = "btHuyHK";
            this.btHuyHK.Size = new System.Drawing.Size(35, 41);
            this.btHuyHK.TabIndex = 4;
            this.btHuyHK.Text = "Hủy";
            this.btHuyHK.UseVisualStyleBackColor = true;
            this.btHuyHK.Click += new System.EventHandler(this.btHuyHK_Click);
            // 
            // btLuuHK
            // 
            this.btLuuHK.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuHK.Location = new System.Drawing.Point(145, 119);
            this.btLuuHK.Name = "btLuuHK";
            this.btLuuHK.Size = new System.Drawing.Size(34, 41);
            this.btLuuHK.TabIndex = 4;
            this.btLuuHK.Text = "Lưu";
            this.btLuuHK.UseVisualStyleBackColor = true;
            this.btLuuHK.Click += new System.EventHandler(this.btLuuHK_Click);
            // 
            // btSuaHK
            // 
            this.btSuaHK.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaHK.Location = new System.Drawing.Point(60, 119);
            this.btSuaHK.Name = "btSuaHK";
            this.btSuaHK.Size = new System.Drawing.Size(38, 42);
            this.btSuaHK.TabIndex = 4;
            this.btSuaHK.Text = "Sửa";
            this.btSuaHK.UseVisualStyleBackColor = true;
            this.btSuaHK.Click += new System.EventHandler(this.btSuaHK_Click);
            // 
            // btThemHK
            // 
            this.btThemHK.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemHK.Location = new System.Drawing.Point(15, 120);
            this.btThemHK.Name = "btThemHK";
            this.btThemHK.Size = new System.Drawing.Size(39, 42);
            this.btThemHK.TabIndex = 4;
            this.btThemHK.Text = "Thêm ";
            this.btThemHK.UseVisualStyleBackColor = true;
            this.btThemHK.Click += new System.EventHandler(this.btThemHK_Click);
            // 
            // btXoaBM
            // 
            this.btXoaBM.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaBM.Location = new System.Drawing.Point(99, 121);
            this.btXoaBM.Name = "btXoaBM";
            this.btXoaBM.Size = new System.Drawing.Size(38, 42);
            this.btXoaBM.TabIndex = 4;
            this.btXoaBM.Text = "Xóa";
            this.btXoaBM.UseVisualStyleBackColor = true;
            this.btXoaBM.Click += new System.EventHandler(this.btXoaBM_Click);
            // 
            // btHuyBM
            // 
            this.btHuyBM.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyBM.Location = new System.Drawing.Point(185, 120);
            this.btHuyBM.Name = "btHuyBM";
            this.btHuyBM.Size = new System.Drawing.Size(35, 41);
            this.btHuyBM.TabIndex = 4;
            this.btHuyBM.Text = "Hủy";
            this.btHuyBM.UseVisualStyleBackColor = true;
            this.btHuyBM.Click += new System.EventHandler(this.btHuyBM_Click);
            // 
            // btSuaBM
            // 
            this.btSuaBM.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaBM.Location = new System.Drawing.Point(56, 121);
            this.btSuaBM.Name = "btSuaBM";
            this.btSuaBM.Size = new System.Drawing.Size(37, 42);
            this.btSuaBM.TabIndex = 4;
            this.btSuaBM.Text = "Sửa";
            this.btSuaBM.UseVisualStyleBackColor = true;
            this.btSuaBM.Click += new System.EventHandler(this.btSuaBM_Click);
            // 
            // btLuuBM
            // 
            this.btLuuBM.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuBM.Location = new System.Drawing.Point(145, 120);
            this.btLuuBM.Name = "btLuuBM";
            this.btLuuBM.Size = new System.Drawing.Size(34, 41);
            this.btLuuBM.TabIndex = 4;
            this.btLuuBM.Text = "Lưu";
            this.btLuuBM.UseVisualStyleBackColor = true;
            this.btLuuBM.Click += new System.EventHandler(this.btLuuBM_Click);
            // 
            // btThemBM
            // 
            this.btThemBM.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemBM.Location = new System.Drawing.Point(6, 121);
            this.btThemBM.Name = "btThemBM";
            this.btThemBM.Size = new System.Drawing.Size(44, 42);
            this.btThemBM.TabIndex = 4;
            this.btThemBM.Text = "Thêm ";
            this.btThemBM.UseVisualStyleBackColor = true;
            this.btThemBM.Click += new System.EventHandler(this.btThemBM_Click);
            // 
            // btXoaCV
            // 
            this.btXoaCV.Image = global::QuanLyGiaoVienHS.Properties.Resources.icon_trash_30x30;
            this.btXoaCV.Location = new System.Drawing.Point(102, 120);
            this.btXoaCV.Name = "btXoaCV";
            this.btXoaCV.Size = new System.Drawing.Size(34, 42);
            this.btXoaCV.TabIndex = 4;
            this.btXoaCV.Text = "Xóa";
            this.btXoaCV.UseVisualStyleBackColor = true;
            this.btXoaCV.Click += new System.EventHandler(this.btXoaCV_Click);
            // 
            // btHuyCV
            // 
            this.btHuyCV.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btHuyCV.Location = new System.Drawing.Point(182, 121);
            this.btHuyCV.Name = "btHuyCV";
            this.btHuyCV.Size = new System.Drawing.Size(35, 41);
            this.btHuyCV.TabIndex = 4;
            this.btHuyCV.Text = "Hủy";
            this.btHuyCV.UseVisualStyleBackColor = true;
            this.btHuyCV.Click += new System.EventHandler(this.btHuyCV_Click);
            // 
            // btSuaCV
            // 
            this.btSuaCV.Image = global::QuanLyGiaoVienHS.Properties.Resources.edit_icon;
            this.btSuaCV.Location = new System.Drawing.Point(61, 120);
            this.btSuaCV.Name = "btSuaCV";
            this.btSuaCV.Size = new System.Drawing.Size(35, 42);
            this.btSuaCV.TabIndex = 4;
            this.btSuaCV.Text = "Sửa";
            this.btSuaCV.UseVisualStyleBackColor = true;
            this.btSuaCV.Click += new System.EventHandler(this.btSuaCV_Click);
            // 
            // btThemCV
            // 
            this.btThemCV.Image = global::QuanLyGiaoVienHS.Properties.Resources.Create;
            this.btThemCV.Location = new System.Drawing.Point(11, 120);
            this.btThemCV.Name = "btThemCV";
            this.btThemCV.Size = new System.Drawing.Size(44, 42);
            this.btThemCV.TabIndex = 4;
            this.btThemCV.Text = "Thêm";
            this.btThemCV.UseVisualStyleBackColor = true;
            this.btThemCV.Click += new System.EventHandler(this.btThemCV_Click);
            // 
            // btLuuCV
            // 
            this.btLuuCV.Image = global::QuanLyGiaoVienHS.Properties.Resources.geo_icon;
            this.btLuuCV.Location = new System.Drawing.Point(142, 121);
            this.btLuuCV.Name = "btLuuCV";
            this.btLuuCV.Size = new System.Drawing.Size(34, 41);
            this.btLuuCV.TabIndex = 4;
            this.btLuuCV.Text = "Lưu";
            this.btLuuCV.UseVisualStyleBackColor = true;
            this.btLuuCV.Click += new System.EventHandler(this.btLuuCV_Click);
            // 
            // DuLieuRieng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 511);
            this.Controls.Add(this.btThoatDLRieng);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DuLieuRieng";
            this.Text = "DuLieuRieng";
            this.Load += new System.EventHandler(this.DuLieuRieng_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DuLieuRieng_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThemCV;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btXoaCV;
        private System.Windows.Forms.Button btSuaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXoaHK;
        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.TextBox txtTenHK;
        private System.Windows.Forms.Button btSuaHK;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThemHK;
        private System.Windows.Forms.Button btXoaBM;
        private System.Windows.Forms.DataGridView dgvBoMon;
        private System.Windows.Forms.Button btSuaBM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThemBM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBM;
        private System.Windows.Forms.TextBox txtTenBM;
        private System.Windows.Forms.Button btXoaHL;
        private System.Windows.Forms.DataGridView dgvHocLuc;
        private System.Windows.Forms.TextBox txtTenHL;
        private System.Windows.Forms.Button btThemKL;
        private System.Windows.Forms.Button btSuaHL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btLuuCV;
        private System.Windows.Forms.Button btHuyCV;
        private System.Windows.Forms.Button btThoatDLRieng;
        private System.Windows.Forms.Button btHuyHK;
        private System.Windows.Forms.Button btLuuHK;
        private System.Windows.Forms.Button btHuyBM;
        private System.Windows.Forms.Button btLuuBM;
        private System.Windows.Forms.Button btHuyHL;
        private System.Windows.Forms.Button btLuuHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHL;
    }
}