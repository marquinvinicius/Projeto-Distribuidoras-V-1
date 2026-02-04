using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Marcas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Front.Marcas
{
    public partial class CadastrarMarcaControl : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly MarcaCategoriaApiClient _marcaCategoriaApiClient = new MarcaCategoriaApiClient(_httpClient);
        private readonly MarcasApiClient _marcaApi = new MarcasApiClient(_httpClient);
        private readonly CategoriasApiClient _categoriaApi = new CategoriasApiClient(_httpClient);
        private BindingList<GridMarca> _marcaCategorias = new BindingList<GridMarca>();
        public CadastrarMarcaControl()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O nome da marca não pode ser vazio.");
                return;
            }
            txtNome.Enabled = false;
        }

        private async void CadastrarMarcaControl_Load(object sender, EventArgs e)
        {
            await LoadCategorias();
        }
        private async Task LoadCategorias()
        {
            var categorias = await _categoriaApi.GetAllCategoriasAsync();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
        }

        private void btnAdcionarCategoria_Click(object sender, EventArgs e)
        {
            var categoriaSelecionada = cmbCategoria.SelectedItem as CategoriaDTO;
            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma categoria.");
                return;
            }
            var marcaEscolhida = txtNome.Text;
            if (string.IsNullOrEmpty(marcaEscolhida))
            {
                MessageBox.Show("Por favor, insira o nome da marca antes de adicionar uma categoria.");
                return;
            }
            _marcaCategorias.Add(new GridMarca
            {
                Marca = marcaEscolhida,
                Categoria = categoriaSelecionada.Nome,
            });
            tabelaMarca.DataSource = _marcaCategorias;
            tabelaMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            var linhaSelect = tabelaMarca.CurrentRow;
            if (linhaSelect != null)
            {
                var marcaCategoriaSelecionada = linhaSelect.DataBoundItem as GridMarca;
                if (marcaCategoriaSelecionada != null)
                {
                    _marcaCategorias.Remove(marcaCategoriaSelecionada);
                }
            }
        }

        private void btnRemoverNova_Click(object sender, EventArgs e)
        {
            var linhaSelect = tabelaMarca.CurrentRow;
            if (linhaSelect != null)
            {
                var marcaCategoriaSelecionada = linhaSelect.DataBoundItem as GridMarca;
                if (marcaCategoriaSelecionada != null)
                {
                    _marcaCategorias.Remove(marcaCategoriaSelecionada);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tabelaMarca.DataSource = null;
        }
        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            //marcas
            var marcas = await _marcaApi.GetAllMarcasAsync();
            var nomeMarca = txtNome.Text;
            if (string.IsNullOrEmpty(nomeMarca))
            {
                MessageBox.Show("Por favor, insira um nome para a marca.");
                return;
            }
            if (marcas.Any(m => m.Nome.Equals(nomeMarca, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A marca já existe. Por favor, insira uma marca diferente.");
                return;
            }
            var novaMarca = await _marcaApi.CreateMarcaAsync(new MarcaInputDTO
            {
                Nome = nomeMarca
            });


        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            var telaNovaCategoria = new NovaCategoria();
            telaNovaCategoria.ShowDialog();
        }
    }
}
