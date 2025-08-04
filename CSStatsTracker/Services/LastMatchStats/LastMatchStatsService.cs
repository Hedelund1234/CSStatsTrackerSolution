using CSStatsTracker.Entities.MatchRelated;
using CSStatsTracker.Entities;
using CSStatsTracker.Entities.MatchStatsRelated;
using System.Net.Http.Json;

namespace CSStatsTracker.Services.LastMatchStats
{
    public class LastMatchStatsService : ILastMatchStatsService
    {
        private readonly HttpClient _httpClient;
        public LastMatchStatsService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FaceitClient");
        }
        public async Task<Round> GetLastMatchStatsInfoAsync(string matchIdh)
        {
            var url = $"matches/{matchIdh}/stats";

            var response = await _httpClient.GetFromJsonAsync<RoundHistoryResponse>(url);

            return response?.Rounds.FirstOrDefault() ?? new Round();
        }
    }
}
