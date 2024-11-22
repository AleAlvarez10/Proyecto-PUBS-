using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Proyecto_PUBS.Tablas
{
    public class AutoresDAL
    {
        private DataTable? dataTable1;
        public static int AgregarAutores(Autores autores)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                
                string query = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@au_id", autores.au_id);
                command.Parameters.AddWithValue("@au_lname", autores.au_lname);
                command.Parameters.AddWithValue("@au_fname", autores.au_fname);
                command.Parameters.AddWithValue("@phone", autores.phone);
                command.Parameters.AddWithValue("@address", autores.address);
                command.Parameters.AddWithValue("@city", autores.city);
                command.Parameters.AddWithValue("@state", autores.state);
                command.Parameters.AddWithValue("@zip", autores.zip);
                command.Parameters.AddWithValue("@contract", autores.contract);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }


        public static List<Autores> Mostrar()
        {
            List<Autores> List = new List<Autores>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "Select *from authors";
                
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Autores autores = new Autores();
                    autores.au_id = reader.GetString(0);
                    autores.au_lname = reader.GetString(1);
                    autores.au_fname = reader.GetString(2);
                    autores.phone = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                    {
                        autores.address = reader.GetString(4);
                    }
                    else
                    {
                        autores.address = null;  // Asignar null si el valor es DBNull
                    }

                    if (!reader.IsDBNull(5))
                    {
                        autores.city = reader.GetString(5);
                    }
                    else
                    {
                        autores.city = null;  // Asignar null si el valor es DBNull
                    }

                    if (!reader.IsDBNull(6))
                    {
                        autores.state = reader.GetString(6);
                    }
                    else
                    {
                        autores.state = null;  // Asignar null si el valor es DBNull
                    }

                    if (!reader.IsDBNull(7))
                    {
                        autores.zip = reader.GetString(7);
                    }
                    else
                    {
                        autores.zip = null;  // Asignar null si el valor es DBNull
                    }
                    
                    bool Contract = reader.GetBoolean(8);

                    List.Add(autores);
                }
                conn.Close();
                return List;
            }

        }
        public static int EliminarAutores(string au_id)
        {
            int retorna = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "DELETE FROM authors WHERE au_id = @au_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@au_id", au_id);
                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }
    }        
}
