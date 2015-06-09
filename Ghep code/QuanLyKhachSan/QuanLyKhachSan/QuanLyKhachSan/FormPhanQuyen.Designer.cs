namespace QuanLyKhachSan
{
    partial class FormPhanQuyen
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
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.tb_Role = new System.Windows.Forms.Label();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_UserName.Location = new System.Drawing.Point(37, 39);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(120, 20);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "Tên đăng nhập:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_Password.Location = new System.Drawing.Point(37, 86);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(79, 20);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(174, 33);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(153, 26);
            this.tb_UserName.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(174, 80);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(153, 26);
            this.tb_Password.TabIndex = 3;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.Color.DeepPink;
            this.bt_Luu.Location = new System.Drawing.Point(41, 196);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(91, 48);
            this.bt_Luu.TabIndex = 4;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.Color.DeepPink;
            this.bt_Thoat.Location = new System.Drawing.Point(236, 196);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(91, 48);
            this.bt_Thoat.TabIndex = 5;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // tb_Role
            // 
            this.tb_Role.AutoSize = true;
            this.tb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Role.ForeColor = System.Drawing.Color.DeepPink;
            this.tb_Role.Location = new System.Drawing.Point(37, 138);
            this.tb_Role.Name = "tb_Role";
            this.tb_Role.Size = new System.Drawing.Size(119, 20);
            this.tb_Role.TabIndex = 6;
            this.tb_Role.Text = "Quyền truy cập:";
            // 
            // cb_Role
            // 
            this.cb_Role.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cb_Role.Location = new System.Drawing.Point(174, 130);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(153, 28);
            this.cb_Role.TabIndex = 7;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(374, 268);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.tb_Role);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserName);
            this.MaximizeBox = false;
            this.Name = "FormPhanQuyen";
            this.Text = "Phân Quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label tb_Role;
        private System.Windows.Forms.ComboBox cb_Role;
    }
}