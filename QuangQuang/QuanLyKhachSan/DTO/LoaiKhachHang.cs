using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHang
    {
        public string ID_LoaiKhachHang { get; set; }
        public string TenLoaiKhachHang { get; set; }

        public LoaiKhachHang() { }
        public LoaiKhachHang(string id, string tenLoaiKhachHang)
        {
            ID_LoaiKhachHang = id;
            TenLoaiKhachHang = tenLoaiKhachHang;
        }

    }
}
