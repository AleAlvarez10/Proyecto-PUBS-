using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class DescuentosDAL
    {
        private DataTable? dataTable1;
        public static int AgregarDescuentos(Descuentos descuentos)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {

                string query = "INSERT INTO discounts (stor_id, discounttype, lowqty, highqty, discount) VALUES (@stor_id, @discounttype, @lowqty, @highqty, @discount)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@discounttype", descuentos.discounttype);
                command.Parameters.AddWithValue("@stor_id", descuentos.stor_id);
                command.Parameters.AddWithValue("@lowqty", descuentos.lowqty);
                command.Parameters.AddWithValue("@highqty", descuentos.highqty);
                command.Parameters.AddWithValue("@discount", descuentos.discount);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static List<Descuentos> Mostrar()
        {
            List<Descuentos> List = new List<Descuentos>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "Select *from discounts";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Descuentos descuentos = new Descuentos();

                    descuentos.discounttype = reader.IsDBNull(0) ? null : reader.GetString(0);
                    descuentos.stor_id = reader.IsDBNull(1) ? null : reader.GetString(1);
                    descuentos.lowqty = reader.IsDBNull(2) ? (short?)null : reader.GetInt16(2);
                    descuentos.highqty = reader.IsDBNull(3) ? (short?)null : reader.GetInt16(3);
                    descuentos.discount = reader.GetDecimal(4);
  


                    List.Add(descuentos);
                }
                conn.Close();
                return List;
            }

        }
        public static int EliminarDescuentos(string stor_id)
        {
            // Variable para contar cuántas filas fueron afectadas por la eliminación
            int filasAfectadas = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para eliminar los descuentos basados en el 'stor_id'
                string query = "DELETE FROM discounts WHERE stor_id = @stor_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@stor_id", stor_id);

                try
                {
                    // Ejecutar el comando DELETE y obtener el número de filas afectadas
                    filasAfectadas = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, mostrar un mensaje y devolver 0 (indicando fallo)
                    MessageBox.Show("Error al eliminar los descuentos: " + ex.Message);
                    return 0;  // Retornar 0 si ocurre un error
                }

                // Si no ocurre ningún error, devolver el número de filas afectadas
                return filasAfectadas; // Retorna el número de filas afectadas por la eliminación
            }
        }
    }
}
