using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO m_LoaiPhong;
        public LoaiPhongBUS()
        {
            m_LoaiPhong = new LoaiPhongDAO();
        }

        public DataTable GetDsLoaiPhong()
        {
            return m_LoaiPhong.GetDsLoaiPhong();
        }
    }
}
