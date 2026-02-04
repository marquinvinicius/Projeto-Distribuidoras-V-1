using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades.Enums;
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

namespace FrontDistribuidora.Telas.Relatorios
{
    public partial class RelatorioEstoque : UserControl
    {
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(_httpClient);
        private readonly MarcasApiClient _marcasApiClient = new MarcasApiClient(_httpClient);
        private readonly CategoriasApiClient _categoriasApiClient = new CategoriasApiClient(_httpClient);
        private static readonly HttpClient _httpClient = new HttpClient();
        private IEnumerable<ProdutoDTO> _produtos;
        private IEnumerable<MarcaDTO> _marcas;
        private IEnumerable<CategoriaDTO> _categorias;
        public RelatorioEstoque()
        {
            InitializeComponent();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = cmbProduto.SelectedItem as ProdutoInputDTO;
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
        private async Task LoadMarcasAsync()
        {
            _marcas = await _marcasApiClient.GetAllMarcasAsync();
            cmbMarca.DataSource = _marcas;
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMarca.SelectedIndex = -1;
        }
        private async Task LoadCategoriasAsync()
        {
            _categorias = await _categoriasApiClient.GetAllCategoriasAsync();
            cmbCategoria.DataSource = _categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoria.SelectedIndex = -1;
        }

        private async void RelatorioEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProdutosAsync();
                LoadTiposAsync();
                await LoadCategoriasAsync();
                await LoadMarcasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
                throw;
            }
        }
        private async void LoadTiposAsync()
        {
            var tiposTransacao = Enum.GetValues(typeof(TipoTransacao)).Cast<TipoTransacao>().ToList();


            var dataSource = tiposTransacao.Select(t => new
            {
                Id = (int)t,              
                Nome = t.ToString()       
            }).ToList();
            
            cmbTipo.ValueMember = "Id";    
            cmbTipo.DisplayMember = "Nome"; 
            cmbTipo.DataSource = dataSource;
            cmbTipo.SelectedIndex = -1;
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
