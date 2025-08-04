using CSStatsTracker.Entities.MatchRelated;
using CSStatsTracker.Entities.MatchStatsRelated;

namespace CSStatsTracker.Services.LastMatchStats
{
    public interface ILastMatchStatsService
    {
        Task<Round> GetLastMatchStatsInfoAsync(string matchIdh);
    }
}
