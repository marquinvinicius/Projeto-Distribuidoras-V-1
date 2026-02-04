namespace FrontDistribuidora.Telas.Produto
{
    partial class EditarProduto
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
            label6 = new Label();
            btnLimpar = new Button();
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtCusto = new TextBox();
            label3 = new Label();
            txtQuantidade = new TextBox();
            LABEL9 = new Label();
            LABEL25 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label5 = new Label();
            txtMarca = new TextBox();
            txtCategoria = new TextBox();
            label1 = new Label();
            txtVenda = new TextBox();
            label4 = new Label();
            tabelaHistorico = new DataGridView();
            btnExcluir = new Button();
            panelEditar = new Panel();
            ((System.ComponentModel.ISupportInitialize)tabelaHistorico).BeginInit();
            panelEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(190, 280);
            label6.Name = "label6";
            label6.Size = new Size(49, 32);
            label6.TabIndex = 61;
            label6.Text = "R$";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Arial", 18F);
            btnLimpar.Location = new Point(303, 634);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(204, 69);
            btnLimpar.TabIndex = 59;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.Font = new Font("Arial", 18F);
            btnVoltar.Location = new Point(45, 634);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(204, 69);
            btnVoltar.TabIndex = 58;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(815, 634);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(187, 69);
            btnSalvar.TabIndex = 60;
            btnSalvar.Text = "CONFIRMAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCusto
            // 
            txtCusto.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusto.Location = new Point(263, 277);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(244, 39);
            txtCusto.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 280);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 56;
            label3.Text = "CUSTO";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(263, 187);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(244, 39);
            txtQuantidade.TabIndex = 55;
            // 
            // LABEL9
            // 
            LABEL9.AutoSize = true;
            LABEL9.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABEL9.Location = new Point(45, 190);
            LABEL9.Name = "LABEL9";
            LABEL9.Size = new Size(145, 32);
            LABEL9.TabIndex = 54;
            LABEL9.Text = "ESTOQUE";
            // 
            // LABEL25
            // 
            LABEL25.AutoSize = true;
            LABEL25.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABEL25.Location = new Point(45, 522);
            LABEL25.Name = "LABEL25";
            LABEL25.Size = new Size(172, 32);
            LABEL25.TabIndex = 50;
            LABEL25.Text = "CATEGORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 445);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 49;
            label2.Text = "MARCA";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(263, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 39);
            txtNome.TabIndex = 47;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 122);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 46;
            label5.Text = "NOME";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(263, 442);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(244, 39);
            txtMarca.TabIndex = 62;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(263, 519);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(244, 39);
            txtCategoria.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 348);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 66;
            label1.Text = "R$";
            // 
            // txtVenda
            // 
            txtVenda.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVenda.Location = new Point(263, 345);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(244, 39);
            txtVenda.TabIndex = 65;
            txtVenda.TextChanged += txtVenda_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 348);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 64;
            label4.Text = "VENDA";
            // 
            // tabelaHistorico
            // 
            tabelaHistorico.BackgroundColor = Color.White;
            tabelaHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaHistorico.Location = new Point(600, 119);
            tabelaHistorico.Name = "tabelaHistorico";
            tabelaHistorico.Size = new Size(402, 456);
            tabelaHistorico.TabIndex = 67;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.Font = new Font("Arial", 18F);
            btnExcluir.Location = new Point(559, 634);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(204, 69);
            btnExcluir.TabIndex = 68;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // panelEditar
            // 
            panelEditar.Controls.Add(btnExcluir);
            panelEditar.Controls.Add(tabelaHistorico);
            panelEditar.Controls.Add(label1);
            panelEditar.Controls.Add(txtVenda);
            panelEditar.Controls.Add(label4);
            panelEditar.Controls.Add(txtCategoria);
            panelEditar.Controls.Add(txtMarca);
            panelEditar.Controls.Add(label6);
            panelEditar.Controls.Add(btnLimpar);
            panelEditar.Controls.Add(btnVoltar);
            panelEditar.Controls.Add(btnSalvar);
            panelEditar.Controls.Add(txtCusto);
            panelEditar.Controls.Add(label3);
            panelEditar.Controls.Add(txtQuantidade);
            panelEditar.Controls.Add(LABEL9);
            panelEditar.Controls.Add(LABEL25);
            panelEditar.Controls.Add(label2);
            panelEditar.Controls.Add(txtNome);
            panelEditar.Controls.Add(label5);
            panelEditar.Location = new Point(0, 0);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(1050, 750);
            panelEditar.TabIndex = 69;
            // 
            // EditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelEditar);
            Name = "EditarProduto";
            Size = new Size(1050, 750);
            Load += EditarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)tabelaHistorico).EndInit();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Button btnLimpar;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtCusto;
        private Label label3;
        private TextBox txtQuantidade;
        private Label LABEL9;
        private Label LABEL25;
        private Label label2;
        private TextBox txtNome;
        private Label label5;
        private TextBox txtMarca;
        private TextBox txtCategoria;
        private Label label1;
        private TextBox txtVenda;
        private Label label4;
        private DataGridView tabelaHistorico;
        private Button btnExcluir;
        private Panel panelEditar;
    }
}
