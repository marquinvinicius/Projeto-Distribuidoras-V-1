namespace FrontDistribuidora.Telas.Preços.Margem
{
    partial class CadastroMargemMarca
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
            tabelaMarca = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            btnAplicar = new Button();
            cmbMarca = new ComboBox();
            txtMargem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tabelaPreco);
            panel1.Controls.Add(tabelaMarca);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAplicar);
            panel1.Controls.Add(cmbMarca);
            panel1.Controls.Add(txtMargem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 750);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(768, 650);
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
            tabelaPreco.Location = new Point(578, 179);
            tabelaPreco.Name = "tabelaPreco";
            tabelaPreco.Size = new Size(437, 404);
            tabelaPreco.TabIndex = 20;
            // 
            // tabelaMarca
            // 
            tabelaMarca.AllowUserToAddRows = false;
            tabelaMarca.BackgroundColor = Color.White;
            tabelaMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMarca.Location = new Point(27, 179);
            tabelaMarca.Name = "tabelaMarca";
            tabelaMarca.Size = new Size(437, 404);
            tabelaMarca.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(442, 650);
            button2.Name = "button2";
            button2.Size = new Size(247, 54);
            button2.TabIndex = 16;
            button2.Text = "HISTORICO";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(27, 650);
            button3.Name = "button3";
            button3.Size = new Size(247, 54);
            button3.TabIndex = 15;
            button3.Text = "VOLTAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.LightSkyBlue;
            btnAplicar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAplicar.Location = new Point(756, 99);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(218, 41);
            btnAplicar.TabIndex = 14;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbMarca
            // 
            cmbMarca.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(283, 96);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(282, 41);
            cmbMarca.TabIndex = 13;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(27, 96);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(175, 41);
            txtMargem.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 29);
            label2.Name = "label2";
            label2.Size = new Size(118, 33);
            label2.TabIndex = 10;
            label2.Text = "MARCA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 9;
            label1.Text = "MARGEM";
            // 
            // CadastroMargemMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "CadastroMargemMarca";
            Size = new Size(1050, 750);
            Load += CadastroMargemMarca_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaMarca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button btnAplicar;
        private ComboBox cmbMarca;
        private TextBox txtMargem;
        private Label label2;
        private Label label1;
        private DataGridView tabelaPreco;
        private DataGridView tabelaMarca;
        private Button button1;
    }
}
