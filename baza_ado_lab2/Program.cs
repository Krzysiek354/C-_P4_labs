// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using baza_ado_lab2;


//string connectionStringg = "Data Source=192.168.2.4;Username=pi;password=raspberr;SslMode=none;database=temperat";
string connectionStringg = @"Server=192.168.2.2:3306; UID = pi; PWD = raspberr; Database = temperat";

string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind2;Integrated Security=True;Pooling=False";


using (SqlConnection connection = new SqlConnection(connectionStringg))
{
    connection.Open();
    using (SqlCommand komenda = new SqlCommand("SELECT * FROM dbo.[temper]", connection))
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
    //string sqll = "INSERT Into Region"+"(RegionID, RegionDescription) VALUES"+"(@liczba,@kierunek)";
    //using (SqlCommand komenda = new SqlCommand(sqll,connection))
    //{ 
    //    SqlParameter parameter = new SqlParameter()
    //    {
    //        ParameterName = "@liczba",
    //        Value = 11,
    //        SqlDbType = System.Data.SqlDbType.Int
            
    //    };
    //    komenda.Parameters.Add(parameter);
    //    parameter = new SqlParameter()
    //    {
    //        ParameterName = "@kierunek",
    //        Value = "polnocyzachod",
    //        SqlDbType = System.Data.SqlDbType.NVarChar,
    //        Size = 20

    //    };
    //    komenda.Parameters.Add(parameter);
    //    komenda.ExecuteNonQuery();

    //}
    connection.Close();
}



    Console.ReadKey();
