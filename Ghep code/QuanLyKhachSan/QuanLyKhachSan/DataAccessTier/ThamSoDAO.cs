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
    public class ThamSoDAO: DBConnection
    {
        public ThamSoDAO():base()
        { 
        }

        public DataTable LayThamSo()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("DuLieuThamSo", connection);
                command.CommandType = CommandType.StoredProcedure;
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

        public bool ThemThamSoMoi(ThamSoDTO _thamSo)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }


            }
            catch (Exception)
            {
                
                throw;
            }
            return false;
        }
        public float getTyLePhuThu()
        {
            float TyLe = 0;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetLatestTyLePhuThu", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    TyLe = float.Parse(rd["TiSoPhuThu"].ToString());
                }
                rd.Close();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            return TyLe;
        }
        public SqlCommand ThemTyLePhuThuCmd(float pTyLe)
        {
            SqlCommand cmd = new SqlCommand("CapNhapTyLePhuThu", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@TyLe", System.Data.SqlDbType.Float).Value = pTyLe;
                connection.Close();
                return cmd;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }

        public int getSoKhachToiDa()
        {
            int khachToiDa = 0;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetLatestSoKhachToiDaTrongPhong", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    khachToiDa = int.Parse(rd["SoKhachToiDa"].ToString());
                }
                rd.Close();
                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            return khachToiDa;
        }
        public SqlCommand themSoKhachToiDaCmd(int p)
        {
            SqlCommand cmd = new SqlCommand("CapNhapSoKhachToiDaTrongPhong", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@SoKhach", System.Data.SqlDbType.Int).Value = p;
                connection.Close();
                return cmd;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
    }
}
