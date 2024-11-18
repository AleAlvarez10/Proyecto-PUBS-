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
    public partial class FrmTiendas : Form
    {
        public FrmTiendas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Tiendas tiendas = new Tiendas();

            tiendas.stor_id = txt_stor_id.Text;
            tiendas.stor_name = txt_stor_name.Text;
            tiendas.stor_address = txt_stor_address.Text;
            tiendas.city = txt_city.Text;
            tiendas.state = txt_state.Text;
            tiendas.zip = txt_zip.Text;

            int result = TiendasDAL.AgregarTiendas(tiendas);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar.");
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }


        }
    }
}
