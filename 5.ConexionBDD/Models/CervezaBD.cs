using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace FundamentosCSHARP.Models
{

    class CervezaBD
    {
        private string connectionString
            ="Data Source=localhost;Initial Catalog=mydb;"
            +"User=root;Password=9zU~-5RH@wHT:;";
            /*="Server=localhost;Database=mydb;"
            +"Uid=root;Pwd=9zU~-5RH@wHT:;";*/
            
            /*"Password=9zU~-5RH@wHT:;"
            +"Server=aws-0-eu-central-1.pooler.supabase.com;"
            //+"Port=5432;"
            +"Database=postgres;";*/
            /*="Data Source=aws-0-eu-central-1.pooler.supabase.com;"
            +"Initial Catalog=postgres;"
            //+"Port=5432;"
            +"User=postgres.ekktfuasfuadapgoczzh;"
            +"Password=9zU~-5RH@wHT:;";*/

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad "+
                    "from cerveza";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int cantidad = reader.GetInt32(4);
                    string nombre = reader.GetString(1);
                    Cerveza cerveza = new Cerveza(cantidad, nombre);
                    cerveza.Alcohol = reader.GetInt32(3);
                    cerveza.Marca = reader.GetString(2);
                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }

            return cervezas;
        }
    }
}