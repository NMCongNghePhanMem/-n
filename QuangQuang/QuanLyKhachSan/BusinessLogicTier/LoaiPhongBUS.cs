using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogicTier
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO loaiPhongDAO;
        public LoaiPhongBUS()
        {
            loaiPhongDAO = new LoaiPhongDAO();
        }
        public LoaiPhong getLoaiPhongByID(string pID)
        {
            return loaiPhongDAO.getLoaiPhongByMaLoaiPhong(pID);
        }
        public DataTable getDanhMucLoaiPhong()
        {
            return loaiPhongDAO.getDanhMucLoaiPhong();
        }
        public int getDonGiaLonNhat()
        {
            return loaiPhongDAO.getDonGiaLonNhat();
        }
        public int themLoaiPhong(string pMaLoaiPhong, int pDonGia)
        {
            return loaiPhongDAO.themLoaiPhong(pMaLoaiPhong,pDonGia);
        }
        public int xoaLoaiPhong(string pMaLoaiPhong)
        {
            return loaiPhongDAO.xoaLoaiPhong(pMaLoaiPhong);
        }
        public int capNhapDonGia(string pMaLoaiPhong, int pDonGia)
        {
            return loaiPhongDAO.capNhapDonGia(pMaLoaiPhong, pDonGia);
        }
        public SqlCommand themLoaiPhongCmd(string pMaLoaiPhong, int pDonGia)
        {
            return loaiPhongDAO.themLoaiPhongCmd(pMaLoaiPhong, pDonGia);
        }
        public SqlCommand xoaLoaiPhongCmd(string pMaLoaiPhong)
        {
            return loaiPhongDAO.xoaLoaiPhongCmd(pMaLoaiPhong);
        }
        public SqlCommand capNhapDonGiaCmd(string pMaLoaiPhong, int pDonGia)
        {
            return loaiPhongDAO.capNhapDonGiaCmd(pMaLoaiPhong, pDonGia);
        }
    }
}
