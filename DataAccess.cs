using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Cafe_Management_System
{
    class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(@"Data Source=RIAZ\SQLEXPRESS;Initial Catalog=Cafe-Management-System;Integrated Security=True");
            this.connection.Open();
        }

        public SqlDataAdapter GetDataL(string sql)
        {
            return new SqlDataAdapter(sql, this.connection);
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }

    }
}
