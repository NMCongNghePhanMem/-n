using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietPhieuThueDTO
    {
        public string ID_ChiTietPhieuThue { get; set; }
        public string ID_PhieuThue { get; set; }
        public string ID_LoaiKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }

        public ChiTietPhieuThueDTO() { }

        public ChiTietPhieuThueDTO(string idChiTiet, string idPhieuThue, string idLoaiKhachHang, string tenKhachHang, string cmnd, string diaChi)
        {
            ID_ChiTietPhieuThue = idChiTiet;
            ID_PhieuThue = idPhieuThue;
            ID_LoaiKhachHang = idLoaiKhachHang;
            TenKhachHang = tenKhachHang;
            CMND = cmnd;
            DiaChi = diaChi;
        }
    }
}
