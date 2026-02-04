using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Services
{
    public class CategoriasApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://localhost:7285/api/categorias";
        public CategoriasApiClient(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<IEnumerable<CategoriaDTO>> GetAllCategoriasAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();

            var categorias = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<CategoriaDTO>>(categorias);
        }
        public async Task<CategoriaDTO> GetCategoriaByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");
            response.EnsureSuccessStatusCode();

            var categoria = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CategoriaDTO>(categoria);
        }
        public async Task<bool> CreateCategoriaAsync(CategoriaInputDTO novaCategoria)
        {
            var jsonContent = JsonConvert.SerializeObject(novaCategoria);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_baseUrl, contentString);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateCategoriaAsync(int id, CategoriaInputDTO categoriaActualizada)
        {
            var jsonContent = JsonConvert.SerializeObject(categoriaActualizada);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_baseUrl}/{id}", contentString);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteCategoriaAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
