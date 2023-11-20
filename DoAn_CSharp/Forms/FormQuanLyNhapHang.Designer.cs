namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyNhapHang
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
            this.tbQuanLyNhapHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnXoaQLPN = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiemQLPN = new System.Windows.Forms.ComboBox();
            this.txtTimKiemQLPN = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongSoLuongNhap = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaALLTPN = new FontAwesome.Sharp.IconButton();
            this.btnXoaTPN = new FontAwesome.Sharp.IconButton();
            this.dtgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.cbTimKiemTPN = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemTPN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLapPhieuTPN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.btnChuyenQua = new FontAwesome.Sharp.IconButton();
            this.tbQuanLyNhapHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuanLyNhapHang
            // 
            this.tbQuanLyNhapHang.Controls.Add(this.tabPage1);
            this.tbQuanLyNhapHang.Controls.Add(this.tabPage2);
            this.tbQuanLyNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuanLyNhapHang.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuanLyNhapHang.Location = new System.Drawing.Point(0, 0);
            this.tbQuanLyNhapHang.Name = "tbQuanLyNhapHang";
            this.tbQuanLyNhapHang.SelectedIndex = 0;
            this.tbQuanLyNhapHang.Size = new System.Drawing.Size(984, 589);
            this.tbQuanLyNhapHang.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Phiếu Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietPhieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(185, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dtgvChiTietPhieuNhap
            // 
            this.dtgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuNhap.Location = new System.Drawing.Point(6, 19);
            this.dtgvChiTietPhieuNhap.Name = "dtgvChiTietPhieuNhap";
            this.dtgvChiTietPhieuNhap.Size = new System.Drawing.Size(593, 205);
            this.dtgvChiTietPhieuNhap.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachPhieuNhap);
            this.groupBox1.Controls.Add(this.btnXoaQLPN);
            this.groupBox1.Controls.Add(this.dateTimePickerDenNgay);
            this.groupBox1.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTimKiemQLPN);
            this.groupBox1.Controls.Add(this.txtTimKiemQLPN);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Nhập";
            // 
            // dtgvDanhSachPhieuNhap
            // 
            this.dtgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuNhap.Location = new System.Drawing.Point(6, 101);
            this.dtgvDanhSachPhieuNhap.Name = "dtgvDanhSachPhieuNhap";
            this.dtgvDanhSachPhieuNhap.Size = new System.Drawing.Size(950, 191);
            this.dtgvDanhSachPhieuNhap.TabIndex = 69;
            // 
            // btnXoaQLPN
            // 
            this.btnXoaQLPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaQLPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaQLPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaQLPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaQLPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaQLPN.Location = new System.Drawing.Point(741, 52);
            this.btnXoaQLPN.Name = "btnXoaQLPN";
            this.btnXoaQLPN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaQLPN.TabIndex = 68;
            this.btnXoaQLPN.Text = "Xóa";
            this.btnXoaQLPN.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(483, 66);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerDenNgay.TabIndex = 67;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(324, 66);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerTuNgay.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Đến Ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Từ Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Lọc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Tìm Kiếm :";
            // 
            // cbTimKiemQLPN
            // 
            this.cbTimKiemQLPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemQLPN.FormattingEnabled = true;
            this.cbTimKiemQLPN.Location = new System.Drawing.Point(553, 13);
            this.cbTimKiemQLPN.Name = "cbTimKiemQLPN";
            this.cbTimKiemQLPN.Size = new System.Drawing.Size(115, 22);
            this.cbTimKiemQLPN.TabIndex = 61;
            // 
            // txtTimKiemQLPN
            // 
            this.txtTimKiemQLPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemQLPN.Location = new System.Drawing.Point(324, 13);
            this.txtTimKiemQLPN.Name = "txtTimKiemQLPN";
            this.txtTimKiemQLPN.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiemQLPN.TabIndex = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChuyenQua);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNhapHang);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtTongSoLuongNhap);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(527, 344);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(440, 208);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập Hàng";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.Location = new System.Drawing.Point(152, 141);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(148, 28);
            this.btnNhapHang.TabIndex = 66;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tổng Số Lượng Nhập :";
            // 
            // txtTongSoLuongNhap
            // 
            this.txtTongSoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuongNhap.Location = new System.Drawing.Point(180, 60);
            this.txtTongSoLuongNhap.Name = "txtTongSoLuongNhap";
            this.txtTongSoLuongNhap.Size = new System.Drawing.Size(226, 20);
            this.txtTongSoLuongNhap.TabIndex = 59;
            this.txtTongSoLuongNhap.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(465, 208);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hình Ảnh Sản Phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaALLTPN);
            this.groupBox4.Controls.Add(this.btnXoaTPN);
            this.groupBox4.Controls.Add(this.dtgvChiTietNhapHang);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(511, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 261);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Nhập Hàng";
            // 
            // btnXoaALLTPN
            // 
            this.btnXoaALLTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaALLTPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaALLTPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaALLTPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaALLTPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaALLTPN.Location = new System.Drawing.Point(279, 32);
            this.btnXoaALLTPN.Name = "btnXoaALLTPN";
            this.btnXoaALLTPN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaALLTPN.TabIndex = 65;
            this.btnXoaALLTPN.Text = "Xóa ALL ";
            this.btnXoaALLTPN.UseVisualStyleBackColor = true;
            // 
            // btnXoaTPN
            // 
            this.btnXoaTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaTPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaTPN.Location = new System.Drawing.Point(376, 32);
            this.btnXoaTPN.Name = "btnXoaTPN";
            this.btnXoaTPN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTPN.TabIndex = 64;
            this.btnXoaTPN.Text = "Xóa";
            this.btnXoaTPN.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietNhapHang
            // 
            this.dtgvChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietNhapHang.Location = new System.Drawing.Point(6, 71);
            this.dtgvChiTietNhapHang.Name = "dtgvChiTietNhapHang";
            this.dtgvChiTietNhapHang.Size = new System.Drawing.Size(456, 184);
            this.dtgvChiTietNhapHang.TabIndex = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvDanhSachSanPham);
            this.groupBox3.Controls.Add(this.cbTimKiemTPN);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTimKiemTPN);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 261);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm ";
            // 
            // dtgvDanhSachSanPham
            // 
            this.dtgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSanPham.Location = new System.Drawing.Point(6, 71);
            this.dtgvDanhSachSanPham.Name = "dtgvDanhSachSanPham";
            this.dtgvDanhSachSanPham.Size = new System.Drawing.Size(453, 184);
            this.dtgvDanhSachSanPham.TabIndex = 62;
            // 
            // cbTimKiemTPN
            // 
            this.cbTimKiemTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTPN.FormattingEnabled = true;
            this.cbTimKiemTPN.Location = new System.Drawing.Point(299, 36);
            this.cbTimKiemTPN.Name = "cbTimKiemTPN";
            this.cbTimKiemTPN.Size = new System.Drawing.Size(141, 22);
            this.cbTimKiemTPN.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tìm Kiếm :";
            // 
            // txtTimKiemTPN
            // 
            this.txtTimKiemTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTPN.Location = new System.Drawing.Point(102, 36);
            this.txtTimKiemTPN.Name = "txtTimKiemTPN";
            this.txtTimKiemTPN.Size = new System.Drawing.Size(165, 20);
            this.txtTimKiemTPN.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.dateTimePickerNgayLapPhieuTPN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 65);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nhân Viên :";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(739, 21);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(200, 20);
            this.txtMaNhanVien.TabIndex = 56;
            // 
            // dateTimePickerNgayLapPhieuTPN
            // 
            this.dateTimePickerNgayLapPhieuTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLapPhieuTPN.Location = new System.Drawing.Point(409, 19);
            this.dateTimePickerNgayLapPhieuTPN.Name = "dateTimePickerNgayLapPhieuTPN";
            this.dateTimePickerNgayLapPhieuTPN.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayLapPhieuTPN.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Ngày Lập Phiếu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã Phiếu Nhập :";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(138, 19);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(115, 20);
            this.txtMaPhieuNhap.TabIndex = 53;
            // 
            // btnChuyenQua
            // 
            this.btnChuyenQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenQua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenQua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChuyenQua.IconColor = System.Drawing.Color.Black;
            this.btnChuyenQua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChuyenQua.Location = new System.Drawing.Point(473, 216);
            this.btnChuyenQua.Name = "btnChuyenQua";
            this.btnChuyenQua.Size = new System.Drawing.Size(38, 23);
            this.btnChuyenQua.TabIndex = 66;
            this.btnChuyenQua.Text = ">";
            this.btnChuyenQua.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.tbQuanLyNhapHang);
            this.Name = "FormQuanLyNhapHang";
            this.Text = "QUẢN LÝ NHẬP HÀNG";
            this.tbQuanLyNhapHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbQuanLyNhapHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuNhap;
        private FontAwesome.Sharp.IconButton btnXoaQLPN;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiemQLPN;
        private System.Windows.Forms.TextBox txtTimKiemQLPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapPhieuTPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTimKiemTPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiemTPN;
        private System.Windows.Forms.DataGridView dtgvDanhSachSanPham;
        private System.Windows.Forms.DataGridView dtgvChiTietNhapHang;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongSoLuongNhap;
        private FontAwesome.Sharp.IconButton btnXoaALLTPN;
        private FontAwesome.Sharp.IconButton btnXoaTPN;
        private FontAwesome.Sharp.IconButton btnChuyenQua;
    }
}