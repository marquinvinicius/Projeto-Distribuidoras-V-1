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
    public partial class CadastroMargemMarca : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly MarcasApiClient _marcaApi = new MarcasApiClient(_httpClient);
        private readonly ProdutoApiClient _produtoApi = new ProdutoApiClient(_httpClient);
        private BindingList<GridGeral> _produtos = new BindingList<GridGeral>();
        private BindingList<GridGeralPronto> _produtosPronto = new BindingList<GridGeralPronto>();
        private IEnumerable<MarcaDTO> _marcas;
        private IEnumerable<ProdutoDTO> _produtosCarregados = Enumerable.Empty<ProdutoDTO>();


        public CadastroMargemMarca()
        {
            InitializeComponent();
        }
        private async void CadastroMargemMarca_Load(object sender, EventArgs e)
        {
            await LoadMarcaAsync();
        }
        private async void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var marcaselecionada = cmbMarca.SelectedItem as MarcaDTO;
            if (marcaselecionada == null)
            {
                _produtos.Clear();
                tabelaMarca.DataSource = _produtos;
                return;
            }

            _produtosCarregados = await _produtoApi.BuscarPorMarcaAsync(marcaselecionada.Id);

            _produtos.Clear();

            foreach (var produto in _produtosCarregados)
            {
                _produtos.Add(new GridGeral
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco
                });
            }
            tabelaMarca.DataSource = _produtos;
            tabelaMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private async Task LoadMarcaAsync()
        {
            _marcas = await _marcaApi.GetAllMarcasAsync();
            cmbMarca.SelectedIndexChanged -= cmbMarca_SelectedIndexChanged;

            cmbMarca.DataSource = _marcas;
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMarca.SelectedIndex = -1;

            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var produtos = _produtosCarregados;
            if (produtos == null || !produtos.Any())
            {
                MessageBox.Show("Nenhum produto carregado para aplicar a margem.");
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
                var novoPreco = produto.Preco + (produto.Preco * margem / 100);
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
