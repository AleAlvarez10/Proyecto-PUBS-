namespace Proyecto_PUBS
{
    partial class FrmRoysched
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoysched));
            BtnCancelar = new Button();
            btnAceptar = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_lorange = new MaskedTextBox();
            txt_title_id = new MaskedTextBox();
            txt_hirange = new MaskedTextBox();
            label2 = new Label();
            txt_royalty = new MaskedTextBox();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnCancelar.Location = new Point(159, 270);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 34);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.Location = new Point(32, 270);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 34);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 137);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 17;
            label4.Text = "High Range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 81);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 16;
            label3.Text = "Low Range";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 14;
            label1.Text = "ID del Titulo";
            // 
            // txt_lorange
            // 
            txt_lorange.Location = new Point(26, 99);
            txt_lorange.Mask = "0000";
            txt_lorange.Name = "txt_lorange";
            txt_lorange.Size = new Size(100, 23);
            txt_lorange.TabIndex = 13;
            // 
            // txt_title_id
            // 
            txt_title_id.Location = new Point(26, 41);
            txt_title_id.Name = "txt_title_id";
            txt_title_id.Size = new Size(100, 23);
            txt_title_id.TabIndex = 12;
            // 
            // txt_hirange
            // 
            txt_hirange.Location = new Point(26, 155);
            txt_hirange.Mask = "00000";
            txt_hirange.Name = "txt_hirange";
            txt_hirange.Size = new Size(100, 23);
            txt_hirange.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 191);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 21;
            label2.Text = "Royalty";
            // 
            // txt_royalty
            // 
            txt_royalty.Location = new Point(26, 209);
            txt_royalty.Mask = "00";
            txt_royalty.Name = "txt_royalty";
            txt_royalty.Size = new Size(100, 23);
            txt_royalty.TabIndex = 20;
            // 
            // FrmRoysched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 335);
            Controls.Add(label2);
            Controls.Add(txt_royalty);
            Controls.Add(BtnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_lorange);
            Controls.Add(txt_title_id);
            Controls.Add(txt_hirange);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRoysched";
            Text = "Roysched";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button btnAceptar;
        private Label label4;
        private Label label3;
        private Label label1;
        private MaskedTextBox txt_lorange;
        private MaskedTextBox txt_title_id;
        private MaskedTextBox txt_hirange;
        private Label label2;
        private MaskedTextBox txt_royalty;
    }
}