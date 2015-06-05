using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonDTO
    {
        public string MaChiTietHoaDon { get; set; }
        public string MaHoaDon { get; set; }
        public string MaPhieuThue { get; set; }
        public int SoNgayThue { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }

        public ChiTietHoaDonDTO() { }
        public ChiTietHoaDonDTO(string idChiTiet, string idHoaDon, string idPhieuThue, int soNgayThue, float donGia, float thanhTien)
        {
            MaChiTietHoaDon = idChiTiet;
            MaHoaDon = idHoaDon;
            MaPhieuThue = idPhieuThue;
            SoNgayThue = soNgayThue;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
