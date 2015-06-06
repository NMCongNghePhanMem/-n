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
using System.Data.SqlClient;


namespace QuanLyKhachSan
{
    public partial class FormThayDoiQuyDinh : Form
    {
        delegate int ThemLoaiPhongDelegate();

        BusinessLogicTier.LoaiPhongBUS loaiPhong;
        BusinessLogicTier.LoaiKhachHangBUS loaiKhach;
        BusinessLogicTier.ThamSoBUS thamSo;
        bool isLoaiPhongChanged;//quy định bị thay đổi?
        bool isLoaiKhachChanged;
        bool isThamSoChanged;
        float tyLePhuThu;
        int soKhachToiDa;
        Color UnSavedRecord = Color.FromArgb(90, 0, 150, 136);



        List<SqlCommand> cmdList;
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
            loaiPhong = new LoaiPhongBUS();
            loaiKhach = new LoaiKhachHangBUS();
            thamSo = new ThamSoBUS();
            updateListViewLoaiPhong(loaiPhong.getDanhMucLoaiPhong());
            updateListViewLoaiKhach(loaiKhach.getDanhMucLoaiKhach());
            tyLePhuThu = thamSo.getTyLePhuThu();
            soKhachToiDa = thamSo.getSoKhachToiDa();
            textBoxTyLePhuThu.Text = tyLePhuThu.ToString();
            textBoxSoKhachToiDa.Text = soKhachToiDa.ToString();

            isLoaiKhachChanged = false;
            isLoaiPhongChanged = false;
            isThamSoChanged = false;
            cmdList = new List<SqlCommand>();

        }


