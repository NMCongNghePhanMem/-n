using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicTier;
namespace QuanLyKhachSan
{
    public partial class DoiMatKhau : Form
    {
        PhanQuyenBUS m_PhanQuyen;
        public DoiMatKhau()
        {
            InitializeComponent();
            m_PhanQuyen = new PhanQuyenBUS();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            PhanQuyenDTO _phanquyen = new PhanQuyenDTO();
            _phanquyen.Password = mtb_MatKhauCu.Text;
            _phanquyen.UserName = MainForm.username;
            if (mtb_MatKhauMoi.Text != mtb_XacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng mật khẩu mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (m_PhanQuyen.KiemTraMatKhau(_phanquyen) == null)
            {
                MessageBox.Show("Sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            _phanquyen.Password = mtb_MatKhauMoi.Text;
            m_PhanQuyen.DoiMatKhau(_phanquyen);
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK);
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
