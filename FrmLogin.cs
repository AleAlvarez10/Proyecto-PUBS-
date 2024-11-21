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
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_PUBS
{
    public partial class FrmLogin : Form
    {
        public static string UserType { get; private set; } = "";  // Valor predeterminado
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
                string usuario = txt_user.Text;
                string contrasena = txt_password.Text;

                // Intentar verificar las credenciales
                if (VerificarCredenciales(usuario, contrasena))
                {
                    // Si las credenciales son correctas, continuar con el inicio de sesión
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Si las credenciales son incorrectas
                    MessageBox.Show("Credenciales incorrectas. Intentos restantes: " + (3 - intentos).ToString());
                    intentos++;

                    if (intentos >= 3)
                    {
                        MessageBox.Show("Acceso denegado. Se han alcanzado el número máximo de intentos.");
                        Application.Exit(); // Salir de la aplicación después de 3 intentos fallidos
                    }
                }
            }

        private int intentos = 0;
        private bool VerificarCredenciales(string usuario, string contrasena)
        {
            // Aquí puedes comparar con una base de datos o una lista de usuarios
            // Si la autenticación es exitosa, se establece el tipo de usuario
            if (usuario == "admn" && contrasena == "0000") // Ejemplo
            {
                Session.UserType = "Administrador";
                return true;
            }
            else if (usuario == "clie" && contrasena == "0000") // Ejemplo
            {
                Session.UserType = "Cliente";
                return true;
            }
            else if (usuario == "trab" && contrasena == "0000") // Ejemplo
            {
                Session.UserType = "Trabajador";
                return true;
            }
                return false;
        }

        private void AbrirMenu(string usuario)
        {
            FrmStrip strip = new FrmStrip();

            this.Hide(); // Ocultar el formulario de login.
            strip.Show(); // Mostrar el formulario de menú principal.
        }
    }
}
