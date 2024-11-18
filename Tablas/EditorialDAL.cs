using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    public class EditorialDAL
    {
        // Método para insertar un nuevo registro en la tabla publishers
        public static int AgregarEditorial(Editorial editorial)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Asegúrate de que la conexión esté abierta
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "INSERT INTO publishers (pub_id, pub_name, city, state, country) " +
                               "VALUES (@pub_id, @pub_name, @city, @state, @country)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@pub_id", editorial.pub_id);
                    command.Parameters.AddWithValue("@pub_name", string.IsNullOrWhiteSpace(editorial.pub_name) ? (object)DBNull.Value : editorial.pub_name);
                    command.Parameters.AddWithValue("@city", string.IsNullOrWhiteSpace(editorial.city) ? (object)DBNull.Value : editorial.city);
                    command.Parameters.AddWithValue("@state", string.IsNullOrWhiteSpace(editorial.state) ? (object)DBNull.Value : editorial.state);
                    command.Parameters.AddWithValue("@country", string.IsNullOrWhiteSpace(editorial.country) ? (object)DBNull.Value : editorial.country);

                    retorna = command.ExecuteNonQuery();
                }
            }
            return retorna;
        }

        // Método para mostrar todos los registros de la tabla publishers
        public static List<Editorial> Mostrar()
        {
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM publishers";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Editorial editor = new Editorial
                        {
                            pub_id = reader.GetString(0),
                            pub_name = !reader.IsDBNull(1) ? reader.GetString(1) : null,
                            city = !reader.IsDBNull(2) ? reader.GetString(2) : null,
                            state = !reader.IsDBNull(3) ? reader.GetString(3) : null,
                            country = !reader.IsDBNull(4) ? reader.GetString(4) : null
                        };

                        lista.Add(editor);
                    }
                    reader.Close();
                }
            }
            return lista;
        }

        // Método para eliminar un registro de la tabla publishers
        public static int EliminarEditorial(string pub_id)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "DELETE FROM publishers WHERE pub_id = @pub_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@pub_id", pub_id);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

    }

}
