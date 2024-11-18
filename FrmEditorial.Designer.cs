namespace Proyecto_PUBS
{
    partial class FrmEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorial));
            label1 = new Label();
            label2 = new Label();
            txt_pub_id = new MaskedTextBox();
            txt_country = new MaskedTextBox();
            txt_state = new MaskedTextBox();
            txt_city = new MaskedTextBox();
            txt_pub_name = new MaskedTextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Editor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 93);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Editorial";
            // 
            // txt_pub_id
            // 
            txt_pub_id.Location = new Point(25, 45);
            txt_pub_id.Mask = "0000";
            txt_pub_id.Name = "txt_pub_id";
            txt_pub_id.Size = new Size(100, 23);
            txt_pub_id.TabIndex = 2;
            // 
            // txt_country
            // 
            txt_country.Location = new Point(191, 111);
            txt_country.Name = "txt_country";
            txt_country.Size = new Size(100, 23);
            txt_country.TabIndex = 3;
            // 
            // txt_state
            // 
            txt_state.Location = new Point(191, 45);
            txt_state.Mask = "AA";
            txt_state.Name = "txt_state";
            txt_state.Size = new Size(100, 23);
            txt_state.TabIndex = 4;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(25, 184);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(100, 23);
            txt_city.TabIndex = 5;
            // 
            // txt_pub_name
            // 
            txt_pub_name.Location = new Point(25, 111);
            txt_pub_name.Name = "txt_pub_name";
            txt_pub_name.Size = new Size(100, 23);
            txt_pub_name.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.Location = new Point(282, 372);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(391, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(191, 27);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(191, 93);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "Pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 166);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 12;
            label6.Text = "Ciudad";
            // 
            // FrmEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 422);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txt_pub_name);
            Controls.Add(txt_city);
            Controls.Add(txt_state);
            Controls.Add(txt_country);
            Controls.Add(txt_pub_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEditorial";
            Text = "Editorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txt_pub_id;
        private MaskedTextBox txt_country;
        private MaskedTextBox txt_state;
        private MaskedTextBox txt_city;
        private MaskedTextBox txt_pub_name;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}