using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkingV1.DBClass
{
    class DB : PublicVariables
    {
        public static DataTable Retreivedata(string Query)
        {
            DataTable result = new DataTable();
            using (SqlConnection conect = new SqlConnection(ConnectionString))
            {
                conect.Open();
                //Write SQL Statement
                SqlCommand Command = new SqlCommand(Query, conect);
                //Run SQL Statement 
                result.Load(Command.ExecuteReader());
                //Close Connection
            }
            return result;
        }

        public static void Execute(string Query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
