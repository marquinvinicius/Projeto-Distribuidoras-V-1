namespace Distribuidora.Front.Marcas
{
    partial class CadastrarMarcaControl
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
            panel1 = new Panel();
            label4 = new Label();
            btnNovaCategoria = new Button();
            btnNome = new Button();
            btnEditar = new Button();
            btnAdcionarCategoria = new Button();
            btnRemoverCategoria = new Button();
            txtNome = new TextBox();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            tabelaMarca = new DataGridView();
            label2 = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnMenu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 35);
            label1.Name = "label1";
            label1.Size = new Size(458, 42);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE MARCAS";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnNovaCategoria);
            panel1.Controls.Add(btnNome);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAdcionarCategoria);
            panel1.Controls.Add(btnRemoverCategoria);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tabelaMarca);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(32, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 510);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(37, 315);
            label4.Name = "label4";
            label4.Size = new Size(218, 27);
            label4.TabIndex = 15;
            label4.Text = "NOVA CATEGORIA";
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.BackColor = Color.PaleTurquoise;
            btnNovaCategoria.Font = new Font("Arial", 12F);
            btnNovaCategoria.Location = new Point(288, 306);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(176, 48);
            btnNovaCategoria.TabIndex = 14;
            btnNovaCategoria.Text = "ADICIONAR";
            btnNovaCategoria.UseVisualStyleBackColor = false;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // btnNome
            // 
            btnNome.BackColor = Color.PaleTurquoise;
            btnNome.Font = new Font("Arial", 12F);
            btnNome.Location = new Point(312, 78);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(115, 35);
            btnNome.TabIndex = 13;
            btnNome.Text = "SALVAR";
            btnNome.UseVisualStyleBackColor = false;
            btnNome.Click += btnNome_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.PaleTurquoise;
            btnEditar.Font = new Font("Arial", 12F);
            btnEditar.Location = new Point(460, 78);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 35);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdcionarCategoria
            // 
            btnAdcionarCategoria.BackColor = Color.PaleTurquoise;
            btnAdcionarCategoria.Font = new Font("Arial", 12F);
            btnAdcionarCategoria.Location = new Point(312, 194);
            btnAdcionarCategoria.Name = "btnAdcionarCategoria";
            btnAdcionarCategoria.Size = new Size(115, 35);
            btnAdcionarCategoria.TabIndex = 11;
            btnAdcionarCategoria.Text = "ADICIONAR";
            btnAdcionarCategoria.UseVisualStyleBackColor = false;
            btnAdcionarCategoria.Click += btnAdcionarCategoria_Click;
            // 
            // btnRemoverCategoria
            // 
            btnRemoverCategoria.BackColor = Color.PaleTurquoise;
            btnRemoverCategoria.Font = new Font("Arial", 12F);
            btnRemoverCategoria.Location = new Point(460, 194);
            btnRemoverCategoria.Name = "btnRemoverCategoria";
            btnRemoverCategoria.Size = new Size(115, 35);
            btnRemoverCategoria.TabIndex = 10;
            btnRemoverCategoria.Text = "REMOVER";
            btnRemoverCategoria.UseVisualStyleBackColor = false;
            btnRemoverCategoria.Click += btnRemoverCategoria_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(37, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 35);
            txtNome.TabIndex = 7;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(37, 194);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(226, 35);
            cmbCategoria.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F);
            label3.Location = new Point(260, 147);
            label3.Name = "label3";
            label3.Size = new Size(164, 27);
            label3.TabIndex = 4;
            label3.Text = "CATEGORIAS";
            // 
            // tabelaMarca
            // 
            tabelaMarca.AllowUserToAddRows = false;
            tabelaMarca.BackgroundColor = Color.White;
            tabelaMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMarca.Location = new Point(609, 76);
            tabelaMarca.Name = "tabelaMarca";
            tabelaMarca.Size = new Size(362, 381);
            tabelaMarca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(260, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 27);
            label2.TabIndex = 2;
            label2.Text = "NOME";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleTurquoise;
            btnSalvar.Font = new Font("Arial", 12F);
            btnSalvar.Location = new Point(867, 643);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 62);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.PaleTurquoise;
            btnLimpar.Font = new Font("Arial", 12F);
            btnLimpar.Location = new Point(451, 643);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(156, 62);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.PaleTurquoise;
            btnMenu.Font = new Font("Arial", 12F);
            btnMenu.Location = new Point(32, 643);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(156, 62);
            btnMenu.TabIndex = 17;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // CadastrarMarcaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnMenu);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "CadastrarMarcaControl";
            Size = new Size(1050, 750);
            Load += CadastrarMarcaControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DataGridView tabelaMarca;
        private TextBox txtNome;
        private ComboBox cmbCategoria;
        private Button btnNome;
        private Button btnEditar;
        private Button btnAdcionarCategoria;
        private Button btnRemoverCategoria;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnMenu;
        private Label label4;
        private Button btnNovaCategoria;
    }
}
