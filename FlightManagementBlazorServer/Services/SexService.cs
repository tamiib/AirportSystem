using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class SexService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44334/api/Sex";
        public SexService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Sex>> GetSex()
        {
            return await _httpClient.GetFromJsonAsync<List<Sex>>(BaseApiUrl);
        }
    }
}
