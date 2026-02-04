namespace FrontDistribuidora.Telas.Produto
{
    partial class PesquisarProduto
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
            panelPesquisar = new Panel();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnIniciar = new Button();
            tabelaProdutos = new DataGridView();
            label1 = new Label();
            txtPesquisar = new TextBox();
            panelPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).BeginInit();
            SuspendLayout();
            // 
            // panelPesquisar
            // 
            panelPesquisar.BackColor = Color.White;
            panelPesquisar.Controls.Add(btnDeletar);
            panelPesquisar.Controls.Add(btnEditar);
            panelPesquisar.Controls.Add(btnPesquisar);
            panelPesquisar.Controls.Add(btnIniciar);
            panelPesquisar.Controls.Add(tabelaProdutos);
            panelPesquisar.Controls.Add(label1);
            panelPesquisar.Controls.Add(txtPesquisar);
            panelPesquisar.Dock = DockStyle.Fill;
            panelPesquisar.Location = new Point(0, 0);
            panelPesquisar.Name = "panelPesquisar";
            panelPesquisar.Size = new Size(1050, 750);
            panelPesquisar.TabIndex = 0;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.LightSkyBlue;
            btnDeletar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(472, 663);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(165, 55);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSkyBlue;
            btnEditar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(860, 663);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 55);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.LightSkyBlue;
            btnPesquisar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(762, 62);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(165, 55);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.LightSkyBlue;
            btnIniciar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(24, 663);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(165, 55);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "INICIO";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // tabelaProdutos
            // 
            tabelaProdutos.AllowUserToAddRows = false;
            tabelaProdutos.BackgroundColor = Color.Azure;
            tabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaProdutos.Location = new Point(24, 147);
            tabelaProdutos.Name = "tabelaProdutos";
            tabelaProdutos.ReadOnly = true;
            tabelaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaProdutos.Size = new Size(1001, 497);
            tabelaProdutos.TabIndex = 3;
            tabelaProdutos.CellContentClick += tabelaProdutos_CellContentClick;
            tabelaProdutos.CellDoubleClick += tabelaProdutos_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 70);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 2;
            label1.Text = "PRODUTO";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(250, 67);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(444, 39);
            txtPesquisar.TabIndex = 1;
            // 
            // PesquisarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelPesquisar);
            Name = "PesquisarProduto";
            Size = new Size(1050, 750);
            Load += PesquisarProduto_Load;
            panelPesquisar.ResumeLayout(false);
            panelPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPesquisar;
        private Button btnIniciar;
        private DataGridView tabelaProdutos;
        private Label label1;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnDeletar;
        private Button btnEditar;
    }
}
