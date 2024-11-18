namespace Proyecto_PUBS
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            dTP_hire = new DateTimePicker();
            txt_job_id = new MaskedTextBox();
            txt_emp_id = new MaskedTextBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_job_lvl = new MaskedTextBox();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            txt_minit = new MaskedTextBox();
            txt_pub_id = new MaskedTextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // dTP_hire
            // 
            dTP_hire.Location = new Point(175, 161);
            dTP_hire.Name = "dTP_hire";
            dTP_hire.Size = new Size(233, 23);
            dTP_hire.TabIndex = 0;
            // 
            // txt_job_id
            // 
            txt_job_id.Location = new Point(31, 219);
            txt_job_id.Mask = "00";
            txt_job_id.Name = "txt_job_id";
            txt_job_id.Size = new Size(109, 23);
            txt_job_id.TabIndex = 33;
            // 
            // txt_emp_id
            // 
            txt_emp_id.CausesValidation = false;
            txt_emp_id.Location = new Point(31, 43);
            txt_emp_id.Mask = "AAAAAAAAA";
            txt_emp_id.Name = "txt_emp_id";
            txt_emp_id.Size = new Size(100, 23);
            txt_emp_id.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(31, 25);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 31;
            label9.Text = "ID Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(31, 262);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 30;
            label4.Text = "Minit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(31, 201);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 29;
            label3.Text = "ID del Empleo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 143);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 28;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 84);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(31, 102);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(100, 23);
            txt_fname.TabIndex = 25;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(31, 161);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(100, 23);
            txt_lname.TabIndex = 24;
            // 
            // txt_job_lvl
            // 
            txt_job_lvl.CausesValidation = false;
            txt_job_lvl.Location = new Point(175, 43);
            txt_job_lvl.Mask = "000";
            txt_job_lvl.Name = "txt_job_lvl";
            txt_job_lvl.Size = new Size(100, 23);
            txt_job_lvl.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(175, 25);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 41;
            label5.Text = "Nivel de Empleo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(175, 143);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 38;
            label8.Text = "Fecha de contratacion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(175, 84);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 37;
            label10.Text = "ID Pub";
            // 
            // txt_minit
            // 
            txt_minit.Location = new Point(31, 280);
            txt_minit.Mask = "A";
            txt_minit.Name = "txt_minit";
            txt_minit.Size = new Size(100, 23);
            txt_minit.TabIndex = 43;
            // 
            // txt_pub_id
            // 
            txt_pub_id.Location = new Point(175, 102);
            txt_pub_id.Mask = "0000";
            txt_pub_id.Name = "txt_pub_id";
            txt_pub_id.Size = new Size(100, 23);
            txt_pub_id.TabIndex = 44;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(353, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.Location = new Point(227, 378);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 45;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(516, 453);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txt_pub_id);
            Controls.Add(txt_minit);
            Controls.Add(txt_job_lvl);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(txt_job_id);
            Controls.Add(txt_emp_id);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_fname);
            Controls.Add(txt_lname);
            Controls.Add(dTP_hire);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEmpleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dTP_hire;
        private MaskedTextBox txt_job_id;
        private MaskedTextBox txt_emp_id;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private MaskedTextBox txt_job_lvl;
        private Label label5;
        private Label label8;
        private Label label10;
        private MaskedTextBox txt_minit;
        private MaskedTextBox txt_pub_id;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}