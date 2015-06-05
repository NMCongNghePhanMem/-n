using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public float TongChiTietThanhToan { get; set; }

        public HoaDonDTO() { }
        public HoaDonDTO(string idHoaDon, DateTime ngayThanhToan, string tenKhachHang, string diaChi, float TCTThanhToan)
        {
            MaHoaDon = idHoaDon;
            NgayThanhToan = ngayThanhToan;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            TongChiTietThanhToan = TCTThanhToan;
        }
    }
}
