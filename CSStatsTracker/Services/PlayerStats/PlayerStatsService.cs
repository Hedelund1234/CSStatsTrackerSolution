using CSStatsTracker.Entities;
using Blazored.LocalStorage;
using System.Net.Http.Json;


namespace CSStatsTracker.Services.PlayerStats
{
    public class PlayerStatsService : IPlayerStatsService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        public PlayerStatsService(IHttpClientFactory httpClientFactory, ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
            _httpClient = httpClientFactory.CreateClient("FaceitClient");
        }
        public async Task<Player> GetPlayerInfoAsync(string name)
        {
            var url = $"players?nickname={name}&game=csgo";

            var player = await _httpClient.GetFromJsonAsync<Player>(url);

            return player ?? new Player();
        }
    }
}
