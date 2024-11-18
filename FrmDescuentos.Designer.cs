namespace Proyecto_PUBS
{
    partial class FrmDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDescuentos));
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_discount = new TextBox();
            txt_discounttype = new TextBox();
            txt_highqty = new TextBox();
            btnCancelar = new Button();
            txt_lowqty = new TextBox();
            btnAceptar = new Button();
            txt_stor_id = new MaskedTextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(49, 43);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 41;
            label9.Text = "ID de Tienda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(49, 280);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 34;
            label4.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(49, 219);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 33;
            label3.Text = "High Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 161);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 32;
            label2.Text = "Low Qty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(49, 102);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 31;
            label1.Text = "Tipo de Descuento";
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(49, 298);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(100, 23);
            txt_discount.TabIndex = 30;
            // 
            // txt_discounttype
            // 
            txt_discounttype.Location = new Point(49, 120);
            txt_discounttype.Name = "txt_discounttype";
            txt_discounttype.Size = new Size(100, 23);
            txt_discounttype.TabIndex = 29;
            // 
            // txt_highqty
            // 
            txt_highqty.Location = new Point(49, 237);
            txt_highqty.Name = "txt_highqty";
            txt_highqty.Size = new Size(100, 23);
            txt_highqty.TabIndex = 28;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(429, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_lowqty
            // 
            txt_lowqty.Location = new Point(49, 179);
            txt_lowqty.Name = "txt_lowqty";
            txt_lowqty.Size = new Size(100, 23);
            txt_lowqty.TabIndex = 23;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.Location = new Point(292, 419);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txt_stor_id
            // 
            txt_stor_id.Location = new Point(49, 61);
            txt_stor_id.Mask = "0000";
            txt_stor_id.Name = "txt_stor_id";
            txt_stor_id.Size = new Size(100, 23);
            txt_stor_id.TabIndex = 42;
            // 
            // FrmDescuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 502);
            Controls.Add(txt_stor_id);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_discount);
            Controls.Add(txt_discounttype);
            Controls.Add(txt_highqty);
            Controls.Add(btnCancelar);
            Controls.Add(txt_lowqty);
            Controls.Add(btnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDescuentos";
            Text = "Descuentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_discount;
        private TextBox txt_discounttype;
        private TextBox txt_highqty;
        private Button btnCancelar;
        private TextBox txt_lowqty;
        private Button btnAceptar;
        private MaskedTextBox txt_stor_id;
    }
}