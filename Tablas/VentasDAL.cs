using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
                string query = @"
                    SELECT 
                        s.stor_id AS 'ID del almacén', 
                        st.stor_name AS 'Nombre de la tienda', 
                        s.ord_num AS 'Número de orden', 
                        s.ord_date AS 'Fecha de la orden', 
                        SUM(s.qty) AS 'Cantidad total',
                        s.payterms AS 'Términos de pago', 
                        STRING_AGG(p.title + ' ($' + FORMAT(p.price, 'N2') + ')', ', ') AS 'Títulos y precios'
                    FROM sales s
                    INNER JOIN titles p ON s.title_id = p.title_id
                    INNER JOIN stores st ON s.stor_id = st.stor_id
                    GROUP BY s.stor_id, st.stor_name, s.ord_num, s.ord_date, s.payterms;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asegúrate de usar los índices correctos
                            string storId = reader.GetString(0);              // ID del almacén
                            string storeName = reader.GetString(1);       // Nombre de la tienda
                            string orderNum = reader.GetString(2);        // Número de orden
                            DateTime orderDate = reader.GetDateTime(3);   // Fecha de la orden
                            int totalQty = reader.GetInt32(4);           // Cantidad total
                            string payTerms = reader.GetString(5);       // Términos de pago
                            string titlesAndPrices = reader.GetString(6); // Títulos y precios

                            Console.WriteLine($"Almacén: {storId}, Tienda: {storeName}, Orden: {orderNum}, Fecha: {orderDate}, Cantidad: {totalQty}, Términos: {payTerms}, Productos: {titlesAndPrices}");
                        }
                    }
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
