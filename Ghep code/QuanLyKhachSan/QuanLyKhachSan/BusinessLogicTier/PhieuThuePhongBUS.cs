using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;

namespace BusinessLogicTier
{
    public class PhieuThuePhongBUS
    {
        PhieuThuePhongDAO m_PhieuThue;

        public PhieuThuePhongBUS()
        {
            m_PhieuThue = new PhieuThuePhongDAO();
        }

        public DataTable LayPhieuThueHienTai()
        { 
            return m_PhieuThue.LayDsPhieuThueHienTai();
        }

        public string LayMaPhieuDuocThem()
        {
            return (m_PhieuThue.SetMaPhieuThue()).Rows[0][0].ToString();
        }

        public bool ThemPhieuThue(PhieuThuePhongDTO _phieuThuePhong)
        {
            _phieuThuePhong.ID_PhieuThue = LayMaPhieuDuocThem();
            return m_PhieuThue.ThemPhieuThuePhong(_phieuThuePhong);
        }
    }
}
