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
    public partial class FrmEmpleos : Form
    {
        public FrmEmpleos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar que el campo de descripción no esté vacío
            if (string.IsNullOrEmpty(txt_job_desc.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el empleo.");
                return;
            }

            // Crear una nueva instancia del objeto Empleos
            Empleos empleo = new Empleos
            {
                job_desc = txt_job_desc.Text,
                min_lvl = string.IsNullOrEmpty(txt_min_lvl.Text) ? (int?)null : Convert.ToInt32(txt_min_lvl.Text),
                max_lvl = string.IsNullOrEmpty(txt_max_lvl.Text) ? (int?)null : Convert.ToInt32(txt_max_lvl.Text)
            };

            // Llamar al método para agregar el empleo
            int resultado = EmpleosDAL.AgregarEmpleos(empleo);

            if (resultado > 0)
            {
                MessageBox.Show("Empleo agregado exitosamente.");
                // Limpiar los campos después de la inserción exitosa
                txt_job_desc.Clear();
                txt_min_lvl.Clear();
                txt_max_lvl.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar el empleo.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
