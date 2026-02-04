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

namespace FrontDistribuidora.Telas.Vinculos
{
    public partial class VincularCategoria : UserControl
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly CategoriasApiClient _categoriasApiClient = new CategoriasApiClient(httpClient);
        private readonly MarcasApiClient _marcasApiClient = new MarcasApiClient(httpClient);
        private readonly MarcaCategoriaApiClient _marcaCategoriaApiClient = new MarcaCategoriaApiClient(httpClient);
        private IEnumerable<CategoriaDTO> _categorias;
        private IEnumerable<MarcaDTO> _marcas;
        private BindingList<GridMarcaCategoria> _gridMarca = new BindingList<GridMarcaCategoria>();
        public VincularCategoria()
        {
            InitializeComponent();
        }
        private async void VincularCategoria_Load(object sender, EventArgs e)
        {
            await LoadCategorias();
            await LoadMarcas();
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async Task LoadMarcas()
        {
            _marcas = await _marcasApiClient.GetAllMarcasAsync();
            cmbMarca.DataSource = _marcas.ToList();
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.ValueMember = "Id";
            cmbMarca.SelectedIndex = -1;
        }
        private async Task LoadCategorias()
        {
            _categorias = await _categoriasApiClient.GetAllCategoriasAsync();
            cmbCategoria.DataSource = _categorias.ToList();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var marcaSelecionada = cmbMarca.SelectedItem as MarcaDTO;
            cmbMarca.Enabled = false;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            var categoriaSelecionada = cmbCategoria.SelectedItem as CategoriaDTO;
            var marcaSelecionada = cmbMarca.SelectedItem as MarcaDTO;
            var gridItem = new GridMarcaCategoria
            {
                Marca = marcaSelecionada.Nome,
                Categoria = categoriaSelecionada.Nome
            };
            _gridMarca.Add(gridItem);

            tabelaMarca.DataSource = _gridMarca;
            tabelaMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

}
