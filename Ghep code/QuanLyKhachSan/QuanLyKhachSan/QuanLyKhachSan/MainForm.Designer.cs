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
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msThietLap = new System.Windows.Forms.ToolStripMenuItem();
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
            this.msTraCuuPhong.Click += new System.EventHandler(this.msTraCuuPhong_Click);
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
            this.msTaoPTP.Size = new System.Drawing.Size(192, 26);
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
            this.msHoaDon.Size = new System.Drawing.Size(142, 26);
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
            this.msBaoCaoThang,
            this.traCứuToolStripMenuItem});
            this.msBaoCaoTheoLoaiPhong.Name = "msBaoCaoTheoLoaiPhong";
            this.msBaoCaoTheoLoaiPhong.Size = new System.Drawing.Size(142, 26);
            this.msBaoCaoTheoLoaiPhong.Text = "Báo Cáo ";
            // 
            // msBaoCaoThang
            // 
            this.msBaoCaoThang.Name = "msBaoCaoThang";
            this.msBaoCaoThang.Size = new System.Drawing.Size(205, 26);
            this.msBaoCaoThang.Text = "Lập cáo cáo tháng";
            this.msBaoCaoThang.Click += new System.EventHandler(this.msBaoCaoThang_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.traCứuToolStripMenuItem.Text = "Tra cứu ";
            this.traCứuToolStripMenuItem.Click += new System.EventHandler(this.traCứuToolStripMenuItem_Click);
            // 
            // msThietLap
            // 
            this.msThietLap.Name = "msThietLap";
            this.msThietLap.Size = new System.Drawing.Size(85, 25);
            this.msThietLap.Text = "Thiết Lập";
            this.msThietLap.Click += new System.EventHandler(this.msThietLap_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem msBaoCaoThang;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
    }
}

