using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PhieuThuePhongDTO
    {
        public string ID_PhieuThue { get; set; }
        public string ID_Phong { get; set; }
        public DateTime NgayThue { get; set; }
        public float DonGia { get; set; }

        public PhieuThuePhongDTO() { }
        public PhieuThuePhongDTO (string idPhieuThue, string idPhong, DateTime ngayThue, float donGia)
        {
            ID_PhieuThue = idPhieuThue;
            ID_Phong = idPhong;
            NgayThue = ngayThue;
            DonGia = donGia;
        }
    }
}
