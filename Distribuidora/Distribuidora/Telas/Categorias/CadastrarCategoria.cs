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

namespace FrontDistribuidora.Telas.Categorias
{
    public partial class CadastrarCategoria : UserControl
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly CategoriasApiClient _categoriasApiClient = new CategoriasApiClient(httpClient);
        private BindingList<CategoriaInputDTO> _gridCategorias = new BindingList<CategoriaInputDTO>();
        private IEnumerable<CategoriaDTO> _categorias;
        public CadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var nomeCategoria = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nomeCategoria))
            {
                MessageBox.Show("O nome da categoria não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novaCategoria = new CategoriaInputDTO { Nome = nomeCategoria };
            _gridCategorias.Add(novaCategoria);
            txtNome.Clear();
            tabelaCategoria.DataSource = _gridCategorias;
            tabelaCategoria.Columns["Nome"].HeaderText = "CATEGORIA";
            tabelaCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaCategoria.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabelaCategoria.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoriasParaSalvar = _gridCategorias.ToList();
            foreach (var categoria in categoriasParaSalvar)
            {
                await _categoriasApiClient.CreateCategoriaAsync(categoria);
            }
            _gridCategorias.Clear();
            MessageBox.Show("Categorias salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
