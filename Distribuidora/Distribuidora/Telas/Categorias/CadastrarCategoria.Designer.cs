namespace FrontDistribuidora.Telas.Categorias
{
    partial class CadastrarCategoria
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
            label1 = new Label();
            txtNome = new TextBox();
            tabelaCategoria = new DataGridView();
            btnMenu = new Button();
            limpar = new Button();
            btnSalvar = new Button();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelaCategoria).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 82);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(64, 136);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 35);
            txtNome.TabIndex = 8;
            // 
            // tabelaCategoria
            // 
            tabelaCategoria.AllowUserToAddRows = false;
            tabelaCategoria.BackgroundColor = Color.White;
            tabelaCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCategoria.Location = new Point(566, 82);
            tabelaCategoria.Name = "tabelaCategoria";
            tabelaCategoria.Size = new Size(436, 462);
            tabelaCategoria.TabIndex = 9;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.PaleTurquoise;
            btnMenu.Font = new Font("Arial", 12F);
            btnMenu.Location = new Point(64, 632);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(181, 62);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // limpar
            // 
            limpar.BackColor = Color.PaleTurquoise;
            limpar.Font = new Font("Arial", 12F);
            limpar.Location = new Point(476, 632);
            limpar.Name = "limpar";
            limpar.Size = new Size(181, 62);
            limpar.TabIndex = 15;
            limpar.Text = "LIMPAR";
            limpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleTurquoise;
            btnSalvar.Font = new Font("Arial", 12F);
            btnSalvar.Location = new Point(821, 632);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(181, 62);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.PaleTurquoise;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.Location = new Point(372, 136);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(130, 37);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // CadastrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnAdicionar);
            Controls.Add(btnSalvar);
            Controls.Add(limpar);
            Controls.Add(btnMenu);
            Controls.Add(tabelaCategoria);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "CadastrarCategoria";
            Size = new Size(1050, 750);
            ((System.ComponentModel.ISupportInitialize)tabelaCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private DataGridView tabelaCategoria;
        private Button btnMenu;
        private Button limpar;
        private Button btnSalvar;
        private Button btnAdicionar;
    }
}
