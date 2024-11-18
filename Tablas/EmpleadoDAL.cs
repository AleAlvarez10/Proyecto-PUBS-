﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class EmpleadoDAL
    {
        // Método para agregar un nuevo empleado a la base de datos
        public static int AgregarEmpleado(Empleado empleado)
        {
            int retorno = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "INSERT INTO employee (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) " +
                               "VALUES (@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_date)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@emp_id", empleado.emp_id);
                command.Parameters.AddWithValue("@fname", empleado.fname);
                command.Parameters.AddWithValue("@mInit", empleado.minit);
                command.Parameters.AddWithValue("@lname", empleado.lname);
                command.Parameters.AddWithValue("@job_id", empleado.job_id);
                command.Parameters.AddWithValue("@job_lvl", empleado.job_lvl);
                command.Parameters.AddWithValue("@pub_id", empleado.pub_id);
                command.Parameters.AddWithValue("@hire_date", empleado.hire_date);

                retorno = command.ExecuteNonQuery();
            }

            return retorno;
        }

        // Método para obtener una lista de todos los empleados
        public static List<Empleado> Mostrar()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "SELECT * FROM employee";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado
                    {
                        emp_id = reader.GetString(0),
                        fname = reader.GetString(1),
                        minit = reader.IsDBNull(2) ? null : reader.GetString(2),
                        lname = reader.GetString(3),
                        job_id = Convert.ToInt16(reader.GetValue(4)),
                        job_lvl = Convert.ToByte(reader.GetValue(5)),
                        pub_id = reader.GetString(6),
                        hire_date = reader.GetDateTime(7)
                    };

                    listaEmpleados.Add(empleado);
                }
            }

            return listaEmpleados;
        }

        // Método para eliminar un empleado por su ID
        public static int EliminarEmpleado(string emp_id)
        {
            int retorno = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "DELETE FROM employees WHERE emp_id = @emp_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@emp_id", emp_id);
                retorno = command.ExecuteNonQuery();
            }

            return retorno;
        }

        // Método para actualizar la información de un empleado
        public static int ActualizarEmpleado(Empleado empleado)
        {
            int retorno = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "UPDATE employees SET fname = @fname, minit = @mInit, lname = @lname, " +
                               "job_d = @job_d, job_lvl = @job_lvl, pub_id = @pub_id, hire_date = @hire_date " +
                               "WHERE emp_id = @emp_id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@emp_id", empleado.emp_id);
                command.Parameters.AddWithValue("@fname", empleado.fname);
                command.Parameters.AddWithValue("@minit", empleado.minit);
                command.Parameters.AddWithValue("@lname", empleado.lname);
                command.Parameters.AddWithValue("@job_id", empleado.job_id);
                command.Parameters.AddWithValue("@job_lvl", empleado.job_lvl);
                command.Parameters.AddWithValue("@pub_id", empleado.pub_id);
                command.Parameters.AddWithValue("@hire_date", empleado.hire_date);

                retorno = command.ExecuteNonQuery();
            }

            return retorno;
        }
    }
}