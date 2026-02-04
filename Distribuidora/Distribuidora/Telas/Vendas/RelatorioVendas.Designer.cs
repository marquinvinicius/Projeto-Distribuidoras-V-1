namespace FrontDistribuidora.Telas.Vendas
{
    partial class RelatorioVendas
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
            label2 = new Label();
            label1 = new Label();
            dataFim = new DateTimePicker();
            dataInicio = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F);
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 8;
            label2.Text = "DATA FINAL ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F);
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 7;
            label1.Text = "DATA INICIAL ";
            // 
            // dataFim
            // 
            dataFim.Font = new Font("Arial", 14.25F);
            dataFim.Location = new Point(36, 165);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(383, 29);
            dataFim.TabIndex = 5;
            // 
            // dataInicio
            // 
            dataInicio.Font = new Font("Arial", 14.25F);
            dataInicio.Location = new Point(36, 61);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(383, 29);
            dataInicio.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(486, 490);
            dataGridView1.TabIndex = 9;
            // 
            // RelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Name = "RelatorioVendas";
            Size = new Size(1008, 637);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker dataFim;
        private DateTimePicker dataInicio;
        private DataGridView dataGridView1;
    }
}
