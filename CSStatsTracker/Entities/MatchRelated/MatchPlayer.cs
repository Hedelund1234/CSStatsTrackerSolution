namespace CSStatsTracker.Entities.MatchRelated
{
    public class MatchPlayer
    {
        public Guid Player_Id { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }
        public int Skill_Level { get; set; }
        public string Game_Player_Id { get; set; }
        public string Game_Player_Name { get; set; }
        public string Faceit_Url { get; set; }
    }
}
