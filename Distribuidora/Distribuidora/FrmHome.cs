using Distribuidora.Front;
using Distribuidora.Front.Marcas;
using Distribuidora.Front.Preços;
using Distribuidora.Front.Recebimento;
using Distribuidora.Front.Vendas;
using FrontDistribuidora.Telas.Categorias;
using FrontDistribuidora.Telas.Preços.Margem;
using FrontDistribuidora.Telas.Produto;
using FrontDistribuidora.Telas.Relatorios;
using FrontDistribuidora.Telas.Vinculos;

namespace Distribuidora
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cadastrarPreçoMenu_Click(object sender, EventArgs e)
        {

        }

        private void realizarVendaItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var realizarVenda = new RealizarVendaControl();
            panelHome.Controls.Add(realizarVenda);
            realizarVenda.Dock = DockStyle.Fill;
        }

        private void adicionarProdutoMenu_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var adicionarProduto = new AdicionarProdutoControl();
            panelHome.Controls.Add(adicionarProduto);
            adicionarProduto.Dock = DockStyle.Fill;
        }

        private void receberMercadoriaItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var receberMercadoria = new ReceberMercadoriaControl();
            panelHome.Controls.Add(receberMercadoria);
            receberMercadoria.Dock = DockStyle.Fill;
        }

        private void cadastrarMarcaMenu_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastrarMarca = new CadastrarMarcaControl();
            panelHome.Controls.Add(cadastrarMarca);
            cadastrarMarca.Dock = DockStyle.Fill;
        }

        private void relatórioDeEstoqueMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var relatorioEstoque = new RelatorioEstoque();
            panelHome.Controls.Add(relatorioEstoque);
            relatorioEstoque.Dock = DockStyle.Fill;
        }

        private void cadastroUnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastroEspecifico = new CadastrarPrecoUnico();
            panelHome.Controls.Add(cadastroEspecifico);
            cadastroEspecifico.Dock = DockStyle.Fill;
        }

        private void margemCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastroMargemCategoria = new CadastroMargemCategoria();
            panelHome.Controls.Add(cadastroMargemCategoria);
            cadastroMargemCategoria.Dock = DockStyle.Fill;
        }

        private void margemGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastroMargemGeral = new CadastroMargemGeral();
            panelHome.Controls.Add(cadastroMargemGeral);
            cadastroMargemGeral.Dock = DockStyle.Fill;
        }

        private void margemMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastroMargemMarca = new CadastroMargemMarca();
            panelHome.Controls.Add(cadastroMargemMarca);
            cadastroMargemMarca.Dock = DockStyle.Fill;
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var pesquisar = new PesquisarProduto();
            panelHome.Controls.Add(pesquisar);
            pesquisar.Dock = DockStyle.Fill;
        }

        private void vincularCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var vincularCategoria = new VincularCategoria();
            panelHome.Controls.Add(vincularCategoria);
            vincularCategoria.Dock = DockStyle.Fill;
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var cadastrarCategoria = new CadastrarCategoria();
            panelHome.Controls.Add(cadastrarCategoria);
            cadastrarCategoria.Dock = DockStyle.Fill;
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            var rela = new RelatorioVendas();
            panelHome.Controls.Add(rela);
            rela.Dock = DockStyle.Fill;
        }
    }
}
