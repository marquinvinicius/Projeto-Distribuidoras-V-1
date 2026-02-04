namespace Distribuidora.Front.Vendas
{
    partial class RealizarVendaControl
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
            button3 = new Button();
            btnLimpar = new Button();
            button1 = new Button();
            label2 = new Label();
            cmbProduto = new ComboBox();
            label3 = new Label();
            cmbUnidade = new ComboBox();
            panelRealizarVenda = new Panel();
            label6 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            txtPreco = new TextBox();
            label7 = new Label();
            btnAdc = new Button();
            btnRemover = new Button();
            cmbFardo = new ComboBox();
            label4 = new Label();
            tabelaVenda = new DataGridView();
            panelRealizarVenda.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 18);
            label1.Name = "label1";
            label1.Size = new Size(339, 42);
            label1.TabIndex = 0;
            label1.Text = "REALIZAR VENDA";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(835, 657);
            button3.Name = "button3";
            button3.Size = new Size(187, 69);
            button3.TabIndex = 19;
            button3.Text = "CONFIRMAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Arial", 18F);
            btnLimpar.Location = new Point(447, 657);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(204, 69);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 18F);
            button1.Location = new Point(42, 657);
            button1.Name = "button1";
            button1.Size = new Size(204, 69);
            button1.TabIndex = 17;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F);
            label2.Location = new Point(18, 34);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 13;
            label2.Text = "PRODUTO";
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Arial", 20.25F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(189, 33);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(298, 40);
            cmbProduto.TabIndex = 12;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F);
            label3.Location = new Point(20, 163);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 21;
            label3.Text = "UNIDADE";
            // 
            // cmbUnidade
            // 
            cmbUnidade.DropDownWidth = 20;
            cmbUnidade.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.IntegralHeight = false;
            cmbUnidade.ItemHeight = 36;
            cmbUnidade.Location = new Point(191, 157);
            cmbUnidade.MaxDropDownItems = 5;
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(158, 44);
            cmbUnidade.TabIndex = 20;
            // 
            // panelRealizarVenda
            // 
            panelRealizarVenda.Controls.Add(label6);
            panelRealizarVenda.Controls.Add(txtTotal);
            panelRealizarVenda.Controls.Add(label5);
            panelRealizarVenda.Controls.Add(panel1);
            panelRealizarVenda.Controls.Add(tabelaVenda);
            panelRealizarVenda.Controls.Add(label1);
            panelRealizarVenda.Controls.Add(btnLimpar);
            panelRealizarVenda.Controls.Add(button1);
            panelRealizarVenda.Controls.Add(button3);
            panelRealizarVenda.Dock = DockStyle.Fill;
            panelRealizarVenda.Location = new Point(0, 0);
            panelRealizarVenda.Name = "panelRealizarVenda";
            panelRealizarVenda.Size = new Size(1050, 750);
            panelRealizarVenda.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(721, 554);
            label6.Name = "label6";
            label6.Size = new Size(49, 32);
            label6.TabIndex = 30;
            label6.Text = "R$";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(827, 551);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(187, 39);
            txtTotal.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(580, 554);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 28;
            label5.Text = "TOTAL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAdc);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(cmbFardo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbProduto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbUnidade);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 439);
            panel1.TabIndex = 27;
            // 
            // txtPreco
            // 
            txtPreco.Enabled = false;
            txtPreco.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.ForeColor = Color.Black;
            txtPreco.Location = new Point(191, 94);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(158, 39);
            txtPreco.TabIndex = 28;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F);
            label7.Location = new Point(20, 99);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 27;
            label7.Text = "PREÇO";
            // 
            // btnAdc
            // 
            btnAdc.BackColor = Color.White;
            btnAdc.Font = new Font("Arial", 18F);
            btnAdc.Location = new Point(329, 299);
            btnAdc.Name = "btnAdc";
            btnAdc.Size = new Size(158, 48);
            btnAdc.TabIndex = 26;
            btnAdc.Text = "ADICIONAR";
            btnAdc.UseVisualStyleBackColor = false;
            btnAdc.Click += btnAdc_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.White;
            btnRemover.Font = new Font("Arial", 18F);
            btnRemover.Location = new Point(20, 299);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(158, 48);
            btnRemover.TabIndex = 25;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // cmbFardo
            // 
            cmbFardo.DropDownWidth = 20;
            cmbFardo.Font = new Font("Arial", 20.25F);
            cmbFardo.FormattingEnabled = true;
            cmbFardo.IntegralHeight = false;
            cmbFardo.Location = new Point(191, 234);
            cmbFardo.MaxDropDownItems = 5;
            cmbFardo.Name = "cmbFardo";
            cmbFardo.Size = new Size(151, 40);
            cmbFardo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F);
            label4.Location = new Point(20, 232);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 24;
            label4.Text = "FARDO";
            // 
            // tabelaVenda
            // 
            tabelaVenda.AllowUserToAddRows = false;
            tabelaVenda.BackgroundColor = Color.White;
            tabelaVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaVenda.Location = new Point(550, 80);
            tabelaVenda.Name = "tabelaVenda";
            tabelaVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaVenda.Size = new Size(472, 439);
            tabelaVenda.TabIndex = 22;
            tabelaVenda.CellContentClick += tabelaVenda_CellContentClick;
            // 
            // RealizarVendaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelRealizarVenda);
            Name = "RealizarVendaControl";
            Size = new Size(1050, 750);
            Load += RealizarVendaControl_Load;
            panelRealizarVenda.ResumeLayout(false);
            panelRealizarVenda.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button btnLimpar;
        private Button button1;
        private Label label2;
        private ComboBox cmbProduto;
        private Label label3;
        private ComboBox cmbUnidade;
        private Panel panelRealizarVenda;
        private DataGridView tabelaVenda;
        private ComboBox cmbFardo;
        private Label label4;
        private Button btnAdc;
        private Button btnRemover;
        private TextBox txtTotal;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private TextBox txtPreco;
        private Label label7;
    }
}
