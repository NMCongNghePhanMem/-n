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
        public MainForm()
        {
            InitializeComponent();
            if (role == ERole.NhanVien)
            {
                msQuanLyPhong.Visible = false;
                msThietLap.Visible = false;
                msTaiChinh.Visible = false;
                msPhanQuyen.Visible = false;
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

<<<<<<< HEAD:Ghep code/QuanLyKhachSan/QuanLyKhachSan/QuanLyKhachSan/MainForm.cs
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
            DangNhap d = (DangNhap)((MainForm)sender).Owner;
        }
=======
        private void msPhanQuyen_Click(object sender, EventArgs e)
        {
            FormPhanQuyen formPhanQuyen = new FormPhanQuyen();
            formPhanQuyen.ShowDialog();
        }

<<<<<<< HEAD:Ghep code/QuanLyKhachSan/QuanLyKhachSan/QuanLyKhachSan/Form1.cs
        private void msBaoCaoThang_Click(object sender, EventArgs e)
        {
            FormLapBaoCaoDoanThuTheoThang formLapBaoCao = new FormLapBaoCaoDoanThuTheoThang();
            formLapBaoCao.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraCuuBaoCao formTraCuu = new FormTraCuuBaoCao();
            formTraCuu.ShowDialog();
        }

=======
>>>>>>> origin/master:Ghep code/QuanLyKhachSan/QuanLyKhachSan/QuanLyKhachSan/Form1.cs
>>>>>>> origin/master:Ghep code/QuanLyKhachSan/QuanLyKhachSan/QuanLyKhachSan/MainForm.cs

    }
}
