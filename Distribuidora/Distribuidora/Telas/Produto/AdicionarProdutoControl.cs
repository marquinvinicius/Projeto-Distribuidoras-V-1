using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Produto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Front
{
    public partial class AdicionarProdutoControl : UserControl
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(httpClient);
        private readonly MarcasApiClient _marcasApi = new MarcasApiClient(httpClient);
        private readonly CategoriasApiClient _categoriasApiClient = new CategoriasApiClient(httpClient);
        private IEnumerable<MarcaDTO> _marcas;
        private IEnumerable<CategoriaDTO> _categorias;
        private BindingList<GridProdutos> _produtos = new BindingList<GridProdutos>();
        private List<ProdutoInputDTO> _salvar;


        public AdicionarProdutoControl()
        {
            InitializeComponent();
            cmbQtdFardo.MaxDropDownItems = 10;
            for (int i = 1; i <= 100; i++)
            {
                cmbQtdFardo.Items.Add(i);
            }
        }

        private void panelcCadProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async void AdicionarProdutoControl_Load(object sender, EventArgs e)
        {
            await LoadMarcas();
            await LoadCategorias();

        }
        private async Task LoadMarcas()
        {
            _marcas = await _marcasApi.GetAllMarcasAsync();
            cmbMarca.SelectedIndexChanged -= cmbMarca_SelectedIndexChanged;

            cmbMarca.DataSource = _marcas;
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.ValueMember = "Id";
            cmbMarca.SelectedIndex = -1;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
        }
        private async Task LoadCategorias()
        {
            _categorias = await _categoriasApiClient.GetAllCategoriasAsync();
            cmbCategoria.DataSource = _categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnAdcionar_Click(object sender, EventArgs e)
        {
            decimal precoCusto;
            var precoCustoText = txtPreco.Text.Replace(',', '.');
            if (!decimal.TryParse(precoCustoText, NumberStyles.Any, CultureInfo.InvariantCulture, out precoCusto))
            {
                MessageBox.Show("Preço de custo inválido. Por favor, insira um valor numérico válido.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var nomeProduto = txtNome.Text;
            var marcaSelecionada = cmbMarca.SelectedItem as MarcaDTO;
            var categoriaSelecionada = cmbCategoria.SelectedItem as CategoriaDTO;
            var qtdFardo = cmbQtdFardo.SelectedItem;

            var produto = new ProdutoInputDTO
            {
                Nome = nomeProduto,
                MarcaId = marcaSelecionada?.Id ?? 0,
                CategoriaId = categoriaSelecionada?.Id ?? 0,
                PrecoCusto = precoCusto,
                QuantidadeFardo = qtdFardo != null ? Convert.ToInt32(qtdFardo) : 0
            };
            await _produtoApiClient.CreateProdutoAsync(produto);

            if (MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                txtNome.Clear();
                txtPreco.Clear();
                cmbMarca.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cmbQtdFardo.SelectedIndex = -1;
            }

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicinoar_Click(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedItem is not MarcaDTO marca || cmbCategoria.SelectedItem is not CategoriaDTO categoria)
            {
                MessageBox.Show("Selecione Marca e Categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var culture = CultureInfo.CurrentCulture; 

            bool qtdOk = int.TryParse(cmbQtdFardo.SelectedItem?.ToString(), out int fardo);
            bool custoOk = decimal.TryParse(txtPreco.Text, NumberStyles.Number, culture, out decimal preco);
            bool vendaOk = decimal.TryParse(txtVenda.Text, NumberStyles.Number, culture, out decimal venda);

            if (!qtdOk || !custoOk || !vendaOk)
            {
                MessageBox.Show("Verifique os valores numéricos (Fardo, Custo e Venda).", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _produtos.Add(new GridProdutos
            {
                Nome = txtNome.Text,
                Marca = marca.Nome,
                Categoria = categoria.Nome,
                QtdFardo = fardo,
                PrecoCusto = preco,
                PrecoVenda = venda
            });
            tabelaProdutos.DataSource = _produtos;
            tabelaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaProdutos.Columns["PrecoCusto"].DefaultCellStyle.Format = "C2";
            tabelaProdutos.Columns["PrecoVenda"].DefaultCellStyle.Format = "C2";

            LimparCampos();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var produtos = _produtos;
            foreach (var item in produtos)
            {
                var produto = new ProdutoInputDTO
                {
                    Nome = item.Nome,
                    MarcaId = _marcas.FirstOrDefault(m => m.Nome == item.Marca)?.Id ?? 0,
                    CategoriaId = _categorias.FirstOrDefault(c => c.Nome == item.Categoria)?.Id ?? 0,
                    PrecoCusto = item.PrecoCusto,
                    QuantidadeFardo = item.QtdFardo
                };
                _salvar.Add(produto);
            }
            await _produtoApiClient.CreateListaProdutosAsync(_salvar);

            if (MessageBox.Show("Produtos adicionados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                LimparTabela();
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtVenda.Clear();
            cmbMarca.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbQtdFardo.SelectedIndex = -1;
        }
        private void LimparTabela()
        {
            _produtos.Clear();
            tabelaProdutos.DataSource = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTabela();
        }
    }
}
