using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class TitulosDAL
    {
        public static int AgregarTitulos(Titulos titulo)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Verificar si el pub_id existe en la tabla publishers
                string checkQuery = "SELECT COUNT(*) FROM publishers WHERE pub_id = @pub_id";
                SqlCommand checkCommand = new SqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@pub_id", titulo.pub_id);

                int count = (int)checkCommand.ExecuteScalar();

                // Si el pub_id existe, proceder con la inserción en la tabla titles
                if (count > 0)
                {
                    // Consulta SQL para insertar en la tabla titles
                    string insertQuery = "INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate) " +
                                         "VALUES (@title_id, @title, @type, @pub_id, @price, @advance, @royalty, @ytd_sales, @notes, @pubdate)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, conn);

                    // Asignar parámetros a la consulta, manejando valores nulos si es necesario
                    insertCommand.Parameters.AddWithValue("@title_id", string.IsNullOrEmpty(titulo.title_id) ? DBNull.Value : titulo.title_id);
                    insertCommand.Parameters.AddWithValue("@title", string.IsNullOrEmpty(titulo.title) ? DBNull.Value : titulo.title);
                    insertCommand.Parameters.AddWithValue("@type", string.IsNullOrEmpty(titulo.type) ? DBNull.Value : titulo.type);
                    insertCommand.Parameters.AddWithValue("@pub_id", titulo.pub_id); // pub_id no puede ser nulo
                    insertCommand.Parameters.AddWithValue("@price", titulo.price ?? (object)DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@advance", titulo.advance ?? (object)DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@royalty", titulo.royalty ?? (object)DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@ytd_sales", titulo.ytd_sales ?? (object)DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(titulo.notes) ? DBNull.Value : titulo.notes);
                    insertCommand.Parameters.AddWithValue("@pubdate", titulo.pubdate);

                    // Ejecutar la consulta de inserción
                    result = insertCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Título registrado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el título.");
                    }
                }
                else
                {
                    MessageBox.Show("El pub_id no existe en la base de datos.");
                }

            }

            return result;
        }

        public static List<Titulos> Mostrar()
        {
            List<Titulos> listaTitulos = new List<Titulos>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "SELECT title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate FROM titles";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Titulos titulo = new Titulos
                    {
                        title_id = reader.GetString(0), // title_id no permite NULL
                        title = reader.GetString(1), // title no permite NULL
                        type = reader.GetString(2), // type no permite NULL
                        pub_id = reader.IsDBNull(3) ? null : reader.GetString(3), // pub_id puede ser NULL
                        price = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                        advance = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                        royalty = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6),
                        ytd_sales = reader.IsDBNull(7) ? (int?)null : reader.GetInt32(7),
                        notes = reader.IsDBNull(8) ? null : reader.GetString(8), // notes puede ser NULL
                        pubdate = reader.GetDateTime(9) // pubdate no permite NULL
                    };

                    listaTitulos.Add(titulo);
                }
            }

            return listaTitulos;
        }

        public static int EliminarTitulo(string title_id)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                try
                {
                    // Consulta SQL para eliminar el registro basado en title_id
                    string query = "DELETE FROM titles WHERE title_id = @title_id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@title_id", title_id);

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar en la tabla Titles: {ex.Message}");
                }
            }

            return result;
        }



    }
}
