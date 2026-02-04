using ApiDistribuidora.DTOs.Response;
using FrontDistribuidora.Services;
using FrontDistribuidora.Telas.Preços.Margem.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDistribuidora.Telas.Preços.Margem
{
    public partial class CadastroMargemGeral : UserControl
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly ProdutoApiClient _produtoApiClient = new ProdutoApiClient(_httpClient);
        private readonly PrecoVendaApiClient _precoVendaApiClient = new PrecoVendaApiClient(_httpClient);
        private BindingList<GridGeral> _produtos = new BindingList<GridGeral>();
        private BindingList<GridGeralPronto> _produtosPronto = new BindingList<GridGeralPronto>();

        public CadastroMargemGeral()
        {
            InitializeComponent();
            tabelaMargem.RowPostPaint += tabelaPreco_RowPostPaint;
        }

        private async void CadastroMargemGeral_Load(object sender, EventArgs e)
        {
            await LoadProdutos();
            //ConfiguracaoGrid();
        }
        private async Task LoadProdutos()
        {
            var produtos = await _produtoApiClient.GetAllProdutosAsync();
            _produtos.Clear();
            foreach (var produto in produtos)
            {
                _produtos.Add(new GridGeral
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco
                });
            }
            tabelaMargem.DataSource = _produtos;
            tabelaMargem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tabelaPreco_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;

            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            var proodutos = await _produtoApiClient.GetAllProdutosAsync();
            decimal margem;
            var margemTxt = txtMargem.Text;
            if (!decimal.TryParse(margemTxt, out margem))
            {
                MessageBox.Show("Margem inválida. Insira um valor numérico.");
                return;
            }
            _produtosPronto.Clear();
            foreach (var produto in proodutos)
            {
                _produtosPronto.Add(new GridGeralPronto
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco,
                    ValorVenda = produto.Preco + (produto.Preco * margem / 100)
                });
            }
            tabelaPreco.DataSource = _produtosPronto;
            tabelaPreco.Columns["ValorVenda"].Visible = false;
            tabelaPreco.Columns["ValorVendaString"].HeaderText = "ValorVenda";
            tabelaPreco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tabelaMargem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            decimal margem;
            var margemTxt = txtMargem.Text;
            if (!decimal.TryParse(margemTxt, out margem))
            {
                MessageBox.Show("Margem inválida. Insira um valor numérico.");
                return;
            }

            await _precoVendaApiClient.PrecoMargemGeralAsync(margem);
            if (MessageBox.Show("Margem aplicada com sucesso!", "Sucesso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                await LoadProdutos();
                tabelaPreco.DataSource = null;
                txtMargem.Clear();
            }
        }
    }
}
