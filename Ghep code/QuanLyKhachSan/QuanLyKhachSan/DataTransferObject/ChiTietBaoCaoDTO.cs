using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietBaoCaoDTO
    {
        public string MaChiTietBaoCao { get; set; }
        public string MaBaoCao { get; set; }
        public string MaLoaiPhong { get; set; }
        public float DoanhThu { get; set; }
        public float TiLe { get; set; }

        public ChiTietBaoCaoDTO() { }
        public ChiTietBaoCaoDTO(string idChiTiet, string idBaoCao, string idLoaiPhong, float doanhThu, float tiLe)
        {
            MaChiTietBaoCao = idChiTiet;
            MaBaoCao = idBaoCao;
            MaLoaiPhong = idLoaiPhong;
            DoanhThu = doanhThu;
            TiLe = tiLe;
        }
    }
}
