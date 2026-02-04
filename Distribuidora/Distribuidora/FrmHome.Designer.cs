namespace Distribuidora
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            vendasMenu = new ToolStripMenuItem();
            realizarVendaItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarProdutoMenu = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            preçosMenuItem = new ToolStripMenuItem();
            cadastrarPreçoMenu = new ToolStripMenuItem();
            margemCategoriaToolStripMenuItem = new ToolStripMenuItem();
            margemGeralToolStripMenuItem = new ToolStripMenuItem();
            margemMarcaToolStripMenuItem = new ToolStripMenuItem();
            cadastroUnicoToolStripMenuItem = new ToolStripMenuItem();
            margemToolStripMenuItem = new ToolStripMenuItem();
            especificoToolStripMenuItem = new ToolStripMenuItem();
            historicoDePREÇOSToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            categioriasToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            editarPreçoMenu = new ToolStripMenuItem();
            cadastrarMarcaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarMarcaMenu = new ToolStripMenuItem();
            vincularCategoriaToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            vincularMarcaToolStripMenuItem = new ToolStripMenuItem();
            recebimentoToolStripMenuItem = new ToolStripMenuItem();
            receberMercadoriaItem = new ToolStripMenuItem();
            relátoriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeEstoqueMenuItem = new ToolStripMenuItem();
            panelHome = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCyan;
            menuStrip1.Items.AddRange(new ToolStripItem[] { vendasMenu, produtosToolStripMenuItem, preçosMenuItem, cadastrarMarcaToolStripMenuItem, categoriasToolStripMenuItem, recebimentoToolStripMenuItem, relátoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // vendasMenu
            // 
            vendasMenu.DropDownItems.AddRange(new ToolStripItem[] { realizarVendaItem });
            vendasMenu.Name = "vendasMenu";
            vendasMenu.Size = new Size(56, 20);
            vendasMenu.Text = "Vendas";
            // 
            // realizarVendaItem
            // 
            realizarVendaItem.Name = "realizarVendaItem";
            realizarVendaItem.Size = new Size(149, 22);
            realizarVendaItem.Text = "Realizar Venda";
            realizarVendaItem.Click += realizarVendaItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProdutoMenu, pesquisarToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarProdutoMenu
            // 
            adicionarProdutoMenu.Name = "adicionarProdutoMenu";
            adicionarProdutoMenu.Size = new Size(171, 22);
            adicionarProdutoMenu.Text = "Adicionar Produto";
            adicionarProdutoMenu.Click += adicionarProdutoMenu_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(171, 22);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += pesquisarToolStripMenuItem_Click;
            // 
            // preçosMenuItem
            // 
            preçosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarPreçoMenu, cadastroUnicoToolStripMenuItem, historicoDePREÇOSToolStripMenuItem, editarPreçoMenu });
            preçosMenuItem.Name = "preçosMenuItem";
            preçosMenuItem.Size = new Size(54, 20);
            preçosMenuItem.Text = "Preços";
            // 
            // cadastrarPreçoMenu
            // 
            cadastrarPreçoMenu.DropDownItems.AddRange(new ToolStripItem[] { margemCategoriaToolStripMenuItem, margemGeralToolStripMenuItem, margemMarcaToolStripMenuItem });
            cadastrarPreçoMenu.Name = "cadastrarPreçoMenu";
            cadastrarPreçoMenu.Size = new Size(176, 22);
            cadastrarPreçoMenu.Text = "Cadastrar Margem";
            cadastrarPreçoMenu.Click += cadastrarPreçoMenu_Click;
            // 
            // margemCategoriaToolStripMenuItem
            // 
            margemCategoriaToolStripMenuItem.Name = "margemCategoriaToolStripMenuItem";
            margemCategoriaToolStripMenuItem.Size = new Size(173, 22);
            margemCategoriaToolStripMenuItem.Text = "Margem Categoria";
            margemCategoriaToolStripMenuItem.Click += margemCategoriaToolStripMenuItem_Click;
            // 
            // margemGeralToolStripMenuItem
            // 
            margemGeralToolStripMenuItem.Name = "margemGeralToolStripMenuItem";
            margemGeralToolStripMenuItem.Size = new Size(173, 22);
            margemGeralToolStripMenuItem.Text = "Margem Geral";
            margemGeralToolStripMenuItem.Click += margemGeralToolStripMenuItem_Click;
            // 
            // margemMarcaToolStripMenuItem
            // 
            margemMarcaToolStripMenuItem.Name = "margemMarcaToolStripMenuItem";
            margemMarcaToolStripMenuItem.Size = new Size(173, 22);
            margemMarcaToolStripMenuItem.Text = "Margem Marca";
            margemMarcaToolStripMenuItem.Click += margemMarcaToolStripMenuItem_Click;
            // 
            // cadastroUnicoToolStripMenuItem
            // 
            cadastroUnicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { margemToolStripMenuItem, especificoToolStripMenuItem });
            cadastroUnicoToolStripMenuItem.Name = "cadastroUnicoToolStripMenuItem";
            cadastroUnicoToolStripMenuItem.Size = new Size(176, 22);
            cadastroUnicoToolStripMenuItem.Text = "Cadastro Unico";
            cadastroUnicoToolStripMenuItem.Click += cadastroUnicoToolStripMenuItem_Click;
            // 
            // margemToolStripMenuItem
            // 
            margemToolStripMenuItem.Name = "margemToolStripMenuItem";
            margemToolStripMenuItem.Size = new Size(127, 22);
            margemToolStripMenuItem.Text = "Margem";
            // 
            // especificoToolStripMenuItem
            // 
            especificoToolStripMenuItem.Name = "especificoToolStripMenuItem";
            especificoToolStripMenuItem.Size = new Size(127, 22);
            especificoToolStripMenuItem.Text = "Especifico";
            especificoToolStripMenuItem.Click += especificoToolStripMenuItem_Click;
            // 
            // historicoDePREÇOSToolStripMenuItem
            // 
            historicoDePREÇOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem1, categioriasToolStripMenuItem, marcasToolStripMenuItem });
            historicoDePREÇOSToolStripMenuItem.Name = "historicoDePREÇOSToolStripMenuItem";
            historicoDePREÇOSToolStripMenuItem.Size = new Size(176, 22);
            historicoDePREÇOSToolStripMenuItem.Text = "Historico de Preços";
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(133, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // categioriasToolStripMenuItem
            // 
            categioriasToolStripMenuItem.Name = "categioriasToolStripMenuItem";
            categioriasToolStripMenuItem.Size = new Size(133, 22);
            categioriasToolStripMenuItem.Text = "Categiorias";
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(133, 22);
            marcasToolStripMenuItem.Text = "Marcas";
            // 
            // editarPreçoMenu
            // 
            editarPreçoMenu.Name = "editarPreçoMenu";
            editarPreçoMenu.Size = new Size(176, 22);
            editarPreçoMenu.Text = "Editar Preço";
            // 
            // cadastrarMarcaToolStripMenuItem
            // 
            cadastrarMarcaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarMarcaMenu, vincularCategoriaToolStripMenuItem });
            cadastrarMarcaToolStripMenuItem.Name = "cadastrarMarcaToolStripMenuItem";
            cadastrarMarcaToolStripMenuItem.Size = new Size(57, 20);
            cadastrarMarcaToolStripMenuItem.Text = "Marcas";
            // 
            // cadastrarMarcaMenu
            // 
            cadastrarMarcaMenu.Name = "cadastrarMarcaMenu";
            cadastrarMarcaMenu.Size = new Size(180, 22);
            cadastrarMarcaMenu.Text = "Cadastrar Marca";
            cadastrarMarcaMenu.Click += cadastrarMarcaMenu_Click;
            // 
            // vincularCategoriaToolStripMenuItem
            // 
            vincularCategoriaToolStripMenuItem.Name = "vincularCategoriaToolStripMenuItem";
            vincularCategoriaToolStripMenuItem.Size = new Size(180, 22);
            vincularCategoriaToolStripMenuItem.Text = "Vincular Categoria";
            vincularCategoriaToolStripMenuItem.Click += vincularCategoriaToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCategoriaToolStripMenuItem, vincularMarcaToolStripMenuItem });
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            cadastrarCategoriaToolStripMenuItem.Size = new Size(180, 22);
            cadastrarCategoriaToolStripMenuItem.Text = "Cadastrar Categoria";
            cadastrarCategoriaToolStripMenuItem.Click += cadastrarCategoriaToolStripMenuItem_Click;
            // 
            // vincularMarcaToolStripMenuItem
            // 
            vincularMarcaToolStripMenuItem.Name = "vincularMarcaToolStripMenuItem";
            vincularMarcaToolStripMenuItem.Size = new Size(180, 22);
            vincularMarcaToolStripMenuItem.Text = "Vincular Marca";
            // 
            // recebimentoToolStripMenuItem
            // 
            recebimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { receberMercadoriaItem });
            recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            recebimentoToolStripMenuItem.Size = new Size(89, 20);
            recebimentoToolStripMenuItem.Text = "Recebimento";
            // 
            // receberMercadoriaItem
            // 
            receberMercadoriaItem.Name = "receberMercadoriaItem";
            receberMercadoriaItem.Size = new Size(179, 22);
            receberMercadoriaItem.Text = "Receber Mercadoria";
            receberMercadoriaItem.Click += receberMercadoriaItem_Click;
            // 
            // relátoriosToolStripMenuItem
            // 
            relátoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeVendasToolStripMenuItem, relatórioDeEstoqueMenuItem });
            relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            relátoriosToolStripMenuItem.Size = new Size(71, 20);
            relátoriosToolStripMenuItem.Text = "Relátorios";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(182, 22);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // relatórioDeEstoqueMenuItem
            // 
            relatórioDeEstoqueMenuItem.Name = "relatórioDeEstoqueMenuItem";
            relatórioDeEstoqueMenuItem.Size = new Size(182, 22);
            relatórioDeEstoqueMenuItem.Text = "Relatório de Estoque";
            relatórioDeEstoqueMenuItem.Click += relatórioDeEstoqueMenuItem_Click;
            // 
            // panelHome
            // 
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(0, 24);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1050, 751);
            panelHome.TabIndex = 1;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1050, 775);
            Controls.Add(panelHome);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1066, 814);
            MinimumSize = new Size(1066, 814);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vendasMenu;
        private ToolStripMenuItem realizarVendaItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem adicionarProdutoMenu;
        private ToolStripMenuItem preçosMenuItem;
        private ToolStripMenuItem cadastrarPreçoMenu;
        private ToolStripMenuItem editarPreçoMenu;
        private Panel panelHome;
        private ToolStripMenuItem cadastrarMarcaToolStripMenuItem;
        private ToolStripMenuItem cadastrarMarcaMenu;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private ToolStripMenuItem recebimentoToolStripMenuItem;
        private ToolStripMenuItem relátoriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private ToolStripMenuItem relatórioDeEstoqueMenuItem;
        private ToolStripMenuItem receberMercadoriaItem;
        private ToolStripMenuItem margemCategoriaToolStripMenuItem;
        private ToolStripMenuItem margemGeralToolStripMenuItem;
        private ToolStripMenuItem margemMarcaToolStripMenuItem;
        private ToolStripMenuItem cadastroUnicoToolStripMenuItem;
        private ToolStripMenuItem margemToolStripMenuItem;
        private ToolStripMenuItem especificoToolStripMenuItem;
        private ToolStripMenuItem historicoDePREÇOSToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem categioriasToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem vincularCategoriaToolStripMenuItem;
        private ToolStripMenuItem vincularMarcaToolStripMenuItem;
    }
}
