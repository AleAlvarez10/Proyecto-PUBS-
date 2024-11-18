using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class VentasDAL
    {
        public static int AgregarVentas(Ventas venta)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Verificar si el title_id existe en la tabla titles
                string checkTitleQuery = "SELECT COUNT(*) FROM titles WHERE title_id = @title_id";
                SqlCommand checkTitleCommand = new SqlCommand(checkTitleQuery, conn);
                checkTitleCommand.Parameters.AddWithValue("@title_id", venta.title_id);

                int titleCount = (int)checkTitleCommand.ExecuteScalar();

                // Verificar si el stor_id existe en la tabla stores
                string checkStorQuery = "SELECT COUNT(*) FROM stores WHERE stor_id = @stor_id";
                SqlCommand checkStorCommand = new SqlCommand(checkStorQuery, conn);
                checkStorCommand.Parameters.AddWithValue("@stor_id", venta.stor_id);

                int storCount = (int)checkStorCommand.ExecuteScalar();

                // Si tanto el title_id como el stor_id existen, proceder con la inserción
                if (titleCount > 0)
                {
                    if (storCount > 0)
                    {
                        // Consulta SQL para insertar en la tabla sales
                        string insertQuery = "INSERT INTO sales (stor_id, ord_num, ord_date, qty, payterms, title_id) " +
                                             "VALUES (@stor_id, @ord_num, @ord_date, @qty, @payterms, @title_id)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, conn);

                        insertCommand.Parameters.AddWithValue("@stor_id", venta.stor_id);
                        insertCommand.Parameters.AddWithValue("@ord_num", venta.ord_num);
                        insertCommand.Parameters.AddWithValue("@ord_date", venta.ord_date);
                        insertCommand.Parameters.AddWithValue("@qty", venta.qty);
                        insertCommand.Parameters.AddWithValue("@payterms", venta.payterms);
                        insertCommand.Parameters.AddWithValue("@title_id", venta.title_id);

                        // Ejecutar la consulta de inserción
                        result = insertCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Venta registrada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar la venta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El stor_id no existe en la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("El title_id no existe en la base de datos.");
                }
            }

            return result;
        }

        public static List<Ventas> Mostrar()
        {
            List<Ventas> listaVentas = new List<Ventas>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "SELECT stor_id, ord_num, ord_date, qty, payterms, title_id FROM sales";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ventas venta = new Ventas
                    {
                        stor_id = reader.GetString(0),        // Almacén ID (char(4))
                        ord_num = reader.GetString(1),        // Número de orden (varchar(20))
                        ord_date = reader.GetDateTime(2),     // Fecha de la orden (datetime)
                        qty = reader.GetInt16(3),             // Cantidad (smallint)
                        payterms = reader.GetString(4),       // Términos de pago (varchar(12))
                        title_id = reader.GetString(5)        // ID del título (varchar(6))
                    };

                    listaVentas.Add(venta);
                }
            }
            return listaVentas;
        }

        public static int EliminarVenta(string stor_id, string ord_num)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                try
                {
                    // Consulta SQL para eliminar el registro basado en stor_id y ord_num
                    string query = "DELETE FROM sales WHERE stor_id = @stor_id AND ord_num = @ord_num";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@stor_id", stor_id);
                    command.Parameters.AddWithValue("@ord_num", ord_num);

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar en la tabla Ventas: {ex.Message}");
                }
            }

            return result;
        }





    }


}
