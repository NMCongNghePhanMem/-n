using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace BusinessLogicTier
{
    public class ThamSoBUS
    {
        ThamSoDAO m_ThamSo;

        public ThamSoBUS()
        {
            m_ThamSo = new ThamSoDAO();
        }

        public DataTable LayThamSo()
        {
            return m_ThamSo.LayThamSo();
        }

        public int getSoKhachToiDa()
        {
            return m_ThamSo.getSoKhachToiDa();
        }
        public SqlCommand themSoKhachToiDa(int pSoKhach)
        {
            return m_ThamSo.themSoKhachToiDaCmd(pSoKhach);
        }
        public float getTyLePhuThu()
        {
            return m_ThamSo.getTyLePhuThu();
        }
        public SqlCommand themTyLePhuThu(float pTyle)
        {
            return m_ThamSo.ThemTyLePhuThuCmd(pTyle);
        }

    }
}
