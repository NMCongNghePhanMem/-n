namespace QuanLyKhachSan
{
    partial class FormThayDoiQuyDinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewLoaiPhong = new System.Windows.Forms.ListView();
            this.LoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonThemLoaiPhong = new System.Windows.Forms.Button();
            this.buttonXoaLoaiPhong = new System.Windows.Forms.Button();
            this.buttonCapNhapLoaiPhong = new System.Windows.Forms.Button();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.textBoxLoaiPhong = new System.Windows.Forms.TextBox();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLoaiKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTyLePhuThu = new System.Windows.Forms.TextBox();
            this.labelTyLePhuThu = new System.Windows.Forms.Label();
            this.textBoxSoKhachToiDa = new System.Windows.Forms.TextBox();
            this.labelSoKhachToiDa = new System.Windows.Forms.Label();
            this.listViewLoaiKhach = new System.Windows.Forms.ListView();
            this.maLoaiKhach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenLoaiKhach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonThemLoaiKhach = new System.Windows.Forms.Button();
            this.textBoxMaLoaiKhach = new System.Windows.Forms.TextBox();
            this.buttonXoaLoaiKhach = new System.Windows.Forms.Button();
            this.labelLoaiKhach = new System.Windows.Forms.Label();
            this.buttonCapNhapLoaiKhach = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuyBo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewLoaiPhong);
            this.panel1.Controls.Add(this.buttonThemLoaiPhong);
            this.panel1.Controls.Add(this.buttonXoaLoaiPhong);
            this.panel1.Controls.Add(this.buttonCapNhapLoaiPhong);
            this.panel1.Controls.Add(this.textBoxDonGia);
            this.panel1.Controls.Add(this.labelDonGia);
            this.panel1.Controls.Add(this.textBoxLoaiPhong);
            this.panel1.Controls.Add(this.labelLoaiPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 395);
            this.panel1.TabIndex = 0;
            // 
            // listViewLoaiPhong
            // 
            this.listViewLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoaiPhong,
            this.DonGia});
            this.listViewLoaiPhong.FullRowSelect = true;
            this.listViewLoaiPhong.Location = new System.Drawing.Point(4, 97);
            this.listViewLoaiPhong.MultiSelect = false;
            this.listViewLoaiPhong.Name = "listViewLoaiPhong";
            this.listViewLoaiPhong.Size = new System.Drawing.Size(337, 295);
            this.listViewLoaiPhong.TabIndex = 13;
            this.listViewLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.listViewLoaiPhong.View = System.Windows.Forms.View.Details;
            this.listViewLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.listViewLoaiPhong_SelectedIndexChanged);
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.Text = "Loại Phòng";
            this.LoaiPhong.Width = 160;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn Giá";
            this.DonGia.Width = 167;
            // 
            // buttonThemLoaiPhong
            // 
            this.buttonThemLoaiPhong.Location = new System.Drawing.Point(54, 61);
            this.buttonThemLoaiPhong.Name = "buttonThemLoaiPhong";
            this.buttonThemLoaiPhong.Size = new System.Drawing.Size(75, 23);
            this.buttonThemLoaiPhong.TabIndex = 12;
            this.buttonThemLoaiPhong.Text = "Thêm";
            this.buttonThemLoaiPhong.UseVisualStyleBackColor = true;
            this.buttonThemLoaiPhong.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoaLoaiPhong
            // 
            this.buttonXoaLoaiPhong.Location = new System.Drawing.Point(135, 61);
            this.buttonXoaLoaiPhong.Name = "buttonXoaLoaiPhong";
            this.buttonXoaLoaiPhong.Size = new System.Drawing.Size(75, 23);
            this.buttonXoaLoaiPhong.TabIndex = 11;
            this.buttonXoaLoaiPhong.Text = "Xóa";
            this.buttonXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.buttonXoaLoaiPhong.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhapLoaiPhong
            // 
            this.buttonCapNhapLoaiPhong.Location = new System.Drawing.Point(216, 61);
            this.buttonCapNhapLoaiPhong.Name = "buttonCapNhapLoaiPhong";
            this.buttonCapNhapLoaiPhong.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhapLoaiPhong.TabIndex = 10;
            this.buttonCapNhapLoaiPhong.Text = "Cập Nhập";
            this.buttonCapNhapLoaiPhong.UseVisualStyleBackColor = true;
            this.buttonCapNhapLoaiPhong.Click += new System.EventHandler(this.buttonCapNhap_Click);
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(79, 35);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(232, 20);
            this.textBoxDonGia.TabIndex = 9;
            this.textBoxDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDonGia_KeyPress);
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(12, 38);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(46, 13);
            this.labelDonGia.TabIndex = 8;
            this.labelDonGia.Text = "Đơn Giá";
            // 
            // textBoxLoaiPhong
            // 
            this.textBoxLoaiPhong.Location = new System.Drawing.Point(79, 9);
            this.textBoxLoaiPhong.Name = "textBoxLoaiPhong";
            this.textBoxLoaiPhong.Size = new System.Drawing.Size(232, 20);
            this.textBoxLoaiPhong.TabIndex = 7;
            this.textBoxLoaiPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoaiPhong_KeyPress);
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.Location = new System.Drawing.Point(12, 12);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(61, 13);
            this.labelLoaiPhong.TabIndex = 6;
            this.labelLoaiPhong.Text = "Loại Phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxLoaiKhach);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxTyLePhuThu);
            this.panel2.Controls.Add(this.labelTyLePhuThu);
            this.panel2.Controls.Add(this.textBoxSoKhachToiDa);
            this.panel2.Controls.Add(this.labelSoKhachToiDa);
            this.panel2.Controls.Add(this.listViewLoaiKhach);
            this.panel2.Controls.Add(this.buttonThemLoaiKhach);
            this.panel2.Controls.Add(this.textBoxMaLoaiKhach);
            this.panel2.Controls.Add(this.buttonXoaLoaiKhach);
            this.panel2.Controls.Add(this.labelLoaiKhach);
            this.panel2.Controls.Add(this.buttonCapNhapLoaiKhach);
            this.panel2.Location = new System.Drawing.Point(382, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 395);
            this.panel2.TabIndex = 1;
            // 
            // textBoxLoaiKhach
            // 
            this.textBoxLoaiKhach.Location = new System.Drawing.Point(224, 27);
            this.textBoxLoaiKhach.Name = "textBoxLoaiKhach";
            this.textBoxLoaiKhach.Size = new System.Drawing.Size(113, 20);
            this.textBoxLoaiKhach.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Loại Khách";
            // 
            // textBoxTyLePhuThu
            // 
            this.textBoxTyLePhuThu.Location = new System.Drawing.Point(204, 358);
            this.textBoxTyLePhuThu.Name = "textBoxTyLePhuThu";
            this.textBoxTyLePhuThu.Size = new System.Drawing.Size(72, 20);
            this.textBoxTyLePhuThu.TabIndex = 20;
            this.textBoxTyLePhuThu.TextChanged += new System.EventHandler(this.textBoxTyLePhuThu_TextChanged);
            this.textBoxTyLePhuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTyLePhuThu_KeyPress);
            // 
            // labelTyLePhuThu
            // 
            this.labelTyLePhuThu.AutoSize = true;
            this.labelTyLePhuThu.Location = new System.Drawing.Point(55, 361);
            this.labelTyLePhuThu.Name = "labelTyLePhuThu";
            this.labelTyLePhuThu.Size = new System.Drawing.Size(78, 13);
            this.labelTyLePhuThu.TabIndex = 19;
            this.labelTyLePhuThu.Text = "Tỷ Lệ Phụ Thu";
            // 
            // textBoxSoKhachToiDa
            // 
            this.textBoxSoKhachToiDa.Location = new System.Drawing.Point(204, 332);
            this.textBoxSoKhachToiDa.Name = "textBoxSoKhachToiDa";
            this.textBoxSoKhachToiDa.Size = new System.Drawing.Size(72, 20);
            this.textBoxSoKhachToiDa.TabIndex = 18;
            this.textBoxSoKhachToiDa.TextChanged += new System.EventHandler(this.textBoxSoKhachToiDa_TextChanged);
            this.textBoxSoKhachToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoKhachToiDa_KeyPress);
            // 
            // labelSoKhachToiDa
            // 
            this.labelSoKhachToiDa.AutoSize = true;
            this.labelSoKhachToiDa.Location = new System.Drawing.Point(55, 335);
            this.labelSoKhachToiDa.Name = "labelSoKhachToiDa";
            this.labelSoKhachToiDa.Size = new System.Drawing.Size(143, 13);
            this.labelSoKhachToiDa.TabIndex = 17;
            this.labelSoKhachToiDa.Text = "Số khách tối đa trong phòng";
            // 
            // listViewLoaiKhach
            // 
            this.listViewLoaiKhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maLoaiKhach,
            this.tenLoaiKhach});
            this.listViewLoaiKhach.FullRowSelect = true;
            this.listViewLoaiKhach.Location = new System.Drawing.Point(3, 97);
            this.listViewLoaiKhach.MultiSelect = false;
            this.listViewLoaiKhach.Name = "listViewLoaiKhach";
            this.listViewLoaiKhach.Size = new System.Drawing.Size(341, 218);
            this.listViewLoaiKhach.TabIndex = 14;
            this.listViewLoaiKhach.UseCompatibleStateImageBehavior = false;
            this.listViewLoaiKhach.View = System.Windows.Forms.View.Details;
            this.listViewLoaiKhach.SelectedIndexChanged += new System.EventHandler(this.listViewLoaiKhach_SelectedIndexChanged);
            // 
            // maLoaiKhach
            // 
            this.maLoaiKhach.Text = "Mã";
            this.maLoaiKhach.Width = 110;
            // 
            // tenLoaiKhach
            // 
            this.tenLoaiKhach.Text = "Loại Khách Hàng";
            this.tenLoaiKhach.Width = 203;
            // 
            // buttonThemLoaiKhach
            // 
            this.buttonThemLoaiKhach.Location = new System.Drawing.Point(55, 57);
            this.buttonThemLoaiKhach.Name = "buttonThemLoaiKhach";
            this.buttonThemLoaiKhach.Size = new System.Drawing.Size(75, 23);
            this.buttonThemLoaiKhach.TabIndex = 16;
            this.buttonThemLoaiKhach.Text = "Thêm";
            this.buttonThemLoaiKhach.UseVisualStyleBackColor = true;
            this.buttonThemLoaiKhach.Click += new System.EventHandler(this.buttonThemLoaiKhach_Click);
            // 
            // textBoxMaLoaiKhach
            // 
            this.textBoxMaLoaiKhach.Location = new System.Drawing.Point(58, 27);
            this.textBoxMaLoaiKhach.Name = "textBoxMaLoaiKhach";
            this.textBoxMaLoaiKhach.Size = new System.Drawing.Size(83, 20);
            this.textBoxMaLoaiKhach.TabIndex = 15;
            this.textBoxMaLoaiKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaLoaiKhach_KeyPress);
            // 
            // buttonXoaLoaiKhach
            // 
            this.buttonXoaLoaiKhach.Location = new System.Drawing.Point(136, 57);
            this.buttonXoaLoaiKhach.Name = "buttonXoaLoaiKhach";
            this.buttonXoaLoaiKhach.Size = new System.Drawing.Size(75, 23);
            this.buttonXoaLoaiKhach.TabIndex = 15;
            this.buttonXoaLoaiKhach.Text = "Xóa";
            this.buttonXoaLoaiKhach.UseVisualStyleBackColor = true;
            this.buttonXoaLoaiKhach.Click += new System.EventHandler(this.buttonXoaLoaiKhach_Click);
            // 
            // labelLoaiKhach
            // 
            this.labelLoaiKhach.AutoSize = true;
            this.labelLoaiKhach.Location = new System.Drawing.Point(3, 34);
            this.labelLoaiKhach.Name = "labelLoaiKhach";
            this.labelLoaiKhach.Size = new System.Drawing.Size(56, 13);
            this.labelLoaiKhach.TabIndex = 14;
            this.labelLoaiKhach.Text = "Mã Khách";
            // 
            // buttonCapNhapLoaiKhach
            // 
            this.buttonCapNhapLoaiKhach.Location = new System.Drawing.Point(217, 57);
            this.buttonCapNhapLoaiKhach.Name = "buttonCapNhapLoaiKhach";
            this.buttonCapNhapLoaiKhach.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhapLoaiKhach.TabIndex = 14;
            this.buttonCapNhapLoaiKhach.Text = "Cập Nhập";
            this.buttonCapNhapLoaiKhach.UseVisualStyleBackColor = true;
            this.buttonCapNhapLoaiKhach.Click += new System.EventHandler(this.buttonCapNhapLoaiKhach_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(573, 426);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonHuyBo
            // 
            this.buttonHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHuyBo.Location = new System.Drawing.Point(654, 426);
            this.buttonHuyBo.Name = "buttonHuyBo";
            this.buttonHuyBo.Size = new System.Drawing.Size(75, 23);
            this.buttonHuyBo.TabIndex = 3;
            this.buttonHuyBo.Text = "Hủy Bỏ";
            this.buttonHuyBo.UseVisualStyleBackColor = true;
            this.buttonHuyBo.Click += new System.EventHandler(this.buttonHuyBo_Click);
            // 
            // FormThayDoiQuyDinh
            // 
            this.AcceptButton = this.buttonLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonHuyBo;
            this.ClientSize = new System.Drawing.Size(744, 458);
            this.Controls.Add(this.buttonHuyBo);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormThayDoiQuyDinh";
            this.Text = "Thiết Lập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox textBoxLoaiPhong;
        private System.Windows.Forms.Label labelLoaiPhong;
        private System.Windows.Forms.ListView listViewLoaiPhong;
        private System.Windows.Forms.ColumnHeader LoaiPhong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.Button buttonThemLoaiPhong;
        private System.Windows.Forms.Button buttonXoaLoaiPhong;
        private System.Windows.Forms.Button buttonCapNhapLoaiPhong;
        private System.Windows.Forms.TextBox textBoxMaLoaiKhach;
        private System.Windows.Forms.Label labelLoaiKhach;
        private System.Windows.Forms.TextBox textBoxTyLePhuThu;
        private System.Windows.Forms.Label labelTyLePhuThu;
        private System.Windows.Forms.TextBox textBoxSoKhachToiDa;
        private System.Windows.Forms.Label labelSoKhachToiDa;
        private System.Windows.Forms.ListView listViewLoaiKhach;
        private System.Windows.Forms.ColumnHeader maLoaiKhach;
        private System.Windows.Forms.Button buttonThemLoaiKhach;
        private System.Windows.Forms.Button buttonXoaLoaiKhach;
        private System.Windows.Forms.Button buttonCapNhapLoaiKhach;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuyBo;
        private System.Windows.Forms.ColumnHeader tenLoaiKhach;
        private System.Windows.Forms.TextBox textBoxLoaiKhach;
        private System.Windows.Forms.Label label1;
    }
}