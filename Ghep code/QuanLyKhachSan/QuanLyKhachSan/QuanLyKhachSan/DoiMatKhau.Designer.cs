namespace QuanLyKhachSan
{
    partial class DoiMatKhau
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
            this.lb_MatKhauCu = new System.Windows.Forms.Label();
            this.lb_MatKhauMoi = new System.Windows.Forms.Label();
            this.lb_XacNhanMatKhauMoi = new System.Windows.Forms.Label();
            this.mtb_MatKhauCu = new System.Windows.Forms.MaskedTextBox();
            this.mtb_MatKhauMoi = new System.Windows.Forms.MaskedTextBox();
            this.mtb_XacNhanMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_MatKhauCu
            // 
            this.lb_MatKhauCu.AutoSize = true;
            this.lb_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauCu.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_MatKhauCu.Location = new System.Drawing.Point(28, 21);
            this.lb_MatKhauCu.Name = "lb_MatKhauCu";
            this.lb_MatKhauCu.Size = new System.Drawing.Size(96, 20);
            this.lb_MatKhauCu.TabIndex = 1;
            this.lb_MatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lb_MatKhauMoi
            // 
            this.lb_MatKhauMoi.AutoSize = true;
            this.lb_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhauMoi.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_MatKhauMoi.Location = new System.Drawing.Point(27, 53);
            this.lb_MatKhauMoi.Name = "lb_MatKhauMoi";
            this.lb_MatKhauMoi.Size = new System.Drawing.Size(104, 20);
            this.lb_MatKhauMoi.TabIndex = 2;
            this.lb_MatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lb_XacNhanMatKhauMoi
            // 
            this.lb_XacNhanMatKhauMoi.AutoSize = true;
            this.lb_XacNhanMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XacNhanMatKhauMoi.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_XacNhanMatKhauMoi.Location = new System.Drawing.Point(28, 83);
            this.lb_XacNhanMatKhauMoi.Name = "lb_XacNhanMatKhauMoi";
            this.lb_XacNhanMatKhauMoi.Size = new System.Drawing.Size(147, 20);
            this.lb_XacNhanMatKhauMoi.TabIndex = 3;
            this.lb_XacNhanMatKhauMoi.Text = "Xác nhận mật khẩu";
            // 
            // mtb_MatKhauCu
            // 
            this.mtb_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_MatKhauCu.Location = new System.Drawing.Point(181, 18);
            this.mtb_MatKhauCu.Name = "mtb_MatKhauCu";
            this.mtb_MatKhauCu.PasswordChar = '@';
            this.mtb_MatKhauCu.Size = new System.Drawing.Size(222, 26);
            this.mtb_MatKhauCu.TabIndex = 5;
            // 
            // mtb_MatKhauMoi
            // 
            this.mtb_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_MatKhauMoi.Location = new System.Drawing.Point(181, 50);
            this.mtb_MatKhauMoi.Name = "mtb_MatKhauMoi";
            this.mtb_MatKhauMoi.PasswordChar = '@';
            this.mtb_MatKhauMoi.Size = new System.Drawing.Size(222, 26);
            this.mtb_MatKhauMoi.TabIndex = 6;
            // 
            // mtb_XacNhanMatKhau
            // 
            this.mtb_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_XacNhanMatKhau.Location = new System.Drawing.Point(181, 80);
            this.mtb_XacNhanMatKhau.Name = "mtb_XacNhanMatKhau";
            this.mtb_XacNhanMatKhau.PasswordChar = '@';
            this.mtb_XacNhanMatKhau.Size = new System.Drawing.Size(222, 26);
            this.mtb_XacNhanMatKhau.TabIndex = 7;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Luu.Location = new System.Drawing.Point(100, 120);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 38);
            this.bt_Luu.TabIndex = 8;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Thoat.Location = new System.Drawing.Point(230, 120);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 38);
            this.bt_Thoat.TabIndex = 9;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(430, 170);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.mtb_XacNhanMatKhau);
            this.Controls.Add(this.mtb_MatKhauMoi);
            this.Controls.Add(this.mtb_MatKhauCu);
            this.Controls.Add(this.lb_XacNhanMatKhauMoi);
            this.Controls.Add(this.lb_MatKhauMoi);
            this.Controls.Add(this.lb_MatKhauCu);
            this.MaximizeBox = false;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MatKhauCu;
        private System.Windows.Forms.Label lb_MatKhauMoi;
        private System.Windows.Forms.Label lb_XacNhanMatKhauMoi;
        private System.Windows.Forms.MaskedTextBox mtb_MatKhauCu;
        private System.Windows.Forms.MaskedTextBox mtb_MatKhauMoi;
        private System.Windows.Forms.MaskedTextBox mtb_XacNhanMatKhau;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Thoat;
    }
}