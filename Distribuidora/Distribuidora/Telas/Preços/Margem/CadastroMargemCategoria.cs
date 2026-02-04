using ApiDistribuidora.DTOs.Response;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Preços.Margem.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDistribuidora.Telas.Preços.Margem
{
    public partial class CadastroMargemCategoria : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly CategoriasApiClient _categoriasApiClient = new CategoriasApiClient(_httpClient);
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(_httpClient);
        private BindingList<GridGeral> _produtos = new BindingList<GridGeral>();
        private BindingList<GridGeralPronto> _produtosPronto = new BindingList<GridGeralPronto>();
        private IEnumerable<CategoriaDTO> _categorias;
        private IEnumerable<ProdutoDTO> _produtosCarregados = Enumerable.Empty<ProdutoDTO>();

        public CadastroMargemCategoria()
        {
            InitializeComponent();
        }

        private async void CadastroMargemCategoria_Load(object sender, EventArgs e)
        {
            await LoadCategoriasAsync();
        }


        private async Task LoadCategoriasAsync()
        {
            _categorias =  await _categoriasApiClient.GetAllCategoriasAsync();
            cmbCategoria.SelectedIndexChanged -= cmbCategoria_SelectedIndexChanged;

            cmbCategoria.DataSource = _categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoria.SelectedIndex = -1;

            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;

        }

        private async void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            var categoriaSelecionada = cmbCategoria.SelectedItem as CategoriaDTO;
            if (categoriaSelecionada == null)
            {
                _produtos.Clear();
                tabelaCategoria.DataSource = _produtos;
                return;
            }

            _produtosCarregados = await _produtoApiClient.BuscarPorCategoriaAsync(categoriaSelecionada.Id);

            _produtos.Clear();
            foreach (var produtos in _produtosCarregados)
            {
                _produtos.Add(new GridGeral
                {
                    Id = produtos.Id,
                    Nome = produtos.Nome,
                    Preco = produtos.Preco
                });
            }
            tabelaCategoria.DataSource = _produtos;
            tabelaCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            var produtos = _produtosCarregados;
            if (produtos == null || !produtos.Any())
            {
                MessageBox.Show("Não há produtos para aplicar margem");
                return;
            }

            decimal margem;
            if (!decimal.TryParse(txtMargem.Text, out margem))
            {
                MessageBox.Show("Insira um valor de margem válido.");
                return;
            }
            _produtosPronto.Clear();
            foreach (var produto in produtos)
            {
                _produtosPronto.Add(new GridGeralPronto
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco,
                    ValorVenda = produto.Preco + (produto.Preco * margem / 100)
                });
            }
            tabelaPreco.DataSource = _produtosPronto;
            tabelaPreco.Columns["ValorVenda"].Visible = false;
            tabelaPreco.Columns["ValorVendaString"].HeaderText = "ValorVenda";
            tabelaPreco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
