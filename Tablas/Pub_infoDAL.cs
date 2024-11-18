using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Pub_infoDAL
    {
        public static int AgregarPubInfo(Pub_info pubInfo)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())  // Usamos BD.obtenerConexion() para obtener la conexión
            {
                string query = "INSERT INTO publishers (pub_id, logo, pr_info) VALUES (@pub_id, @logo, @pr_info)";
                SqlCommand command = new SqlCommand(query, conn);

                // Añadimos los parámetros a la consulta SQL
                command.Parameters.AddWithValue("@pub_id", pubInfo.pub_id);

                // Si logo es nulo, asignamos DBNull.Value
                if (pubInfo.logo != null)
                {
                    command.Parameters.AddWithValue("@logo", pubInfo.logo);
                }
                else
                {
                    command.Parameters.AddWithValue("@logo", DBNull.Value);  // Usamos DBNull.Value para valores nulos
                }

                // Si pr_info es nulo, asignamos DBNull.Value
                command.Parameters.AddWithValue("@pr_info", string.IsNullOrEmpty(pubInfo.pr_info) ? DBNull.Value : pubInfo.pr_info);

                // Ejecutamos la consulta
                retorna = command.ExecuteNonQuery();  // Ejecuta la consulta INSERT
            }

            return retorna;  // Retorna el número de filas afectadas
        }

        public static List<Pub_info> Mostrar()
        {
            List<Pub_info> listaPubInfo = new List<Pub_info>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL que selecciona todos los campos relevantes de la tabla publishers
                string query = "SELECT pub_id, logo, pr_info FROM pub_info";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Crear un objeto Pub_info para cada fila obtenida
                    Pub_info pubInfo = new Pub_info
                    {
                        pub_id = reader.GetString(0),
                        logo = reader.IsDBNull(1) ? null : (byte[])reader[1], // Leer el logo (tipo binario)
                        pr_info = reader.IsDBNull(2) ? null : reader.GetString(2) // Leer la información adicional
                    };

                    listaPubInfo.Add(pubInfo);  // Agregar el objeto a la lista
                }
            }

            return listaPubInfo;
        }

        public static int EliminarPubInfo(string pub_id)
        {
            // Variable para contar cuántas filas fueron afectadas por la eliminación
            int filasAfectadas = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para eliminar el editor basado en el 'pub_id'
                string query = "DELETE FROM publishers WHERE pub_id = @pub_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@pub_id", pub_id);

                try
                {
                    // Ejecutar el comando DELETE y obtener el número de filas afectadas
                    filasAfectadas = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, mostrar un mensaje y devolver 0 (indicando fallo)
                    MessageBox.Show("Error al eliminar el editor: " + ex.Message);
                    return 0;  // Retornar 0 si ocurre un error
                }

                // Si no ocurre ningún error, devolver el número de filas afectadas
                return filasAfectadas;  // Retorna el número de filas afectadas por la eliminación
            }
        }


    }
}
