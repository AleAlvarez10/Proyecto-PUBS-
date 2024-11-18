using Proyecto_PUBS.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PUBS
{
    public partial class FrmEditorial : Form
    {
        public FrmEditorial()
        {
            InitializeComponent();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            // Abre la conexión a la base de datos
            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Validar que el usuario haya ingresado un pub_id válido
                if (string.IsNullOrEmpty(txt_pub_id.Text))
                {
                    MessageBox.Show("Por favor, ingrese un 'pub_id' válido.");
                    return;
                }

                // Verificar si el pub_id ya existe en la tabla publishers
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM publishers WHERE pub_id = @pub_id", conn);
                checkCommand.Parameters.AddWithValue("@pub_id", txt_pub_id.Text);
                int count = (int)checkCommand.ExecuteScalar();

                // Si el pub_id ya está registrado, muestra un mensaje y no permite la inserción
                if (count > 0)
                {
                    MessageBox.Show("El 'pub_id' ingresado ya está registrado. Intente con otro ID.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar el nuevo registro en la tabla publishers
                SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO publishers (pub_id, pub_name, city, state, country) " +
                    "VALUES (@pub_id, @pub_name, @city, @state, @country)", conn);

                insertCommand.Parameters.AddWithValue("@pub_id", txt_pub_id.Text);

                // Manejo de valores nulos para los campos opcionales
                insertCommand.Parameters.AddWithValue("@pub_name", string.IsNullOrWhiteSpace(txt_pub_name.Text) ? (object)DBNull.Value : txt_pub_name.Text);
                insertCommand.Parameters.AddWithValue("@city", string.IsNullOrWhiteSpace(txt_city.Text) ? (object)DBNull.Value : txt_city.Text);
                insertCommand.Parameters.AddWithValue("@state", string.IsNullOrWhiteSpace(txt_state.Text) ? (object)DBNull.Value : txt_state.Text);
                insertCommand.Parameters.AddWithValue("@country", string.IsNullOrWhiteSpace(txt_country.Text) ? (object)DBNull.Value : txt_country.Text);

                // Ejecutar la inserción
                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Editorial registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar la editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

