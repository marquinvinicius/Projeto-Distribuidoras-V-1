namespace Distribuidora.Front.Recebimento
{
    partial class ReceberMercadoriaControl
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
            button5 = new Button();
            txQuantidade = new TextBox();
            cmbProduto = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            txtNovoPreco = new TextBox();
            label9 = new Label();
            btnAdicionar = new Button();
            btnNovoProduto = new Button();
            txtPrecoAtual = new TextBox();
            label4 = new Label();
            cmbTransacao = new ComboBox();
            label5 = new Label();
            cmbUnidade = new ComboBox();
            UNIDADE = new Label();
            panelReceber = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelReceber.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 26);
            label1.Name = "label1";
            label1.Size = new Size(614, 42);
            label1.TabIndex = 1;
            label1.Text = "RECEBIMENTO DE MERCADORIA";
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Font = new Font("Arial", 12F);
            button5.Location = new Point(799, 649);
            button5.Name = "button5";
            button5.Size = new Size(221, 70);
            button5.TabIndex = 24;
            button5.Text = "SALVAR";
            button5.UseVisualStyleBackColor = false;
            // 
            // txQuantidade
            // 
            txQuantidade.Font = new Font("Arial", 21.75F);
            txQuantidade.Location = new Point(315, 206);
            txQuantidade.Name = "txQuantidade";
            txQuantidade.Size = new Size(205, 41);
            txQuantidade.TabIndex = 19;
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Arial", 21.75F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(29, 74);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(230, 41);
            cmbProduto.TabIndex = 17;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 21.75F);
            label3.Location = new Point(315, 157);
            label3.Name = "label3";
            label3.Size = new Size(205, 33);
            label3.TabIndex = 15;
            label3.Text = "QUANTIDADE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 21.75F);
            label2.Location = new Point(29, 24);
            label2.Name = "label2";
            label2.Size = new Size(161, 33);
            label2.TabIndex = 14;
            label2.Text = "PRODUTO";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Arial", 12F);
            button1.Location = new Point(28, 649);
            button1.Name = "button1";
            button1.Size = new Size(221, 70);
            button1.TabIndex = 48;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Arial", 12F);
            button2.Location = new Point(422, 649);
            button2.Name = "button2";
            button2.Size = new Size(221, 70);
            button2.TabIndex = 49;
            button2.Text = "LIMPAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(628, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(392, 496);
            dataGridView1.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 21.75F);
            label8.Location = new Point(3, 320);
            label8.Name = "label8";
            label8.Size = new Size(52, 33);
            label8.TabIndex = 53;
            label8.Text = "R$";
            // 
            // txtNovoPreco
            // 
            txtNovoPreco.Font = new Font("Arial", 21.75F);
            txtNovoPreco.Location = new Point(29, 206);
            txtNovoPreco.Name = "txtNovoPreco";
            txtNovoPreco.Size = new Size(230, 41);
            txtNovoPreco.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 21.75F);
            label9.Location = new Point(29, 157);
            label9.Name = "label9";
            label9.Size = new Size(118, 33);
            label9.TabIndex = 51;
            label9.Text = "PREÇO";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.Font = new Font("Arial", 12F);
            btnAdicionar.Location = new Point(29, 430);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(230, 42);
            btnAdicionar.TabIndex = 54;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.BackColor = Color.White;
            btnNovoProduto.Font = new Font("Arial", 12F);
            btnNovoProduto.Location = new Point(315, 430);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(205, 42);
            btnNovoProduto.TabIndex = 55;
            btnNovoProduto.Text = "NOVO  PRODUTO";
            btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // txtPrecoAtual
            // 
            txtPrecoAtual.Font = new Font("Arial", 21.75F);
            txtPrecoAtual.Location = new Point(315, 74);
            txtPrecoAtual.Name = "txtPrecoAtual";
            txtPrecoAtual.Size = new Size(205, 41);
            txtPrecoAtual.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 21.75F);
            label4.Location = new Point(342, 24);
            label4.Name = "label4";
            label4.Size = new Size(216, 33);
            label4.TabIndex = 57;
            label4.Text = "PREÇO ATUAL";
            // 
            // cmbTransacao
            // 
            cmbTransacao.Font = new Font("Arial", 21.75F);
            cmbTransacao.FormattingEnabled = true;
            cmbTransacao.Location = new Point(315, 336);
            cmbTransacao.Name = "cmbTransacao";
            cmbTransacao.Size = new Size(205, 41);
            cmbTransacao.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 21.75F);
            label5.Location = new Point(315, 286);
            label5.Name = "label5";
            label5.Size = new Size(196, 33);
            label5.TabIndex = 58;
            label5.Text = "TRANSAÇÃO";
            // 
            // cmbUnidade
            // 
            cmbUnidade.Font = new Font("Arial", 21.75F);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(27, 336);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(230, 41);
            cmbUnidade.TabIndex = 61;
            // 
            // UNIDADE
            // 
            UNIDADE.AutoSize = true;
            UNIDADE.Font = new Font("Arial", 21.75F);
            UNIDADE.Location = new Point(27, 286);
            UNIDADE.Name = "UNIDADE";
            UNIDADE.Size = new Size(144, 33);
            UNIDADE.TabIndex = 60;
            UNIDADE.Text = "UNIDADE";
            // 
            // panelReceber
            // 
            panelReceber.Controls.Add(panel1);
            panelReceber.Controls.Add(dataGridView1);
            panelReceber.Controls.Add(button2);
            panelReceber.Controls.Add(button1);
            panelReceber.Controls.Add(button5);
            panelReceber.Controls.Add(label1);
            panelReceber.Location = new Point(0, 0);
            panelReceber.Name = "panelReceber";
            panelReceber.Size = new Size(1054, 752);
            panelReceber.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(cmbUnidade);
            panel1.Controls.Add(UNIDADE);
            panel1.Controls.Add(cmbTransacao);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPrecoAtual);
            panel1.Controls.Add(btnNovoProduto);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtNovoPreco);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txQuantidade);
            panel1.Controls.Add(cmbProduto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 498);
            panel1.TabIndex = 62;
            // 
            // ReceberMercadoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelReceber);
            Controls.Add(label8);
            Name = "ReceberMercadoriaControl";
            Size = new Size(1050, 750);
            Load += ReceberMercadoriaControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelReceber.ResumeLayout(false);
            panelReceber.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button5;
        private TextBox txQuantidade;
        private ComboBox cmbProduto;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtNovoPreco;
        private Label label9;
        private Button btnAdicionar;
        private Button btnNovoProduto;
        private TextBox txtPrecoAtual;
        private Label label4;
        private ComboBox cmbTransacao;
        private Label label5;
        private ComboBox cmbUnidade;
        private Label UNIDADE;
        private Panel panelReceber;
        private Panel panel1;
    }
}
