namespace Proyecto_PUBS
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            dataGridView1 = new DataGridView();
            cmbTablas = new ComboBox();
            txtBuscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(32, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(328, 79);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(32, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(328, 79);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackgroundImageLayout = ImageLayout.None;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Image = (Image)resources.GetObject("btnMostrar.Image");
            btnMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrar.Location = new Point(32, 174);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(328, 73);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(384, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(950, 477);
            dataGridView1.TabIndex = 3;
            // 
            // cmbTablas
            // 
            cmbTablas.BackColor = Color.WhiteSmoke;
            cmbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTablas.FlatStyle = FlatStyle.System;
            cmbTablas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTablas.FormattingEnabled = true;
            cmbTablas.Items.AddRange(new object[] { "Autores", "Descuentos", "Editorial", "Empleados", "Empleos", "Pub_Info", "Roysched", "Tiendas", "Titulo_autor", "Titulos", "Ventas" });
            cmbTablas.Location = new Point(30, 33);
            cmbTablas.Name = "cmbTablas";
            cmbTablas.Size = new Size(330, 29);
            cmbTablas.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(384, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(646, 29);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(384, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 7;
            label2.Text = "Buscar: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Tabla:";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1376, 601);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbTablas);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            Text = "Menu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnMostrar;
        private DataGridView dataGridView1;
        private ComboBox cmbTablas;
        private TextBox txtBuscar;
        private Label label2;
        private Label label1;
    }
}