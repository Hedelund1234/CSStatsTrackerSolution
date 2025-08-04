namespace CSStatsTracker.Entities.MatchRelated
{
    public class MatchItem
    {
        public string Match_Id { get; set; }
        public string Game_Id { get; set; }
        public string Region { get; set; }
        public string Match_Type { get; set; }
        public string Game_Mode { get; set; }
        public int Max_Players { get; set; }
        public int Teams_Size { get; set; }
        public Teams Teams { get; set; }
        public List<Guid> Playing_Players { get; set; } = new();
        public string Competition_Id { get; set; }
        public string Competition_Name { get; set; }
        public string Competition_Type { get; set; }
        public string Organizer_Id { get; set; }
        public string Status { get; set; }
        public long Started_At { get; set; }
        public long Finished_At { get; set; }
        public MatchResults Results { get; set; }
        public string Faceit_Url { get; set; }
    }
}
