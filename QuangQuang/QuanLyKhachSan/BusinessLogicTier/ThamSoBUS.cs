using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data.SqlClient;

namespace BusinessLogicTier
{

    public class ThamSoBUS
    {
        ThamSoDAO ThamSo;
        public ThamSoBUS()
        {
            ThamSo = new ThamSoDAO();
        }
        public int getSoKhachToiDa(){
            return ThamSo.getSoKhachToiDa();
        }
        public SqlCommand themSoKhachToiDa(int pSoKhach)
        {
            return ThamSo.themSoKhachToiDaCmd(pSoKhach);
        }
        public float getTyLePhuThu(){
            return ThamSo.getTyLePhuThu();
        }
        public SqlCommand themTyLePhuThu(float pTyle)
        {
            return ThamSo.ThemTyLePhuThuCmd(pTyle);
        }
    }
}
