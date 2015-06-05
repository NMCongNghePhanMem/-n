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
    public class BaoCaoBUS
    {
        BaoCaoDAO objBaoCao = new BaoCaoDAO();
        string maBaoCao;
        public bool ThemBaoCaoThang(BaoCaoDTO bc)
        {
            maBaoCao = objBaoCao.MaBaoCaoGanNhat();
            if (maBaoCao == "")
                maBaoCao = "0";
            bc.MaBaoCao = (int.Parse(maBaoCao) + 1).ToString();

            return objBaoCao.ThemBaoCaoThang(bc);
        }

        public bool XoaBaoCaoThang (string maBaoCao)
        {
            return objBaoCao.XoaBaoCaoThang(maBaoCao);
        }

        public string LayMaBaoCao (int thang, int nam)
        {
            return objBaoCao.LayMaBaoCao(thang, nam);
        }

        public int NamNhoNhat()
        {
            return objBaoCao.NamNhoNhat();
        }

        public string MaBaoCaoGanNhat()
        {
            return objBaoCao.MaBaoCaoGanNhat();
        }
        
    }
}
