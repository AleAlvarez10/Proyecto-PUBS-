using Proyecto_PUBS.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PUBS
{
    public partial class FrmTitulos : Form
    {
        public FrmTitulos()
        {
            InitializeComponent();
        }

        private void txt_minit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear un objeto de la clase Titulo con los valores del formulario
            Titulos nuevoTitulo = new Titulos()
            {
                title_id = txt_title_id.Text.Trim(),    // Obtener el title_id desde un TextBox
                title = txt_title.Text.Trim(),         // Obtener el title desde un TextBox
                type = txt_type.Text.Trim(),           // Obtener el type desde un TextBox
                pub_id = txt_pub_id.Text.Trim(),        // Obtener el pub_id desde un TextBox
                price = string.IsNullOrEmpty(txt_price.Text) ? (decimal?)null : Convert.ToDecimal(txt_price.Text),  // Si el precio es vacío, se asigna null
                advance = string.IsNullOrEmpty(txt_advance.Text) ? (decimal?)null : Convert.ToDecimal(txt_advance.Text),  // Si advance es vacío, se asigna null
                royalty = string.IsNullOrEmpty(txt_royalty.Text) ? (int?)null : Convert.ToInt32(txt_royalty.Text),  // Si royalty es vacío, se asigna null
                ytd_sales = string.IsNullOrEmpty(txt_ytd_sales.Text) ? (int?)null : Convert.ToInt32(txt_ytd_sales.Text),  // Si ytd_sales es vacío, se asigna null
                notes = txt_notes.Text.Trim(),         // Obtener notes desde un TextBox
                pubdate = dTP_Pub.Value            // Obtener la fecha desde un DateTimePicker
            };

            // Llamar al método AgregarTitulo para insertar el nuevo título en la base de datos
            int resultado = TitulosDAL.AgregarTitulos(nuevoTitulo);

            // Comprobar el resultado de la operación
            if (resultado > 0)
            {
                MessageBox.Show("Título registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Hubo un problema al registrar el título. Verifique los datos e intente nuevamente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
