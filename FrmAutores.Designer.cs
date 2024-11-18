namespace Proyecto_PUBS
{
    partial class FrmAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutores));
            btnAceptar = new Button();
            txt_aulname = new TextBox();
            btnCancelar = new Button();
            txt_state = new TextBox();
            txt_city = new TextBox();
            txt_aufname = new TextBox();
            txt_address = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbContract = new ComboBox();
            label9 = new Label();
            btnPrueba = new Button();
            txt_id = new MaskedTextBox();
            txt_phone = new MaskedTextBox();
            txt_zip = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.Location = new Point(297, 397);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txt_aulname
            // 
            txt_aulname.Location = new Point(32, 178);
            txt_aulname.Name = "txt_aulname";
            txt_aulname.Size = new Size(100, 23);
            txt_aulname.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(423, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_state
            // 
            txt_state.Location = new Point(188, 119);
            txt_state.Name = "txt_state";
            txt_state.Size = new Size(100, 23);
            txt_state.TabIndex = 4;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(188, 60);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(100, 23);
            txt_city.TabIndex = 5;
            // 
            // txt_aufname
            // 
            txt_aufname.Location = new Point(32, 119);
            txt_aufname.Name = "txt_aufname";
            txt_aufname.Size = new Size(100, 23);
            txt_aufname.TabIndex = 7;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(32, 297);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(32, 101);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 10;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(32, 160);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 218);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 279);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(188, 42);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 14;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(188, 101);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 15;
            label6.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(188, 160);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 16;
            label7.Text = "ZIP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(188, 226);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 17;
            label8.Text = "Contrato";
            // 
            // cmbContract
            // 
            cmbContract.FormattingEnabled = true;
            cmbContract.Items.AddRange(new object[] { "0", "1" });
            cmbContract.Location = new Point(188, 244);
            cmbContract.Name = "cmbContract";
            cmbContract.Size = new Size(121, 23);
            cmbContract.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(32, 42);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 20;
            label9.Text = "ID";
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(334, 342);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(153, 27);
            btnPrueba.TabIndex = 21;
            btnPrueba.Text = "Prueba-InsercionAuto";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // txt_id
            // 
            txt_id.CausesValidation = false;
            txt_id.Location = new Point(32, 60);
            txt_id.Mask = "000-00-0000";
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 22;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(32, 244);
            txt_phone.Mask = "000 000-000";
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(109, 23);
            txt_phone.TabIndex = 23;
            // 
            // txt_zip
            // 
            txt_zip.Location = new Point(188, 178);
            txt_zip.Mask = "00000";
            txt_zip.Name = "txt_zip";
            txt_zip.Size = new Size(100, 23);
            txt_zip.TabIndex = 24;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(txt_zip);
            Controls.Add(txt_phone);
            Controls.Add(txt_id);
            Controls.Add(btnPrueba);
            Controls.Add(label9);
            Controls.Add(cmbContract);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(txt_aufname);
            Controls.Add(txt_city);
            Controls.Add(txt_state);
            Controls.Add(btnCancelar);
            Controls.Add(txt_aulname);
            Controls.Add(btnAceptar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAutores";
            Text = "Autores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txt_aulname;
        private Button btnCancelar;
        private TextBox txt_state;
        private TextBox txt_city;
        private TextBox txt_aufname;
        private TextBox textBox7;
        private TextBox txt_address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbContract;
        private Label label9;
        private Button btnPrueba;
        private MaskedTextBox txt_id;
        private MaskedTextBox txt_phone;
        private MaskedTextBox txt_zip;

      
    }
}


