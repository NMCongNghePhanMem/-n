using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class HoaDonBUS
    {
        HoaDonDAO objHoaDon = new HoaDonDAO();
        string maHoaDonGanNhat = "";
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            maHoaDonGanNhat = objHoaDon.MaHoaDonGanNhat();
            if (maHoaDonGanNhat == "")
                maHoaDonGanNhat = "0";

            hd.MaHoaDon = (int.Parse(maHoaDonGanNhat) + 1).ToString();
            return objHoaDon.ThemHoaDon(hd);
        }
        public bool XoaHoaDon (string maHoaDon)
        {
            return objHoaDon.XoaHoaDon(maHoaDon);
        }
        public bool CapNhatHoaDon(HoaDonDTO hd)
        {
            return objHoaDon.CapNhatHoaDon(hd);
        }
        public DateTime NgayThanhToan(string maHoaDon)
        {
            return objHoaDon.NgayThanhToan(maHoaDon);
        }
        public string MaHoaDonGanNhat()
        {
            return objHoaDon.MaHoaDonGanNhat();
        }
        public DataTable LayHoaDonNgayHienTai()
        {
            return objHoaDon.LayHoaDonNgayHienTai();
        }
        
    }
}
