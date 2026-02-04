using ApiDistribuidora.DTOs.Response;
using FrontDistribuidora.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDistribuidora.Telas.Produto
{
    public partial class PesquisarProduto : UserControl
    {
        private readonly ProdutoApiClient _produtoApi = new ProdutoApiClient(_httpClient);
        private readonly PrecoVendaApiClient _precoVendaApi = new PrecoVendaApiClient(_httpClient);
        private static readonly HttpClient _httpClient = new HttpClient();
        private BindingList<GridProdutos> _tabela;
        private IEnumerable<ProdutoDTO> _produtosCarregados = Enumerable.Empty<ProdutoDTO>();
        private IEnumerable<PrecoVendaDTO> _precosCarregados = Enumerable.Empty<PrecoVendaDTO>();

        public PesquisarProduto()
        {
            InitializeComponent();
        }

        private async void PesquisarProduto_Load(object sender, EventArgs e)
        {
            _produtosCarregados = await _produtoApi.GetAllProdutosAsync();
            _precosCarregados = await _precoVendaApi.GetAllPrecosVendaAsync();
            _tabela = new BindingList<GridProdutos>(
                (from produto in _produtosCarregados
                 join preco in _precosCarregados
                 on produto.Id equals preco.ProdutoId into precosGroup
                 from preco in precosGroup.DefaultIfEmpty()
                 select new GridProdutos
                 {
                     Id = produto.Id,
                     Nome = produto.Nome,
                     Marca = produto.MarcaNome,
                     Categoria = produto.CategoriaNome,
                     QtdFardo = produto.QuantidadeFardo,
                     PrecoCusto = produto.Preco,
                     PrecoVenda = preco?.PrecoUnitario ?? 0m
                 }).ToList()
            );
            tabelaProdutos.DataSource = _tabela;
            tabelaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var nomeProduto = txtPesquisar.Text;
            if (string.IsNullOrEmpty(nomeProduto) || nomeProduto.Length < 1)
            {
                tabelaProdutos.DataSource = null;
                return;
            }
            try
            {
                var produtos = await _produtoApi.BuscarPorNomeAsync(nomeProduto);
                tabelaProdutos.DataSource = produtos.ToList();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro de conexãp {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado {ex.Message}");
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            var produto = txtPesquisar.Text;
            var pesquisa = await _produtoApi.BuscarPorNomeAsync(produto);
            if (pesquisa != null)
            {
                tabelaProdutos.DataSource = pesquisa.ToList();
            }

        }

        private void tabelaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = tabelaProdutos.Rows[e.RowIndex];
                var produtoId = (int)selectedRow.Cells["Id"].Value;
                var produtoSelecionado = _produtosCarregados.FirstOrDefault(p => p.Id == produtoId);
                if (produtoSelecionado != null)
                {
                    var editarProdutoControl = new EditarProduto(produtoSelecionado);
                    editarProdutoControl.Dock = DockStyle.Fill;
                    var parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Controls.Clear();
                        parentForm.Controls.Add(editarProdutoControl);
                    }
                }
            }
            //erro pra estudar mais tarde
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
