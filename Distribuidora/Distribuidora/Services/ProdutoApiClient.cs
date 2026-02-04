using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Services
{
    public class ProdutoApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://localhost:7285/api/produtos";
        public ProdutoApiClient(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<IEnumerable<ProdutoDTO>> GetAllProdutosAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();

            var produtos = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<ProdutoDTO>>(produtos);
        }

        public async Task<IEnumerable<ProdutoDTO>> BuscarPorNomeAsync(string nome)
        {
            var url = $"{_baseUrl}/BuscarNome/{nome}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json  = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ProdutoDTO>>(json);
        }

        public async Task<IEnumerable<ProdutoDTO>> BuscarPorMarcaAsync(int marcaId)
        {
            var url = $"{_baseUrl}/BuscarMarca/{marcaId}";
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                if (json == null)
                {
                    MessageBox.Show("Erro ao carregar produtos por marca");
                }
                return JsonConvert.DeserializeObject<IEnumerable<ProdutoDTO>>(json);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: ", ex.Message);
                throw;
            }
        }
        public async Task<ProdutoDTO> GetProdutoByIdAsync(int id)
        {
            var url = $"{_baseUrl}/{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var produto = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutoDTO>(produto);
        }
        public async Task<IEnumerable<ProdutoDTO>> BuscarPorCategoriaAsync(int categoriaId)
        {
            var url = $"{_baseUrl}/BuscarCategoria/{categoriaId}";
            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            if (json == null)
            {
                 MessageBox.Show("Erro ao carregar produtos por categoria");
            }
            return JsonConvert.DeserializeObject<IEnumerable<ProdutoDTO>>(json);
        }

        public async Task<ProdutoInputDTO> CreateProdutoAsync (ProdutoInputDTO produto)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseUrl, produto);
            response.EnsureSuccessStatusCode();

            var createdProduto = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutoInputDTO>(createdProduto);
        }
        public async Task<IEnumerable<ProdutoDTO>> CreateListaProdutosAsync(IEnumerable<ProdutoInputDTO> produtos)
        {
            var url = $"{_baseUrl}/addLista";
            var response = await _httpClient.PostAsJsonAsync(url, produtos);
            response.EnsureSuccessStatusCode();
            var createdProdutos = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<ProdutoDTO>>(createdProdutos);
        }
    }
}
