namespace CSStatsTracker.Entities.MatchStatsRelated
{
    public class MatchStatsRelatedTeam
    {
        public string Team_Id { get; set; }
        public bool Premade { get; set; }
        public TeamStats Team_Stats { get; set; }
        public List<MatchStatsPlayer> Players { get; set; } = new();
    }
}
