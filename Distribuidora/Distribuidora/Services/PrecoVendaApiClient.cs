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
    public class PrecoVendaApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://localhost:7285/api/precovenda";

        public PrecoVendaApiClient (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Historico de preços de venda
        public async Task<IEnumerable<PrecoVendaDTO>> GetAllPrecosVendaAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/todos");
            response.EnsureSuccessStatusCode();
            var precosVenda = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<PrecoVendaDTO>>(precosVenda);
        }


        //preco atual por produto
        public async Task<PrecoVendaDTO> GetPrecoVendaByProdutoIdAsync(int produtoId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/atual/{produtoId}");
            response.EnsureSuccessStatusCode();
            var precoVenda = await response.Content.ReadFromJsonAsync<PrecoVendaDTO>();

            return precoVenda;
        }

        //historico de preços por produto
        public async Task<IEnumerable<PrecoVendaDTO>> GetHistoricoPreco (int produtoId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/historico/{produtoId}");
            response.EnsureSuccessStatusCode();
            var historico = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<PrecoVendaDTO>>(historico);

        }

        
        #region Posts
        public async Task PrecoUnicoAsync(int produtoId, decimal preco)
        {
            try
            {
                var url = $"{_baseUrl}/adcionar";
                var payload = new
                {
                    ProdutoId = produtoId,
                    ValorVenda = preco
                };
                var response = await _httpClient.PostAsJsonAsync(url, payload);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Erro de comunicação com a api", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao definir preço único", ex);
            }
        }
        public async Task PrecoMargemAsync(int produtoId, decimal margem)
        {
            var url = $"{_baseUrl}/margemunico";
            var payload = new
            {
                ProdutoId = produtoId,
                Margem = margem
            };
            var response = await _httpClient.PostAsJsonAsync(url, payload);
            response.EnsureSuccessStatusCode();
        }

        public async Task PrecoMargemGeralAsync(decimal margem)
        {
            var url = $"{_baseUrl}/margemgeral";
            var payload = new
            {
                Margem = margem
            };
            var response = await _httpClient.PostAsJsonAsync(url, payload);
            response.EnsureSuccessStatusCode();
        }
    }
    #endregion
}
