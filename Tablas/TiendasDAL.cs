using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class TiendasDAL
    {
        private DataTable? dataTable1;
        public static int AgregarTiendas(Tiendas tiendas)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {

                string query = "INSERT INTO stores (stor_id, stor_name, stor_address, city, state, zip) VALUES (@stor_id, @stor_name, @stor_address, @city, @state, @zip)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@stor_id", tiendas.stor_id);
                command.Parameters.AddWithValue("@stor_name", tiendas.stor_name);
                command.Parameters.AddWithValue("@stor_address", tiendas.stor_address);
                command.Parameters.AddWithValue("@city", tiendas.city);
                command.Parameters.AddWithValue("@state", tiendas.state);
                command.Parameters.AddWithValue("@zip", tiendas.zip);
 

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static List<Tiendas> Mostrar()
        {
            List<Tiendas> List = new List<Tiendas>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "Select *from stores";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   
                    Tiendas tiendas = new Tiendas();
                    tiendas.stor_id = reader.GetString(0);
                    tiendas.stor_name = reader.GetString(1);
                    tiendas.stor_address = reader.GetString(2);
                    tiendas.city = reader.GetString(3);
                    tiendas.state = reader.GetString(4);
                    tiendas.zip = reader.GetString(5);
                   

                    List.Add(tiendas);
                }
                conn.Close();
                return List;
            }

        }
        public static int EliminarTiendas(string stor_id)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "DELETE FROM stores WHERE stor_id = @stor_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@stor_id", stor_id);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}

