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
    public class LoaiPhongDAO: DBConnection
    {
        public LoaiPhongDAO()
        { }

        public DataTable GetDsLoaiPhong()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LietKeLoaiPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adap.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
            catch (Exception)
            {
                connection.Close();
            }

            return null;
        }
		
		public LoaiPhongDTO getLoaiPhongByMaLoaiPhong(string pID)
        {
            LoaiPhongDTO loaiPhong = null;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetLoaiPhongByID", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaLoaiPhong",SqlDbType.NVarChar,10).Value = pID;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    loaiPhong = new LoaiPhongDTO();
                    loaiPhong.ID_LoaiPhong = rd["MaLoaiPhong"].ToString();
                    loaiPhong.DonGia = int.Parse(rd["DonGia"].ToString());
                }
               
            }
            catch (Exception)
            {
                connection.Close();
            }
            return loaiPhong;
        }
        public DataTable getDanhMucLoaiPhong()
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetDanhMucLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                connection.Close(); 
            }
            return dt;
        }
        public int getDonGiaLonNhat()
        {
            int max = 0;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetDonGiaLonNhat", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    max = (int)float.Parse(rd["DonGia"].ToString());
                }
            }
            catch (Exception)
            {
                connection.Close();
            }
            return max;
        }
    }
}
