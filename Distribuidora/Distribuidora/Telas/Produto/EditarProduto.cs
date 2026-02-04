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
    public partial class EditarProduto : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly ProdutoApiClient _produtoApi = new ProdutoApiClient(_httpClient);
        private readonly PrecoVendaApiClient _precoVendaApi = new PrecoVendaApiClient(_httpClient);
        private ProdutoDTO _produto;

        public EditarProduto(ProdutoDTO produto)
        {
            InitializeComponent();
            _produto = produto;
            txtNome.Text = produto.Nome;
            txtQuantidade.Text = produto.Estoque.ToString();
            txtCusto.Text = produto.Preco.ToString("F2");
            txtMarca.Text = produto.MarcaNome;
            txtCategoria.Text = produto.CategoriaNome;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async void txtVenda_TextChanged(object sender, EventArgs e)
        {
        }

        private async void EditarProduto_Load(object sender, EventArgs e)
        {
            var preco = await _precoVendaApi.GetPrecoVendaByProdutoIdAsync(_produto.Id);
            if (preco != null)
            {
                txtVenda.Text = preco.PrecoUnitario.ToString("F2");
            }
            else
            {
                txtVenda.Text = "0.00";
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelEditar.Controls.Clear();
            var pesquisar = new PesquisarProduto();
            panelEditar.Controls.Add(pesquisar);
            pesquisar.Dock = DockStyle.Fill;
        }
    }
}
