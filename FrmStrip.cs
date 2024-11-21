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


    public partial class FrmStrip : Form
    {
        public string UsuarioTipo { get; set; }
        public FrmStrip()
        {
            InitializeComponent();
        }

        private void FrmStrip_Load(object sender, EventArgs e)
        {

        }

        private void Admin()
        {

        }

        private void Cliente()
        {
            //aut 0,tiend 2,editr5,titul7

            catalogoToolStripMenuItem.Enabled = true;
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(10);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(9);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(8);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(6);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(4);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(3);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(1);

            // Mostrar un mensaje de bienvenida
            MessageBox.Show("Bienvenido, Cliente.");
        }

        private void Trabajador()
        {
            // Habilitar los botones para ver, agregar y buscar en todas las tablas excepto las prohibidas (Pub_Info y Titulo_Autor)
            catalogoToolStripMenuItem.Enabled = true;
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(10);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(8);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(6);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(4);
            catalogoToolStripMenuItem.DropDownItems.RemoveAt(3);

            // Mostrar un mensaje de bienvenida
            MessageBox.Show("Bienvenido, Trabajador.");
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.ConfigureForAdmin();
    
        }
    }
}

