namespace FrontDistribuidora.Telas.Relatorios
{
    partial class RelatorioEstoque
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
            cmbTipo = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            btnPesquisar = new Button();
            button1 = new Button();
            cmbCategoria = new ComboBox();
            cmbMarca = new ComboBox();
            cmbProduto = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataFim = new DateTimePicker();
            dataInicio = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(cmbMarca);
            panel1.Controls.Add(cmbProduto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataFim);
            panel1.Controls.Add(dataInicio);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 637);
            panel1.TabIndex = 0;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(204, 280);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(284, 32);
            cmbTipo.TabIndex = 14;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F);
            label6.Location = new Point(26, 280);
            label6.Name = "label6";
            label6.Size = new Size(58, 24);
            label6.TabIndex = 13;
            label6.Text = "TIPO";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(788, 539);
            button2.Name = "button2";
            button2.Size = new Size(202, 59);
            button2.TabIndex = 12;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(26, 539);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(462, 59);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(518, 539);
            button1.Name = "button1";
            button1.Size = new Size(206, 59);
            button1.TabIndex = 11;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(204, 461);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(284, 32);
            cmbCategoria.TabIndex = 10;
            // 
            // cmbMarca
            // 
            cmbMarca.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(204, 403);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(284, 32);
            cmbMarca.TabIndex = 9;
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(204, 337);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(284, 32);
            cmbProduto.TabIndex = 8;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F);
            label5.Location = new Point(26, 340);
            label5.Name = "label5";
            label5.Size = new Size(112, 24);
            label5.TabIndex = 7;
            label5.Text = "PRODUTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F);
            label4.Location = new Point(26, 406);
            label4.Name = "label4";
            label4.Size = new Size(83, 24);
            label4.TabIndex = 6;
            label4.Text = "MARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F);
            label3.Location = new Point(26, 464);
            label3.Name = "label3";
            label3.Size = new Size(145, 24);
            label3.TabIndex = 5;
            label3.Text = "CARTEGORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F);
            label2.Location = new Point(26, 149);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 4;
            label2.Text = "DATA FINAL ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F);
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 3;
            label1.Text = "DATA INICIAL ";
            // 
            // dataFim
            // 
            dataFim.Font = new Font("Arial", 14.25F);
            dataFim.Location = new Point(26, 191);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(462, 29);
            dataFim.TabIndex = 1;
            // 
            // dataInicio
            // 
            dataInicio.Font = new Font("Arial", 14.25F);
            dataInicio.Location = new Point(26, 87);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(462, 29);
            dataInicio.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(518, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(472, 482);
            dataGridView1.TabIndex = 2;
            // 
            // RelatorioEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "RelatorioEstoque";
            Size = new Size(1008, 637);
            Load += RelatorioEstoque_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private Button btnPesquisar;
        private Label label1;
        private ComboBox cmbCategoria;
        private ComboBox cmbMarca;
        private ComboBox cmbProduto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private ComboBox cmbTipo;
        private Label label6;
    }
}
