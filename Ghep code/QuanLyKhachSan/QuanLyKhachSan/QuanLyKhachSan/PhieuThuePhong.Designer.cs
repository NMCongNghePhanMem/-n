namespace QuanLyKhachSan
{
    partial class PhieuThuePhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.lb_NgayThue = new System.Windows.Forms.Label();
            this.lb_Phong = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_TenPhong = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachKhach = new System.Windows.Forms.DataGridView();
            this.col_DS_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiKhach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThemKhach = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.bt_TaoMoi = new System.Windows.Forms.Button();
            this.gb_DsKhach = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhach)).BeginInit();
            this.gb_DsKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Thoat.Location = new System.Drawing.Point(712, 304);
            this.bt_Thoat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(104, 41);
            this.bt_Thoat.TabIndex = 26;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Luu.Location = new System.Drawing.Point(238, 304);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(114, 41);
            this.bt_Luu.TabIndex = 23;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // lb_NgayThue
            // 
            this.lb_NgayThue.AutoSize = true;
            this.lb_NgayThue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayThue.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_NgayThue.Location = new System.Drawing.Point(82, 68);
            this.lb_NgayThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NgayThue.Name = "lb_NgayThue";
            this.lb_NgayThue.Size = new System.Drawing.Size(148, 21);
            this.lb_NgayThue.TabIndex = 18;
            this.lb_NgayThue.Text = "Ngày Bắt Đầu Thuê";
            // 
            // lb_Phong
            // 
            this.lb_Phong.AutoSize = true;
            this.lb_Phong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phong.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_Phong.Location = new System.Drawing.Point(144, 17);
            this.lb_Phong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Phong.Name = "lb_Phong";
            this.lb_Phong.Size = new System.Drawing.Size(86, 21);
            this.lb_Phong.TabIndex = 15;
            this.lb_Phong.Text = "Tên Phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 23);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // cb_TenPhong
            // 
            this.cb_TenPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenPhong.FormattingEnabled = true;
            this.cb_TenPhong.Location = new System.Drawing.Point(276, 17);
            this.cb_TenPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_TenPhong.Name = "cb_TenPhong";
            this.cb_TenPhong.Size = new System.Drawing.Size(276, 24);
            this.cb_TenPhong.TabIndex = 31;
            // 
            // dgvDanhSachKhach
            // 
            this.dgvDanhSachKhach.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachKhach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKhach.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvDanhSachKhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKhach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachKhach.ColumnHeadersHeight = 40;
            this.dgvDanhSachKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DS_STT,
            this.colTenKhachHang,
            this.colLoaiKhach,
            this.colCMND,
            this.colDiaChi});
            this.dgvDanhSachKhach.EnableHeadersVisualStyles = false;
            this.dgvDanhSachKhach.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvDanhSachKhach.Location = new System.Drawing.Point(9, 29);
            this.dgvDanhSachKhach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvDanhSachKhach.Name = "dgvDanhSachKhach";
            this.dgvDanhSachKhach.RowHeadersWidth = 30;
            this.dgvDanhSachKhach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDanhSachKhach.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhSachKhach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachKhach.RowTemplate.Height = 30;
            this.dgvDanhSachKhach.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachKhach.Size = new System.Drawing.Size(802, 137);
            this.dgvDanhSachKhach.TabIndex = 30;
            // 
            // col_DS_STT
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.col_DS_STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_DS_STT.HeaderText = "STT";
            this.col_DS_STT.Name = "col_DS_STT";
            this.col_DS_STT.ReadOnly = true;
            this.col_DS_STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_DS_STT.Width = 70;
            // 
            // colTenKhachHang
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenKhachHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTenKhachHang.HeaderText = "Khách Hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenKhachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenKhachHang.Width = 180;
            // 
            // colLoaiKhach
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoaiKhach.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLoaiKhach.HeaderText = "Loại Khách";
            this.colLoaiKhach.Name = "colLoaiKhach";
            this.colLoaiKhach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLoaiKhach.Width = 150;
            // 
            // colCMND
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCMND.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCMND.Width = 120;
            // 
            // colDiaChi
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiaChi.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiaChi.Width = 250;
            // 
            // btThemKhach
            // 
            this.btThemKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKhach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btThemKhach.Location = new System.Drawing.Point(608, 50);
            this.btThemKhach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btThemKhach.Name = "btThemKhach";
            this.btThemKhach.Size = new System.Drawing.Size(160, 41);
            this.btThemKhach.TabIndex = 32;
            this.btThemKhach.Text = "Thêm Khách";
            this.btThemKhach.UseVisualStyleBackColor = true;
            this.btThemKhach.Click += new System.EventHandler(this.btThemKhach_Click);
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btIn.Location = new System.Drawing.Point(484, 304);
            this.btIn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(104, 41);
            this.btIn.TabIndex = 33;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // bt_TaoMoi
            // 
            this.bt_TaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TaoMoi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_TaoMoi.Location = new System.Drawing.Point(14, 304);
            this.bt_TaoMoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_TaoMoi.Name = "bt_TaoMoi";
            this.bt_TaoMoi.Size = new System.Drawing.Size(104, 41);
            this.bt_TaoMoi.TabIndex = 34;
            this.bt_TaoMoi.Text = "Tạo mới";
            this.bt_TaoMoi.UseVisualStyleBackColor = true;
            this.bt_TaoMoi.Click += new System.EventHandler(this.bt_TaoMoi_Click);
            // 
            // gb_DsKhach
            // 
            this.gb_DsKhach.Controls.Add(this.dgvDanhSachKhach);
            this.gb_DsKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DsKhach.ForeColor = System.Drawing.Color.DeepPink;
            this.gb_DsKhach.Location = new System.Drawing.Point(4, 124);
            this.gb_DsKhach.Name = "gb_DsKhach";
            this.gb_DsKhach.Size = new System.Drawing.Size(819, 175);
            this.gb_DsKhach.TabIndex = 35;
            this.gb_DsKhach.TabStop = false;
            this.gb_DsKhach.Text = "Danh Sách Khách Hàng";
            // 
            // PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 354);
            this.Controls.Add(this.gb_DsKhach);
            this.Controls.Add(this.bt_TaoMoi);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btThemKhach);
            this.Controls.Add(this.cb_TenPhong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.lb_NgayThue);
            this.Controls.Add(this.lb_Phong);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "PhieuThuePhong";
            this.Text = "Phiếu Thuê Phòng";
            this.Load += new System.EventHandler(this.PhieuThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhach)).EndInit();
            this.gb_DsKhach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Label lb_NgayThue;
        private System.Windows.Forms.Label lb_Phong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_TenPhong;
        private System.Windows.Forms.DataGridView dgvDanhSachKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DS_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.Button btThemKhach;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button bt_TaoMoi;
        private System.Windows.Forms.GroupBox gb_DsKhach;
    }
}