namespace Distribuidora.Front.Preços
{
    partial class CadastrarPrecoUnico
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
            txtPreçoCusto = new TextBox();
            cmbProduto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecoVenda = new TextBox();
            btnVoltar = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            panelCadPreco = new Panel();
            panelCadPreco.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 17);
            label1.Name = "label1";
            label1.Size = new Size(504, 55);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR PREÇO";
            // 
            // txtPreçoCusto
            // 
            txtPreçoCusto.BackColor = Color.White;
            txtPreçoCusto.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreçoCusto.Location = new Point(549, 281);
            txtPreçoCusto.Name = "txtPreçoCusto";
            txtPreçoCusto.ReadOnly = true;
            txtPreçoCusto.Size = new Size(363, 44);
            txtPreçoCusto.TabIndex = 2;
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(549, 181);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(363, 44);
            cmbProduto.TabIndex = 3;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F);
            label2.Location = new Point(70, 189);
            label2.Name = "label2";
            label2.Size = new Size(173, 36);
            label2.TabIndex = 4;
            label2.Text = "PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 24F);
            label3.Location = new Point(70, 289);
            label3.Name = "label3";
            label3.Size = new Size(300, 36);
            label3.TabIndex = 5;
            label3.Text = "PREÇO DE CUSTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 24F);
            label4.Location = new Point(70, 387);
            label4.Name = "label4";
            label4.Size = new Size(299, 36);
            label4.TabIndex = 6;
            label4.Text = "PREÇO DE VENDA";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecoVenda.Location = new Point(549, 387);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(363, 44);
            txtPrecoVenda.TabIndex = 7;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.Font = new Font("Arial", 18F);
            btnVoltar.Location = new Point(70, 539);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(172, 69);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Arial", 18F);
            btnLimpar.Location = new Point(403, 539);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(172, 69);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(730, 539);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(172, 69);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panelCadPreco
            // 
            panelCadPreco.Controls.Add(btnSalvar);
            panelCadPreco.Controls.Add(btnLimpar);
            panelCadPreco.Controls.Add(btnVoltar);
            panelCadPreco.Controls.Add(txtPrecoVenda);
            panelCadPreco.Controls.Add(label4);
            panelCadPreco.Controls.Add(label3);
            panelCadPreco.Controls.Add(label2);
            panelCadPreco.Controls.Add(cmbProduto);
            panelCadPreco.Controls.Add(txtPreçoCusto);
            panelCadPreco.Controls.Add(label1);
            panelCadPreco.Dock = DockStyle.Fill;
            panelCadPreco.Location = new Point(0, 0);
            panelCadPreco.Name = "panelCadPreco";
            panelCadPreco.Size = new Size(1008, 637);
            panelCadPreco.TabIndex = 11;
            // 
            // CadastrarPrecoUnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelCadPreco);
            Name = "CadastrarPrecoUnico";
            Size = new Size(1008, 637);
            Load += CadastrarPrecoUnico_Load;
            panelCadPreco.ResumeLayout(false);
            panelCadPreco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtPreçoCusto;
        private ComboBox cmbProduto;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrecoVenda;
        private Button btnVoltar;
        private Button btnLimpar;
        private Button btnSalvar;
        private Panel panelCadPreco;
    }
}
