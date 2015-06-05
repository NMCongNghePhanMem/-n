using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class ChiTietPhieuThuePhongBUS
    {
        ChiTietPhieuThueDAO m_ChiTietPTP;

        public ChiTietPhieuThuePhongBUS()
        {
            m_ChiTietPTP = new ChiTietPhieuThueDAO();
        }

        public string LayMaChiTietPhieuThue()
        {
            if (m_ChiTietPTP.LayMaChiTietPTP().Rows.Count == 0)
            {
                return "0";
            }
            return (m_ChiTietPTP.LayMaChiTietPTP()).Rows[0][0].ToString();
        }

        public bool ThemChiTietPTP(ChiTietPhieuThueDTO _chiTietPTP)
        {
            _chiTietPTP.ID_ChiTietPhieuThue = (int.Parse(LayMaChiTietPhieuThue()) + 1).ToString();
            return m_ChiTietPTP.ThemChiTietPTP(_chiTietPTP);
        }

        public DataTable LayDsKhachTrongPhong(string _maPhieu)
        {
            return m_ChiTietPTP.LayDsKhachTrongPhong(_maPhieu);
        }

        public bool XoaChiTietPT(string _maPTP)
        {
            return m_ChiTietPTP.XoaChiTietPTP(_maPTP);
        }
    }
}
