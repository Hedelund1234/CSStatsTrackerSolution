namespace CSStatsTracker.Entities.MatchRelated
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }
        public string Type { get; set; }
        public List<MatchPlayer> Players { get; set; } = new();
    }
}
