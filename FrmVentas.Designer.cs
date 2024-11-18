namespace Proyecto_PUBS
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            txt_qty = new MaskedTextBox();
            txt_title_id = new MaskedTextBox();
            txt_stor_id = new MaskedTextBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_ord_num = new TextBox();
            txt_payterms = new MaskedTextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dateTimePickerOrd = new DateTimePicker();
            SuspendLayout();
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(40, 170);
            txt_qty.Mask = "00";
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(100, 23);
            txt_qty.TabIndex = 53;
            // 
            // txt_title_id
            // 
            txt_title_id.Location = new Point(219, 109);
            txt_title_id.Name = "txt_title_id";
            txt_title_id.Size = new Size(109, 23);
            txt_title_id.TabIndex = 52;
            // 
            // txt_stor_id
            // 
            txt_stor_id.CausesValidation = false;
            txt_stor_id.Location = new Point(40, 50);
            txt_stor_id.Mask = "0000";
            txt_stor_id.Name = "txt_stor_id";
            txt_stor_id.Size = new Size(100, 23);
            txt_stor_id.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(40, 32);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 50;
            label9.Text = "ID Tienda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(40, 152);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 49;
            label4.Text = "Qty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(219, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 48;
            label3.Text = "ID del Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(219, 152);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 47;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 91);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 46;
            label1.Text = "Numero de Orden";
            // 
            // txt_ord_num
            // 
            txt_ord_num.Location = new Point(40, 109);
            txt_ord_num.Name = "txt_ord_num";
            txt_ord_num.Size = new Size(100, 23);
            txt_ord_num.TabIndex = 45;
            // 
            // txt_payterms
            // 
            txt_payterms.Location = new Point(219, 50);
            txt_payterms.Name = "txt_payterms";
            txt_payterms.Size = new Size(100, 23);
            txt_payterms.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(219, 32);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 54;
            label5.Text = "Pay Terms";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.Location = new Point(433, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAceptar.Location = new Point(307, 265);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 56;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dateTimePickerOrd
            // 
            dateTimePickerOrd.Location = new Point(219, 170);
            dateTimePickerOrd.Name = "dateTimePickerOrd";
            dateTimePickerOrd.Size = new Size(200, 23);
            dateTimePickerOrd.TabIndex = 58;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 331);
            Controls.Add(dateTimePickerOrd);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txt_payterms);
            Controls.Add(label5);
            Controls.Add(txt_qty);
            Controls.Add(txt_title_id);
            Controls.Add(txt_stor_id);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ord_num);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVentas";
            Text = "Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txt_qty;
        private MaskedTextBox txt_title_id;
        private MaskedTextBox txt_stor_id;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_ord_num;
        private MaskedTextBox txt_payterms;
        private Label label5;
        private Button btnCancelar;
        private Button btnAceptar;
        private DateTimePicker dateTimePickerOrd;
    }
}