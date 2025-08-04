using CSStatsTracker.Entities.MatchRelated;

namespace CSStatsTracker.Entities.MatchStatsRelated
{
    public class Round
    {
        public string Best_Of { get; set; }
        public string? Competition_Id { get; set; }
        public string Game_Id { get; set; }
        public string Game_Mode { get; set; }
        public string Match_Id { get; set; }
        public string Match_Round { get; set; }
        public string Played { get; set; }
        public RoundStats Round_Stats { get; set; }
        public List<MatchStatsRelatedTeam> Teams { get; set; } = new();
    }
}
