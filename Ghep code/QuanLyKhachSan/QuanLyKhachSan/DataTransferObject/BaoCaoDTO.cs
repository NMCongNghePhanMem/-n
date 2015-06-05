using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaoCaoDTO
    {
        public string MaBaoCao { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public float TongDoanhThu { get; set; }

        public BaoCaoDTO() { }
        public BaoCaoDTO(string idBaoCao, int thang, int nam , float tongDoanhThu)
        {
            MaBaoCao = idBaoCao;
            Thang = thang;
            Nam = nam;
            TongDoanhThu = tongDoanhThu;
        }
    }
}
