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
    public partial class XoaPhanQuyen : Form
    {
        PhanQuyenBUS m_PhanQuyen;

        public XoaPhanQuyen()
        {
            InitializeComponent();
            m_PhanQuyen = new PhanQuyenBUS();
            DataTable Username = m_PhanQuyen.LayUsername();
            for (int i = 0; i < Username.Rows.Count; i++)
            {
                cb_Username.Items.Add(Username.Rows[i][0].ToString());
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (cb_Username.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            m_PhanQuyen.XoaPhanQuyen(cb_Username.Text);
            cb_Username.Items.Clear();
            DataTable Username = m_PhanQuyen.LayUsername();
            for (int i = 0; i < Username.Rows.Count; i++)
            {
                cb_Username.Items.Add(Username.Rows[i][0].ToString());
            }
            MessageBox.Show("Đã Xóa", "Thông báo", MessageBoxButtons.OK);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
