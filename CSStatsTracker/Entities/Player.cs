namespace CSStatsTracker.Entities
{
    public class Player
    {
        public Guid Player_Id { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }
        public string Country { get; set; }
        public Dictionary<string, GameStats> Games { get; set; }
        public List<Guid> Friends_Ids { get; set; }
        public GameStats CS2 => Games.ContainsKey("cs2") ? Games["cs2"] : null;
    }
}
