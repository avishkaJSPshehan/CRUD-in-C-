using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_Operation_with_Database
{
    class Program
    {
        string connection_string = "CHANGE THIS ACCOURDING TO YOUR CONNECTION";

        void insert_data()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand("INSERT INTO <tabale_name> VALUES(enter the values for the columns separated by comma)", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("INSERTED SUCCESSFUL");
        }

        static void Main(string[] args)
        {
        }
    }
}
