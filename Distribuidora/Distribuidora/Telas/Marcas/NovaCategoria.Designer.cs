namespace FrontDistribuidora.Telas.Marcas
{
    partial class NovaCategoria
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
            btnSalvar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleTurquoise;
            btnSalvar.Font = new Font("Arial", 12F);
            btnSalvar.Location = new Point(292, 229);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(183, 68);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(115, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 35);
            txtNome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(145, 35);
            label2.Name = "label2";
            label2.Size = new Size(148, 27);
            label2.TabIndex = 15;
            label2.Text = "CATEGORIA";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PaleTurquoise;
            btnCancelar.Font = new Font("Arial", 12F);
            btnCancelar.Location = new Point(49, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 68);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NovaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(503, 345);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Name = "NovaCategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovaCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private Label label2;
        private Button btnCancelar;
    }
}