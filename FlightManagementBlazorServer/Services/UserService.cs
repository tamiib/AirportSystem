using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44334/api/User";
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task AddUserAsync(User user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task LogUserAsync(User user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, ($"{BaseApiUrl}/login"));
            request.Content = new StringContent(JsonSerializer.Serialize(user),Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<User> GetUser(string username, string password)
        {
            return await _httpClient.GetFromJsonAsync<User>($"{BaseApiUrl}/get/{username}/{password}");
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>(BaseApiUrl);
        }
    }
}

