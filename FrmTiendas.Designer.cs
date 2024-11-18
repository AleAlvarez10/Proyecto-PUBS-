namespace Proyecto_PUBS
{
    partial class FrmTiendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiendas));
            label9 = new Label();
            txt_stor_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_zip = new TextBox();
            txt_stor_name = new TextBox();
            txt_city = new TextBox();
            btnCancelar = new Button();
            txt_stor_address = new TextBox();
            btnAceptar = new Button();
            label5 = new Label();
            txt_state = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(41, 33);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 53;
            label9.Text = "ID de Tienda";
            // 
            // txt_stor_id
            // 
            txt_stor_id.Location = new Point(41, 51);
            txt_stor_id.Name = "txt_stor_id";
            txt_stor_id.Size = new Size(100, 23);
            txt_stor_id.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(41, 340);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 51;
            label4.Text = "ZIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(41, 209);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 50;
            label3.Text = "Ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(41, 151);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 49;
            label2.Text = "Direccion de la Tienda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(41, 92);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 48;
            label1.Text = "Nombre de Tienda";
            // 
            // txt_zip
            // 
            txt_zip.Location = new Point(41, 358);
            txt_zip.Name = "txt_zip";
            txt_zip.Size = new Size(100, 23);
            txt_zip.TabIndex = 47;
            // 
            // txt_stor_name
            // 
            txt_stor_name.Location = new Point(41, 110);
            txt_stor_name.Name = "txt_stor_name";
            txt_stor_name.Size = new Size(100, 23);
            txt_stor_name.TabIndex = 46;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(41, 227);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(100, 23);
            txt_city.TabIndex = 45;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(413, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txt_stor_address
            // 
            txt_stor_address.Location = new Point(41, 169);
            txt_stor_address.Name = "txt_stor_address";
            txt_stor_address.Size = new Size(100, 23);
            txt_stor_address.TabIndex = 43;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.Location = new Point(265, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 42;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(41, 273);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 55;
            label5.Text = "Estado";
            // 
            // txt_state
            // 
            txt_state.Location = new Point(41, 291);
            txt_state.Name = "txt_state";
            txt_state.Size = new Size(100, 23);
            txt_state.TabIndex = 54;
            // 
            // FrmTiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 450);
            Controls.Add(label5);
            Controls.Add(txt_state);
            Controls.Add(label9);
            Controls.Add(txt_stor_id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_zip);
            Controls.Add(txt_stor_name);
            Controls.Add(txt_city);
            Controls.Add(btnCancelar);
            Controls.Add(txt_stor_address);
            Controls.Add(btnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTiendas";
            Text = "Tiendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        public TextBox txt_stor_id;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_zip;
        private TextBox txt_stor_name;
        private TextBox txt_city;
        private Button btnCancelar;
        private TextBox txt_stor_address;
        private Button btnAceptar;
        private Label label5;
        private TextBox txt_state;
    }
}