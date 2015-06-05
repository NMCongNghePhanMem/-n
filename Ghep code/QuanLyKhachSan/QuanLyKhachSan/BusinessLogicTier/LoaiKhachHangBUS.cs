using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class LoaiKhachHangBUS
    {
        LoaiKhachHangDAO m_KhachHang;

        public LoaiKhachHangBUS()
        {
            m_KhachHang = new LoaiKhachHangDAO();
        }

        public DataTable LayThongTinLoaiKH()
        {
            return m_KhachHang.LayThongTinLoaiKhachHang();
        }
    }
}
