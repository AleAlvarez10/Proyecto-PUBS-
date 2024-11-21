using Microsoft.VisualBasic.Devices;
using Proyecto_PUBS.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_PUBS
{
    public partial class FrmMenu : Form
    {
        public string UsuarioTipo { get; set; }

        private DataTable? dataTable1;
        public FrmMenu()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            RefreshDGV();
        }


        public void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                dataGridView1.DataSource = AutoresDAL.Mostrar();

                dataGridView1.Columns["au_id"].HeaderText = "ID Autor";
                dataGridView1.Columns["au_lname"].HeaderText = "Apellido";
                dataGridView1.Columns["au_fname"].HeaderText = "Nombre";
                dataGridView1.Columns["phone"].HeaderText = "Teléfono";
                dataGridView1.Columns["address"].HeaderText = "Dirección";
                dataGridView1.Columns["city"].HeaderText = "Ciudad";
                dataGridView1.Columns["state"].HeaderText = "Estado";
                dataGridView1.Columns["zip"].HeaderText = "Código Postal";
                dataGridView1.Columns["contract"].HeaderText = "Contrato";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                dataGridView1.DataSource = DescuentosDAL.Mostrar();

                dataGridView1.Columns["discounttype"].HeaderText = "Tipo de descuento";
                dataGridView1.Columns["stor_id"].HeaderText = "ID de la tienda";
                dataGridView1.Columns["lowqty"].HeaderText = "Cantidad mínima";
                dataGridView1.Columns["highqty"].HeaderText = "Cantidad máxima";
                dataGridView1.Columns["discount"].HeaderText = "Descuento";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                dataGridView1.DataSource = TiendasDAL.Mostrar();

                dataGridView1.Columns["stor_id"].HeaderText = "ID del almacén";
                dataGridView1.Columns["stor_name"].HeaderText = "Nombre de la tienda";
                dataGridView1.Columns["stor_address"].HeaderText = "Dirección de la tienda";
                dataGridView1.Columns["city"].HeaderText = "Ciudad";
                dataGridView1.Columns["state"].HeaderText = "Estado";
                dataGridView1.Columns["zip"].HeaderText = "Código Postal";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                dataGridView1.DataSource = EmpleadoDAL.Mostrar();

                dataGridView1.Columns["emp_id"].HeaderText = "ID del empleado";
                dataGridView1.Columns["fname"].HeaderText = "Nombre";
                dataGridView1.Columns["minit"].HeaderText = "Inicial del segundo nombre";
                dataGridView1.Columns["lname"].HeaderText = "Apellido";
                dataGridView1.Columns["job_id"].HeaderText = "ID del trabajo";
                dataGridView1.Columns["job_lvl"].HeaderText = "Nivel del trabajo";
                dataGridView1.Columns["pub_id"].HeaderText = "ID de la editorial";
                dataGridView1.Columns["hire_date"].HeaderText = "Fecha de contratación";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                dataGridView1.DataSource = Pub_infoDAL.Mostrar();

                dataGridView1.Columns["pub_id"].HeaderText = "ID del editor";
                dataGridView1.Columns["logo"].HeaderText = "Logo";
                dataGridView1.Columns["pr_info"].HeaderText = "Información adicional";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                dataGridView1.DataSource = EditorialDAL.Mostrar();

                dataGridView1.Columns["pub_id"].HeaderText = "ID del editor";
                dataGridView1.Columns["pub_name"].HeaderText = "Nombre del editor";
                dataGridView1.Columns["city"].HeaderText = "Ciudad";
                dataGridView1.Columns["state"].HeaderText = "Estado";
                dataGridView1.Columns["country"].HeaderText = "País";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                dataGridView1.DataSource = EmpleosDAL.Mostrar();

                dataGridView1.Columns["job_id"].HeaderText = "ID del puesto";
                dataGridView1.Columns["job_desc"].HeaderText = "Descripción del puesto";
                dataGridView1.Columns["min_lvl"].HeaderText = "Nivel mínimo";
                dataGridView1.Columns["max_lvl"].HeaderText = "Nivel máximo";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                dataGridView1.DataSource = RoyschedDAL.Mostrar();

                dataGridView1.Columns["title_id"].HeaderText = "ID del título";
                dataGridView1.Columns["lorange"].HeaderText = "Rango bajo";
                dataGridView1.Columns["hirange"].HeaderText = "Rango alto";
                dataGridView1.Columns["royalty"].HeaderText = "Regalías";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")
            {
                dataGridView1.DataSource = TitulosDAL.Mostrar();

                dataGridView1.Columns["title_id"].HeaderText = "ID del título";
                dataGridView1.Columns["title"].HeaderText = "Título";
                dataGridView1.Columns["type"].HeaderText = "Tipo";
                dataGridView1.Columns["pub_id"].HeaderText = "ID del editor";
                dataGridView1.Columns["price"].HeaderText = "Precio";
                dataGridView1.Columns["advance"].HeaderText = "Anticipo";
                dataGridView1.Columns["royalty"].HeaderText = "Regalías";
                dataGridView1.Columns["ytd_sales"].HeaderText = "Ventas anuales";
                dataGridView1.Columns["notes"].HeaderText = "Notas";
                dataGridView1.Columns["pubdate"].HeaderText = "Fecha de publicación";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                dataGridView1.DataSource = VentasDAL.Mostrar();

                dataGridView1.Columns["stor_id"].HeaderText = "ID del almacén";
                dataGridView1.Columns["ord_num"].HeaderText = "Número de orden";
                dataGridView1.Columns["ord_date"].HeaderText = "Fecha de la orden";
                dataGridView1.Columns["qty"].HeaderText = "Cantidad";
                dataGridView1.Columns["payterms"].HeaderText = "Términos de pago";
                dataGridView1.Columns["title_id"].HeaderText = "ID del título";

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                dataGridView1.DataSource = Titulos_autorDAL.Mostrar();

                dataGridView1.Columns["au_id"].HeaderText = "ID del autor";
                dataGridView1.Columns["title_id"].HeaderText = "ID del título";
                dataGridView1.Columns["au_ord"].HeaderText = "Orden del autor";
                dataGridView1.Columns["royaltyper"].HeaderText = "Porcentaje de regalías";

            }

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                FrmAutores autores = new FrmAutores();
                autores.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                FrmDescuentos descuentos = new FrmDescuentos();
                descuentos.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                FrmTiendas tiendas = new FrmTiendas();
                tiendas.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                FrmEmpleado empleado = new FrmEmpleado();
                empleado.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                FrmEditorial editorial = new FrmEditorial();
                editorial.Show();

            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                FrmEmpleos empleos = new FrmEmpleos();
                empleos.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                MessageBox.Show("No se pueden ingresar datos en esta tabla");
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                FrmRoysched roysched = new FrmRoysched();
                roysched.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                MessageBox.Show("No se pueden ingresar datos a esta tabla");
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                FrmVentas ventas = new FrmVentas();
                ventas.Show();
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")
            {
                FrmTitulos titulo = new FrmTitulos();
                titulo.Show();
            }




        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                string buscarTexto = txtBuscar.Text.Trim();

                // Verificar si el TextBox tiene texto, si no, cargar todos los datos
                if (!string.IsNullOrEmpty(buscarTexto))
                {
                    BuscarDatos(buscarTexto);
                }
                else
                {
                    RefreshDGV(); // Cargar todos los datos de la tabla si el TextBox está vacío
                }
            }
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "au_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["au_id"].Value;

                    if (valorCelda != null)
                    {
                        string au_id = valorCelda.ToString();
                        int resultado = AutoresDAL.EliminarAutores(au_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV(); // Asumiendo que tienes un método para recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Autor' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "au_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["stor_id"].Value;

                    if (valorCelda != null)
                    {
                        string stor_id = valorCelda.ToString();
                        int resultado = DescuentosDAL.EliminarDescuentos(stor_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV(); // Asumiendo que tienes un método para recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Tienda' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "au_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["stor_id"].Value;

                    if (valorCelda != null)
                    {
                        string stor_id = valorCelda.ToString();
                        int resultado = TiendasDAL.EliminarTiendas(stor_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV(); // Asumiendo que tienes un método para recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Tienda' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "emp_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["emp_id"].Value;

                    if (valorCelda != null)
                    {
                        string emp_id = valorCelda.ToString();
                        int resultado = EmpleadoDAL.EliminarEmpleado(emp_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV(); // Asumiendo que tienes un método para recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Empleado' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "pub_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["pub_id"].Value;

                    if (valorCelda != null)
                    {
                        string pub_id = valorCelda.ToString();
                        int resultado = EditorialDAL.EliminarEditorial(pub_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar la editorial.");
                            // Refrescar el DataGridView para mostrar la información actualizada
                            RefreshDGV(); // Asegúrate de que tienes un método para recargar los datos
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la editorial.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Editorial' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "job_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["job_id"].Value;

                    if (valorCelda != null)
                    {
                        // Convertir el valor de la celda a int (job_id es de tipo entero)
                        int job_id = Convert.ToInt32(valorCelda);
                        int resultado = EmpleosDAL.EliminarEmpleos(job_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Empleo' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                MessageBox.Show("No se puede eliminar infomarcion de esta tabla");
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "title_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["title_id"].Value;

                    if (valorCelda != null)
                    {
                        // Convertir el valor de la celda a string (title_id es de tipo string)
                        string title_id = valorCelda.ToString();
                        int resultado = RoyschedDAL.EliminarRoysched(title_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar.");
                            // Refrescar el DataGridView para que muestre la información actualizada
                            RefreshDGV();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Título' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                MessageBox.Show("No se puede eliminar informacion de esta tabla");
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "title_id"
                    var valorCelda = dataGridView1.CurrentRow.Cells["title_id"].Value;

                    if (valorCelda != null)
                    {
                        // Convertir el valor de la celda a string (title_id es de tipo string)
                        string title_id = valorCelda.ToString();
                        int resultado = TitulosDAL.EliminarTitulo(title_id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar el título.");
                            // Refrescar el DataGridView para mostrar los datos actualizados
                            RefreshDGV();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el título.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Título' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Intentar obtener el valor de la celda "stor_id" y "ord_num"
                    var valorStorId = dataGridView1.CurrentRow.Cells["stor_id"].Value;
                    var valorOrdNum = dataGridView1.CurrentRow.Cells["ord_num"].Value;

                    if (valorStorId != null && valorOrdNum != null)
                    {
                        // Convertir los valores de las celdas a string
                        string stor_id = valorStorId.ToString();
                        string ord_num = valorOrdNum.ToString();

                        // Llamar al método para eliminar en VentasDAL
                        int resultado = VentasDAL.EliminarVenta(stor_id, ord_num);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Éxito al eliminar la venta.");
                            // Refrescar el DataGridView para mostrar los datos actualizados
                            RefreshDGV();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la venta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'ID de Tienda' o 'Número de Orden' está vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }




        }
        public void RefreshDGV()
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM authors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM discounts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM stores";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM pub_info";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM publishers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM jobs";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM roysched";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM titleauthor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM titles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "SELECT * FROM sales";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

        }

        public void BuscarDatos(string buscarTexto)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion()) // Asegúrate de que BD.obtenerConexion() esté correctamente configurado
                    {
                        // Consulta para obtener todos los registros de la tabla authors donde el texto de búsqueda coincida
                        string query = "SELECT * FROM authors WHERE CONCAT(au_id, ' ', au_lname, ' ', au_fname, ' ', phone, ' ', address, ' ', city, ' ', state, ' ', zip) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Asignar los resultados al DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion()) // Asegúrate de que BD.obtenerConexion() esté correctamente configurado
                    {
                        // Consulta para obtener todos los registros de la tabla authors donde el texto de búsqueda coincida
                        string query = "SELECT * FROM discounts WHERE CONCAT(discounttype, ' ',stor_id , ' ', lowqty, ' ', highqty, ' ', discount) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Asignar los resultados al DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion()) // Asegúrate de que BD.obtenerConexion() esté correctamente configurado
                    {
                        // Consulta para obtener todos los registros de la tabla authors donde el texto de búsqueda coincida
                        string query = "SELECT * FROM stores WHERE CONCAT(stor_id , ' ', stor_name, ' ', stor_name, ' ', city, ' ', state, ' ', zip) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Asignar los resultados al DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM employee WHERE CONCAT(emp_id, ' ', fname, ' ', minit, ' ', lname, ' ', job_id, ' ', pub_id, ' ', hire_date) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM pub_info WHERE CONCAT(pub_id, ' ', pr_info) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM publishers WHERE CONCAT(pub_id, ' ', pub_name, ' ', city, ' ', state, ' ', country) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM jobs WHERE CONCAT(job_id, ' ', job_desc, ' ', min_lvl, ' ', max_lvl) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM roysched WHERE CONCAT(title_id, ' ', lorange, ' ', hirange, ' ', royalty) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM titleauthor WHERE CONCAT(au_id, ' ', title_id, ' ', au_ord, ' ', royaltyper) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM titles WHERE CONCAT(title_id, ' ', title, ' ', type, ' ', pub_id, ' ', price, ' ', advance, ' ', royalty, ' ', ytd_sales, ' ', notes, ' ', pubdate) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = "SELECT * FROM sales WHERE CONCAT(stor_id, ' ', ord_num, ' ', ord_date, ' ', qty, ' ', payterms, ' ', title_id) LIKE @buscarTexto";

                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@buscarTexto", "%" + buscarTexto + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void GuardarCambios(string columna, string nuevoValor, string? au_id, string? stor_id, string? emp_id, string? job_id, string? pub_id, string? title_id, string? ord_num)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())
                    {
                        string query = $"UPDATE authors SET {columna} = @nuevoValor WHERE au_id = @au_id";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, establecer @nuevoValor como NULL
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            command.Parameters.AddWithValue("@au_id", au_id);

                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Autores): {ex.Message}");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                SqlConnection conn = null;

                try
                {
                    conn = BD.obtenerConexion();

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    // Mostrar mensajes de depuración para verificar los datos
                    Console.WriteLine($"Actualizando columna: {columna}");
                    Console.WriteLine($"Nuevo valor: '{nuevoValor}'");
                    Console.WriteLine($"stor_id: '{stor_id}'");

                    string query;

                    // Si stor_id está vacío, actualizar todas las filas
                    if (string.IsNullOrEmpty(stor_id))
                    {
                        query = $"UPDATE discounts SET {columna} = @nuevoValor";
                    }
                    else
                    {
                        query = $"UPDATE discounts SET {columna} = @nuevoValor WHERE stor_id = @stor_id";
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Permitir que el nuevo valor sea vacío o nulo
                        command.Parameters.AddWithValue("@nuevoValor", string.IsNullOrEmpty(nuevoValor) ? (object)DBNull.Value : nuevoValor);

                        // Agregar el parámetro stor_id solo si tiene un valor
                        if (!string.IsNullOrEmpty(stor_id))
                        {
                            command.Parameters.AddWithValue("@stor_id", stor_id);
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar el cambio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                SqlConnection conn = null;

                try
                {
                    conn = BD.obtenerConexion();

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    // Mostrar mensajes de depuración para verificar los datos
                    Console.WriteLine($"Actualizando columna: {columna}");
                    Console.WriteLine($"Nuevo valor: '{nuevoValor}'");
                    Console.WriteLine($"stor_id: '{stor_id}'");

                    string query;

                    // Si stor_id está vacío, actualizar todas las filas
                    if (string.IsNullOrEmpty(stor_id))
                    {
                        query = $"UPDATE stores SET {columna} = @nuevoValor";
                    }
                    else
                    {
                        query = $"UPDATE stores SET {columna} = @nuevoValor WHERE stor_id = @stor_id";
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Permitir que el nuevo valor sea vacío o nulo
                        command.Parameters.AddWithValue("@nuevoValor", string.IsNullOrEmpty(nuevoValor) ? (object)DBNull.Value : nuevoValor);

                        // Agregar el parámetro stor_id solo si tiene un valor
                        if (!string.IsNullOrEmpty(stor_id))
                        {
                            command.Parameters.AddWithValue("@stor_id", stor_id);
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar el cambio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")  // Tabla empleados
            {
                SqlConnection conn = null;

                try
                {
                    conn = BD.obtenerConexion();

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    // Mostrar mensajes de depuración para verificar los datos
                    Console.WriteLine($"Actualizando columna: {columna}");
                    Console.WriteLine($"Nuevo valor: '{nuevoValor}'");
                    Console.WriteLine($"emp_id: '{emp_id}'");

                    string query;

                    // Si emp_id está vacío, actualizar todas las filas
                    if (string.IsNullOrEmpty(emp_id))
                    {
                        query = $"UPDATE employee SET {columna} = @nuevoValor";  // Tabla empleados
                    }
                    else
                    {
                        query = $"UPDATE employee SET {columna} = @nuevoValor WHERE emp_id = @emp_id";  // Columna emp_id
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Permitir que el nuevo valor sea vacío o nulo
                        command.Parameters.AddWithValue("@nuevoValor", string.IsNullOrEmpty(nuevoValor) ? (object)DBNull.Value : nuevoValor);

                        // Agregar el parámetro emp_id solo si tiene un valor
                        if (!string.IsNullOrEmpty(emp_id))
                        {
                            command.Parameters.AddWithValue("@emp_id", emp_id);  // Columna emp_id
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar el cambio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")  // Tabla empleos
            {
                SqlConnection conn = null;

                try
                {
                    conn = BD.obtenerConexion();

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string query;

                    // Si job_id está vacío, actualizar todas las filas
                    if (string.IsNullOrEmpty(job_id))
                    {
                        query = $"UPDATE jobs SET {columna} = @nuevoValor";  // Tabla empleos
                    }
                    else
                    {
                        query = $"UPDATE jobs SET {columna} = @nuevoValor WHERE job_id = @job_id";  // Columna job_id
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nuevoValor", string.IsNullOrEmpty(nuevoValor) ? (object)DBNull.Value : nuevoValor);

                        // Agregar el parámetro job_id solo si tiene un valor
                        if (!string.IsNullOrEmpty(job_id))
                        {
                            command.Parameters.AddWithValue("@job_id", job_id);  // Columna job_id
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar el cambio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editorial")  // Tabla editores
            {
                SqlConnection conn = null;

                try
                {
                    conn = BD.obtenerConexion();

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string query;

                    // Si pub_id está vacío, actualizar todas las filas
                    if (string.IsNullOrEmpty(pub_id))
                    {
                        query = $"UPDATE publishers SET {columna} = @nuevoValor";  // Tabla editores
                    }
                    else
                    {
                        query = $"UPDATE publishers SET {columna} = @nuevoValor WHERE pub_id = @pub_id";  // Columna pub_id
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nuevoValor", string.IsNullOrEmpty(nuevoValor) ? (object)DBNull.Value : nuevoValor);

                        // Agregar el parámetro pub_id solo si tiene un valor
                        if (!string.IsNullOrEmpty(pub_id))
                        {
                            command.Parameters.AddWithValue("@pub_id", pub_id);  // Columna pub_id
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar el cambio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")  // Tabla Roysched
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())  // Establece la conexión a la base de datos
                    {
                        // Consulta SQL para actualizar la columna en la tabla 'roysched'
                        string query = $"UPDATE roysched SET {columna} = @nuevoValor WHERE title_id = @title_id";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, se asigna DBNull para manejar nulos
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            // Agregar el parámetro 'title_id' que es el identificador único
                            command.Parameters.AddWithValue("@title_id", title_id);

                            // Ejecutar la consulta y verificar el número de filas afectadas
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Roysched): {ex.Message}");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")  // Tabla Pub_Info
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())  // Establece la conexión a la base de datos
                    {
                        // Consulta SQL para actualizar la columna en la tabla 'pub_info'
                        string query = $"UPDATE pub_info SET {columna} = @nuevoValor WHERE pub_id = @pub_id";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, se asigna DBNull para manejar nulos
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            // Agregar el parámetro 'pub_id' que es el identificador único
                            command.Parameters.AddWithValue("@pub_id", pub_id);

                            // Ejecutar la consulta y verificar el número de filas afectadas
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Pub_Info): {ex.Message}");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")  // Tabla Titulo_autor
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())  // Establece la conexión a la base de datos
                    {
                        // Consulta SQL para actualizar la columna en la tabla 'titulo_autor'
                        string query = $"UPDATE titleauthor SET {columna} = @nuevoValor WHERE au_id = @au_id AND title_id = @title_id";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, se asigna DBNull para manejar nulos
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            // Agregar los parámetros 'au_id' y 'title_id' como identificadores únicos
                            command.Parameters.AddWithValue("@au_id", au_id);
                            command.Parameters.AddWithValue("@title_id", title_id);

                            // Ejecutar la consulta y verificar el número de filas afectadas
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Titulo_autor): {ex.Message}");
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")  // Tabla Titulo
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())  // Establece la conexión a la base de datos
                    {
                        // Consulta SQL para actualizar la columna en la tabla 'titulo'
                        string query = $"UPDATE titles SET {columna} = @nuevoValor WHERE title_id = @title_id";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, se asigna DBNull para manejar nulos
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            // Agregar el parámetro 'title_id' que es el identificador único
                            command.Parameters.AddWithValue("@title_id", title_id);

                            // Ejecutar la consulta y verificar el número de filas afectadas
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Titulo): {ex.Message}");
                }
            }

            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")  // Tabla Ventas
            {
                try
                {
                    using (SqlConnection conn = BD.obtenerConexion())  // Establece la conexión a la base de datos
                    {
                        // Consulta SQL para actualizar la columna en la tabla 'ventas'
                        string query = $"UPDATE sales SET {columna} = @nuevoValor WHERE stor_id = @stor_id AND ord_num = @ord_num";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            // Si el nuevo valor es una cadena vacía, se asigna DBNull para manejar nulos
                            if (string.IsNullOrWhiteSpace(nuevoValor))
                            {
                                command.Parameters.AddWithValue("@nuevoValor", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                            }

                            // Agregar los parámetros 'stor_id' y 'ord_num' como identificadores únicos
                            command.Parameters.AddWithValue("@stor_id", stor_id);
                            command.Parameters.AddWithValue("@ord_num", ord_num);

                            // Ejecutar la consulta y verificar el número de filas afectadas
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Los cambios se guardaron exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los cambios.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la base de datos (Ventas): {ex.Message}");
                }
            }













        }

        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbTablas.SelectedItem?.ToString() == "Autores")
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el stor_id para la fila actual, manejando posibles valores nulos
                    string au_id = dataGridView1.Rows[e.RowIndex].Cells["au_id"].Value?.ToString() ?? string.Empty;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string pub_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Validar si la columna es `lowqty`, `highqty` o `discount`
                    if (columna == "address" || columna == "city" || columna == "state" || columna == "zip")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull para evitar errores de conversión
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar cambios, permitiendo celdas vacías
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Descuentos")
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el stor_id para la fila actual, manejando posibles valores nulos
                    string stor_id = dataGridView1.Rows[e.RowIndex].Cells["stor_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string pub_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Validar si la columna es `lowqty`, `highqty` o `discount`
                    if (columna == "lowqty" || columna == "highqty" || columna == "discount")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull para evitar errores de conversión
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar cambios, permitiendo celdas vacías
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Tiendas")
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el stor_id para la fila actual, manejando posibles valores nulos
                    string stor_id = dataGridView1.Rows[e.RowIndex].Cells["stor_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string pub_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Validar si la columna es `lowqty`, `highqty` o `discount`
                    if (columna == "lowqty" || columna == "highqty" || columna == "discount")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull para evitar errores de conversión
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar cambios, permitiendo celdas vacías
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleados")
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el emp_id para la fila actual, manejando posibles valores nulos
                    string emp_id = dataGridView1.Rows[e.RowIndex].Cells["emp_id"].Value?.ToString() ?? string.Empty;
                    string stor_id = null;
                    string au_id = null;
                    string job_id = null;
                    string pub_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Validar si es necesario realizar alguna acción en columnas específicas
                    if (columna == "fname" || columna == "minit" || columna == "lname" || columna == "job_id" || columna == "pub_id")
                    {
                        // Llamar al método para guardar cambios
                        GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                    }
                    else
                    {
                        MessageBox.Show("La columna seleccionada no es editable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Empleos")  // Tabla empleos
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el job_id para la fila actual, manejando posibles valores nulos
                    string job_id = dataGridView1.Rows[e.RowIndex].Cells["job_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string pub_id = null;
                    string title_id = null;
                    string ord_num = null;


                    // Llamar al método para guardar cambios, permitiendo celdas vacías
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Editores")  // Tabla editores
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Verificar si es necesario acortar el valor
                    if (nuevoValor.Length > 50) // Ajusta el límite según tu tabla
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el pub_id para la fila actual, manejando posibles valores nulos
                    string pub_id = dataGridView1.Rows[e.RowIndex].Cells["pub_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Llamar al método para guardar cambios, permitiendo celdas vacías
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Roysched")  // Tabla Roysched
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado de la celda
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Si el nuevo valor excede el límite (si es necesario), puedes acortarlo
                    if (nuevoValor.Length > 50) // Ajusta según la longitud máxima de la columna
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el 'title_id' de la fila actual
                    string title_id = dataGridView1.Rows[e.RowIndex].Cells["title_id"].Value?.ToString() ?? string.Empty;
                    string pub_id = null;
                    string au_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string ord_num = null;

                    // Verificar si la columna es una que admite valores nulos
                    if (columna == "lorange" || columna == "hirange" || columna == "royalty")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar los cambios
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda en Roysched: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Pub_Info")  // Tabla Pub_Info
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado de la celda
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Si el nuevo valor excede el límite (si es necesario), puedes acortarlo
                    if (nuevoValor.Length > 50) // Ajusta según la longitud máxima de la columna
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el 'pub_id' de la fila actual
                    string pub_id = dataGridView1.Rows[e.RowIndex].Cells["pub_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string title_id = null;
                    string ord_num = null;

                    // Verificar si la columna es una que admite valores nulos
                    if (columna == "pr_info" || columna == "logo")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar los cambios
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda en Pub_Info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulo_autor")  // Tabla Titulo_autor
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado de la celda
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Si el nuevo valor excede el límite (si es necesario), puedes acortarlo
                    if (nuevoValor.Length > 50) // Ajusta según la longitud máxima de la columna
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el 'au_id' y 'title_id' de la fila actual
                    string au_id = dataGridView1.Rows[e.RowIndex].Cells["au_id"].Value?.ToString() ?? string.Empty;
                    string title_id = dataGridView1.Rows[e.RowIndex].Cells["title_id"].Value?.ToString() ?? string.Empty;
                    string pub_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string ord_num = null;

                    // Verificar si la columna es una que admite valores nulos
                    if (columna == "au_ord" || columna == "royaltyper")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar los cambios
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda en Titulo_autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Titulos")  // Tabla Titulo
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado de la celda
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Si el nuevo valor excede el límite (si es necesario), puedes acortarlo
                    if (nuevoValor.Length > 50) // Ajusta según la longitud máxima de la columna
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el 'title_id' de la fila actual
                    string title_id = dataGridView1.Rows[e.RowIndex].Cells["title_id"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string pub_id = null;
                    string stor_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string ord_num = null;


                    // Verificar si la columna es una que admite valores nulos
                    if (columna == "price" || columna == "advance" || columna == "royalty" || columna == "ytd_sales" || columna == "notes")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar los cambios
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda en Titulo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbTablas.SelectedItem?.ToString() == "Ventas")  // Tabla Ventas
            {
                try
                {
                    // Obtener la columna y el nuevo valor editado de la celda
                    string columna = dataGridView1.Columns[e.ColumnIndex].Name;
                    string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                    // Si el nuevo valor excede el límite (si es necesario), puedes acortarlo
                    if (nuevoValor.Length > 50) // Ajusta según la longitud máxima de la columna
                    {
                        nuevoValor = nuevoValor.Substring(0, 50);
                    }

                    // Obtener el 'stor_id' y 'ord_num' de la fila actual
                    string stor_id = dataGridView1.Rows[e.RowIndex].Cells["stor_id"].Value?.ToString() ?? string.Empty;
                    string ord_num = dataGridView1.Rows[e.RowIndex].Cells["ord_num"].Value?.ToString() ?? string.Empty;
                    string au_id = null;
                    string pub_id = null;
                    string emp_id = null;
                    string job_id = null;
                    string title_id = null;


                    // Verificar si la columna es una que admite valores nulos
                    if (columna == "payterms" || columna == "title_id")
                    {
                        // Si el nuevo valor es vacío, asignar DBNull
                        if (string.IsNullOrWhiteSpace(nuevoValor))
                        {
                            nuevoValor = DBNull.Value.ToString();
                        }
                    }

                    // Llamar al método para guardar los cambios
                    GuardarCambios(columna, nuevoValor, au_id, stor_id, emp_id, job_id, pub_id, title_id, ord_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar la celda en Ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }








        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {

            
        }

        public void ConfigureForAdmin()
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();

            
            
        }

        public void ConfigureForClient()
        {
            // Habilitar solo las acciones de ver y buscar en las tablas permitidas para el Cliente
            cmbTablas.Enabled = true;   // El ComboBox de tablas debe estar habilitado
            txtBuscar.Enabled = true;     // El TextBox para búsqueda debe estar habilitado
            btnMostrar.Enabled = true;  // El botón de mostrar está habilitado
            btnAgregar.Enabled = false;  // El botón de agregar debe estar deshabilitado
            btnEliminar.Enabled = false; // El botón de eliminar debe estar deshabilitado

            // Solo habilitar la búsqueda para tablas permitidas (Autores, Tiendas, Editoriales, Titulos)
            cmbTablas.Items.Clear();
            cmbTablas.Items.Add("Autores");
            cmbTablas.Items.Add("Tiendas");
            cmbTablas.Items.Add("Editorial");
            cmbTablas.Items.Add("Titulos");

            // Mostrar un mensaje de bienvenida
            MessageBox.Show("Bienvenido, Cliente. Solo tienes acceso a ver y buscar en las tablas de Autores, Tiendas, Editoriales y Titulos.");
        }

        public void ConfigureForWorker()
        {
            // Habilitar los botones para ver, agregar y buscar en todas las tablas excepto las prohibidas (Pub_Info y Titulo_Autor)
            cmbTablas.Enabled = true;   // El ComboBox de tablas debe estar habilitado
            txtBuscar.Enabled = true;     // El TextBox para búsqueda debe estar habilitado
            btnMostrar.Enabled = true;  // Botón para mostrar registros
            btnAgregar.Enabled = true;  // Botón para agregar registros
            btnEliminar.Enabled = true; // Botón para eliminar registros
            

            // Eliminar las tablas Pub_Info y Titulo_Autor de las opciones disponibles para el trabajador
            cmbTablas.Items.Clear();
            cmbTablas.Items.Add("Autores");
            cmbTablas.Items.Add("Tiendas");
            cmbTablas.Items.Add("Editorial");
            cmbTablas.Items.Add("Ventas");
            cmbTablas.Items.Add("Roysched");
            cmbTablas.Items.Add("Jobs");

            // Mostrar un mensaje de bienvenida
            MessageBox.Show("Bienvenido, Trabajador. Tienes acceso a ver, agregar y buscar en todas las tablas excepto Pub_Info y Titulo_Autor.");
        }



    }
}


