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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            Autores autores = new Autores();
            autores.au_id = txt_id.Text;
            autores.au_lname = txt_aulname.Text;
            autores.au_fname = txt_aufname.Text;
            autores.phone = txt_phone.Text;
            autores.address = txt_address.Text;
            autores.city = txt_city.Text;
            autores.state = txt_state.Text;
            autores.zip = txt_zip.Text;
            autores.contract = cmbContract.Text;

            int result = AutoresDAL.AgregarAutores(autores);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar.");
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }

        }



        private void btnPrueba_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "333-33-3333";
            this.txt_aulname.Text = "Alvarez";
            this.txt_aufname.Text = "Frayre";
            this.txt_phone.Text = "871 565 8706";
            this.txt_address.Text = "47 Najera";
            this.txt_city.Text = "Torreon";
            this.txt_state.Text = "CO";
            this.txt_zip.Text = "27000";



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
