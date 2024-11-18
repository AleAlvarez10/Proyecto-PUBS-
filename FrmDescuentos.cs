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
    public partial class FrmDescuentos : Form
    {
        public FrmDescuentos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {// Abriendo la conexión a la base de datos
            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Validar que el usuario haya ingresado un stor_id válido
                if (string.IsNullOrEmpty(txt_stor_id.Text))
                {
                    MessageBox.Show("Por favor, ingrese un stor_id válido.");
                    return;
                }

                // Verificar si el stor_id existe en la tabla stores
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stores WHERE stor_id = @stor_id", conn);
                checkCommand.Parameters.AddWithValue("@stor_id", txt_stor_id.Text);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    // Insertar el descuento si el stor_id es válido
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO discounts (stor_id, discounttype, lowqty, highqty, discount) VALUES (@stor_id, @discounttype, @lowqty, @highqty, @discount)", conn);
                    insertCommand.Parameters.AddWithValue("@stor_id", txt_stor_id.Text);
                    insertCommand.Parameters.AddWithValue("@discounttype", txt_discounttype.Text);

                    // Si no se ingresó valor en lowqty, se asigna DBNull.Value
                    if (string.IsNullOrEmpty(txt_lowqty.Text))
                        insertCommand.Parameters.AddWithValue("@lowqty", DBNull.Value);
                    else
                        insertCommand.Parameters.AddWithValue("@lowqty", Convert.ToInt32(txt_lowqty.Text));

                    // Si no se ingresó valor en highqty, se asigna DBNull.Value
                    if (string.IsNullOrEmpty(txt_highqty.Text))
                        insertCommand.Parameters.AddWithValue("@highqty", DBNull.Value);
                    else
                        insertCommand.Parameters.AddWithValue("@highqty", Convert.ToInt32(txt_highqty.Text));

                    insertCommand.Parameters.AddWithValue("@discount", Convert.ToDecimal(txt_discount.Text));

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Descuento registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El ID no existe en la tabla Tiendas.");
                }
            }
        }

        private void txt_stor_id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

