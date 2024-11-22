using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class RoyschedDAL
    {
        public static int AgregarRoysched(Roysched roysched)
        {
                int resultado = 0;

                using (SqlConnection conn = BD.obtenerConexion())
                {
                    // Verificamos si el title_id existe en la tabla titles
                    string checkQuery = "SELECT COUNT(*) FROM titles WHERE title_id = @title_id";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, conn);
                    checkCommand.Parameters.AddWithValue("@title_id", roysched.title_id);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)  // Si el title_id existe
                    {
                        // Si el title_id existe, procedemos con la inserción en Roysched
                        string insertQuery = "INSERT INTO Roysched (title_id,title, lorange, hirange, royalty) VALUES (@title_id,@title, @lorange, @hirange, @royalty)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                        insertCommand.Parameters.AddWithValue("@title_id", roysched.title_id);

                        insertCommand.Parameters.AddWithValue("@title_name", roysched.title);                    

                        // Si el valor de lorange es null, se asigna DBNull.Value
                        insertCommand.Parameters.AddWithValue("@lorange", (object)roysched.lorange ?? DBNull.Value);

                        // Si el valor de hirange es null, se asigna DBNull.Value
                        insertCommand.Parameters.AddWithValue("@hirange", (object)roysched.hirange ?? DBNull.Value);

                        // Si el valor de royalty es null, se asigna DBNull.Value
                        insertCommand.Parameters.AddWithValue("@royalty", (object)roysched.royalty ?? DBNull.Value);

                        // Ejecutamos la consulta de inserción
                        resultado = insertCommand.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro agregado exitosamente en Roysched.");
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el registro en Roysched.");
                        }
                    }
                    else
                    {
                        // Si el title_id no existe en la tabla titles
                        MessageBox.Show("El title_id no existe en la tabla titles. No se puede agregar el registro.");
                    }
                }

                return resultado;
        }

        public static List<Roysched> Mostrar()
        {
            List<Roysched> listaRoysched = new List<Roysched>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para seleccionar todos los registros de la tabla roysched
                string query =
                    "SELECT r.title_id, t.title, r.lorange, r.hirange, r.royalty FROM roysched r INNER JOIN titles t ON r.title_id = t.title_id";
                 
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Crear un nuevo objeto Roysched y llenar sus propiedades con los datos leídos
                    Roysched roysched = new Roysched
                    {
                        title_id = reader.GetString(0), // title_id no puede ser null
                        title = reader.GetString(1),
                        lorange = reader.GetInt32(2),     // lorange
                        hirange = reader.GetInt32(3),     // hirange
                        royalty = reader.GetInt32(4)
                    };

                    // Agregar el objeto Roysched a la lista
                    listaRoysched.Add(roysched);
                }

                // Cerrar la conexión
                conn.Close();
            }

            return listaRoysched; // Retorna la lista de registros
        }

        public static int EliminarRoysched(string title_id)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                try
                {
                    // Consulta SQL para eliminar el registro basado en title_id
                    string query = "DELETE FROM roysched WHERE title_id = @title_id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@title_id", title_id);

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar en la tabla roysched: {ex.Message}");
                }
            }

            return result;
        }


    }
}
