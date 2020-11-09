using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Database.Models
{
    class DBAccess
    {
        private static SqlConnection conn = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConn = "Data Source=TANGMINHTIN;Initial Catalog=CRUD_Database;Integrated Security=True";

        public void createConn()
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void closeConn()
        {
            conn.Close();
        }

        public int excuteDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (conn.State == 0)
                {
                    createConn();
                }
                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                string insert = builder.GetInsertCommand().CommandText.ToString();
                string update = builder.GetUpdateCommand().CommandText.ToString();
                string delete = builder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    createConn();
                }

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public SqlDataReader readDatathroughReader(string query)
        {
            // DataReader used to sequentially read data from a data source
            SqlDataReader reader;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    createConn();
                }

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int excuteQuery(SqlCommand cmd)
        {
            try
            {
                if (conn.State == 0)
                {
                    createConn();
                }
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
