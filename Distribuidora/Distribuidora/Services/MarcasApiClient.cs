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
    public class MarcasApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://localhost:7285/api/marcas";

        public MarcasApiClient(HttpClient http)
        {
            _httpClient = http;
        }

        public async Task<IEnumerable<MarcaDTO>> GetAllMarcasAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();

            var marcas = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<MarcaDTO>>(marcas);

        }
        public async Task<MarcaDTO> GetMarcaByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");
            response.EnsureSuccessStatusCode();

            var marca = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcaDTO>(marca);
        }
        public async Task<MarcaDTO> GetMarcaByNameAsync(string nome)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/byname/{nome}");
            response.EnsureSuccessStatusCode();

            var marca = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcaDTO>(marca);
        }

        public async Task<bool> CreateMarcaAsync(MarcaInputDTO novaMarca)
        {
            var jsonContent = JsonConvert.SerializeObject(novaMarca);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_baseUrl, contentString);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateMarcaAsync(int id, MarcaInputDTO marcaActualizada)
        {
            var jsonContent = JsonConvert.SerializeObject(marcaActualizada);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_baseUrl}/{id}", contentString);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteMarcaAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
