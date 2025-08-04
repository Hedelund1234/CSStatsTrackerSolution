using CSStatsTracker.Entities;
using CSStatsTracker.Entities.MatchRelated;
using System.Net.Http;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace CSStatsTracker.Services.LastMatch
{
    public class LastMatchService : ILastMatchService
    {
        private readonly HttpClient _httpClient;
        public LastMatchService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FaceitClient");
        }
        public async Task<MatchItem> GetLastMatchInfoAsync(Guid playerId)
        {
            var url = $"players/{playerId}/history?game=cs2&limit=1";

            var response = await _httpClient.GetFromJsonAsync<MatchHistoryResponse>(url);

            return response?.Items.FirstOrDefault() ?? new MatchItem();
        }
    }
}
