using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataTransferObject;

namespace QuanLyKhachSan
{
    public partial class FormPhanQuyen : Form
    {
        PhanQuyenBUS m_PhanQuyen;

        public FormPhanQuyen()
        {
            InitializeComponent();
            m_PhanQuyen = new PhanQuyenBUS();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "" || tb_Password.Text == "" || cb_Role.Text == "")
            {
                MessageBox.Show("Thông tin không đúng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (m_PhanQuyen.KiemTraUserName(tb_UserName.Text) == null)
            {
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            PhanQuyenDTO phanQuyen = new PhanQuyenDTO();
            phanQuyen.UserName = tb_Password.Text;
            phanQuyen.Password = tb_Password.Text;
            phanQuyen.Role = cb_Role.Text;

            m_PhanQuyen.ThemQuyenTruyCap(phanQuyen);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
