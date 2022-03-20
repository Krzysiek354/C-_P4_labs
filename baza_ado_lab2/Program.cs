// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using baza_ado_lab2;

string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind2;Integrated Security=True;Pooling=False";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    using (SqlCommand komenda = new SqlCommand("SELECT * FROM dbo.[Region]", connection))
    {
        SqlDataReader reader = komenda.ExecuteReader();


        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                    reader.GetString(1));
            }
        }
        else
        {
            Console.WriteLine("No rows found.");
        }
        reader.Close();
    }

    using (SqlCommand komenda = connection.CreateCommand())//new SqlCommand("INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthEastern')", connection))
    {
        komenda.CommandType = System.Data.CommandType.Text;
        komenda.CommandText = "INSERT Region(RegionID, RegionDescription) VALUES(8, 'Polnoc')";
        komenda.ExecuteNonQuery();

    }
    connection.Close();
}



    Console.ReadKey();
