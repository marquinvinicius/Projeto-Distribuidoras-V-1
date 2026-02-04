using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Front.Vendas
{
    public partial class RealizarVendaControl : UserControl
    {
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(_httpClient);
        private readonly PrecoVendaApiClient _precoVendaApiClient = new PrecoVendaApiClient(_httpClient);
        private static readonly HttpClient _httpClient = new HttpClient();
        private BindingList<GridVenda> _vendagrid = new BindingList<GridVenda>();
        private IEnumerable<ProdutoDTO> _produtos;
        private IEnumerable<PrecoVendaDTO> _precosVenda;
        public RealizarVendaControl()
        {
            InitializeComponent();
            cmbFardo.MaxDropDownItems = 10; ;
            cmbUnidade.MaxDropDownItems = 10;
            for (int i = 1; i <= 100; i++)
            {
                cmbUnidade.Items.Add(i);
                cmbFardo.Items.Add(i);
            }
        }

        private async Task LoadProdutosAsync()
        {
            _produtos = await _produtoApiClient.GetAllProdutosAsync();
            cmbProduto.DataSource = _produtos;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProduto.SelectedIndex = -1;
        }

        private async void RealizarVendaControl_Load(object sender, EventArgs e)
        {
            await LoadProdutosAsync();
            _precosVenda = await _precoVendaApiClient.GetAllPrecosVendaAsync();
        }

        private void tabelaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigurarGrid()
        {
            _vendagrid.Clear();
            tabelaVenda.DataSource = _vendagrid;
            tabelaVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tabelaVenda.Columns["Id"].Visible = false;
            tabelaVenda.Columns["Nome"].HeaderText = "Produto";
            tabelaVenda.Columns["Preco"].HeaderText = "Preço Unitário";
            tabelaVenda.Columns["Preco"].DefaultCellStyle.Format = "C";
            tabelaVenda.Columns["Quantidade"].HeaderText = "Quantidade";
            tabelaVenda.Columns["Total"].HeaderText = "Total";
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            decimal precoUnitario;
            var produtoSelecionado = cmbProduto.SelectedItem as ProdutoDTO;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Produto inválido.");
                return;
            }
            var preco = txtPreco.Text.Replace("R$", "").Trim();
            if (!decimal.TryParse(preco, out precoUnitario))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            int quantidadeUnidade = cmbUnidade.SelectedItem != null ? (int)cmbUnidade.SelectedItem : 0;
            int quantidadeFardo = cmbFardo.SelectedItem != null ? (int)cmbFardo.SelectedItem : 0;
            int quantidadeTotal = quantidadeUnidade + (quantidadeFardo * produtoSelecionado.QuantidadeFardo);

            if (quantidadeTotal <= 0)
            {
                MessageBox.Show("Selecione uma quantidade válida.");
                return;
            }
            var novoItem = new GridVenda
            {
                Nome = produtoSelecionado.Nome,
                Preco = precoUnitario,
                Quantidade = quantidadeTotal,
                Total = produtoSelecionado.Preco * quantidadeTotal
            };
            _vendagrid.Add(novoItem);
            tabelaVenda.DataSource = _vendagrid;
            decimal valorTotal = _vendagrid.Sum(item => item.Total);
            txtTotal.Text = valorTotal.ToString("C");

            cmbProduto.SelectedIndex = -1;
            cmbUnidade.SelectedIndex = -1;
            cmbFardo.SelectedIndex = -1;
            txtPreco.Text = string.Empty;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private async void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_precosVenda == null) return;
            var produtoSelecionado = cmbProduto.SelectedItem as ProdutoDTO;
            if (produtoSelecionado == null) return;

            var precoVenda = _precosVenda.FirstOrDefault(p => p.ProdutoId == produtoSelecionado.Id);

            if (precoVenda != null)
            {
                txtPreco.Text = precoVenda.PrecoUnitario.ToString("C");
                txtPreco.Enabled = false;
            }
            else
            {
                txtPreco.Text = 0.ToString("C");
            }


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = tabelaVenda.CurrentRow;
            if (linhaSelecionada != null)
            {
                var itemVendaSelecionado = linhaSelecionada.DataBoundItem as GridVenda;
                if (itemVendaSelecionado != null)
                {
                    _vendagrid.Remove(itemVendaSelecionado);
                    decimal valorTotal = _vendagrid.Sum(item => item.Total);
                    txtTotal.Text = valorTotal.ToString("C");
                }
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tabelaVenda.DataSource = null;
            _vendagrid.Clear();
            txtTotal.Text = 0.ToString("C");
        }
    }

}
