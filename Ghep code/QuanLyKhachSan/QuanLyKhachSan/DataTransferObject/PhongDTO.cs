using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PhongDTO
    {
        public string ID_Phong { get; set; }
        public string ID_LoaiPhong { get; set; }
        public bool TinhTrangPhong { get; set; }
        public string GhiChu { get; set; }

        public PhongDTO() { }
        public PhongDTO(string idPhong, string idLoaiPhong, bool tinhTrang, string ghiChu)
        {
            ID_Phong = idPhong;
            ID_LoaiPhong = idLoaiPhong;
            TinhTrangPhong = tinhTrang;
            GhiChu = ghiChu;
        }
    }
}
