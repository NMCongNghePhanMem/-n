using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

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
        public LoaiPhongDTO getLoaiPhongByID(string pID)
        {
            return m_LoaiPhong.getLoaiPhongByMaLoaiPhong(pID);
        }
        public DataTable getDanhMucLoaiPhong()
        {
            return m_LoaiPhong.getDanhMucLoaiPhong();
        }
        public int getDonGiaLonNhat()
        {
            return m_LoaiPhong.getDonGiaLonNhat();
        }
        public int themLoaiPhong(string pMaLoaiPhong, int pDonGia)
        {
            return m_LoaiPhong.themLoaiPhong(pMaLoaiPhong, pDonGia);
        }
        public int xoaLoaiPhong(string pMaLoaiPhong)
        {
            return m_LoaiPhong.xoaLoaiPhong(pMaLoaiPhong);
        }
        public int capNhapDonGia(string pMaLoaiPhong, int pDonGia)
        {
            return m_LoaiPhong.capNhapDonGia(pMaLoaiPhong, pDonGia);
        }
        public SqlCommand themLoaiPhongCmd(string pMaLoaiPhong, int pDonGia)
        {
            return m_LoaiPhong.themLoaiPhongCmd(pMaLoaiPhong, pDonGia);
        }
        public SqlCommand xoaLoaiPhongCmd(string pMaLoaiPhong)
        {
            return m_LoaiPhong.xoaLoaiPhongCmd(pMaLoaiPhong);
        }
        public SqlCommand capNhapDonGiaCmd(string pMaLoaiPhong, int pDonGia)
        {
            return m_LoaiPhong.capNhapDonGiaCmd(pMaLoaiPhong, pDonGia);
        }
    }
}
