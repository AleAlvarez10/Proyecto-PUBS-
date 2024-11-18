using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Titulos_autorDAL
    {
        public static int AgregarTituloAutor(Titulo_autor tituloAutor)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "INSERT INTO titleauthor (au_id, title_id, au_ord, royaltyper) " +
                               "VALUES (@au_id, @title_id, @au_ord, @royaltyper)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@au_id", tituloAutor.au_id);
                command.Parameters.AddWithValue("@title_id", tituloAutor.title_id);

                // Manejar campos que permiten nulls
                command.Parameters.AddWithValue("@au_ord", (object?)tituloAutor.au_ord ?? DBNull.Value);
                command.Parameters.AddWithValue("@royaltyper", (object?)tituloAutor.royaltyper ?? DBNull.Value);

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar título-autor: " + ex.Message);
                }
            }
            return result;
        }


        public static List<Titulo_autor> Mostrar()
        {
            List<Titulo_autor> listaTituloAutor = new List<Titulo_autor>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "SELECT au_id, title_id, au_ord, royaltyper FROM titleauthor";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Crear y asignar valores al objeto Titulo_autor
                    Titulo_autor tituloAutor = new Titulo_autor
                    {
                        au_id = reader.GetString(0),
                        title_id = reader.GetString(1),
                        au_ord = reader.IsDBNull(2) ? null : (byte?)reader.GetByte(2),
                        royaltyper = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3)
                    };

                    listaTituloAutor.Add(tituloAutor);
                }
            }

            return listaTituloAutor;
        }





    }
}
