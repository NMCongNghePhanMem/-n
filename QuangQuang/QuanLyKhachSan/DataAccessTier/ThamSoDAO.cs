using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class ThamSoDAO: DBConnection
    {
        public ThamSoDAO() : base() { }
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
                SqlDataReader rd =cmd.ExecuteReader();
                if (rd.Read())
                {
                    TyLe = float.Parse(rd["TiLePhuThu"].ToString());
                }
                rd.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            return TyLe;
        }
        public SqlCommand ThemTyLePhuThuCmd(float pTyLe)
        {
            SqlCommand cmd = new SqlCommand("CapNhapTyLePhuThu",connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                cmd.Parameters.Add("@TyLe", System.Data.SqlDbType.Float).Value = pTyLe;
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
