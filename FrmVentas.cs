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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Ventas
            Tablas.Ventas nuevaVenta = new Tablas.Ventas();

            // Asignar los valores de los TextBox y demás controles a la propiedad correspondiente de la clase Ventas
            nuevaVenta.stor_id = txt_stor_id.Text;         // Asignar el ID de la tienda
            nuevaVenta.ord_num = txt_ord_num.Text;         // Asignar el número de orden
            nuevaVenta.ord_date = dateTimePickerOrd.Value;      // Asignar la fecha de la orden
            nuevaVenta.qty = Convert.ToInt16(txt_qty.Text); // Asignar la cantidad
            nuevaVenta.payterms = txt_payterms.Text;     // Asignar los términos de pago
            nuevaVenta.title_id = txt_title_id.Text;      // Asignar el ID del título

            // Llamar al método AgregarVenta para insertar la venta en la base de datos
            int resultado = VentasDAL.AgregarVentas(nuevaVenta);

            // Verificar el resultado de la inserción
            if (resultado > 0)
            {
                MessageBox.Show("Venta registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar la venta.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
