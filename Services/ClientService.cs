using System.Net.Http;
using System.Net.Http.Json;
using CRMApplicationWeb.ViewModels;

namespace CRMApplicationWeb.Services
{
    public class ClientService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:5001/api/client"; // Conferir essa url depois de referenciar o projeto da API

        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ClientViewModel>> GetClient()
        {
            var clients = await _httpClient.GetFromJsonAsync<List<ClientViewModel>>(_baseUrl);
            return clients ?? new List<ClientViewModel>();
        }
    }
}