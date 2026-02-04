using ApiDistribuidora.DTOs.Input;
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

namespace FrontDistribuidora.Telas.Marcas
{
    public partial class NovaCategoria : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly CategoriasApiClient _categoriaApi = new CategoriasApiClient(_httpClient);
        public NovaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoriaNome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(categoriaNome))
            {
                MessageBox.Show("Por favor, insira um nome válido para a categoria.", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await _categoriaApi.CreateCategoriaAsync(new CategoriaInputDTO { Nome = categoriaNome});
            MessageBox.Show("Categoria criada com sucesso!", 
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
