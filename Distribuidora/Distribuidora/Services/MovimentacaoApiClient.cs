using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Services
{
    public class MovimentacaoApiClient
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "http://localhost:7285/api/movimentacaoestoque";

        public MovimentacaoApiClient (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
