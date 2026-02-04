using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Services
{
    public class MarcaCategoriaApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://localhost:7285/api/marcacategoria";

        public MarcaCategoriaApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<CategoriaDTO>> GetCategoriaPorMarca(int marcaId)
        {
            var url = $"{_baseUrl}/categoriaPorMarca/{marcaId}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var json = await response.Content.ReadAsStringAsync();
            if (json == null)
            {
                MessageBox.Show("Erro de no Servico");
            }
            return JsonConvert.DeserializeObject<IEnumerable<CategoriaDTO>>(json);
        }
        public async Task<bool> VincularMarcaCategoria(int marcaId, int categoriaId)
        {
            var url = $"{_baseUrl}/vincular/{marcaId}/{categoriaId}";
            var response = await _httpClient.PostAsync(url, null);
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DesvincularMarcaCategoria(int marcaId, int categoriaId)
        {
            var url = $"{_baseUrl}/desvincular/{marcaId}/{categoriaId}";
            var response = await _httpClient.PostAsync(url, null);

            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }
    }
}
