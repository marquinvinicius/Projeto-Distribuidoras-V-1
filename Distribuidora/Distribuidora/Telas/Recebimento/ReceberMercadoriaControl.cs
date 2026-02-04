using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades.Enums;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Recebimento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Front.Recebimento
{
    public partial class ReceberMercadoriaControl : UserControl
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(httpClient);
        private BindingList<GridReceberMercadoria> _receba = new BindingList<GridReceberMercadoria>();

        public ReceberMercadoriaControl()
        {
            InitializeComponent();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduto = cmbProduto.SelectedItem as ProdutoDTO;
        }

        private async void ReceberMercadoriaControl_Load(object sender, EventArgs e)
        {
            await LoadProdutos();
            LoadTransacao();
            LoadUnidade();

        }
        private async Task LoadProdutos()
        {
            var produtos = await _produtoApiClient.GetAllProdutosAsync();
            cmbProduto.DataSource = produtos;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "Id";
            cmbProduto.SelectedIndex = -1;
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadTransacao()
        {
            var tiposTransacao = Enum.GetValues(typeof(TipoTransacao)).Cast<TipoTransacao>().ToList();


            var dataSource = tiposTransacao.Select(t => new
            {
                Id = (int)t,
                Nome = t.ToString()
            }).ToList();

            cmbTransacao.ValueMember = "Id";
            cmbTransacao.DisplayMember = "Nome";
            cmbTransacao.DataSource = dataSource;
            cmbTransacao.SelectedIndex = -1;

        }
        private void LoadUnidade()
        {
            var tipoUnidade = Enum.GetValues(typeof(TipoUnidade)).Cast<TipoUnidade>().ToList();


            var dataSource = tipoUnidade.Select(t => new
            {
                Id = (int)t,
                Nome = t.ToString()
            }).ToList();

            cmbUnidade.ValueMember = "Id";
            cmbUnidade.DisplayMember = "Nome";
            cmbUnidade.DataSource = dataSource;
            cmbUnidade.SelectedIndex = -1;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quantidade;
            decimal precoCusto;

            var selectedProduto = cmbProduto.SelectedItem as ProdutoDTO;

        }
    }
}
