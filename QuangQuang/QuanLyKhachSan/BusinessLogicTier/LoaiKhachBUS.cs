using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace BusinessLogicTier
{
    
    public class LoaiKhachBUS
    {
        LoaiKhachHangDAO LoaiKhachDAO;
        public LoaiKhachBUS() { LoaiKhachDAO = new LoaiKhachHangDAO(); }
        public DataTable getDanhMucLoaiKhach()
        {
            return LoaiKhachDAO.getDanhMucLoaiKhach();
        }
        public LoaiKhachHang getLoaiKhachByID(string pLoaiKhach)
        {
            return LoaiKhachDAO.getLoaiKhachByID(pLoaiKhach);
        }
        public SqlCommand themLoaiKhach(string pID, string pLoaiKhach)
        {
            return LoaiKhachDAO.themLoaiKhachCmd(pID, pLoaiKhach);
        }
        public SqlCommand xoaLoaiKhach(string pID)
        {
            return LoaiKhachDAO.xoaLoaiKhachCmd(pID);
        }
        public SqlCommand capNhapLoaiKhach(string pID, string pLoaiKhach)
        {
            return LoaiKhachDAO.capNhapLoaiKhachCmd(pID, pLoaiKhach);
        }
    }
}
