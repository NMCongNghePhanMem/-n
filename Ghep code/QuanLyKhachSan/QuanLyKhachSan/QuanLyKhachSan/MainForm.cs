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

namespace QuanLyKhachSan
{
    public enum ERole
    {
        QuanLy,
        NhanVien,
    }
    public partial class MainForm : Form
    {
        public static ERole role;
        public static String username;
        public bool IsLogOut;
        public MainForm()
        {
            InitializeComponent();
            IsLogOut = false;
            if (role == ERole.NhanVien)
            {
                msQuanLyPhong.Visible = false;
                msThietLap.Visible = false;
                msTaiChinh.Visible = false;
                msTaoMoi.Visible = false;
                msXoaQuyenTruyCap.Visible = false;
            }
        }

        private void msQuanLyPhong_Click(object sender, EventArgs e)
        {
            DanhMucPhong formDanhMucPhong = new DanhMucPhong();
            formDanhMucPhong.ShowDialog();
        }

        private void msTaoPTP_Click(object sender, EventArgs e)
        {
            PhieuThuePhong formPhieuThuePhong = new PhieuThuePhong();
            formPhieuThuePhong.ShowDialog();
        }

        private void msXemPTP_Click(object sender, EventArgs e)
        {
            ChiTietPhieuThue formPTHienTai = new ChiTietPhieuThue();
            formPTHienTai.ShowDialog();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLapHoaDonThanhToan formLapHoaDon = new FormLapHoaDonThanhToan();
            formLapHoaDon.ShowDialog();
        }

        private void msThietLap_Click(object sender, EventArgs e)
        {
            FormThayDoiQuyDinh formThayDoiQuyDinh = new FormThayDoiQuyDinh();
            formThayDoiQuyDinh.ShowDialog();
        }

        private void msTraCuuPhong_Click(object sender, EventArgs e)
        {
            FormTraCuuPhong formTraCuuPhong = new FormTraCuuPhong();
            formTraCuuPhong.ShowDialog();
        }

        private void msBaoCaoThang_Click(object sender, EventArgs e)
        {
            FormLapBaoCaoDoanThuTheoThang formLapBaoCao = new FormLapBaoCaoDoanThuTheoThang();
            formLapBaoCao.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraCuuBaoCao formTraCuuBaoCao = new FormTraCuuBaoCao();
            formTraCuuBaoCao.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
<<<<<<< HEAD
            DangNhap.formDN.Close();
=======
            if (!IsLogOut)
            {
                Environment.Exit(1); 
            }
>>>>>>> origin/master
        }

        private void msTaoMoi_Click(object sender, EventArgs e)
        {
            FormPhanQuyen formPhanQuyen = new FormPhanQuyen();
            formPhanQuyen.ShowDialog();
        }

        private void msDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }

        private void msDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap.getInstance().Show();
            IsLogOut = true;
            this.Close();
        }

        private void msXoaQuyenTruyCap_Click(object sender, EventArgs e)
        {
            XoaPhanQuyen m_XoaPQ = new XoaPhanQuyen();
            m_XoaPQ.ShowDialog();
        }


    }
}
