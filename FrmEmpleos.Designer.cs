namespace Proyecto_PUBS
{
    partial class FrmEmpleos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleos));
            txt_job_desc = new MaskedTextBox();
            txt_max_lvl = new MaskedTextBox();
            txt_min_lvl = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAceptar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // txt_job_desc
            // 
            txt_job_desc.Location = new Point(38, 74);
            txt_job_desc.Name = "txt_job_desc";
            txt_job_desc.Size = new Size(227, 23);
            txt_job_desc.TabIndex = 0;
            // 
            // txt_max_lvl
            // 
            txt_max_lvl.Location = new Point(186, 171);
            txt_max_lvl.Mask = "000";
            txt_max_lvl.Name = "txt_max_lvl";
            txt_max_lvl.Size = new Size(100, 23);
            txt_max_lvl.TabIndex = 1;
            // 
            // txt_min_lvl
            // 
            txt_min_lvl.Location = new Point(38, 171);
            txt_min_lvl.Mask = "000";
            txt_min_lvl.Name = "txt_min_lvl";
            txt_min_lvl.Size = new Size(100, 23);
            txt_min_lvl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(38, 56);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripcion del Empleo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(38, 153);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Nivel Minimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(186, 153);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Nivel Maximo";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.Location = new Point(397, 274);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnCancelar.Location = new Point(528, 274);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 34);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmEmpleos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 335);
            Controls.Add(BtnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_min_lvl);
            Controls.Add(txt_max_lvl);
            Controls.Add(txt_job_desc);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEmpleos";
            Text = "Empleos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txt_job_desc;
        private MaskedTextBox txt_max_lvl;
        private MaskedTextBox txt_min_lvl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAceptar;
        private Button BtnCancelar;
    }
}