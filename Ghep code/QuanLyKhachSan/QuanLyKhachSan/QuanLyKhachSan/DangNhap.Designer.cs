namespace QuanLyKhachSan
{
    partial class DangNhap
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
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.mtb_Password = new System.Windows.Forms.MaskedTextBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_UserName
            // 
            this.tb_UserName.BackColor = System.Drawing.Color.Silver;
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(194, 46);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(158, 26);
            this.tb_UserName.TabIndex = 0;
            // 
            // mtb_Password
            // 
            this.mtb_Password.BackColor = System.Drawing.Color.Silver;
            this.mtb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Password.Location = new System.Drawing.Point(194, 87);
            this.mtb_Password.Name = "mtb_Password";
            this.mtb_Password.PasswordChar = '@';
            this.mtb_Password.Size = new System.Drawing.Size(158, 26);
            this.mtb_Password.TabIndex = 1;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_UserName.Location = new System.Drawing.Point(58, 52);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(129, 20);
            this.lb_UserName.TabIndex = 2;
            this.lb_UserName.Text = "Tên đăng nhập";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_Password.Location = new System.Drawing.Point(58, 93);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(83, 20);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // bt_Login
            // 
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.DeepPink;
            this.bt_Login.Location = new System.Drawing.Point(140, 163);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(106, 35);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Đăng nhập";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(400, 247);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.mtb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.MaskedTextBox mtb_Password;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button bt_Login;
    }
}