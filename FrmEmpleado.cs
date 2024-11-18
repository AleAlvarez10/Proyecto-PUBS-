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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.emp_id = txt_emp_id.Text;
            empleado.fname = txt_fname.Text;
            empleado.minit = string.IsNullOrWhiteSpace(txt_minit.Text) ? null : txt_minit.Text;
            empleado.lname = txt_lname.Text;
            empleado.job_id = Convert.ToInt16(txt_job_id.Text); // Asegúrate de que el campo sea un número válido
            empleado.job_lvl = Convert.ToByte(txt_job_lvl.Text); // Asegúrate de que el campo sea un número válido
            empleado.pub_id = txt_pub_id.Text;
            empleado.hire_date = dTP_hire.Value; // Asumiendo que usas un DateTimePicker

            // Insertar en la base de datos
            int result = EmpleadoDAL.AgregarEmpleado(empleado);

            if (result > 0)
            {
                MessageBox.Show("Éxito al guardar.");
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }
    }
}
