namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyHoaDon
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
            this.dtgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatHoaDon = new FontAwesome.Sharp.IconButton();
            this.reportViewerHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachHoaDon);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dateTimePickerDenNgay);
            this.groupBox1.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dtgvDanhSachHoaDon
            // 
            this.dtgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDon.Location = new System.Drawing.Point(6, 140);
            this.dtgvDanhSachHoaDon.Name = "dtgvDanhSachHoaDon";
            this.dtgvDanhSachHoaDon.Size = new System.Drawing.Size(504, 201);
            this.dtgvDanhSachHoaDon.TabIndex = 60;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(435, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(263, 103);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerDenNgay.TabIndex = 58;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(104, 103);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerTuNgay.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Đến Ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Từ Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Lọc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tìm Kiếm :";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(333, 41);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(115, 22);
            this.cbTimKiem.TabIndex = 51;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(104, 41);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 233);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dtgvChiTietHoaDon
            // 
            this.dtgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHoaDon.Location = new System.Drawing.Point(6, 21);
            this.dtgvChiTietHoaDon.Name = "dtgvChiTietHoaDon";
            this.dtgvChiTietHoaDon.Size = new System.Drawing.Size(504, 201);
            this.dtgvChiTietHoaDon.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuatHoaDon);
            this.panel1.Location = new System.Drawing.Point(524, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatHoaDon.IconColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(175, 13);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(124, 23);
            this.btnXuatHoaDon.TabIndex = 61;
            this.btnXuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // reportViewerHoaDon
            // 
            this.reportViewerHoaDon.Location = new System.Drawing.Point(524, 69);
            this.reportViewerHoaDon.Name = "reportViewerHoaDon";
            this.reportViewerHoaDon.ServerReport.BearerToken = null;
            this.reportViewerHoaDon.Size = new System.Drawing.Size(460, 508);
            this.reportViewerHoaDon.TabIndex = 5;
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.reportViewerHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "QUẢN LÝ HÓA ĐƠN ";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDon;
        private System.Windows.Forms.DataGridView dtgvChiTietHoaDon;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHoaDon;
        private FontAwesome.Sharp.IconButton btnXuatHoaDon;
    }
}