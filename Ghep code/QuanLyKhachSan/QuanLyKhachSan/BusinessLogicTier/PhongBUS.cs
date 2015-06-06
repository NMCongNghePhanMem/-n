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
    public class PhongBUS
    {
        PhongDAO m_Phong;

        public PhongBUS()
        {
            m_Phong = new PhongDAO();
        }

        public DataTable GetPhong()
        {
            return m_Phong.LayTatCaPhong();
        }

        public bool ThemPhong(PhongDTO _phong)
        {
            return m_Phong.ThemPhong(_phong);
        }

        public bool XoaPhong(string _idPhong)
        {
            return m_Phong.XoaPhong(_idPhong);
        }

        public bool SuaPhongTrongDanhMuc(string _idPhong, PhongDTO _phong)
        {
            return m_Phong.SuaPhongTrongDanhMuc(_idPhong, _phong);
        }

        public PhongDTO getPhongByID(string pID)
        {
            return m_Phong.GetPhongByMaPhong(pID);
        }
        public DataTable getDanhMucPhong()
        {
            return m_Phong.GetDanhMucPhong();
        }
        public DataTable traCuuPhong(string pPhong, string pLoaiPhong, bool? ptinhTrang, int maxGia, int minGia)
        {
            return m_Phong.TraCuuPhong(pPhong, pLoaiPhong, ptinhTrang, maxGia, minGia);
        }
    }
}
