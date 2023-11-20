namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyNhanVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.cbMaChucVu = new System.Windows.Forms.ComboBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvQuanLyNhanVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtLocTu = new System.Windows.Forms.TextBox();
            this.txtLocToi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.btnChonAnh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chức Vụ :";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(144, 12);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(319, 20);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(144, 141);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(319, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Tài Khoản :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật Khẩu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ Tên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa Chỉ : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "SĐT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "CCCD /CMND :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giới Tính :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tìm Kiếm :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Lọc Theo Mã : ";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(144, 79);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(319, 20);
            this.txtTenTaiKhoan.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(144, 108);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(319, 20);
            this.txtMatKhau.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(144, 178);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(319, 20);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(144, 214);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(319, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(144, 253);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(319, 20);
            this.txtCCCD.TabIndex = 17;
            // 
            // cbMaChucVu
            // 
            this.cbMaChucVu.FormattingEnabled = true;
            this.cbMaChucVu.Location = new System.Drawing.Point(144, 47);
            this.cbMaChucVu.Name = "cbMaChucVu";
            this.cbMaChucVu.Size = new System.Drawing.Size(121, 22);
            this.cbMaChucVu.TabIndex = 18;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(280, 49);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(183, 20);
            this.txtMaChucVu.TabIndex = 19;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(144, 296);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(319, 22);
            this.cbGioiTinh.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(654, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ảnh Nhân Viên : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(654, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Hình Ảnh Ở Đây :";
            // 
            // dtgvQuanLyNhanVien
            // 
            this.dtgvQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanLyNhanVien.Location = new System.Drawing.Point(6, 419);
            this.dtgvQuanLyNhanVien.Name = "dtgvQuanLyNhanVien";
            this.dtgvQuanLyNhanVien.Size = new System.Drawing.Size(966, 162);
            this.dtgvQuanLyNhanVien.TabIndex = 24;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(144, 339);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(153, 20);
            this.txtTimKiem.TabIndex = 28;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(313, 340);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(150, 22);
            this.cbTimKiem.TabIndex = 29;
            // 
            // txtLocTu
            // 
            this.txtLocTu.Location = new System.Drawing.Point(174, 383);
            this.txtLocTu.Name = "txtLocTu";
            this.txtLocTu.Size = new System.Drawing.Size(91, 20);
            this.txtLocTu.TabIndex = 32;
            // 
            // txtLocToi
            // 
            this.txtLocToi.Location = new System.Drawing.Point(345, 383);
            this.txtLocToi.Name = "txtLocToi";
            this.txtLocToi.Size = new System.Drawing.Size(91, 20);
            this.txtLocToi.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(171, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "Từ : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "Tới :";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(521, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(838, 316);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCapNhat.IconColor = System.Drawing.Color.Black;
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.Location = new System.Drawing.Point(739, 316);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 55;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(641, 316);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.Location = new System.Drawing.Point(853, 366);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(88, 23);
            this.btnXuatExcel.TabIndex = 58;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChonAnh.IconColor = System.Drawing.Color.Black;
            this.btnChonAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonAnh.Location = new System.Drawing.Point(866, 79);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 59;
            this.btnChonAnh.Text = "Chọn Ảnh ";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLocToi);
            this.Controls.Add(this.txtLocTu);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dtgvQuanLyNhanVien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.cbMaChucVu);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormQuanLyNhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.ComboBox cbMaChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgvQuanLyNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtLocTu;
        private System.Windows.Forms.TextBox txtLocToi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private FontAwesome.Sharp.IconButton btnChonAnh;
    }
}