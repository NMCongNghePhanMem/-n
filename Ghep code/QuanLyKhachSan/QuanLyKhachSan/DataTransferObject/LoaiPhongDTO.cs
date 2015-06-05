using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiPhongDTO
    {
        public string ID_LoaiPhong { get; set; }
        public float DonGia { get; set; }

        public LoaiPhongDTO() 
        { }

        public LoaiPhongDTO(string id,float dongia)
        {
            ID_LoaiPhong = id;
            DonGia = dongia;
        }
    }
}
