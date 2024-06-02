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

        public void Add(Cerveza cerveza)
        {
            string query = "insert into cerveza(nombre, marca, alcohol, cantidad) "+
            "values @nombre, @marca, @alcohol, @cantidad"; 
            //se podría poner con "values"+cerveza.nombre+...etc pero no es una buena práctiva
            //se podría hacer inyección sql
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(@nombre, cerveza.nombre);
                command.Parameters.AddWithValue(@marca, cerveza.marca);
                command.Parameters.AddWithValue(@alcohol, cerveza.alcohol);
                command.Parameters.AddWithValue(@cantidad, cerveza.cantidad);

                connection.Open();
                connection.ExecuteNonQuery();

                connection.Close();
        }

        public void Edit(Cerveza cerveza, int Id)
        {
            string query = "update  cerveza set nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad "+
            "where id=@id"; 
            //se podría poner con "values"+cerveza.nombre+...etc pero no es una buena práctiva
            //se podría hacer inyección sql
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(@nombre, cerveza.nombre);
                command.Parameters.AddWithValue(@marca, cerveza.marca);
                command.Parameters.AddWithValue(@alcohol, cerveza.alcohol);
                command.Parameters.AddWithValue(@cantidad, cerveza.cantidad);
                command.Parameters.AddWithValue(@id, Id);//se puede agregar a la clase cerveza, es buena práctica

                connection.Open();
                connection.ExecuteNonQuery();
                
                connection.Close();
        }

        public void Delete(int Id)
        {
            string query = "delete cerveza "+
            "where id=@id"; 
            //se podría poner con "values"+cerveza.nombre+...etc pero no es una buena práctiva
            //se podría hacer inyección sql
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);                
                command.Parameters.AddWithValue(@id, Id);//se puede agregar a la clase cerveza, es buena práctica

                connection.Open();
                connection.ExecuteNonQuery();
                
                connection.Close();
        }
    }
}