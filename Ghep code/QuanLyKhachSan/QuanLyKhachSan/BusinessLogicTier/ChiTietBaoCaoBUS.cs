using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;
namespace BusinessLogicTier
{
    public class ChiTietBaoCaoBUS
    {
        ChiTietBaoCaoDAO objCTBC = new ChiTietBaoCaoDAO();

        public bool ThemChiTietBaoCao(ChiTietBaoCaoDTO ctbc)
        {
            return objCTBC.ThemChiTietBaoCao(ctbc);
        }

        public bool XoaTatCaChiTietBaoCao(string maBaoCao)
        {
            return objCTBC.XoaTatCaChiTietBaoCao(maBaoCao);
        }

        public DataTable ChiTietBaoCaoMaLoaiPhongVaDoanhThu(int thang, int nam)
        {
            return objCTBC.ChiTietBaoCaoMaLoaiPhongVaDoanhThu(thang, nam); 
        }

        public DataTable NoiDungChiTietBaoCao(string maBaoCao)
        {
            return objCTBC.NoiDungChiTietBaoCao(maBaoCao);
        }
    }
}
