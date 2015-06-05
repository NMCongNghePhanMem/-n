using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataTransferObject;
using BusinessLogicTier;

namespace QuanLyKhachSan
{
   
    public partial class ChiTietPhieuThue : Form
    {
        //List<DuLieuKH> lstCustomer;
        DataTable m_TbPhong;
        PhongBUS m_PhongObject;
        DataTable m_TbThamSo;
        ThamSoBUS m_ThamSoObject;
        DataTable m_TbLoaiPhong;
        LoaiPhongBUS m_LoaiPhongObject;
        DataTable m_TbLoaiKhach;
        LoaiKhachHangBUS m_LoaiKhachObject;
        DataTable m_DsKhachTrongMotPhieuThue;
        ChiTietPhieuThuePhongBUS m_ChiTietPT;
        DataTable m_DsPhieuThue;
        PhieuThuePhongBUS m_PTPhongObject;
        String m_MaPhongString;
        ChiTietPhieuThuePhongBUS m_ChiTietPTP;

        public ChiTietPhieuThue()
        {
            InitializeComponent();
            //lstCustomer = new List<DuLieuKH>();
            m_ChiTietPTP = new ChiTietPhieuThuePhongBUS();
            m_TbPhong = new DataTable();
            m_PhongObject = new PhongBUS();
            m_TbPhong = m_PhongObject.GetPhong();
            m_TbThamSo = new DataTable();
            m_ThamSoObject = new ThamSoBUS();
            m_TbLoaiPhong = new DataTable();
            m_LoaiPhongObject = new LoaiPhongBUS();
            m_TbLoaiKhach = new DataTable();
            m_LoaiKhachObject = new LoaiKhachHangBUS();
            m_TbLoaiKhach = m_LoaiKhachObject.LayThongTinLoaiKH();
            m_MaPhongString = "";
            m_DsKhachTrongMotPhieuThue = new DataTable();
            m_ChiTietPT = new ChiTietPhieuThuePhongBUS();
            m_PTPhongObject = new PhieuThuePhongBUS();
            m_DsPhieuThue = new DataTable();
            m_DsPhieuThue = m_PTPhongObject.LayPhieuThueHienTai();
            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                cb_Phong.Items.Add(m_DsPhieuThue.Rows[i]["MaPhong"].ToString());
            }

            for (int i = 0; i < m_TbLoaiKhach.Rows.Count; i++)
            {
                col_ThongTinKH_LoaiKhach.Items.Add(m_TbLoaiKhach.Rows[i]["TenLoaiKhachHang"].ToString());
            }
        }

