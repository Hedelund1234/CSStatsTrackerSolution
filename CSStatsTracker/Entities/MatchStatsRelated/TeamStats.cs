using System.Text.Json.Serialization;

namespace CSStatsTracker.Entities.MatchStatsRelated
{
    public class TeamStats
    {
        [JsonPropertyName("Team")]
        public string Team { get; set; }

        [JsonPropertyName("Team Headshots")]
        public string TeamHeadshots { get; set; }

        [JsonPropertyName("Overtime score")]
        public string OvertimeScore { get; set; }

        [JsonPropertyName("Second Half Score")]
        public string SecondHalfScore { get; set; }

        [JsonPropertyName("Team Win")]
        public string TeamWin { get; set; }

        [JsonPropertyName("Final Score")]
        public string FinalScore { get; set; }

        [JsonPropertyName("First Half Score")]
        public string FirstHalfScore { get; set; }
    }
}
