using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class EmpleosDAL
    {
        public static int AgregarEmpleos(Empleos empleo)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para insertar en la tabla jobs
                // NO incluimos el job_id porque se generará automáticamente
                string query = "INSERT INTO jobs (job_desc, min_lvl, max_lvl) VALUES (@job_desc, @min_lvl, @max_lvl)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@job_desc", empleo.job_desc);
                command.Parameters.AddWithValue("@min_lvl", empleo.min_lvl.HasValue ? empleo.min_lvl.Value : (object)DBNull.Value);
                command.Parameters.AddWithValue("@max_lvl", empleo.max_lvl.HasValue ? empleo.max_lvl.Value : (object)DBNull.Value);

                // Ejecutar la consulta de inserción
                result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Empleo agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el empleo.");
                }
            }
            return result;
        }



        public static List<Empleos> Mostrar()
        {
            List<Empleos> listaEmpleos = new List<Empleos>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para obtener todos los empleos
                string query = "SELECT job_id, job_desc, min_lvl, max_lvl FROM jobs";
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    // Leer los datos del SqlDataReader y agregarlos a la lista
                    while (reader.Read())
                    {
                        Empleos empleo = new Empleos
                        {
                            job_id = Convert.ToInt16(reader.GetValue(0)),
                            job_desc = reader.IsDBNull(1) ? null : reader.GetString(1), // job_desc, puede ser null
                            min_lvl = Convert.ToInt16(reader.GetValue(2)),
                            max_lvl = Convert.ToInt16(reader.GetValue(3))
                        };

                        listaEmpleos.Add(empleo);
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, mostrar un mensaje
                    MessageBox.Show("Error al obtener los empleos: " + ex.Message);
                }
            }

            return listaEmpleos;
        }

        public static int EliminarEmpleos(int job_id)
        {
            int result = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Consulta SQL para eliminar el empleo basado en job_id
                string query = "DELETE FROM jobs WHERE job_id = @job_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@job_id", job_id);

                // Ejecutar la consulta y devolver el número de filas afectadas
                result = command.ExecuteNonQuery();
            }

            return result;
        }



    }
}
