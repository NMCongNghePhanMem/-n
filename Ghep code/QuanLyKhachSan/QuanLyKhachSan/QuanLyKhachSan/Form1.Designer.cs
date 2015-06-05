namespace QuanLyKhachSan
{
    partial class MainForm
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
            this.msQuanLyKhachSan = new System.Windows.Forms.MenuStrip();
            this.msPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuanLyPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msTraCuuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msPhieuThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msTaoPTP = new System.Windows.Forms.ToolStripMenuItem();
            this.msXemPTP = new System.Windows.Forms.ToolStripMenuItem();
            this.msTaiChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.msHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBaoCaoTheoLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msBaoCaoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.msQlLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msThemLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msXoaLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msSuaLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msQlLoaiKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.msThemLoaiKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.msXoaLoaiKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.msSuaLoaiKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.msThietLap = new System.Windows.Forms.ToolStripMenuItem();
            this.msSoKhachToiDa = new System.Windows.Forms.ToolStripMenuItem();
            this.msSoKhachKhongPhuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuanLyKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // msQuanLyKhachSan
            // 
            this.msQuanLyKhachSan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msQuanLyKhachSan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msQuanLyKhachSan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPhong,
            this.msPhieuThuePhong,
            this.msTaiChinh,
            this.msQuanLy,
            this.msThietLap});
            this.msQuanLyKhachSan.Location = new System.Drawing.Point(0, 0);
            this.msQuanLyKhachSan.Name = "msQuanLyKhachSan";
            this.msQuanLyKhachSan.Size = new System.Drawing.Size(650, 29);
            this.msQuanLyKhachSan.TabIndex = 1;
            this.msQuanLyKhachSan.Text = "menuStrip1";
            // 
            // msPhong
            // 
            this.msPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQuanLyPhong,
            this.msTraCuuPhong});
            this.msPhong.Name = "msPhong";
            this.msPhong.Size = new System.Drawing.Size(67, 25);
            this.msPhong.Text = "Phòng";
            // 
            // msQuanLyPhong
            // 
            this.msQuanLyPhong.Name = "msQuanLyPhong";
            this.msQuanLyPhong.Size = new System.Drawing.Size(138, 26);
            this.msQuanLyPhong.Text = "Quản Lý";
            this.msQuanLyPhong.Click += new System.EventHandler(this.msQuanLyPhong_Click);
            // 
            // msTraCuuPhong
            // 
            this.msTraCuuPhong.Name = "msTraCuuPhong";
            this.msTraCuuPhong.Size = new System.Drawing.Size(138, 26);
            this.msTraCuuPhong.Text = "Tra Cứu";
            // 
            // msPhieuThuePhong
            // 
            this.msPhieuThuePhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTaoPTP,
            this.msXemPTP});
            this.msPhieuThuePhong.Name = "msPhieuThuePhong";
            this.msPhieuThuePhong.Size = new System.Drawing.Size(148, 25);
            this.msPhieuThuePhong.Text = "Phiếu Thuê Phòng";
            // 
            // msTaoPTP
            // 
            this.msTaoPTP.Name = "msTaoPTP";
            this.msTaoPTP.Size = new System.Drawing.Size(152, 26);
            this.msTaoPTP.Text = "Tạo Mới";
            this.msTaoPTP.Click += new System.EventHandler(this.msTaoPTP_Click);
            // 
            // msXemPTP
            // 
            this.msXemPTP.Name = "msXemPTP";
            this.msXemPTP.Size = new System.Drawing.Size(192, 26);
            this.msXemPTP.Text = "Xem + Cập nhật";
            this.msXemPTP.Click += new System.EventHandler(this.msXemPTP_Click);
            // 
            // msTaiChinh
            // 
            this.msTaiChinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHoaDon,
            this.msBaoCaoTheoLoaiPhong});
            this.msTaiChinh.Name = "msTaiChinh";
            this.msTaiChinh.Size = new System.Drawing.Size(87, 25);
            this.msTaiChinh.Text = "Tài Chính";
            // 
            // msHoaDon
            // 
            this.msHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem});
            this.msHoaDon.Name = "msHoaDon";
            this.msHoaDon.Size = new System.Drawing.Size(257, 26);
            this.msHoaDon.Text = "Hóa Đơn";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.lToolStripMenuItem.Text = "Lập";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // msBaoCaoTheoLoaiPhong
            // 
            this.msBaoCaoTheoLoaiPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBaoCaoThang});
            this.msBaoCaoTheoLoaiPhong.Name = "msBaoCaoTheoLoaiPhong";
            this.msBaoCaoTheoLoaiPhong.Size = new System.Drawing.Size(257, 26);
            this.msBaoCaoTheoLoaiPhong.Text = "Báo Cáo Theo Loại Phòng";
            // 
            // msBaoCaoThang
            // 
            this.msBaoCaoThang.Name = "msBaoCaoThang";
            this.msBaoCaoThang.Size = new System.Drawing.Size(123, 26);
            this.msBaoCaoThang.Text = "Tháng";
            // 
            // msQuanLy
            // 
            this.msQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQlLoaiPhong,
            this.msQlLoaiKhach});
            this.msQuanLy.Name = "msQuanLy";
            this.msQuanLy.Size = new System.Drawing.Size(80, 25);
            this.msQuanLy.Text = "Quản Lý";
            // 
            // msQlLoaiPhong
            // 
            this.msQlLoaiPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msThemLoaiPhong,
            this.msXoaLoaiPhong,
            this.msSuaLoaiPhong});
            this.msQlLoaiPhong.Name = "msQlLoaiPhong";
            this.msQlLoaiPhong.Size = new System.Drawing.Size(158, 26);
            this.msQlLoaiPhong.Text = "Loại Phòng";
            // 
            // msThemLoaiPhong
            // 
            this.msThemLoaiPhong.Name = "msThemLoaiPhong";
            this.msThemLoaiPhong.Size = new System.Drawing.Size(119, 26);
            this.msThemLoaiPhong.Text = "Thêm";
            // 
            // msXoaLoaiPhong
            // 
            this.msXoaLoaiPhong.Name = "msXoaLoaiPhong";
            this.msXoaLoaiPhong.Size = new System.Drawing.Size(119, 26);
            this.msXoaLoaiPhong.Text = "Xóa";
            // 
            // msSuaLoaiPhong
            // 
            this.msSuaLoaiPhong.Name = "msSuaLoaiPhong";
            this.msSuaLoaiPhong.Size = new System.Drawing.Size(119, 26);
            this.msSuaLoaiPhong.Text = "Sửa";
            // 
            // msQlLoaiKhach
            // 
            this.msQlLoaiKhach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msThemLoaiKhach,
            this.msXoaLoaiKhach,
            this.msSuaLoaiKhach});
            this.msQlLoaiKhach.Name = "msQlLoaiKhach";
            this.msQlLoaiKhach.Size = new System.Drawing.Size(158, 26);
            this.msQlLoaiKhach.Text = "Loại Khách";
            // 
            // msThemLoaiKhach
            // 
            this.msThemLoaiKhach.Name = "msThemLoaiKhach";
            this.msThemLoaiKhach.Size = new System.Drawing.Size(119, 26);
            this.msThemLoaiKhach.Text = "Thêm";
            // 
            // msXoaLoaiKhach
            // 
            this.msXoaLoaiKhach.Name = "msXoaLoaiKhach";
            this.msXoaLoaiKhach.Size = new System.Drawing.Size(119, 26);
            this.msXoaLoaiKhach.Text = "Xóa";
            // 
            // msSuaLoaiKhach
            // 
            this.msSuaLoaiKhach.Name = "msSuaLoaiKhach";
            this.msSuaLoaiKhach.Size = new System.Drawing.Size(119, 26);
            this.msSuaLoaiKhach.Text = "Sửa";
            // 
            // msThietLap
            // 
            this.msThietLap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSoKhachToiDa,
            this.msSoKhachKhongPhuThu});
            this.msThietLap.Name = "msThietLap";
            this.msThietLap.Size = new System.Drawing.Size(85, 25);
            this.msThietLap.Text = "Thiết Lập";
            // 
            // msSoKhachToiDa
            // 
            this.msSoKhachToiDa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msSoKhachToiDa.Name = "msSoKhachToiDa";
            this.msSoKhachToiDa.Size = new System.Drawing.Size(264, 24);
            this.msSoKhachToiDa.Text = "Số Khách Tối Đa";
            // 
            // msSoKhachKhongPhuThu
            // 
            this.msSoKhachKhongPhuThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msSoKhachKhongPhuThu.Name = "msSoKhachKhongPhuThu";
            this.msSoKhachKhongPhuThu.Size = new System.Drawing.Size(264, 24);
            this.msSoKhachKhongPhuThu.Text = "Số Khách Không Tính Phụ Thu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.Controls.Add(this.msQuanLyKhachSan);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QUẢN LÝ KHÁCH SẠN";
            this.msQuanLyKhachSan.ResumeLayout(false);
            this.msQuanLyKhachSan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msQuanLyKhachSan;
        private System.Windows.Forms.ToolStripMenuItem msPhong;
        private System.Windows.Forms.ToolStripMenuItem msQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem msPhieuThuePhong;
        private System.Windows.Forms.ToolStripMenuItem msTaoPTP;
        private System.Windows.Forms.ToolStripMenuItem msXemPTP;
        private System.Windows.Forms.ToolStripMenuItem msTaiChinh;
        private System.Windows.Forms.ToolStripMenuItem msTraCuuPhong;
        private System.Windows.Forms.ToolStripMenuItem msHoaDon;
        private System.Windows.Forms.ToolStripMenuItem msBaoCaoTheoLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msThietLap;
        private System.Windows.Forms.ToolStripMenuItem msSoKhachToiDa;
        private System.Windows.Forms.ToolStripMenuItem msSoKhachKhongPhuThu;
        private System.Windows.Forms.ToolStripMenuItem msQuanLy;
        private System.Windows.Forms.ToolStripMenuItem msQlLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msThemLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msXoaLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msSuaLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msQlLoaiKhach;
        private System.Windows.Forms.ToolStripMenuItem msThemLoaiKhach;
        private System.Windows.Forms.ToolStripMenuItem msXoaLoaiKhach;
        private System.Windows.Forms.ToolStripMenuItem msSuaLoaiKhach;
        private System.Windows.Forms.ToolStripMenuItem msBaoCaoThang;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
    }
}

