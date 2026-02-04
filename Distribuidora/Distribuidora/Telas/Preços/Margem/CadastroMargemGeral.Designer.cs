namespace FrontDistribuidora.Telas.Preços.Margem
{
    partial class CadastroMargemGeral
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
            tabelaPreco = new DataGridView();
            button1 = new Button();
            btnSalvar = new Button();
            button3 = new Button();
            btnAplicar = new Button();
            txtMargem = new TextBox();
            tabelaMargem = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaMargem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabelaPreco);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAplicar);
            panel1.Controls.Add(txtMargem);
            panel1.Controls.Add(tabelaMargem);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 750);
            panel1.TabIndex = 1;
            // 
            // tabelaPreco
            // 
            tabelaPreco.AllowUserToAddRows = false;
            tabelaPreco.BackgroundColor = Color.White;
            tabelaPreco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaPreco.Location = new Point(531, 155);
            tabelaPreco.Name = "tabelaPreco";
            tabelaPreco.ReadOnly = true;
            tabelaPreco.Size = new Size(483, 441);
            tabelaPreco.TabIndex = 18;
            tabelaPreco.RowPostPaint += tabelaPreco_RowPostPaint;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(423, 643);
            button1.Name = "button1";
            button1.Size = new Size(247, 54);
            button1.TabIndex = 17;
            button1.Text = "HISTORICO";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightSkyBlue;
            btnSalvar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(767, 643);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(247, 54);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(39, 643);
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
            btnAplicar.Location = new Point(323, 76);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(153, 41);
            btnAplicar.TabIndex = 14;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(39, 76);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(235, 41);
            txtMargem.TabIndex = 12;
            // 
            // tabelaMargem
            // 
            tabelaMargem.AllowUserToAddRows = false;
            tabelaMargem.BackgroundColor = Color.White;
            tabelaMargem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMargem.Location = new Point(39, 155);
            tabelaMargem.Name = "tabelaMargem";
            tabelaMargem.ReadOnly = true;
            tabelaMargem.Size = new Size(377, 441);
            tabelaMargem.TabIndex = 11;
            tabelaMargem.CellContentClick += tabelaMargem_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 10);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 9;
            label1.Text = "MARGEM";
            // 
            // CadastroMargemGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "CadastroMargemGeral";
            Size = new Size(1050, 750);
            Load += CadastroMargemGeral_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaMargem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnSalvar;
        private Button button3;
        private Button btnAplicar;
        private TextBox txtMargem;
        private DataGridView tabelaMargem;
        private Label label1;
        private DataGridView tabelaPreco;
    }
}
