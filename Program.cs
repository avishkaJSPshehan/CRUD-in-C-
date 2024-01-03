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

        void update_data()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand("UPDATE <tabale_name> SET <which column you want to update = value> WHERE <specify the row = primary key>", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("UPDATED SUCCESSFUL");
        }

        void delete_date()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand cmd = new SqlCommand("DELETE FROM <tabale_name> WHERE <specify the row = primary key>", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("DELETED SUCCESSFUL");
        }

        void select_data()
        {
            SqlConnection conn = new SqlConnection(connection_string);

            SqlCommand command = new SqlCommand("SELECT * FROM <table name> WHERE <specify the column> = @addValue", conn);
            SqlDataReader sReader;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fName", <specify the column>);
            sReader = command.ExecuteReader();

            while (sReader.Read())
            {
                //textBoxLastName.Text = sReader["Lastname"].ToString();
                //textBoxAge.Text = sReader["age"].ToString();
                //["age"] another column you want to retrieve
            }
            conn.Close();
        }

        static void Main(string[] args)
        {
            //You can call any above function as your need
            
        }
    }
}
