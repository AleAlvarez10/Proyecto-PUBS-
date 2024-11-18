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
    public partial class FrmRoysched : Form
    {
        public FrmRoysched()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Crear el objeto Roysched con los datos del formulario
            Roysched roysched = new Roysched();
            roysched.title_id = Convert.ToString(txt_title_id.Text); // txtTitleId es un TextBox donde el usuario ingresa el title_id                                                                 
            roysched.lorange = string.IsNullOrWhiteSpace(txt_lorange.Text) ? 0 : Convert.ToInt32(txt_lorange.Text);
            roysched.hirange = string.IsNullOrWhiteSpace(txt_hirange.Text) ? 0 : Convert.ToInt32(txt_hirange.Text);
            roysched.royalty = string.IsNullOrWhiteSpace(txt_royalty.Text) ? 0 : Convert.ToInt32(txt_royalty.Text);


            // Llamar al método para agregar en la base de datos
            int resultado = RoyschedDAL.AgregarRoysched(roysched);

            if (resultado > 0)
            {
                MessageBox.Show("El registro se agregó correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el registro.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
