using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogicTier
{

    public class ChiTietHoaDonBUS
    {

        ChiTietHoaDonDAO objChiTietHoaDon = new ChiTietHoaDonDAO();

        public bool ThemChiTietHoaDon(ChiTietHoaDonDTO cthd)
        {
            return objChiTietHoaDon.ThemChiTietHoaDon(cthd);
        }
        public bool XoaChiTietHoaDon(string maHoaDon, string maPhieuThue)
        {
            return objChiTietHoaDon.XoaChiTietHoaDon(maHoaDon, maPhieuThue);
        }
        public bool CapNhatChiTietHoaDon(string maHoaDonOld, string maPhieuThueOld, ChiTietHoaDonDTO cthd)
        {
            return objChiTietHoaDon.CapNhatChiTietHoaDon(maHoaDonOld, maPhieuThueOld, cthd);
        }
        public int SoNgayThue(string maHoaDon)
        {
            return objChiTietHoaDon.SoNgayThue(maHoaDon);
        }
        public string MaPhieuThueKhongTonTaiCTHD(string maPhong, DateTime ngayThanhToan)
        {
            return objChiTietHoaDon.MaPhieuThueKhongTonTaiCTHD(maPhong, ngayThanhToan);
        }
        public float DonGia(string maHoaDon,string maPhieuThue)
        {
            return objChiTietHoaDon.DonGia(maHoaDon,maPhieuThue);
        }
        public DataTable LayThongTinCTHDVaPTP(string maHoaDon)
        {
            return objChiTietHoaDon.LayThongTinCTHDVaPTP(maHoaDon);
        }

        public bool XoaTatCaChiTietHoaDon(string maHoaDon)
        {
            return objChiTietHoaDon.XoaTatCaChiTietHoaDon(maHoaDon);
        }

         public bool CapNhatTinhTrangPhong(string maPhong, bool tinhTrangPhong)
        {
            return objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, tinhTrangPhong);
        }


    }
}
