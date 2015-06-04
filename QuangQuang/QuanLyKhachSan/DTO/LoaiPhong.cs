using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong
    {
        public string ID_LoaiPhong { get; set; }
        public float DonGia { get; set; }

        public LoaiPhong() { }
        public LoaiPhong(string id, float dongia)
        {
            ID_LoaiPhong = id;
            DonGia = dongia;
        }
    }
}

