namespace FrontDistribuidora.Telas.Preços.Margem
{
    partial class CadastroMargemCategoria
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
            panel1 = new Panel();
            button1 = new Button();
            tabelaPreco = new DataGridView();
            tabelaCategoria = new DataGridView();
            btnSalvar = new Button();
            button3 = new Button();
            btnAplicar = new Button();
            cmbCategoria = new ComboBox();
            txtMargem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaCategoria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tabelaPreco);
            panel1.Controls.Add(tabelaCategoria);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAplicar);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtMargem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 750);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(774, 638);
            button1.Name = "button1";
            button1.Size = new Size(247, 54);
            button1.TabIndex = 21;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabelaPreco
            // 
            tabelaPreco.AllowUserToAddRows = false;
            tabelaPreco.BackgroundColor = Color.White;
            tabelaPreco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaPreco.Location = new Point(525, 145);
            tabelaPreco.Name = "tabelaPreco";
            tabelaPreco.Size = new Size(496, 454);
            tabelaPreco.TabIndex = 20;
            // 
            // tabelaCategoria
            // 
            tabelaCategoria.AllowUserToAddRows = false;
            tabelaCategoria.BackgroundColor = Color.White;
            tabelaCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCategoria.Location = new Point(43, 145);
            tabelaCategoria.Name = "tabelaCategoria";
            tabelaCategoria.Size = new Size(437, 454);
            tabelaCategoria.TabIndex = 19;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightSkyBlue;
            btnSalvar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(404, 638);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(247, 54);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "HISTORICO";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(43, 638);
            button3.Name = "button3";
            button3.Size = new Size(247, 54);
            button3.TabIndex = 7;
            button3.Text = "VOLTAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.LightSkyBlue;
            btnAplicar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAplicar.Location = new Point(744, 81);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(218, 41);
            btnAplicar.TabIndex = 5;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(338, 81);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(282, 41);
            cmbCategoria.TabIndex = 4;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(43, 81);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(175, 41);
            txtMargem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 18);
            label2.Name = "label2";
            label2.Size = new Size(184, 33);
            label2.TabIndex = 1;
            label2.Text = "CATEGORIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 18);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 0;
            label1.Text = "MARGEM";
            // 
            // CadastroMargemCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "CadastroMargemCategoria";
            Size = new Size(1050, 750);
            Load += CadastroMargemCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAplicar;
        private ComboBox cmbCategoria;
        private TextBox txtMargem;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private Button button3;
        private DataGridView tabelaPreco;
        private DataGridView tabelaCategoria;
        private Button button1;
    }
}
