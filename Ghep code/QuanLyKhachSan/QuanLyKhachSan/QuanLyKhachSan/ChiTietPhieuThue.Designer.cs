namespace QuanLyKhachSan
{
    partial class ChiTietPhieuThue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_DsPhieuThue = new System.Windows.Forms.DataGridView();
            this.col_DsPTP_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DsPTP_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DsPTP_NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DsPTP_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DsPhieuThue = new System.Windows.Forms.GroupBox();
            this.gb_DsKhach = new System.Windows.Forms.GroupBox();
            this.dgv_ThongTinKhachHang = new System.Windows.Forms.DataGridView();
            this.col_ThongTinKH_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThongTinKH_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThongTinKH_LoaiKhach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_ThongTinKH_CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThongTinKH_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_LuaChon = new System.Windows.Forms.GroupBox();
            this.bt_ThemKhach = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_HienThi = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.tb_TenPhong = new System.Windows.Forms.Label();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.bt_ChonLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsPhieuThue)).BeginInit();
            this.gb_DsPhieuThue.SuspendLayout();
            this.gb_DsKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinKhachHang)).BeginInit();
            this.gb_LuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DsPhieuThue
            // 
            this.dgv_DsPhieuThue.AllowUserToAddRows = false;
            this.dgv_DsPhieuThue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DsPhieuThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DsPhieuThue.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_DsPhieuThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DsPhieuThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DsPhieuThue.ColumnHeadersHeight = 40;
            this.dgv_DsPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DsPTP_STT,
            this.col_DsPTP_Phong,
            this.col_DsPTP_NgayThue,
            this.col_DsPTP_DonGia});
            this.dgv_DsPhieuThue.EnableHeadersVisualStyles = false;
            this.dgv_DsPhieuThue.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_DsPhieuThue.Location = new System.Drawing.Point(7, 28);
            this.dgv_DsPhieuThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_DsPhieuThue.Name = "dgv_DsPhieuThue";
            this.dgv_DsPhieuThue.ReadOnly = true;
            this.dgv_DsPhieuThue.RowHeadersWidth = 30;
            this.dgv_DsPhieuThue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_DsPhieuThue.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DsPhieuThue.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DsPhieuThue.RowTemplate.Height = 30;
            this.dgv_DsPhieuThue.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DsPhieuThue.Size = new System.Drawing.Size(572, 137);
            this.dgv_DsPhieuThue.TabIndex = 31;
            this.dgv_DsPhieuThue.SelectionChanged += new System.EventHandler(this.dgv_DsPhieuThue_SelectionChanged);
            // 
            // col_DsPTP_STT
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.col_DsPTP_STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_DsPTP_STT.HeaderText = "STT";
            this.col_DsPTP_STT.Name = "col_DsPTP_STT";
            this.col_DsPTP_STT.ReadOnly = true;
            this.col_DsPTP_STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_DsPTP_STT.Width = 60;
            // 
            // col_DsPTP_Phong
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_DsPTP_Phong.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_DsPTP_Phong.HeaderText = "Phòng";
            this.col_DsPTP_Phong.Name = "col_DsPTP_Phong";
            this.col_DsPTP_Phong.ReadOnly = true;
            this.col_DsPTP_Phong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_DsPTP_Phong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_DsPTP_Phong.Width = 150;
            // 
            // col_DsPTP_NgayThue
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_DsPTP_NgayThue.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_DsPTP_NgayThue.HeaderText = "Ngày Thuê";
            this.col_DsPTP_NgayThue.Name = "col_DsPTP_NgayThue";
            this.col_DsPTP_NgayThue.ReadOnly = true;
            this.col_DsPTP_NgayThue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_DsPTP_NgayThue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_DsPTP_NgayThue.Width = 180;
            // 
            // col_DsPTP_DonGia
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_DsPTP_DonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_DsPTP_DonGia.HeaderText = "Đơn Giá";
            this.col_DsPTP_DonGia.Name = "col_DsPTP_DonGia";
            this.col_DsPTP_DonGia.ReadOnly = true;
            this.col_DsPTP_DonGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_DsPTP_DonGia.Width = 150;
            // 
            // gb_DsPhieuThue
            // 
            this.gb_DsPhieuThue.Controls.Add(this.dgv_DsPhieuThue);
            this.gb_DsPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DsPhieuThue.ForeColor = System.Drawing.Color.DeepPink;
            this.gb_DsPhieuThue.Location = new System.Drawing.Point(11, 59);
            this.gb_DsPhieuThue.Name = "gb_DsPhieuThue";
            this.gb_DsPhieuThue.Size = new System.Drawing.Size(587, 172);
            this.gb_DsPhieuThue.TabIndex = 33;
            this.gb_DsPhieuThue.TabStop = false;
            this.gb_DsPhieuThue.Text = "Danh sách phiếu thuê phòng hiện tại";
            // 
            // gb_DsKhach
            // 
            this.gb_DsKhach.Controls.Add(this.dgv_ThongTinKhachHang);
            this.gb_DsKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DsKhach.ForeColor = System.Drawing.Color.DeepPink;
            this.gb_DsKhach.Location = new System.Drawing.Point(11, 237);
            this.gb_DsKhach.Name = "gb_DsKhach";
            this.gb_DsKhach.Size = new System.Drawing.Size(730, 172);
            this.gb_DsKhach.TabIndex = 34;
            this.gb_DsKhach.TabStop = false;
            this.gb_DsKhach.Text = "Thông tin khách hàng";
            // 
            // dgv_ThongTinKhachHang
            // 
            this.dgv_ThongTinKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ThongTinKhachHang.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_ThongTinKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ThongTinKhachHang.ColumnHeadersHeight = 40;
            this.dgv_ThongTinKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ThongTinKH_STT,
            this.col_ThongTinKH_TenKH,
            this.col_ThongTinKH_LoaiKhach,
            this.col_ThongTinKH_CMND,
            this.col_ThongTinKH_DiaChi});
            this.dgv_ThongTinKhachHang.EnableHeadersVisualStyles = false;
            this.dgv_ThongTinKhachHang.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_ThongTinKhachHang.Location = new System.Drawing.Point(9, 28);
            this.dgv_ThongTinKhachHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_ThongTinKhachHang.Name = "dgv_ThongTinKhachHang";
            this.dgv_ThongTinKhachHang.RowHeadersWidth = 30;
            this.dgv_ThongTinKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_ThongTinKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_ThongTinKhachHang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinKhachHang.RowTemplate.Height = 30;
            this.dgv_ThongTinKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongTinKhachHang.Size = new System.Drawing.Size(712, 137);
            this.dgv_ThongTinKhachHang.TabIndex = 31;
            this.dgv_ThongTinKhachHang.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_ThongTinKhachHang_RowStateChanged);
            // 
            // col_ThongTinKH_STT
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.col_ThongTinKH_STT.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_ThongTinKH_STT.HeaderText = "STT";
            this.col_ThongTinKH_STT.Name = "col_ThongTinKH_STT";
            this.col_ThongTinKH_STT.ReadOnly = true;
            this.col_ThongTinKH_STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ThongTinKH_STT.Width = 110;
            // 
            // col_ThongTinKH_TenKH
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ThongTinKH_TenKH.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_ThongTinKH_TenKH.HeaderText = "Họ Tên";
            this.col_ThongTinKH_TenKH.Name = "col_ThongTinKH_TenKH";
            this.col_ThongTinKH_TenKH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ThongTinKH_TenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_ThongTinKH_TenKH.Width = 150;
            // 
            // col_ThongTinKH_LoaiKhach
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ThongTinKH_LoaiKhach.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_ThongTinKH_LoaiKhach.HeaderText = "Loại Khách";
            this.col_ThongTinKH_LoaiKhach.Name = "col_ThongTinKH_LoaiKhach";
            this.col_ThongTinKH_LoaiKhach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ThongTinKH_LoaiKhach.Width = 150;
            // 
            // col_ThongTinKH_CMND
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ThongTinKH_CMND.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_ThongTinKH_CMND.HeaderText = "CMND";
            this.col_ThongTinKH_CMND.Name = "col_ThongTinKH_CMND";
            this.col_ThongTinKH_CMND.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ThongTinKH_CMND.Width = 90;
            // 
            // col_ThongTinKH_DiaChi
            // 
            this.col_ThongTinKH_DiaChi.HeaderText = "Địa Chỉ";
            this.col_ThongTinKH_DiaChi.Name = "col_ThongTinKH_DiaChi";
            this.col_ThongTinKH_DiaChi.Width = 180;
            // 
            // gb_LuaChon
            // 
            this.gb_LuaChon.Controls.Add(this.bt_ThemKhach);
            this.gb_LuaChon.Controls.Add(this.bt_Sua);
            this.gb_LuaChon.Controls.Add(this.bt_HienThi);
            this.gb_LuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_LuaChon.ForeColor = System.Drawing.Color.DeepPink;
            this.gb_LuaChon.Location = new System.Drawing.Point(612, 59);
            this.gb_LuaChon.Name = "gb_LuaChon";
            this.gb_LuaChon.Size = new System.Drawing.Size(129, 172);
            this.gb_LuaChon.TabIndex = 35;
            this.gb_LuaChon.TabStop = false;
            this.gb_LuaChon.Text = "Lựa chọn";
            // 
            // bt_ThemKhach
            // 
            this.bt_ThemKhach.Enabled = false;
            this.bt_ThemKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemKhach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_ThemKhach.Location = new System.Drawing.Point(9, 76);
            this.bt_ThemKhach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_ThemKhach.Name = "bt_ThemKhach";
            this.bt_ThemKhach.Size = new System.Drawing.Size(111, 41);
            this.bt_ThemKhach.TabIndex = 38;
            this.bt_ThemKhach.Text = "Thêm Khách";
            this.bt_ThemKhach.UseVisualStyleBackColor = true;
            this.bt_ThemKhach.Click += new System.EventHandler(this.bt_ThemKhach_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Sua.Location = new System.Drawing.Point(7, 124);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(113, 41);
            this.bt_Sua.TabIndex = 36;
            this.bt_Sua.Text = "Cập nhật";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_HienThi
            // 
            this.bt_HienThi.Enabled = false;
            this.bt_HienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HienThi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_HienThi.Location = new System.Drawing.Point(9, 28);
            this.bt_HienThi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_HienThi.Name = "bt_HienThi";
            this.bt_HienThi.Size = new System.Drawing.Size(111, 41);
            this.bt_HienThi.TabIndex = 24;
            this.bt_HienThi.Text = "Hiển thị";
            this.bt_HienThi.UseVisualStyleBackColor = true;
            this.bt_HienThi.Click += new System.EventHandler(this.bt_HienThi_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Thoat.Location = new System.Drawing.Point(594, 414);
            this.bt_Thoat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(109, 41);
            this.bt_Thoat.TabIndex = 37;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // tb_TenPhong
            // 
            this.tb_TenPhong.AutoSize = true;
            this.tb_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenPhong.ForeColor = System.Drawing.Color.DeepPink;
            this.tb_TenPhong.Location = new System.Drawing.Point(68, 18);
            this.tb_TenPhong.Name = "tb_TenPhong";
            this.tb_TenPhong.Size = new System.Drawing.Size(112, 24);
            this.tb_TenPhong.TabIndex = 38;
            this.tb_TenPhong.Text = "Tìm phòng :";
            // 
            // cb_Phong
            // 
            this.cb_Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(186, 14);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(199, 28);
            this.cb_Phong.TabIndex = 39;
            this.cb_Phong.TextChanged += new System.EventHandler(this.cb_Phong_TextChanged);
            // 
            // bt_ChonLai
            // 
            this.bt_ChonLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChonLai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_ChonLai.Location = new System.Drawing.Point(463, 9);
            this.bt_ChonLai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_ChonLai.Name = "bt_ChonLai";
            this.bt_ChonLai.Size = new System.Drawing.Size(109, 33);
            this.bt_ChonLai.TabIndex = 40;
            this.bt_ChonLai.Text = "Chọn lại";
            this.bt_ChonLai.UseVisualStyleBackColor = true;
            this.bt_ChonLai.Click += new System.EventHandler(this.bt_ChonLai_Click);
            // 
            // ChiTietPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 466);
            this.Controls.Add(this.bt_ChonLai);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.tb_TenPhong);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.gb_LuaChon);
            this.Controls.Add(this.gb_DsKhach);
            this.Controls.Add(this.gb_DsPhieuThue);
            this.Name = "ChiTietPhieuThue";
            this.Text = "Chi Tiết Phiếu Thuê";
            this.Load += new System.EventHandler(this.PhieuThueHienTai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsPhieuThue)).EndInit();
            this.gb_DsPhieuThue.ResumeLayout(false);
            this.gb_DsKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinKhachHang)).EndInit();
            this.gb_LuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DsPhieuThue;
        private System.Windows.Forms.GroupBox gb_DsPhieuThue;
        private System.Windows.Forms.GroupBox gb_DsKhach;
        private System.Windows.Forms.DataGridView dgv_ThongTinKhachHang;
        private System.Windows.Forms.GroupBox gb_LuaChon;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_HienThi;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_ThemKhach;
        private System.Windows.Forms.Label tb_TenPhong;
        private System.Windows.Forms.ComboBox cb_Phong;
        private System.Windows.Forms.Button bt_ChonLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DsPTP_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DsPTP_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DsPTP_NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DsPTP_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThongTinKH_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThongTinKH_TenKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_ThongTinKH_LoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThongTinKH_CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThongTinKH_DiaChi;

    }
}