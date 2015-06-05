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
    public partial class DanhMucPhong : Form
    {
        DataTable m_TbPhong;
        DataTable m_TbLoaiPhong;
        PhongBUS m_PhongObject;
        LoaiPhongBUS m_LoaiPhongObject;
        bool m_IsSave;
        bool m_IsThem;
        bool m_IsXoa;
        bool m_IsSua;

        public DanhMucPhong()
        {
            InitializeComponent();
            m_TbLoaiPhong = new DataTable();
            m_TbPhong = new DataTable();
            m_PhongObject = new PhongBUS();
            m_LoaiPhongObject = new LoaiPhongBUS();
            m_IsSave = true;
            m_IsThem = false;
            m_IsXoa = false;
            m_IsSua = false;
        }

        public void ResetButton()
        {
            bt_Them.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            m_IsThem = false;
            m_IsXoa = false;
            m_IsSua = false;
        }

        public string LayDonGiaTuLoaiPhong(string _loaiPhong)
        {
            for (int i = 0; i < m_TbLoaiPhong.Rows.Count; i++)
            {
                if (_loaiPhong == m_TbLoaiPhong.Rows[i]["MaLoaiPhong"].ToString())
                {
                    return m_TbLoaiPhong.Rows[i]["DonGia"].ToString();
                }
            }
            MessageBox.Show("Không tồn tại loại phòng: " + _loaiPhong);
            return null;
        }

        private void DanhMucPhong_Load(object sender, EventArgs e)
        {

            m_TbPhong = m_PhongObject.GetPhong();
            m_TbLoaiPhong = m_LoaiPhongObject.GetDsLoaiPhong();
            int stt = 0;

            if (m_TbPhong != null)
            {
                foreach (DataRow row in m_TbPhong.Rows)
                {
                    string STT = (++stt).ToString();
                    string idPhong = row["MaPhong"].ToString();
                    string idLoaiPhong = row["MaLoaiPhong"].ToString();
                    string donGia = LayDonGiaTuLoaiPhong(idLoaiPhong);
                    string ghiChu = row["GhiChu"].ToString();
                    string[] element = { STT, idPhong, idLoaiPhong, donGia, ghiChu };
                    ListViewItem lvi = new ListViewItem(element);
                    lv_DanhMucPhong.Items.Add(lvi);
                }
            }

            if (m_TbLoaiPhong != null)
            {
                foreach (DataRow row in m_TbLoaiPhong.Rows)
                {
                    string idLoaiPhong = row["MaLoaiPhong"].ToString();
                    string donGia = row["DonGia"].ToString();
                    cb_LoaiPhong.Items.Add(idLoaiPhong);
                    cb_DonGia.Items.Add(donGia);
                }
            }
        }

        public bool IsError(int _cotListView, string _id)
        {
            
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].SubItems[_cotListView].Text == _id)
                {
                    return true;
                }
            }
            return false;
        }

        public void ResetThemDanhMucPhong()
        {
            tb_NhapTenPhong.Text = "";
            cb_LoaiPhong.SelectedIndex = -1;
            cb_DonGia.ResetText();
            tb_GhiChu.Text = "";
            bt_Them.Enabled = false;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            m_IsSave = false;
            m_IsThem = true;
            m_IsXoa = false;
            bt_Xoa.Enabled = false;
            int STT = lv_DanhMucPhong.Items.Count + 1;
            string idPhong = tb_NhapTenPhong.Text;
            string idLoaiPhong = cb_LoaiPhong.Text;
            string donGia = cb_DonGia.Text;
            string ghiChu = tb_GhiChu.Text;
            string[] element = {STT.ToString(), idPhong, idLoaiPhong, donGia, ghiChu};
            ListViewItem lvi = new ListViewItem(element);

            lvi.BackColor = Color.LightPink;
            if (IsError(col_Phong.DisplayIndex, idPhong) == false)
            {
                lv_DanhMucPhong.Items.Add(lvi);
                MessageBox.Show("Thêm thành công.");
            }
            else 
            {
                MessageBox.Show("Phòng này đã tồn tại trong danh sách.");
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            if (m_IsSave == false || m_IsSua == true || m_IsThem == true || m_IsXoa == true)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu danh sách phòng không.", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Bấm lưu dữ liệu!", "Thông báo", MessageBoxButtons.YesNo);
                    return;
                }
            }
            Close();
        }

        private void cb_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (m_IsXoa == true || m_IsSua == true)
            {
                bt_Them.Enabled = false;
            }
            else
            {
                bt_Them.Enabled = true;
            }
            if (cb_LoaiPhong.SelectedIndex != -1 || cb_LoaiPhong.SelectedIndex >= lv_DanhMucPhong.Items.Count)
            {
                for (int i = 0; i < m_TbLoaiPhong.Rows.Count; i++)
                {
                    string loaiPhong = m_TbLoaiPhong.Rows[i]["MaLoaiPhong"].ToString();
                    string selectedItem = cb_LoaiPhong.SelectedItem.ToString();
                    if (loaiPhong == selectedItem)
                    {
                        cb_DonGia.Text = m_TbLoaiPhong.Rows[i]["DonGia"].ToString();
                    }
                } 
            }
        }

        private void tb_NhapTenPhong_TextChanged(object sender, EventArgs e)
        {
            if (m_IsXoa == true || m_IsSua == true)
            {
                bt_Them.Enabled = false;
            }
            else
            {
                bt_Them.Enabled = true;
            }
            if (tb_NhapTenPhong.Text == "" || cb_LoaiPhong.Text == "" || cb_DonGia.Text == "" )
            {
                bt_Them.Enabled = false;
            }
            else
            {
                bt_Them.Enabled = true;
            }
        }

        private void cb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bt_Sua.Enabled == true || m_IsSua == true)
            {
                bt_Them.Enabled = false;
            }
            if (tb_NhapTenPhong.Text == "" || cb_LoaiPhong.Text == "" || cb_DonGia.Text == "")
            {
                bt_Them.Enabled = false;
            }
            else
            {
                bt_Them.Enabled = true;
            }
        }

        private void cb_DonGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bt_Sua.Enabled == true || m_IsSua == true)
            {
                bt_Them.Enabled = false;
                return;
            }
            if (tb_NhapTenPhong.Text == "" || cb_LoaiPhong.Text == "" || cb_DonGia.Text == "")
            {
                bt_Them.Enabled = false;
                return;
            }
            else
            {
                bt_Them.Enabled = true;
            }
        }

        public void XoaPhongKhoiCSDL()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = lv_DanhMucPhong.Items.Count - 1; i >= 0; i--)
                {
                    if (lv_DanhMucPhong.Items[i].Font.Strikeout == true)
                    {
                        m_PhongObject.XoaPhong(lv_DanhMucPhong.Items[i].SubItems[col_Phong.DisplayIndex].Text);
                        lv_DanhMucPhong.Items[i].Remove();
                    }
                }
            }
            else
            {
                bt_Xoa.Enabled = false;
                m_TbPhong = m_PhongObject.GetPhong();
                return;
            }

            int stt = 0;
            if (m_TbPhong != null)
            {
                for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
                {
                    lv_DanhMucPhong.Items[i].SubItems[col_STT.DisplayIndex].Text = (++stt).ToString();
                }
            }

            m_TbPhong = m_PhongObject.GetPhong();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            m_IsXoa = true;
            for (int i = lv_DanhMucPhong.Items.Count - 1; i >= 0; i--)
            {
                if (lv_DanhMucPhong.Items[i].Selected)
                {
                    lv_DanhMucPhong.Items[i].Font = new Font(lv_DanhMucPhong.Items[i].Text, float.Parse(lv_DanhMucPhong.Items[i].Font.Size.ToString()), FontStyle.Strikeout);
                }
            }
        }

        public void ThemPhongVaoCSDL()
        {
            m_IsSave = true;
            m_TbPhong = m_PhongObject.GetPhong();

            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].BackColor == Color.LightPink)
                {
                    PhongDTO phong = new PhongDTO();
                    phong.ID_Phong = lv_DanhMucPhong.Items[i].SubItems[col_Phong.DisplayIndex].Text;
                    phong.ID_LoaiPhong = lv_DanhMucPhong.Items[i].SubItems[col_LoaiPhong.DisplayIndex].Text;
                    phong.TinhTrangPhong = true;
                    phong.GhiChu = lv_DanhMucPhong.Items[i].SubItems[col_GhiChu.DisplayIndex].Text;
                    m_PhongObject.ThemPhong(phong);
                    lv_DanhMucPhong.Items[i].BackColor = Color.LavenderBlush; 
                }
            }
            m_TbPhong = m_PhongObject.GetPhong();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (m_IsThem == true)
            {
                ThemPhongVaoCSDL();
            }
            if (m_IsXoa == true)
            {
                XoaPhongKhoiCSDL();
            }
            if (m_IsSua == true)
            {
                LuuPhongDangSuaVaoCSDL();
            }
            ResetListView();
            ResetButton();
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK);
        }

        public bool DaChonPhongCanSua()
        {
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].BackColor == Color.SkyBlue)
                {
                    return true;
                }
            }
            return false;
        }
       
        public void ResetListView()
        {
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].Font.Strikeout == true)
                {
                    lv_DanhMucPhong.Items[i].Font = new Font(lv_DanhMucPhong.Items[i].Text, float.Parse(lv_DanhMucPhong.Items[i].Font.Size.ToString()), FontStyle.Regular);
                }
                
                if (lv_DanhMucPhong.Items[i].BackColor == Color.SkyBlue)
                {
                    lv_DanhMucPhong.Items[i].BackColor = Color.LavenderBlush;
                }
            }

            for (int i = lv_DanhMucPhong.Items.Count - 1; i >= 0; i--)
            {
                if (lv_DanhMucPhong.Items[i].BackColor == Color.LightPink)
                {
                    lv_DanhMucPhong.Items[i].Remove();
                }
            }
        }

        private void lv_DanhMucPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_DanhMucPhong.SelectedItems.Count != 0)
            {
                bt_Xoa.Enabled = true;
                if (lv_DanhMucPhong.SelectedItems.Count == 1 && DaChonPhongCanSua() == false && bt_Them.Enabled == false)
                {
                    bt_Sua.Enabled = true;
                }
                else
                {
                    bt_Sua.Enabled = false;
                }
            }
            else
            {
                bt_Xoa.Enabled = false;
                bt_Sua.Enabled = false;
            }
        }

        public bool LayTinhTrangPhong(string _idPhong)
        {
            m_TbPhong = m_PhongObject.GetPhong();
            for (int i = 0; i < m_TbPhong.Rows.Count; i++)
            {
                if (m_TbPhong.Rows[i]["MaPhong"].ToString() == _idPhong)
                {
                    return bool.Parse(m_TbPhong.Rows[i]["TinhTrangPhong"].ToString());
                }
            }
            return true;
        }

        public bool KiemTraPhongDangSua(int rowsSelect, string _phongCu)
        {
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].SubItems[col_Phong.DisplayIndex].Text == _phongCu && i != rowsSelect)
                {
                    return true;
                }
            }
            return false;
        }

        public void LuuPhongDangSuaVaoCSDL()
        {
            int iSelected = -1;
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
			{
			    if (lv_DanhMucPhong.Items[i].BackColor == Color.SkyBlue) // mau xanh la de sua dong
	            {
		            iSelected = i;
                    break;
	            }
			}

            if (iSelected < 0 || iSelected >= lv_DanhMucPhong.Items.Count )
	        {
                if (tb_NhapTenPhong.Text == "" || cb_LoaiPhong.Text == "")
	            {
		            MessageBox.Show("Thiếu dữ liệu phòng.", "Thông báo", MessageBoxButtons.YesNo); 
	            }
                MessageBox.Show("Chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.YesNo); 
		        return;
	        }

            string IdPhongCu = lv_DanhMucPhong.Items[iSelected].SubItems[col_Phong.DisplayIndex].Text;
            if (KiemTraPhongDangSua(iSelected, IdPhongCu) == true)
            {
                MessageBox.Show("Phòng này đã tồn tại trong danh sách.");
            }            
            PhongDTO phong = new PhongDTO(tb_NhapTenPhong.Text, cb_LoaiPhong.Text, LayTinhTrangPhong(IdPhongCu), tb_GhiChu.Text);
            m_PhongObject.SuaPhongTrongDanhMuc(IdPhongCu, phong);
            lv_DanhMucPhong.Items[iSelected].SubItems[col_Phong.DisplayIndex].Text = tb_NhapTenPhong.Text;
            lv_DanhMucPhong.Items[iSelected].SubItems[col_LoaiPhong.DisplayIndex].Text = cb_LoaiPhong.Text;
            lv_DanhMucPhong.Items[iSelected].SubItems[col_DonGia.DisplayIndex].Text = cb_DonGia.Text;
            lv_DanhMucPhong.Items[iSelected].SubItems[col_GhiChu.DisplayIndex].Text = tb_GhiChu.Text;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            m_IsSua = true;
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].Selected == true)
                {
                    lv_DanhMucPhong.Items[i].BackColor = Color.SkyBlue; 
                }
            }
            tb_NhapTenPhong.Text = lv_DanhMucPhong.SelectedItems[0].SubItems[col_Phong.DisplayIndex].Text;
            cb_LoaiPhong.Text = lv_DanhMucPhong.SelectedItems[0].SubItems[col_LoaiPhong.DisplayIndex].Text;
            cb_DonGia.Text = lv_DanhMucPhong.SelectedItems[0].SubItems[col_DonGia.DisplayIndex].Text;
            tb_GhiChu.Text = lv_DanhMucPhong.SelectedItems[0].SubItems[col_GhiChu.DisplayIndex].Text;
            m_IsThem = false;
            bt_Them.Enabled = false;
        }

        public void ResetDongDangSua()
        {
            for (int i = 0; i < lv_DanhMucPhong.Items.Count; i++)
            {
                if (lv_DanhMucPhong.Items[i].BackColor == Color.SkyBlue)
                {
                    lv_DanhMucPhong.Items[i].BackColor = Color.LavenderBlush;
                }
            }
        }

        private void bt_ThemMoi_Click(object sender, EventArgs e)
        {
            if (DaChonPhongCanSua() == true)
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa dòng đang chọn không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    ResetDongDangSua();
                }
            }
            ResetThemDanhMucPhong();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            ResetButton();
            ResetListView();
            ResetThemDanhMucPhong();
        }
    }
}
