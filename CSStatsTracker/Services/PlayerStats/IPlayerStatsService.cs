using CSStatsTracker.Entities;

namespace CSStatsTracker.Services.PlayerStats
{
    public interface IPlayerStatsService
    {
        Task<Player> GetPlayerInfoAsync(string name);
    }
}
