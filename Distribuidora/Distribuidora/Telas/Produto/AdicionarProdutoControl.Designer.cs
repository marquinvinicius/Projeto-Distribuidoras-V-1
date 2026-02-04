namespace Distribuidora.Front
{
    partial class AdicionarProdutoControl
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
            panelcCadProdutos = new Panel();
            label7 = new Label();
            txtVenda = new TextBox();
            label8 = new Label();
            btnAdicinoar = new Button();
            tabelaProdutos = new DataGridView();
            cmbQtdFardo = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            btnLimpar = new Button();
            button1 = new Button();
            btnSalvar = new Button();
            txtPreco = new TextBox();
            label3 = new Label();
            cmbMarca = new ComboBox();
            cmbCategoria = new ComboBox();
            LABEL25 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panelcCadProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).BeginInit();
            SuspendLayout();
            // 
            // panelcCadProdutos
            // 
            panelcCadProdutos.Controls.Add(label7);
            panelcCadProdutos.Controls.Add(txtVenda);
            panelcCadProdutos.Controls.Add(label8);
            panelcCadProdutos.Controls.Add(btnAdicinoar);
            panelcCadProdutos.Controls.Add(tabelaProdutos);
            panelcCadProdutos.Controls.Add(cmbQtdFardo);
            panelcCadProdutos.Controls.Add(label4);
            panelcCadProdutos.Controls.Add(label6);
            panelcCadProdutos.Controls.Add(btnLimpar);
            panelcCadProdutos.Controls.Add(button1);
            panelcCadProdutos.Controls.Add(btnSalvar);
            panelcCadProdutos.Controls.Add(txtPreco);
            panelcCadProdutos.Controls.Add(label3);
            panelcCadProdutos.Controls.Add(cmbMarca);
            panelcCadProdutos.Controls.Add(cmbCategoria);
            panelcCadProdutos.Controls.Add(LABEL25);
            panelcCadProdutos.Controls.Add(label2);
            panelcCadProdutos.Controls.Add(txtNome);
            panelcCadProdutos.Controls.Add(label5);
            panelcCadProdutos.Controls.Add(label1);
            panelcCadProdutos.Dock = DockStyle.Fill;
            panelcCadProdutos.Location = new Point(0, 0);
            panelcCadProdutos.Name = "panelcCadProdutos";
            panelcCadProdutos.Size = new Size(1050, 750);
            panelcCadProdutos.TabIndex = 0;
            panelcCadProdutos.Paint += panelcCadProdutos_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(176, 433);
            label7.Name = "label7";
            label7.Size = new Size(49, 32);
            label7.TabIndex = 52;
            label7.Text = "R$";
            // 
            // txtVenda
            // 
            txtVenda.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVenda.Location = new Point(231, 430);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(244, 39);
            txtVenda.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 433);
            label8.Name = "label8";
            label8.Size = new Size(106, 32);
            label8.TabIndex = 50;
            label8.Text = "VENDA";
            // 
            // btnAdicinoar
            // 
            btnAdicinoar.BackColor = Color.White;
            btnAdicinoar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicinoar.Location = new Point(14, 506);
            btnAdicinoar.Name = "btnAdicinoar";
            btnAdicinoar.Size = new Size(461, 60);
            btnAdicinoar.TabIndex = 7;
            btnAdicinoar.Text = "ADICIONAR";
            btnAdicinoar.UseVisualStyleBackColor = false;
            btnAdicinoar.Click += btnAdicinoar_Click;
            // 
            // tabelaProdutos
            // 
            tabelaProdutos.AllowUserToAddRows = false;
            tabelaProdutos.BackgroundColor = Color.White;
            tabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaProdutos.Location = new Point(497, 111);
            tabelaProdutos.Name = "tabelaProdutos";
            tabelaProdutos.Size = new Size(534, 455);
            tabelaProdutos.TabIndex = 48;
            // 
            // cmbQtdFardo
            // 
            cmbQtdFardo.DropDownHeight = 150;
            cmbQtdFardo.Font = new Font("Arial", 20.25F);
            cmbQtdFardo.FormattingEnabled = true;
            cmbQtdFardo.IntegralHeight = false;
            cmbQtdFardo.Location = new Point(231, 295);
            cmbQtdFardo.Name = "cmbQtdFardo";
            cmbQtdFardo.Size = new Size(158, 40);
            cmbQtdFardo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 298);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 46;
            label4.Text = "QTD FARDO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(169, 375);
            label6.Name = "label6";
            label6.Size = new Size(49, 32);
            label6.TabIndex = 45;
            label6.Text = "R$";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Arial", 18F);
            btnLimpar.Location = new Point(401, 636);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(204, 69);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 18F);
            button1.Location = new Point(14, 636);
            button1.Name = "button1";
            button1.Size = new Size(204, 69);
            button1.TabIndex = 8;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(844, 636);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(187, 69);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(231, 375);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(244, 39);
            txtPreco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 378);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 40;
            label3.Text = "CUSTO";
            // 
            // cmbMarca
            // 
            cmbMarca.Font = new Font("Arial", 20.25F);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(231, 165);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(244, 40);
            cmbMarca.TabIndex = 2;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Arial", 20.25F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(231, 227);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(244, 40);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // LABEL25
            // 
            LABEL25.AutoSize = true;
            LABEL25.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABEL25.Location = new Point(14, 230);
            LABEL25.Name = "LABEL25";
            LABEL25.Size = new Size(172, 32);
            LABEL25.TabIndex = 34;
            LABEL25.Text = "CATEGORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 33;
            label2.Text = "MARCA";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(231, 108);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 39);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 111);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 29;
            label5.Text = "NOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 24);
            label1.Name = "label1";
            label1.Size = new Size(445, 42);
            label1.TabIndex = 1;
            label1.Text = "CADASTRAR PRODUTO";
            // 
            // AdicionarProdutoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelcCadProdutos);
            Name = "AdicionarProdutoControl";
            Size = new Size(1050, 750);
            Load += AdicionarProdutoControl_Load;
            panelcCadProdutos.ResumeLayout(false);
            panelcCadProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelcCadProdutos;
        private Label label1;
        private Label label5;
        private TextBox txtNome;
        private Label LABEL25;
        private Label label2;
        private ComboBox cmbMarca;
        private ComboBox cmbCategoria;
        private TextBox txtPreco;
        private Label label3;
        private Button btnLimpar;
        private Button button1;
        private Button btnSalvar;
        private Label label6;
        private Label label4;
        private ComboBox cmbQtdFardo;
        private DataGridView tabelaProdutos;
        private Button btnAdicinoar;
        private Label label7;
        private TextBox txtVenda;
        private Label label8;
    }
}
