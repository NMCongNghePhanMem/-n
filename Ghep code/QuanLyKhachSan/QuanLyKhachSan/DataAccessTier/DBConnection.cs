using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessTier
{
    //public class sqlConnect
    //{
    //    protected static string _connectionString;

    //    protected SqlConnection connection;
    //    protected SqlDataAdapter adapter;
    //    protected SqlCommand command;

    //    //public string ConnectionString = @"Data Source=emthichhocit94;Initial Catalog=RAPCHIEUPHIM;Integrated Security=True";
    //    public string ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\Study\nhap mon mem\ETN_Cinema 1.5\ETN_Cinema\RAPCHIEUPHIM.mdf;Integrated Security=True";

    //    public void connect()
    //    {
    //        connection = new SqlConnection(ConnectionString);

    //        connection.Open();
    //        executeNonQuery("set dateformat dmy");
    //    }

    //    public void disconnect()
    //    {
    //        connection.Close();
    //    }

    //    public IDataReader executeQueryParameter(string sqlString, List<SqlParameter> List_para)
    //    {

    //        command = new SqlCommand(sqlString, connection);
    //        command.CommandType = CommandType.StoredProcedure;

    //        foreach (SqlParameter para in List_para)
    //        {
    //            command.Parameters.Add(para);
    //        }

    //        return command.ExecuteReader();
    //    }

    //    public IDataReader executeQuery(string sqlString)
    //    {
    //        command = new SqlCommand(sqlString, connection);
    //        command.CommandType = CommandType.StoredProcedure;
    //        return command.ExecuteReader();
    //    }

    //    public void executeNonQuery(string sqlString)
    //    {
    //        command = new SqlCommand(sqlString, connection);
    //        //command.CommandType = CommandType.StoredProcedure;
    //        command.ExecuteNonQuery();
    //    }

    //    public object executeScalar(string sqlString)
    //    {
    //        command = new SqlCommand(sqlString, connection);
    //        return command.ExecuteScalar();
    //    }
    //}
    public class DBConnection
    {
        protected SqlConnection connection;
        public string m_ConnectionString = "Data Source=WIN-KL7CA5972TF\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        public DBConnection()
        {
            try
            {
                connection = new SqlConnection(m_ConnectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
