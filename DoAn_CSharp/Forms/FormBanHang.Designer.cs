namespace DoAn_CSharp.Forms
{
    partial class FormBanHang
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
            this.dateTimePickerNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.btnTimKH = new FontAwesome.Sharp.IconButton();
            this.cbTenKhachHang = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaALL = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dtgvGioHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMieuTaSP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienGiam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.btnChuyenQua = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerNgayLapHoaDon);
            this.panel1.Controls.Add(this.btnTimKH);
            this.panel1.Controls.Add(this.cbTenKhachHang);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.txtTimKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 133);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerNgayLapHoaDon
            // 
            this.dateTimePickerNgayLapHoaDon.Location = new System.Drawing.Point(145, 56);
            this.dateTimePickerNgayLapHoaDon.Name = "dateTimePickerNgayLapHoaDon";
            this.dateTimePickerNgayLapHoaDon.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerNgayLapHoaDon.TabIndex = 64;
            // 
            // btnTimKH
            // 
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKH.IconColor = System.Drawing.Color.Black;
            this.btnTimKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKH.Location = new System.Drawing.Point(640, 17);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKH.TabIndex = 63;
            this.btnTimKH.Text = "Tìm KH";
            this.btnTimKH.UseVisualStyleBackColor = true;
            // 
            // cbTenKhachHang
            // 
            this.cbTenKhachHang.FormattingEnabled = true;
            this.cbTenKhachHang.Location = new System.Drawing.Point(513, 54);
            this.cbTenKhachHang.Name = "cbTenKhachHang";
            this.cbTenKhachHang.Size = new System.Drawing.Size(202, 21);
            this.cbTenKhachHang.TabIndex = 38;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(823, 56);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGhiChu.Size = new System.Drawing.Size(158, 68);
            this.txtGhiChu.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(739, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ghi Chú :";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(823, 20);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(158, 20);
            this.txtSDTKH.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(741, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "SĐT KH :";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(513, 88);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(202, 20);
            this.txtDiaChiKH.TabIndex = 30;
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(513, 18);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(121, 20);
            this.txtTimKhachHang.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa Chỉ KH :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 17);
            this.label.TabIndex = 21;
            this.label.Text = "Ngày Lập Hóa Đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên Khách Hàng :";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(145, 20);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(206, 20);
            this.txtMaHoaDon.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tìm Khách Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(145, 87);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(206, 20);
            this.txtTenNhanVien.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachSanPham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(0, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm ";
            // 
            // dtgvDanhSachSanPham
            // 
            this.dtgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSanPham.Location = new System.Drawing.Point(6, 56);
            this.dtgvDanhSachSanPham.Name = "dtgvDanhSachSanPham";
            this.dtgvDanhSachSanPham.Size = new System.Drawing.Size(463, 184);
            this.dtgvDanhSachSanPham.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tìm Kiếm :";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(335, 25);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(115, 22);
            this.cbTimKiem.TabIndex = 64;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(108, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaALL);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.dtgvGioHang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(513, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ Hàng ";
            // 
            // btnXoaALL
            // 
            this.btnXoaALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaALL.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaALL.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaALL.IconColor = System.Drawing.Color.Black;
            this.btnXoaALL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaALL.Location = new System.Drawing.Point(293, 19);
            this.btnXoaALL.Name = "btnXoaALL";
            this.btnXoaALL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaALL.TabIndex = 68;
            this.btnXoaALL.Text = "Xóa ALL ";
            this.btnXoaALL.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(384, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtgvGioHang
            // 
            this.dtgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGioHang.Location = new System.Drawing.Point(6, 56);
            this.dtgvGioHang.Name = "dtgvGioHang";
            this.dtgvGioHang.Size = new System.Drawing.Size(456, 178);
            this.dtgvGioHang.TabIndex = 66;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMieuTaSP);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDanhMuc);
            this.groupBox3.Controls.Add(this.txtNhaCungCap);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Sản Phẩm ";
            // 
            // txtMieuTaSP
            // 
            this.txtMieuTaSP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMieuTaSP.Location = new System.Drawing.Point(204, 128);
            this.txtMieuTaSP.Multiline = true;
            this.txtMieuTaSP.Name = "txtMieuTaSP";
            this.txtMieuTaSP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMieuTaSP.Size = new System.Drawing.Size(264, 68);
            this.txtMieuTaSP.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(202, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 17);
            this.label15.TabIndex = 65;
            this.label15.Text = "Miêu Tả Sản Phẩm :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(202, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "Danh Mục :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(202, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Nhà Cung Cấp :";
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhMuc.Location = new System.Drawing.Point(335, 64);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(133, 20);
            this.txtDanhMuc.TabIndex = 73;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCungCap.Location = new System.Drawing.Point(335, 24);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(133, 20);
            this.txtNhaCungCap.TabIndex = 71;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnThanhToan);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtTongTien);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTienGiam);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMaGiamGia);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTamTinh);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox4.Location = new System.Drawing.Point(513, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 202);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tính Tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThanhToan.IconColor = System.Drawing.Color.Black;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.Location = new System.Drawing.Point(211, 173);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(103, 23);
            this.btnThanhToan.TabIndex = 69;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tổng Tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTongTien.Location = new System.Drawing.Point(160, 141);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(206, 20);
            this.txtTongTien.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tiền Giảm :";
            // 
            // txtTienGiam
            // 
            this.txtTienGiam.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTienGiam.Location = new System.Drawing.Point(160, 103);
            this.txtTienGiam.Name = "txtTienGiam";
            this.txtTienGiam.Size = new System.Drawing.Size(206, 20);
            this.txtTienGiam.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã Giảm Giá :";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtMaGiamGia.Location = new System.Drawing.Point(160, 65);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(206, 20);
            this.txtMaGiamGia.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tạm Tính :";
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTamTinh.Location = new System.Drawing.Point(160, 25);
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.Size = new System.Drawing.Size(206, 20);
            this.txtTamTinh.TabIndex = 24;
            // 
            // btnChuyenQua
            // 
            this.btnChuyenQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenQua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenQua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChuyenQua.IconColor = System.Drawing.Color.Black;
            this.btnChuyenQua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChuyenQua.Location = new System.Drawing.Point(475, 268);
            this.btnChuyenQua.Name = "btnChuyenQua";
            this.btnChuyenQua.Size = new System.Drawing.Size(38, 23);
            this.btnChuyenQua.TabIndex = 69;
            this.btnChuyenQua.Text = ">";
            this.btnChuyenQua.UseVisualStyleBackColor = true;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.btnChuyenQua);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBanHang";
            this.Text = "BÁN HÀNG ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGioHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtTimKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTenKhachHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapHoaDon;
        private FontAwesome.Sharp.IconButton btnTimKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgvDanhSachSanPham;
        private FontAwesome.Sharp.IconButton btnXoaALL;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridView dtgvGioHang;
        private System.Windows.Forms.TextBox txtMieuTaSP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTienGiam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTamTinh;
        private FontAwesome.Sharp.IconButton btnChuyenQua;
    }
}