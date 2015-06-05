using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataTransferObject;
namespace DataAccessTier
{
    public class BaoCaoDAO : DBConnection
    {
        DataTable dt = new DataTable();
        SqlParameter[] parameter;
        SqlDataAdapter adapter;
        SqlCommand command;
        string tempt = "";
        int nam = 0;
        public BaoCaoDAO() : base() { }

        public bool ThemBaoCaoThang(BaoCaoDTO bc)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ThemBaoCaoThang";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[4];
                parameter[0] = new SqlParameter("@MaBaoCao", bc.MaBaoCao);
                parameter[1] = new SqlParameter("@Thang", bc.Thang);
                parameter[2] = new SqlParameter("@Nam", bc.Nam);
                parameter[3] = new SqlParameter("@TongDoanhThu", bc.TongDoanhThu);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool XoaBaoCaoThang (string maBaoCao)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "XoaBaoCaoThang";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@MaBaoCao", maBaoCao);
                command.Parameters.AddRange(parameter);

                command.ExecuteNonQuery();
                connection.Close();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public string LayMaBaoCao (int thang, int nam)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "LayMaBaoCao";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[3];
                parameter[0] = new SqlParameter("@Thang", thang);
                parameter[1] = new SqlParameter("@Nam", nam);
                parameter[2] = new SqlParameter("@MaBaoCao", SqlDbType.Float);
                parameter[2].Direction = ParameterDirection.Output;

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                return parameter[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return "";
            }
        }

        public int NamNhoNhat()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "NamNhoNhat";
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    nam = (int)reader[0];
                }

                connection.Close();
                return nam;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return 0;
            }
        }

        public string MaBaoCaoGanNhat()
        {
            //string tempt = "";
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select top 1 MaBaoCao from BAOCAO order by MaBaoCao desc";

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    tempt = (string)reader[0];
                }

                connection.Close();
                return tempt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return "";
            }
        }

       
    }
}
