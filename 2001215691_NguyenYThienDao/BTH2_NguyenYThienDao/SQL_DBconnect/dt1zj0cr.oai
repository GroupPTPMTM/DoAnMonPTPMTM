using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL_DBconnect
{
    public class DBconnect
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        bool isset = false;
        //"Server=;Database=;Integrated Security=True;"
        public DBconnect(string connect)
        {
            connection = new SqlConnection(connect);
        }

        public string Script(string Query)
        {
            if (isset)
            {
                try
                {
                    cmd = new SqlCommand(CheckInject(Query), connection);
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                        return "1";
                    else
                        return result.ToString();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return "0";
        }

        public DataTable Select(string Query)
        {
            if (isset)
            {
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter(CheckInject(Query), connection);
                adapter.Fill(dt);
                return dt;
            }
            return new DataTable();
        }

        public void Connect()
        {
            if (!isset)
            {
                connection.Open();
                isset = true;
            }
        }

        public void DisConnect()
        {
            if (isset)
            {
                connection.Close();
                //connection = null;
                adapter = null;
                cmd = null;
                isset = false;
            }
        }

        public string CheckInject(string sql)
        {
            sql = sql.Replace("--", " ");
            sql = sql.Replace("/*", " ");
            //sql = sql.Replace('%', ' ');
            //sql.Replace('*', ' ');
            return sql;
        }

        public string CheckInjectText(string sql)
        {
            sql = sql.Replace(',', ' ');
            sql.Replace('$', ' ');
            sql.Replace('^', ' ');
            sql.Replace('%', ' ');
            return sql;
        }
    }
}
