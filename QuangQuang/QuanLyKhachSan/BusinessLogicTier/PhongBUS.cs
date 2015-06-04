using DataAccessTier;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogicTier
{

    public class PhongBUS
    {
        PhongDAO phongDAO;
        public PhongBUS(){
            phongDAO = new PhongDAO();
        }
        public Phong getPhongByID(string pID){
            return phongDAO.GetPhongByMaPhong(pID);
        }
        public DataTable getDanhMucPhong(){
            return phongDAO.GetDanhMucPhong();
        }
        public DataTable traCuuPhong(string pPhong, string pLoaiPhong, bool? ptinhTrang, int maxGia, int minGia)
        {
            return phongDAO.TraCuuPhong(pPhong, pLoaiPhong, ptinhTrang, maxGia, minGia);
        }
    }
}
