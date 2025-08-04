using CSStatsTracker.Entities;
using CSStatsTracker.Entities.MatchRelated;

namespace CSStatsTracker.Services.LastMatch
{
    public interface ILastMatchService
    {
        Task<MatchItem> GetLastMatchInfoAsync(Guid playerId);
    }
}
