namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyNhaCungCap
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
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtSDTNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChiNhaCungCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtgvQuanLyNhaCungCap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSanPhamCuaNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyNhaCungCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamCuaNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(409, 36);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(319, 20);
            this.txtTenNhaCungCap.TabIndex = 51;
            // 
            // txtSDTNhaCungCap
            // 
            this.txtSDTNhaCungCap.Location = new System.Drawing.Point(408, 99);
            this.txtSDTNhaCungCap.Name = "txtSDTNhaCungCap";
            this.txtSDTNhaCungCap.Size = new System.Drawing.Size(319, 20);
            this.txtSDTNhaCungCap.TabIndex = 50;
            // 
            // txtDiaChiNhaCungCap
            // 
            this.txtDiaChiNhaCungCap.Location = new System.Drawing.Point(408, 65);
            this.txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            this.txtDiaChiNhaCungCap.Size = new System.Drawing.Size(319, 20);
            this.txtDiaChiNhaCungCap.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "SĐT Nhà Cung Cấp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Địa Chỉ Nhà Cung Cấp :";
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(409, 6);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(319, 20);
            this.txtMaNhaCungCap.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Nhà Cung Cấp : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã Nhà Cung Cấp : ";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(626, 187);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(150, 21);
            this.cbTimKiem.TabIndex = 58;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(299, 187);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(303, 20);
            this.txtTimKiem.TabIndex = 57;
            // 
            // dtgvQuanLyNhaCungCap
            // 
            this.dtgvQuanLyNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanLyNhaCungCap.Location = new System.Drawing.Point(13, 228);
            this.dtgvQuanLyNhaCungCap.Name = "dtgvQuanLyNhaCungCap";
            this.dtgvQuanLyNhaCungCap.Size = new System.Drawing.Size(966, 163);
            this.dtgvQuanLyNhaCungCap.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSanPhamCuaNhaCungCap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 171);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm Của Nhà Cung Cấp :";
            // 
            // dtgvSanPhamCuaNhaCungCap
            // 
            this.dtgvSanPhamCuaNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPhamCuaNhaCungCap.Location = new System.Drawing.Point(6, 25);
            this.dtgvSanPhamCuaNhaCungCap.Name = "dtgvSanPhamCuaNhaCungCap";
            this.dtgvSanPhamCuaNhaCungCap.Size = new System.Drawing.Size(954, 140);
            this.dtgvSanPhamCuaNhaCungCap.TabIndex = 62;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(722, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 66;
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
            this.btnXoa.Location = new System.Drawing.Point(606, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 65;
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
            this.btnCapNhat.Location = new System.Drawing.Point(507, 142);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 64;
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
            this.btnThem.Location = new System.Drawing.Point(409, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 63;
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
            this.btnXuatExcel.Location = new System.Drawing.Point(831, 184);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(88, 23);
            this.btnXuatExcel.TabIndex = 67;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgvQuanLyNhaCungCap);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.txtSDTNhaCungCap);
            this.Controls.Add(this.txtDiaChiNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNhaCungCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyNhaCungCap";
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyNhaCungCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamCuaNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtSDTNhaCungCap;
        private System.Windows.Forms.TextBox txtDiaChiNhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgvQuanLyNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSanPhamCuaNhaCungCap;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
    }
}