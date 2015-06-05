using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccessTier
{
    public class ChiTietPhieuThueDAO: DBConnection
    {
        ChiTietPhieuThueDTO m_ChiTietPTP;

        public ChiTietPhieuThueDAO()
        {
            m_ChiTietPTP = new ChiTietPhieuThueDTO();
        }

        public DataTable LayMaChiTietPTP()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LayMaChiTietPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }

        public bool ThemChiTietPTP(ChiTietPhieuThueDTO _phieuThue)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("ThemChiTietPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaChiTietPTP", SqlDbType.VarChar).Value = _phieuThue.ID_ChiTietPhieuThue;
                command.Parameters.Add("@MaPhieuThue", SqlDbType.VarChar).Value = _phieuThue.ID_PhieuThue;
                command.Parameters.Add("@MaLoaiKhachHang", SqlDbType.VarChar).Value = _phieuThue.ID_LoaiKhachHang;
                command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = _phieuThue.TenKhachHang;
                command.Parameters.Add("@CMND", SqlDbType.VarChar).Value = _phieuThue.CMND;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = _phieuThue.DiaChi;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                
                connection.Close();
            }
            return false;
        }

        public DataTable LayDsKhachTrongPhong(string _maPhieu)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LayDsKhachTrongPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MaPhieu", SqlDbType.VarChar).Value = _maPhieu;
                command.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }

        public bool XoaChiTietPTP(string _maPTP)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("XoaChiTietPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaPhieuThue", SqlDbType.VarChar).Value = _maPTP;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return false;
        }
    }
}
