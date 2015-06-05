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
    public class PhieuThuePhongDAO: DBConnection
    {
        PhieuThuePhongDTO m_PhieuThuePhong;
        public PhieuThuePhongDAO()
        {
            m_PhieuThuePhong = new PhieuThuePhongDTO();
        }

        public DataTable SetMaPhieuThue()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SetMaPhieuThue", connection);
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

        public DataTable LayDsPhieuThueHienTai()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LietKePhieuThueHienTai", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                DataTable result = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(result);
                connection.Close();

                return result;
            }
            catch (Exception)
            {
                connection.Close();   
            }
            return null;
        }

        public bool ThemPhieuThuePhong(PhieuThuePhongDTO m_PTP)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("ThemPhieuThuePhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = m_PTP.ID_PhieuThue;
                command.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = m_PTP.ID_Phong;
                command.Parameters.Add("@NgayThue", SqlDbType.SmallDateTime).Value = m_PTP.NgayThue;
                command.Parameters.Add("@DonGia", SqlDbType.Money).Value = m_PTP.DonGia;
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
