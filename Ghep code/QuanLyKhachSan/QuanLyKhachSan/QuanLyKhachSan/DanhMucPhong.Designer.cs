namespace QuanLyKhachSan
{
    partial class DanhMucPhong
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
            this.lv_DanhMucPhong = new System.Windows.Forms.ListView();
            this.col_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Phong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_LoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Phong = new System.Windows.Forms.Label();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_GhiChu = new System.Windows.Forms.Label();
            this.tb_NhapTenPhong = new System.Windows.Forms.TextBox();
            this.tb_GhiChu = new System.Windows.Forms.TextBox();
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.cb_DonGia = new System.Windows.Forms.ComboBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.gbDsPhong = new System.Windows.Forms.GroupBox();
            this.bt_ThemMoi = new System.Windows.Forms.Button();
            this.gbLuaChon.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.gbDsPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_DanhMucPhong
            // 
            this.lv_DanhMucPhong.BackColor = System.Drawing.Color.LavenderBlush;
            this.lv_DanhMucPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_STT,
            this.col_Phong,
            this.col_LoaiPhong,
            this.col_DonGia,
            this.col_GhiChu});
            this.lv_DanhMucPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DanhMucPhong.FullRowSelect = true;
            this.lv_DanhMucPhong.GridLines = true;
            this.lv_DanhMucPhong.Location = new System.Drawing.Point(10, 24);
            this.lv_DanhMucPhong.Name = "lv_DanhMucPhong";
            this.lv_DanhMucPhong.Size = new System.Drawing.Size(582, 136);
            this.lv_DanhMucPhong.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_DanhMucPhong.TabIndex = 0;
            this.lv_DanhMucPhong.UseCompatibleStateImageBehavior = false;
            this.lv_DanhMucPhong.View = System.Windows.Forms.View.Details;
            this.lv_DanhMucPhong.SelectedIndexChanged += new System.EventHandler(this.lv_DanhMucPhong_SelectedIndexChanged);
            // 
            // col_STT
            // 
            this.col_STT.Text = "STT";
            this.col_STT.Width = 80;
            // 
            // col_Phong
            // 
            this.col_Phong.Text = "Phòng";
            this.col_Phong.Width = 84;
            // 
            // col_LoaiPhong
            // 
            this.col_LoaiPhong.Text = "Loại Phòng";
            this.col_LoaiPhong.Width = 98;
            // 
            // col_DonGia
            // 
            this.col_DonGia.Text = "Đơn Giá";
            this.col_DonGia.Width = 85;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.Text = "Ghi Chú";
            this.col_GhiChu.Width = 230;
            // 
            // lb_Phong
            // 
            this.lb_Phong.AutoSize = true;
            this.lb_Phong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phong.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_Phong.Location = new System.Drawing.Point(6, 34);
            this.lb_Phong.Name = "lb_Phong";
            this.lb_Phong.Size = new System.Drawing.Size(57, 21);
            this.lb_Phong.TabIndex = 1;
            this.lb_Phong.Text = "Phòng";
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.AutoSize = true;
            this.lb_LoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiPhong.Location = new System.Drawing.Point(6, 76);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(91, 21);
            this.lb_LoaiPhong.TabIndex = 2;
            this.lb_LoaiPhong.Text = "Loại Phòng";
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGia.Location = new System.Drawing.Point(326, 72);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(67, 21);
            this.lb_DonGia.TabIndex = 3;
            this.lb_DonGia.Text = "Đơn Giá";
            // 
            // lb_GhiChu
            // 
            this.lb_GhiChu.AutoSize = true;
            this.lb_GhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GhiChu.Location = new System.Drawing.Point(327, 31);
            this.lb_GhiChu.Name = "lb_GhiChu";
            this.lb_GhiChu.Size = new System.Drawing.Size(66, 21);
            this.lb_GhiChu.TabIndex = 4;
            this.lb_GhiChu.Text = "Ghi Chú";
            // 
            // tb_NhapTenPhong
            // 
            this.tb_NhapTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapTenPhong.Location = new System.Drawing.Point(111, 32);
            this.tb_NhapTenPhong.Name = "tb_NhapTenPhong";
            this.tb_NhapTenPhong.Size = new System.Drawing.Size(183, 23);
            this.tb_NhapTenPhong.TabIndex = 5;
            this.tb_NhapTenPhong.TextChanged += new System.EventHandler(this.tb_NhapTenPhong_TextChanged);
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GhiChu.Location = new System.Drawing.Point(408, 29);
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.Size = new System.Drawing.Size(263, 23);
            this.tb_GhiChu.TabIndex = 7;
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Location = new System.Drawing.Point(111, 73);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(183, 24);
            this.cb_LoaiPhong.Sorted = true;
            this.cb_LoaiPhong.TabIndex = 8;
            this.cb_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiPhong_SelectedIndexChanged);
            this.cb_LoaiPhong.SelectedValueChanged += new System.EventHandler(this.cb_LoaiPhong_SelectedValueChanged);
            // 
            // cb_DonGia
            // 
            this.cb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DonGia.FormattingEnabled = true;
            this.cb_DonGia.Location = new System.Drawing.Point(408, 69);
            this.cb_DonGia.Name = "cb_DonGia";
            this.cb_DonGia.Size = new System.Drawing.Size(263, 24);
            this.cb_DonGia.Sorted = true;
            this.cb_DonGia.TabIndex = 9;
            this.cb_DonGia.SelectedIndexChanged += new System.EventHandler(this.cb_DonGia_SelectedIndexChanged);
            // 
            // bt_Them
            // 
            this.bt_Them.Enabled = false;
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Them.Location = new System.Drawing.Point(6, 25);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(94, 30);
            this.bt_Them.TabIndex = 10;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Enabled = false;
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Xoa.Location = new System.Drawing.Point(6, 61);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(94, 30);
            this.bt_Xoa.TabIndex = 11;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Enabled = false;
            this.bt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Sua.Location = new System.Drawing.Point(6, 97);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(94, 30);
            this.bt_Sua.TabIndex = 12;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Thoat.Location = new System.Drawing.Point(510, 303);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(94, 30);
            this.bt_Thoat.TabIndex = 13;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Luu.Location = new System.Drawing.Point(262, 301);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(94, 30);
            this.bt_Luu.TabIndex = 14;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.bt_Reset);
            this.gbLuaChon.Controls.Add(this.bt_Sua);
            this.gbLuaChon.Controls.Add(this.bt_Xoa);
            this.gbLuaChon.Controls.Add(this.bt_Them);
            this.gbLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.DeepPink;
            this.gbLuaChon.Location = new System.Drawing.Point(616, 129);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Size = new System.Drawing.Size(106, 166);
            this.gbLuaChon.TabIndex = 15;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa chọn";
            // 
            // bt_Reset
            // 
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_Reset.Location = new System.Drawing.Point(6, 133);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(94, 30);
            this.bt_Reset.TabIndex = 19;
            this.bt_Reset.Text = "Mặc Định";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lb_Phong);
            this.gbThongTin.Controls.Add(this.lb_LoaiPhong);
            this.gbThongTin.Controls.Add(this.tb_NhapTenPhong);
            this.gbThongTin.Controls.Add(this.cb_LoaiPhong);
            this.gbThongTin.Controls.Add(this.cb_DonGia);
            this.gbThongTin.Controls.Add(this.lb_GhiChu);
            this.gbThongTin.Controls.Add(this.tb_GhiChu);
            this.gbThongTin.Controls.Add(this.lb_DonGia);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.DeepPink;
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(704, 111);
            this.gbThongTin.TabIndex = 16;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // gbDsPhong
            // 
            this.gbDsPhong.Controls.Add(this.lv_DanhMucPhong);
            this.gbDsPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDsPhong.ForeColor = System.Drawing.Color.DeepPink;
            this.gbDsPhong.Location = new System.Drawing.Point(12, 129);
            this.gbDsPhong.Name = "gbDsPhong";
            this.gbDsPhong.Size = new System.Drawing.Size(598, 166);
            this.gbDsPhong.TabIndex = 17;
            this.gbDsPhong.TabStop = false;
            this.gbDsPhong.Text = "Danh Sách Phòng";
            // 
            // bt_ThemMoi
            // 
            this.bt_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemMoi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_ThemMoi.Location = new System.Drawing.Point(22, 303);
            this.bt_ThemMoi.Name = "bt_ThemMoi";
            this.bt_ThemMoi.Size = new System.Drawing.Size(106, 30);
            this.bt_ThemMoi.TabIndex = 18;
            this.bt_ThemMoi.Text = "Thêm Mới";
            this.bt_ThemMoi.UseVisualStyleBackColor = true;
            this.bt_ThemMoi.Click += new System.EventHandler(this.bt_ThemMoi_Click);
            // 
            // DanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 345);
            this.Controls.Add(this.bt_ThemMoi);
            this.Controls.Add(this.gbDsPhong);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_Thoat);
            this.MaximizeBox = false;
            this.Name = "DanhMucPhong";
            this.Text = "Danh Mục Phòng";
            this.Load += new System.EventHandler(this.DanhMucPhong_Load);
            this.gbLuaChon.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbDsPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_DanhMucPhong;
        private System.Windows.Forms.ColumnHeader col_STT;
        private System.Windows.Forms.ColumnHeader col_Phong;
        private System.Windows.Forms.ColumnHeader col_LoaiPhong;
        private System.Windows.Forms.ColumnHeader col_DonGia;
        private System.Windows.Forms.ColumnHeader col_GhiChu;
        private System.Windows.Forms.Label lb_Phong;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_GhiChu;
        private System.Windows.Forms.TextBox tb_NhapTenPhong;
        private System.Windows.Forms.TextBox tb_GhiChu;
        private System.Windows.Forms.ComboBox cb_LoaiPhong;
        private System.Windows.Forms.ComboBox cb_DonGia;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbDsPhong;
        private System.Windows.Forms.Button bt_ThemMoi;
        private System.Windows.Forms.Button bt_Reset;

    }
}