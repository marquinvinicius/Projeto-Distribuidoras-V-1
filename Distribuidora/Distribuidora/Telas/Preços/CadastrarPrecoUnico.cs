using ApiDistribuidora.DTOs.Input;
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

namespace Distribuidora.Front.Preços
{
    public partial class CadastrarPrecoUnico : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly ProdutoApiClient _produtoApi = new ProdutoApiClient(_httpClient);
        private readonly PrecoVendaApiClient _precoVendaApi = new PrecoVendaApiClient(_httpClient);
        private IEnumerable<PrecoVendaDTO> _precoVendaDTOs;
        public CadastrarPrecoUnico()
        {
            InitializeComponent();
        }

        private void txtproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoSelecionado = cmbProduto.SelectedItem as ProdutoDTO;
            if (produtoSelecionado != null)
            {
                txtPreçoCusto.Text = produtoSelecionado.Preco.ToString("C");
            }
            else
            {
                txtPreçoCusto.Text = string.Empty;
            }
        }

        private async void CadastrarPrecoUnico_Load(object sender, EventArgs e)
        {
            await LoadProdutosAsync();
            _precoVendaDTOs = await _precoVendaApi.GetAllPrecosVendaAsync();
        }
        private async Task LoadProdutosAsync()
        {
            var produtos = await _produtoApi.GetAllProdutosAsync();
            cmbProduto.DataSource = produtos.ToList();
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "Id";
            cmbProduto.SelectedIndex = -1;
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var precoCustoText = txtPreçoCusto.Text.Replace("R$", "").Trim();
            var precoVenda = txtPrecoVenda.Text.Replace("R$", "").Trim();
            if (decimal.TryParse(precoCustoText, out decimal precoCusto) &&
                decimal.TryParse(precoVenda, out decimal precoVendaDecimal))
            {
                if (precoVendaDecimal < precoCusto)
                {
                    MessageBox.Show("O preço de venda não pode ser menor que o preço de custo.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var produtoSelecionado = cmbProduto.SelectedItem as ProdutoDTO;
                var novoPrecoVenda = new PrecoVendaInputDTO
                {
                    ProdutoId = produtoSelecionado.Id,
                    ValorVenda = precoVendaDecimal
                };
                await _precoVendaApi.PrecoUnicoAsync(produtoSelecionado.Id, precoVendaDecimal);
                MessageBox.Show("Preço de venda atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para os preços.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