        private void updateListViewLoaiPhong(DataTable dt)
        {
            listViewLoaiPhong.Items.Clear();
            //dt = LoaiPhongBUS.getDanhMucLoaiPhong();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dt.Rows[i]["MaLoaiPhong"].ToString();
                item.SubItems.Add(dt.Rows[i]["DonGia"].ToString());
                listViewLoaiPhong.Items.Add(item);
            }
        }
        private void updateListViewLoaiKhach(DataTable dt)
        {
            listViewLoaiKhach.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dt.Rows[i]["MaLoaiKhachHang"].ToString();
                item.SubItems.Add(dt.Rows[i]["TenLoaiKhachHang"].ToString());
                listViewLoaiKhach.Items.Add(item);
            }
        }
        private void buttonCapNhap_Click(object sender, EventArgs e)
        {
            if (textBoxLoaiPhong.Text == "" || textBoxDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Phòng, Đơn Giá");
                return;
            }
            bool isExist = false; int index = 0;
            foreach (ListViewItem item in listViewLoaiPhong.Items)
            {
                if (textBoxLoaiPhong.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    index = item.Index;
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("\"" + textBoxLoaiPhong.Text + "\" không tồn tại", "Cập Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string maLoaiPhong = textBoxLoaiPhong.Text;
                int donGia = (int)float.Parse(textBoxDonGia.Text);
                SqlCommand cmd = loaiPhong.capNhapDonGiaCmd(maLoaiPhong, donGia);
                if (cmd != null)
                {
                    cmdList.Add(cmd);
                    ListViewItem item = new ListViewItem();
                    item.Text = textBoxLoaiPhong.Text;
                    item.SubItems.Add(textBoxDonGia.Text);
                    item.BackColor = UnSavedRecord;
                    listViewLoaiPhong.Items.RemoveAt(index);
                    listViewLoaiPhong.Items.Add(item);
                    isLoaiPhongChanged = true;
                }
                else
                {
                    MessageBox.Show("Cập Nhập Thất Bại", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxLoaiPhong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Phòng");
                return;
            }
            bool isExist = false; int index = 0;
            foreach (ListViewItem item in listViewLoaiPhong.Items)
            {

                if (textBoxLoaiPhong.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    index = item.Index;
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("\"" + textBoxLoaiPhong.Text + "\" không tồn tại", "Xóa Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult selectedOption =
                    MessageBox.Show(this, "Xóa loại phòng \"" + textBoxLoaiPhong.Text + " sẽ đồng thời xóa tất cả các phòng thuộc loại phòng đó!!!", "Bạn có chắc chắn muốn xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (selectedOption == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                if (selectedOption == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand cmd = loaiPhong.xoaLoaiPhongCmd(textBoxLoaiPhong.Text);
                    if (cmd != null)
                    {
                        cmdList.Add(cmd);
                        listViewLoaiPhong.Items.RemoveAt(index);
                        isLoaiPhongChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại", "Lổi không xác đinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxLoaiPhong.Text == "" || textBoxDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Phòng, Đơn Giá");
                return;
            }
            bool isExist = false;
            foreach (ListViewItem item in listViewLoaiPhong.Items)
            {

                if (textBoxLoaiPhong.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist == false)//chưa tồn tại trong CSDL
            {
                string maLoaiPhong = textBoxLoaiPhong.Text;
                int donGia = (int)float.Parse(textBoxDonGia.Text);
                SqlCommand cmd = loaiPhong.themLoaiPhongCmd(maLoaiPhong, donGia);
                if (cmd != null)
                {
                    cmdList.Add(cmd);
                    ListViewItem item = new ListViewItem();
                    item.Text = textBoxLoaiPhong.Text;
                    item.SubItems.Add(textBoxDonGia.Text);
                    item.BackColor = UnSavedRecord;
                    listViewLoaiPhong.Items.Add(item);
                    isLoaiPhongChanged = true;
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("\"" + textBoxLoaiPhong.Text + "\" Đả Có Trong CSDL");
            }

        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            if (cmdList.Count != 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn lưu lại những thay đổi?", "Các Cài Đặt Chưa Được Lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    LuuThietLap();
                }
            }
            this.Close();
        }

        private void listViewLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewLoaiPhong.SelectedItems)
            {
                textBoxLoaiPhong.Text = item.Text;
                textBoxDonGia.Text = item.SubItems[1].Text;
            }
        }

        private void listViewLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewLoaiKhach.SelectedItems)
            {
                textBoxMaLoaiKhach.Text = item.Text;
                textBoxLoaiKhach.Text = item.SubItems[1].Text;
            }
        }

        private void textBoxLoaiPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            else
                e.Handled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            LuuThietLap();
        }
        private void LuuThietLap()
        {
            if (isThamSoChanged == true)
            {
                if (textBoxTyLePhuThu.Text == "" || textBoxSoKhachToiDa.Text == "")
                {
                    MessageBox.Show("Tỷ lệ phụ thu và số khách tối đa không được bỏ trống", "Thiếu Dử Liêu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmdList.Add(thamSo.themSoKhachToiDa(int.Parse(textBoxSoKhachToiDa.Text)));
                cmdList.Add(thamSo.themTyLePhuThu(float.Parse(textBoxTyLePhuThu.Text)));
            }
            int count = 0;
            for (int i = 0; i < cmdList.Count; ++i)
            {
                if (cmdList[i].Connection.State != ConnectionState.Open)
                {
                    cmdList[i].Connection.Open();
                }
                count += cmdList[i].ExecuteNonQuery();
                cmdList[i].Connection.Close();
            }
            MessageBox.Show(count.ToString() + " record(s) bị ảnh hưởng", "Lưu Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmdList.Clear();
            isThamSoChanged = false;
            isLoaiKhachChanged = false;
            isLoaiPhongChanged = false;


            updateListViewLoaiPhong(loaiPhong.getDanhMucLoaiPhong());
            updateListViewLoaiKhach(loaiKhach.getDanhMucLoaiKhach());
        }


        private void buttonThemLoaiKhach_Click(object sender, EventArgs e)
        {
            if (textBoxMaLoaiKhach.Text == "" || textBoxLoaiKhach.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Khách,Mã Loại Khách");
                return;
            }
            bool isExist = false;
            foreach (ListViewItem item in listViewLoaiKhach.Items)
            {

                if (textBoxMaLoaiKhach.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist == false)//chưa tồn tại trong CSDL
            {
                string maLoaiKhach = textBoxMaLoaiKhach.Text;
                string tenLoaiKhach = textBoxLoaiKhach.Text;
                SqlCommand cmd = loaiKhach.themLoaiKhach(maLoaiKhach, tenLoaiKhach);
                if (cmd != null)
                {
                    cmdList.Add(cmd);
                    ListViewItem item = new ListViewItem();
                    item.Text = textBoxMaLoaiKhach.Text;
                    item.SubItems.Add(textBoxLoaiKhach.Text);
                    item.BackColor = UnSavedRecord;
                    listViewLoaiKhach.Items.Add(item);
                    isLoaiKhachChanged = true;
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("\"" + textBoxMaLoaiKhach.Text + "\" Đả Có Trong CSDL");
            }

        }

        private void buttonXoaLoaiKhach_Click(object sender, EventArgs e)
        {
            if (textBoxMaLoaiKhach.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã Loại Khach");
                return;
            }
            bool isExist = false; int index = 0;
            foreach (ListViewItem item in listViewLoaiKhach.Items)
            {

                if (textBoxMaLoaiKhach.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    index = item.Index;
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("\"" + textBoxMaLoaiKhach.Text + "\" không tồn tại", "Xóa Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult selectedOption =
                    MessageBox.Show(this, "Xóa loại khách \"" + textBoxMaLoaiKhach.Text + " sẽ đồng thời xóa tất cả các chi tiết hóa đơn của loại khách đó!!!", "Bạn có chắc chắn muốn xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (selectedOption == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                if (selectedOption == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand cmd = loaiKhach.xoaLoaiKhach(textBoxMaLoaiKhach.Text);
                    if (cmd != null)
                    {
                        cmdList.Add(cmd);
                        listViewLoaiKhach.Items.RemoveAt(index);
                        isLoaiKhachChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại", "Lổi không xác đinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCapNhapLoaiKhach_Click(object sender, EventArgs e)
        {
            if (textBoxMaLoaiKhach.Text == "" || textBoxLoaiKhach.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã Loại Khách, Loại Khách");
                return;
            }
            bool isExist = false; int index = 0;
            foreach (ListViewItem item in listViewLoaiKhach.Items)
            {
                if (textBoxMaLoaiKhach.Text.ToLowerInvariant() == item.Text.ToLowerInvariant())
                {
                    index = item.Index;
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("\"" + textBoxMaLoaiKhach.Text + "\" không tồn tại", "Cập Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string maLoaiKhach = textBoxMaLoaiKhach.Text;
                string tenLoaiKhach = textBoxLoaiKhach.Text;
                SqlCommand cmd = loaiKhach.capNhapLoaiKhach(maLoaiKhach, tenLoaiKhach);
                if (cmd != null)
                {
                    cmdList.Add(cmd);
                    ListViewItem item = new ListViewItem();
                    item.Text = textBoxMaLoaiKhach.Text;
                    item.SubItems.Add(textBoxLoaiKhach.Text);
                    item.BackColor = UnSavedRecord;
                    listViewLoaiKhach.Items.RemoveAt(index);
                    listViewLoaiKhach.Items.Add(item);
                    isLoaiKhachChanged = true;
                }
                else
                {
                    MessageBox.Show("Cập Nhập Thất Bại", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxMaLoaiKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxSoKhachToiDa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSoKhachToiDa.Text == "")
            {
                isThamSoChanged = true;
                return;
            }
            if (soKhachToiDa != int.Parse(textBoxSoKhachToiDa.Text))
                isThamSoChanged = true;
            else
                isThamSoChanged = false;
        }

        private void textBoxTyLePhuThu_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTyLePhuThu.Text == "")
            {
                isThamSoChanged = true;
                return;
            }
            if (tyLePhuThu != float.Parse(textBoxTyLePhuThu.Text))
            {
                isThamSoChanged = true;
            }
            else
            {
                isThamSoChanged = false;
            }
        }

        private void textBoxSoKhachToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxTyLePhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || e.KeyChar == '.')
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void FormThayDoiQuyDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmdList.Count != 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn lưu lại những thay đổi?", "Các Cài Đặt Chưa Được Lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    LuuThietLap();
                }
            }
        }
    }
}
