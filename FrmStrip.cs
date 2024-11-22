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

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            // Comprobar el tipo de usuario desde la sesión
            if (Session.UserType != null)
            {
                // Si el login fue exitoso, configurar el menú
                if (Session.UserType == "Administrador")
                {
                    Admin();
                }
                else if (Session.UserType == "Cliente")
                {
                    Cliente();
                }
                else if (Session.UserType == "Trabajador")
                {
                    Trabajador();
                }

                // Mostrar el FrmMenu
                this.Show();
            }
            else
            {
                // Si no hay tipo de usuario, cerramos la aplicación
                MessageBox.Show("Acceso denegado. El programa se cerrará.");
                Application.Exit();
            }
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
            menu.Show();
            menu.MostrarAutores();
            menu.RefreshDGV();


            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
            else if(Session.UserType == "Trabajador")
            {
                menu.RemovePermsTrabajador();
            }

        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarDescuentos();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }

        }

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarTiendas();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarEmpleados();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }


        }

        private void empleosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarEmpleos();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarEditorial();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }

        private void regalìasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarRoysched();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }


        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarTitulos();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarVentas();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }

        private void titulosYAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            menu.MostrarTituloAutor();
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }

        private void pubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu= new FrmMenu();
            menu.Show();
            menu.MostrarPubInfo(); ;
            menu.RefreshDGV();

            if (Session.UserType == "Cliente")
            {
                menu.RemovePerms();

            }
        }
    }
}

