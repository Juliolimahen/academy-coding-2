using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.DAO
{
    public class ToConnection
    {
        SqlConnection conn = new SqlConnection();

        public ToConnection()
        {
            conn.ConnectionString = @"Data Source=TI-NET-PC\SQLEXPRESS;Initial Catalog=academycoding2;Integrated Security=True";
            //@"server=TI-NET-PC\SQLEXPRESS;DataBase=academycoding2";
        }
        public SqlConnection ToConnect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
        public void ToDisconnect()
        {

            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }
}
