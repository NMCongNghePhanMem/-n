using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using System.Data.SqlClient;

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
        public DataTable getDanhMucLoaiKhach()
        {
            return m_KhachHang.getDanhMucLoaiKhach();
        }
        public DataTransferObject.LoaiKhachHangDTO getLoaiKhachByID(string pLoaiKhach)
        {
            return m_KhachHang.getLoaiKhachByID(pLoaiKhach);
        }
        public SqlCommand themLoaiKhach(string pID, string pLoaiKhach)
        {
            return m_KhachHang.themLoaiKhachCmd(pID, pLoaiKhach);
        }
        public SqlCommand xoaLoaiKhach(string pID)
        {
            return m_KhachHang.xoaLoaiKhachCmd(pID);
        }
        public SqlCommand capNhapLoaiKhach(string pID, string pLoaiKhach)
        {
            return m_KhachHang.capNhapLoaiKhachCmd(pID, pLoaiKhach);
        }
    }
}
