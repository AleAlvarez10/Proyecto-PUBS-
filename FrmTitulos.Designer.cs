namespace Proyecto_PUBS
{
    partial class FrmTitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitulos));
            btnCancelar = new Button();
            btnAceptar = new Button();
            txt_ytd_sales = new MaskedTextBox();
            txt_advance = new MaskedTextBox();
            txt_royalty = new MaskedTextBox();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            txt_price = new MaskedTextBox();
            txt_title_id = new MaskedTextBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_title = new TextBox();
            txt_pub_id = new TextBox();
            dTP_Pub = new DateTimePicker();
            txt_notes = new MaskedTextBox();
            label6 = new Label();
            txt_type = new MaskedTextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(408, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAceptar.Location = new Point(282, 410);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 29);
            btnAceptar.TabIndex = 63;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txt_ytd_sales
            // 
            txt_ytd_sales.Location = new Point(184, 170);
            txt_ytd_sales.Mask = "000000";
            txt_ytd_sales.Name = "txt_ytd_sales";
            txt_ytd_sales.Size = new Size(100, 23);
            txt_ytd_sales.TabIndex = 62;
            // 
            // txt_advance
            // 
            txt_advance.Location = new Point(38, 289);
            txt_advance.Mask = "0000000000";
            txt_advance.Name = "txt_advance";
            txt_advance.Size = new Size(100, 23);
            txt_advance.TabIndex = 61;
            txt_advance.MaskInputRejected += txt_minit_MaskInputRejected;
            // 
            // txt_royalty
            // 
            txt_royalty.CausesValidation = false;
            txt_royalty.Location = new Point(184, 111);
            txt_royalty.Mask = "00";
            txt_royalty.Name = "txt_royalty";
            txt_royalty.Size = new Size(100, 23);
            txt_royalty.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(184, 93);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 59;
            label5.Text = "Royalty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(184, 269);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 58;
            label8.Text = "Fecha de Publicacion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(184, 152);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 57;
            label10.Text = "YTD";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(38, 228);
            txt_price.Mask = "000000";
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(109, 23);
            txt_price.TabIndex = 56;
            // 
            // txt_title_id
            // 
            txt_title_id.CausesValidation = false;
            txt_title_id.Location = new Point(38, 52);
            txt_title_id.Name = "txt_title_id";
            txt_title_id.Size = new Size(100, 23);
            txt_title_id.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(38, 34);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 54;
            label9.Text = "ID Titulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(38, 271);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 53;
            label4.Text = "Advance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(38, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 52;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(38, 152);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 51;
            label2.Text = "ID Editorial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 93);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 50;
            label1.Text = "Titulo";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(38, 111);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(100, 23);
            txt_title.TabIndex = 49;
            // 
            // txt_pub_id
            // 
            txt_pub_id.Location = new Point(38, 170);
            txt_pub_id.Name = "txt_pub_id";
            txt_pub_id.Size = new Size(100, 23);
            txt_pub_id.TabIndex = 48;
            // 
            // dTP_Pub
            // 
            dTP_Pub.Location = new Point(184, 287);
            dTP_Pub.Name = "dTP_Pub";
            dTP_Pub.Size = new Size(233, 23);
            dTP_Pub.TabIndex = 47;
            // 
            // txt_notes
            // 
            txt_notes.Location = new Point(184, 229);
            txt_notes.Name = "txt_notes";
            txt_notes.Size = new Size(100, 23);
            txt_notes.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(184, 211);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 65;
            label6.Text = "Notes";
            // 
            // txt_type
            // 
            txt_type.CausesValidation = false;
            txt_type.Location = new Point(184, 52);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(100, 23);
            txt_type.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(184, 34);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 67;
            label7.Text = "Type";
            // 
            // FrmTitulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 489);
            Controls.Add(txt_type);
            Controls.Add(label7);
            Controls.Add(txt_notes);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txt_ytd_sales);
            Controls.Add(txt_advance);
            Controls.Add(txt_royalty);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(txt_price);
            Controls.Add(txt_title_id);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_title);
            Controls.Add(txt_pub_id);
            Controls.Add(dTP_Pub);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTitulos";
            Text = "Titulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private MaskedTextBox txt_ytd_sales;
        private MaskedTextBox txt_advance;
        private MaskedTextBox txt_royalty;
        private Label label5;
        private Label label8;
        private Label label10;
        private MaskedTextBox txt_price;
        private MaskedTextBox txt_title_id;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_title;
        private TextBox txt_pub_id;
        private DateTimePicker dTP_Pub;
        private MaskedTextBox txt_notes;
        private Label label6;
        private MaskedTextBox txt_type;
        private Label label7;
    }
}