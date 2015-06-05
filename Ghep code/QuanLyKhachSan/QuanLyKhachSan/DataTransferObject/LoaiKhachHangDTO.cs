using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiKhachHangDTO
    {
        public string ID_LoaiKhachHang { get; set; }
        public string TenLoaiKhachHang { get; set; }

        public LoaiKhachHangDTO() { }
        public LoaiKhachHangDTO(string id, string tenLoaiKhachHang)
        {
            ID_LoaiKhachHang = id;
            TenLoaiKhachHang = tenLoaiKhachHang;
        }

    }
}
