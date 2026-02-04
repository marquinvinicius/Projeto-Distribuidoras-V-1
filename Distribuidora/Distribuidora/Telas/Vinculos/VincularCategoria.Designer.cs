namespace FrontDistribuidora.Telas.Vinculos
{
    partial class VincularCategoria
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaMarca = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbMarca = new ComboBox();
            cmbCategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAdcionar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).BeginInit();
            SuspendLayout();
            // 
            // tabelaMarca
            // 
            tabelaMarca.AllowUserToAddRows = false;
            tabelaMarca.BackgroundColor = Color.White;
            tabelaMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMarca.GridColor = Color.Wheat;
            tabelaMarca.Location = new Point(582, 116);
            tabelaMarca.Name = "tabelaMarca";
            tabelaMarca.Size = new Size(423, 409);
            tabelaMarca.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(432, 633);
            button1.Name = "button1";
            button1.Size = new Size(195, 72);
            button1.TabIndex = 1;
            button1.Text = "LIMPAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(52, 633);
            button2.Name = "button2";
            button2.Size = new Size(195, 72);
            button2.TabIndex = 2;
            button2.Text = "MENU INICIAL";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(801, 633);
            button3.Name = "button3";
            button3.Size = new Size(195, 72);
            button3.TabIndex = 3;
            button3.Text = "SALVAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // cmbMarca
            // 
            cmbMarca.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(56, 182);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(246, 41);
            cmbMarca.TabIndex = 4;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(56, 401);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(246, 41);
            cmbCategoria.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 314);
            label1.Name = "label1";
            label1.Size = new Size(217, 40);
            label1.TabIndex = 7;
            label1.Text = "CATEGORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 116);
            label2.Name = "label2";
            label2.Size = new Size(142, 40);
            label2.TabIndex = 8;
            label2.Text = "MARCA";
            // 
            // btnAdcionar
            // 
            btnAdcionar.BackColor = Color.Aquamarine;
            btnAdcionar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdcionar.Location = new Point(354, 401);
            btnAdcionar.Name = "btnAdcionar";
            btnAdcionar.Size = new Size(172, 41);
            btnAdcionar.TabIndex = 9;
            btnAdcionar.Text = "ADICIONAR";
            btnAdcionar.UseVisualStyleBackColor = false;
            btnAdcionar.Click += btnAdcionar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Aquamarine;
            btnConfirmar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(354, 182);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(172, 41);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // VincularCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnConfirmar);
            Controls.Add(btnAdcionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbMarca);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabelaMarca);
            Name = "VincularCategoria";
            Size = new Size(1050, 750);
            Load += VincularCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelaMarca;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbMarca;
        private ComboBox cmbCategoria;
        private Label label1;
        private Label label2;
        private Button btnAdcionar;
        private Button btnConfirmar;
    }
}
