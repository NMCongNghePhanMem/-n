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
    public partial class PhieuThuePhong : Form
    {
        DataTable m_TbLoaiKH;
        DataTable m_TbPhong;
        DataTable m_TbThamSo;
        DataTable m_TbLoaiPhong;
        ThamSoBUS m_ThamSo;
        LoaiPhongBUS m_LoaiPhongObject;
        LoaiKhachHangBUS m_LoaiKhObject;
        PhongBUS m_PhongObject;
        PhieuThuePhongBUS m_PhieuThueObject;
        ChiTietPhieuThuePhongBUS m_ChiTietPtpObject;

        public PhieuThuePhong()
        {
            InitializeComponent();
            m_TbLoaiPhong = new DataTable();
            m_LoaiPhongObject = new LoaiPhongBUS();
            m_ThamSo = new ThamSoBUS();
            m_LoaiKhObject = new LoaiKhachHangBUS();
            m_PhongObject = new PhongBUS();
            m_TbLoaiKH = new DataTable();
            m_TbPhong = new DataTable();
            m_TbThamSo = new DataTable();
            m_TbThamSo = m_ThamSo.LayThamSo();
            m_PhieuThueObject = new PhieuThuePhongBUS();
            m_ChiTietPtpObject = new ChiTietPhieuThuePhongBUS();

            int rowsCount = dgvDanhSachKhach.Rows.Count;
            for (int i = 0; i < dgvDanhSachKhach.Rows.Count; i++)
            {
                dgvDanhSachKhach.Rows[i].Height = 30;
            }
        }

        public void LayDanhSachPhongChoThue()
        {
            cb_TenPhong.Items.Clear();
            m_TbPhong = m_PhongObject.GetPhong();
            for (int i = 0; i < m_TbPhong.Rows.Count; i++)
            {
                if (m_TbPhong.Rows[i]["TinhTrangPhong"].ToString() == true.ToString())
                {
                    cb_TenPhong.Items.Add(m_TbPhong.Rows[i][m_TbPhong.Columns["MaPhong"]].ToString());
                }
            }
        }

        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
            m_TbPhong = m_PhongObject.GetPhong();
            m_TbLoaiKH = m_LoaiKhObject.LayThongTinLoaiKH();
            if (m_TbPhong == null || m_TbLoaiKH == null)
            {
                MessageBox.Show("Dữ liệu chưa được cập nhật","Thông báo",MessageBoxButtons.OK);
                this.Close();
                return;
            }

            LayDanhSachPhongChoThue();

            for (int i = 0; i < m_TbLoaiKH.Rows.Count; i++)
            {
                colLoaiKhach.Items.Add(m_TbLoaiKH.Rows[i]["TenLoaiKhachHang"].ToString());
            }
        }

        public bool CoTinhPhuThu()
        {
            if (dgvDanhSachKhach.Rows.Count > int.Parse(m_TbThamSo.Rows[0]["SoKhachKhongTinhPhuThu"].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CoKhachNuocNgoai()
        {
            for (int i = 0; i < dgvDanhSachKhach.Rows.Count; i++)
            {
                if (dgvDanhSachKhach.Rows[i].Cells[colTenKhachHang.DisplayIndex].Value != null && dgvDanhSachKhach.Rows[i].Cells[colLoaiKhach.DisplayIndex].Value != null && dgvDanhSachKhach.Rows[i].Cells[colLoaiKhach.Index].Value.ToString().Contains("Nước ngoài"))
                {
                    return true;
                }
            }
            return false;
        }

        public float LayDonGiaTuyTheoSoKhach(string _loaiPhong)
        {
            m_TbLoaiPhong = m_LoaiPhongObject.GetDsLoaiPhong();
            float result = 0;
            
            for (int i = 0; i < m_TbLoaiPhong.Rows.Count; i++)
            {
                if (_loaiPhong == m_TbLoaiPhong.Rows[i]["MaLoaiPhong"].ToString())
                {
                    result = float.Parse(m_TbLoaiPhong.Rows[i]["DonGia"].ToString());
                }
            }
            if (result == 0)
	        {
                MessageBox.Show("Không tìm thấy loại phòng " + _loaiPhong, "Thông báo", MessageBoxButtons.OK);
		        return 0;
	        }
            if (CoTinhPhuThu() == true)
            {
                result = result + result * float.Parse(m_TbThamSo.Rows[0]["TiSoPhuThu"].ToString());
            }
            if (CoKhachNuocNgoai() == true)
            {
                result *= float.Parse(m_TbThamSo.Rows[0]["HeSoPhuThu"].ToString());
            }
            return result;
        }

        public string LayLoaiPhong(string _tenPhong)
        {
            for (int i = 0; i < m_TbPhong.Rows.Count; i++)
            {
                if (_tenPhong == m_TbPhong.Rows[i]["MaPhong"].ToString())
                {
                    return m_TbPhong.Rows[i]["MaLoaiPhong"].ToString();
                }
            }
            MessageBox.Show("Không tìm thấy tên phòng này!", "Thông báo", MessageBoxButtons.OK);
            return null;
        }

        public int SoKhachDaNhap()
        {
            int result = 0;
            for (int i = 0; i < dgvDanhSachKhach.Rows.Count; i++)
            {
                if (dgvDanhSachKhach.Rows[i].Cells[colTenKhachHang.DisplayIndex].Value != null && dgvDanhSachKhach.Rows[i].Cells[colLoaiKhach.DisplayIndex].Value != null)
                {
                    result++;
                }
            }
            return result;
        }

        public string LayLoaiKhachHang(string _tenLoaiKhach)
        {
            m_TbLoaiKH = m_LoaiKhObject.LayThongTinLoaiKH();
            for (int i = 0; i < m_TbLoaiKH.Rows.Count; i++)
            {
                if (m_TbLoaiKH.Rows[i]["TenLoaiKhachHang"].ToString().Contains(_tenLoaiKhach))
                {
                    return m_TbLoaiKH.Rows[i]["MaLoaiKhachHang"].ToString();
                }
            }
            MessageBox.Show("Không tìm thấy loại khách hàng này!", "Thông báo", MessageBoxButtons.OK);
            return null;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            string loaiPhong = LayLoaiPhong(cb_TenPhong.Text);
            
            if (loaiPhong == null)
            {
                return;
            }

            if (SoKhachDaNhap() <= 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (SoKhachDaNhap() < dgvDanhSachKhach.Rows.Count)
            {
                MessageBox.Show("Bạn nhập thiếu thông tin của khách!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string m_MaPhieu = m_PhieuThueObject.LayMaPhieuDuocThem();

            DateTime m_DateRent = dateTimePicker1.Value;

            m_PhieuThueObject.ThemPhieuThue(new PhieuThuePhongDTO("", cb_TenPhong.Text, m_DateRent, LayDonGiaTuyTheoSoKhach(loaiPhong)));
            
            for (int i = 0; i < dgvDanhSachKhach.Rows.Count; i++)
            {
                ChiTietPhieuThueDTO _chiTietPhieuThue = new ChiTietPhieuThueDTO();
                _chiTietPhieuThue.ID_ChiTietPhieuThue = "";
                _chiTietPhieuThue.ID_PhieuThue = m_MaPhieu;

                _chiTietPhieuThue.ID_LoaiKhachHang = LayLoaiKhachHang(dgvDanhSachKhach.Rows[i].Cells[colLoaiKhach.DisplayIndex].Value.ToString());
                _chiTietPhieuThue.TenKhachHang = dgvDanhSachKhach.Rows[i].Cells[colTenKhachHang.DisplayIndex].Value.ToString();
                if (dgvDanhSachKhach.Rows[i].Cells[colCMND.DisplayIndex].Value != null)
                {
                    _chiTietPhieuThue.CMND = dgvDanhSachKhach.Rows[i].Cells[colCMND.DisplayIndex].Value.ToString();
                }
                else
                {
                    _chiTietPhieuThue.CMND = "";
                }
                if (dgvDanhSachKhach.Rows[i].Cells[colDiaChi.DisplayIndex].Value != null)
                {
                    _chiTietPhieuThue.DiaChi = dgvDanhSachKhach.Rows[i].Cells[colDiaChi.DisplayIndex].Value.ToString();
                }
                else
                {
                    _chiTietPhieuThue.DiaChi = "";
                }

                m_ChiTietPtpObject.ThemChiTietPTP(_chiTietPhieuThue);
            }

            MessageBox.Show("Đã Lưu!", "Thông báo", MessageBoxButtons.OK);
            btThemKhach.Enabled = false;
            bt_Luu.Enabled = false;
        }

        private void btThemKhach_Click(object sender, EventArgs e)
        {
            if (m_TbThamSo.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có giá trị thiết lập.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
                return;
            }

            if (dgvDanhSachKhach.Rows.Count < int.Parse(m_TbThamSo.Rows[0][m_TbThamSo.Columns["SoKhachToiDa"]].ToString()))
            {
                dgvDanhSachKhach.Rows.Add();
            }
            else
            {
                MessageBox.Show("Số khách đã đầy.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < dgvDanhSachKhach.Rows.Count; i++)
            {
                dgvDanhSachKhach.Rows[i].Cells[col_DS_STT.DisplayIndex].Value = (i + 1).ToString();
            }
        }

        public void ResetFormPhieuThue()
        {
            dgvDanhSachKhach.Rows.Clear();
            LayDanhSachPhongChoThue();
        }

        private void bt_TaoMoi_Click(object sender, EventArgs e)
        {
            btThemKhach.Enabled = true;
            bt_Luu.Enabled = true;
            ResetFormPhieuThue();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết nối máy in thất bại!", "Thông báo", MessageBoxButtons.OK);
        }

    }
}