        public void ResetDsPhong()
        {
            m_DsPhieuThue = m_PTPhongObject.LayPhieuThueHienTai();
            cb_Phong.Items.Clear();
            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                cb_Phong.Items.Add(m_DsPhieuThue.Rows[i]["MaPhong"].ToString());
            }
        }

        private void PhieuThueHienTai_Load(object sender, EventArgs e)
        {
            ResetDsPhong();
            if (m_DsPhieuThue == null)
            {
                MessageBox.Show("Hiện chưa có phòng nào được thuê!");
                return;
            }
            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                string[] row = new string[] 
                                    {   (i + 1).ToString(), 
                                        m_DsPhieuThue.Rows[i]["MaPhong"].ToString(),
                                        m_DsPhieuThue.Rows[i]["NgayThue"].ToString(),
                                        m_DsPhieuThue.Rows[i]["DonGia"].ToString()
                                    };
                dgv_DsPhieuThue.Rows.Add(row);
            }
        }

        public bool KiemTraDongDcChon(int _index)
        {
            for (int j = 0; j < dgv_DsPhieuThue.Columns.Count; j++)
            {
                if (dgv_DsPhieuThue.Rows[_index].Cells[j].Selected != true)
                {
                    return false;
                }
            }
            
            return true;
        }

        public int SoDongDcChon()
        {
            int result = 0;
            for (int i = 0; i < dgv_DsPhieuThue.Rows.Count; i++)
            {
                if (KiemTraDongDcChon(i) == true)
                {
                    result++;
                }
            }
            return result;
        }

        private void dgv_DsPhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_DsPhieuThue.Rows.Count; i++)
            {
                dgv_DsPhieuThue.Rows[i].DefaultCellStyle.BackColor = Color.LavenderBlush;
            }
            if (SoDongDcChon() > 1 || SoDongDcChon() <= 0)
            {
                bt_HienThi.Enabled = false;
            }
            else
            {
                bt_HienThi.Enabled = true;
            }
        }

        public int IndexDongDuocChon()
        {
            if (SoDongDcChon() == 1)
            {
                for (int i = 0; i < dgv_DsPhieuThue.Rows.Count; i++)
                {
                    if (KiemTraDongDcChon(i) == true)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public bool TonTaiPhieuThue()
        {
            ResetDsPhong();
            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                if (cb_Phong.Text == m_DsPhieuThue.Rows[i]["MaPhong"].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public string LayTenLoaiKhach(string _maLoaiKhach)
        {
            for (int i = 0; i < m_TbLoaiKhach.Rows.Count; i++)
            {
                if (_maLoaiKhach == m_TbLoaiKhach.Rows[i]["MaLoaiKhachHang"].ToString())
                {
                    return m_TbLoaiKhach.Rows[i]["TenLoaiKhachHang"].ToString();
                }
            }
            MessageBox.Show("Loại khách không tồn tại trong ds khách này.", "Thông báo", MessageBoxButtons.OK);
            return null;
        }

        public string GetMaPhieu(string _maPhong)
        {
            m_DsPhieuThue = m_PTPhongObject.LayPhieuThueHienTai();

            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                if (_maPhong == m_DsPhieuThue.Rows[i]["MaPhong"].ToString())
                {
                    return m_DsPhieuThue.Rows[i]["MaPhieuThue"].ToString();
                }
            }
            return null;
        }

        public void HienThiDsKhach(string _maPhong)
        {
            if (GetMaPhieu(_maPhong) == null)
            {
                MessageBox.Show("Không tồn tại phiếu này trong ds phiếu thuê hiện tại.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            m_DsKhachTrongMotPhieuThue = m_ChiTietPT.LayDsKhachTrongPhong(GetMaPhieu(_maPhong));

            for (int i = 0; i < m_DsKhachTrongMotPhieuThue.Rows.Count; i++)
            {
                string[] row = new string[]
                                    {   (i + 1).ToString(),
                                        //m_DsKhachTrongMotPhieuThue.Rows[i]["MaChiTietPhieuThue"].ToString(),
                                        m_DsKhachTrongMotPhieuThue.Rows[i]["TenKhachHang"].ToString(),
                                        LayTenLoaiKhach(m_DsKhachTrongMotPhieuThue.Rows[i]["MaLoaiKhachHang"].ToString()),
                                        m_DsKhachTrongMotPhieuThue.Rows[i]["CMND"].ToString(),
                                        m_DsKhachTrongMotPhieuThue.Rows[i]["DiaChi"].ToString()
                                    };
                dgv_ThongTinKhachHang.Rows.Add(row);

                //lstCustomer.Add(new DuLieuKH
                //{   SttDong = (i + 1).ToString(),
                //    MaCTPT = m_DsKhachTrongMotPhieuThue.Rows[i]["MaChiTietPhieuThue"].ToString(),
                //    TenKH = m_DsKhachTrongMotPhieuThue.Rows[i]["TenKhachHang"].ToString(),
                //    MaLoaiKH = LayTenLoaiKhach(m_DsKhachTrongMotPhieuThue.Rows[i]["MaLoaiKhachHang"].ToString()),
                //    CMNDKH = m_DsKhachTrongMotPhieuThue.Rows[i]["CMND"].ToString(),
                //    DiaChiKH = m_DsKhachTrongMotPhieuThue.Rows[i]["DiaChi"].ToString()
                //});               
            }
        }

        private void bt_HienThi_Click(object sender, EventArgs e)
        {
            if (TonTaiPhieuThue() == false && (SoDongDcChon() > 1 || SoDongDcChon() <= 0))
            {
                MessageBox.Show("Phòng này chưa được thuê.", "Thông báo", MessageBoxButtons.OK);
                cb_Phong.Text = "";
                bt_HienThi.Enabled = false;
                return;
            }

            m_MaPhongString = "";

            if (cb_Phong.Text != "")
            {
                m_MaPhongString = cb_Phong.Text;
            }
            else
            {
                if (IndexDongDuocChon() >= 0)
                {
                    m_MaPhongString = dgv_DsPhieuThue.Rows[IndexDongDuocChon()].Cells[col_DsPTP_Phong.DisplayIndex].Value.ToString();
                }
                else
                {
                    bt_HienThi.Enabled = false;
                    return;
                }
            }
            if (m_MaPhongString == "")
            {
                return;
            }

            dgv_ThongTinKhachHang.Rows.Clear();

            HienThiDsKhach(m_MaPhongString);

            bt_ThemKhach.Enabled = true;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_ChonLai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_DsPhieuThue.Rows.Count; i++)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.LavenderBlush;
                style.ForeColor = Color.Black;
                for (int j = 0; j < dgv_DsPhieuThue.Columns.Count; j++)
                {
                    dgv_DsPhieuThue.Rows[IndexDongDuocChon()].Cells[dgv_DsPhieuThue.Columns[j].Index].Style = style; 
                }
            }
            cb_Phong.Text = "";
            dgv_ThongTinKhachHang.Rows.Clear();
        }

        private void cb_Phong_TextChanged(object sender, EventArgs e)
        {
            if (cb_Phong.Text != "")
            {
                bt_HienThi.Enabled = true;
            }
        }

        private void dgv_ThongTinKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_ThongTinKhachHang.Rows.Count > 0)
            {
                bt_ThemKhach.Enabled = true;
            }
            else
            {
                bt_ThemKhach.Enabled = false;
            }
        }

        public bool CoTinhPhuThu()
        {
            m_TbThamSo = m_ThamSoObject.LayThamSo();
            if (dgv_ThongTinKhachHang.Rows.Count > int.Parse(m_TbThamSo.Rows[0]["SoKhachKhongTinhPhuThu"].ToString()))
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
            for (int i = 0; i < dgv_ThongTinKhachHang.Rows.Count; i++)
            {
                if (dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_TenKH.DisplayIndex].Value != null && dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_LoaiKhach.DisplayIndex].Value != null && dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_LoaiKhach.Index].Value.ToString().Contains("Nước ngoài"))
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

        public int SoKhachDaSua()
        {
            int result = 0;
            for (int i = 0; i < dgv_ThongTinKhachHang.Rows.Count; i++)
            {
                if (dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_TenKH.DisplayIndex].Value != null && dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_LoaiKhach.DisplayIndex].Value != null)
                {
                    result++;
                }
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

        public string MaPhieuThueCanSua(string _maPhong)
        {
            for (int i = 0; i < m_DsPhieuThue.Rows.Count; i++)
            {
                if (_maPhong == m_DsPhieuThue.Rows[i]["MaPhong"].ToString())
                {
                    return m_DsPhieuThue.Rows[i]["MaPhieuThue"].ToString();
                }
            }
            return null;
        }

        public string LayLoaiKhachHang(string _tenLoaiKhach)
        {
            m_TbLoaiKhach = m_LoaiKhachObject.LayThongTinLoaiKH();
            for (int i = 0; i < m_TbLoaiKhach.Rows.Count; i++)
            {
                if (m_TbLoaiKhach.Rows[i]["TenLoaiKhachHang"].ToString().Contains(_tenLoaiKhach))
                {
                    return m_TbLoaiKhach.Rows[i]["MaLoaiKhachHang"].ToString();
                }
            }
            MessageBox.Show("Không tìm thấy loại khách hàng này!", "Thông báo", MessageBoxButtons.OK);
            return null;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {

            if (m_MaPhongString == "")
            {
                MessageBox.Show("Chưa chọn phòng cần sửa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string loaiPhong = LayLoaiPhong(m_MaPhongString);

            if (loaiPhong == null)
            {
                return;
            }

            if (SoKhachDaSua() <= 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (SoKhachDaSua() < dgv_ThongTinKhachHang.Rows.Count)
            {
                MessageBox.Show("Bạn nhập sai thông tin của khách!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string m_MaPhieu = MaPhieuThueCanSua(m_MaPhongString);

            m_ChiTietPTP.XoaChiTietPT(m_MaPhieu);
            if (m_ChiTietPTP.XoaChiTietPT(m_MaPhieu) != true)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < dgv_ThongTinKhachHang.Rows.Count; i++)
            {
                ChiTietPhieuThueDTO _chiTietPhieuThue = new ChiTietPhieuThueDTO();
                _chiTietPhieuThue.ID_ChiTietPhieuThue = "";
                _chiTietPhieuThue.ID_PhieuThue = m_MaPhieu;

                _chiTietPhieuThue.ID_LoaiKhachHang = LayLoaiKhachHang(dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_LoaiKhach.DisplayIndex].Value.ToString());
                _chiTietPhieuThue.TenKhachHang = dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_TenKH.DisplayIndex].Value.ToString();
                if (dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_CMND.DisplayIndex].Value != null)
                {
                    _chiTietPhieuThue.CMND = dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_CMND.DisplayIndex].Value.ToString();
                }
                else
                {
                    _chiTietPhieuThue.CMND = "";
                }
                if (dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_DiaChi.DisplayIndex].Value != null)
                {
                    _chiTietPhieuThue.DiaChi = dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_DiaChi.DisplayIndex].Value.ToString();
                }
                else
                {
                    _chiTietPhieuThue.DiaChi = "";
                }

                m_ChiTietPTP.ThemChiTietPTP(_chiTietPhieuThue);
            }

            MessageBox.Show("Đã Lưu!", "Thông báo", MessageBoxButtons.OK);
            bt_ThemKhach.Enabled = false;
            bt_Sua.Enabled = false;
        }

        private void bt_ThemKhach_Click(object sender, EventArgs e)
        {
            m_TbThamSo = m_ThamSoObject.LayThamSo();
            if (m_TbThamSo.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có giá trị thiết lập.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
                return;
            }

            if (dgv_ThongTinKhachHang.Rows.Count < int.Parse(m_TbThamSo.Rows[0][m_TbThamSo.Columns["SoKhachToiDa"]].ToString()))
            {
                dgv_ThongTinKhachHang.Rows.Add();
            }
            else
            {
                MessageBox.Show("Số khách đã đầy.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < dgv_ThongTinKhachHang.Rows.Count; i++)
            {
                dgv_ThongTinKhachHang.Rows[i].Cells[col_ThongTinKH_STT.DisplayIndex].Value = (i + 1).ToString();
            }
        }

    }

}
