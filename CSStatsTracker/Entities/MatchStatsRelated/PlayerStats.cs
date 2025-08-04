using System.Text.Json.Serialization;

namespace CSStatsTracker.Entities.MatchStatsRelated
{
    public class PlayerStats
    {
        [JsonPropertyName("ADR")]
        public string ADR { get; set; }

        [JsonPropertyName("Result")]
        public string Result { get; set; }

        [JsonPropertyName("1v2Count")]
        public string? _1v2Count { get; set; }

        [JsonPropertyName("Utility Damage Success Rate per Match")]
        public string? UtilityDamageSuccessRatePerMatch { get; set; }

        [JsonPropertyName("Pistol Kills")]
        public string? PistolKills { get; set; }

        [JsonPropertyName("Utility Enemies")]
        public string? UtilityEnemies { get; set; }

        [JsonPropertyName("Knife Kills")]
        public string? KnifeKills { get; set; }

        [JsonPropertyName("1v2Wins")]
        public string? _1v2Wins { get; set; }

        [JsonPropertyName("Clutch Kills")]
        public string? ClutchKills { get; set; }

        [JsonPropertyName("Flashes per Round in a Match")]
        public string? FlashesPerRoundInAMatch { get; set; }

        [JsonPropertyName("Sniper Kill Rate per Round")]
        public string? SniperKillRatePerRound { get; set; }

        [JsonPropertyName("MVPs")]
        public string? MVPs { get; set; }

        [JsonPropertyName("Utility Damage")]
        public string? UtilityDamage { get; set; }

        [JsonPropertyName("Quadro Kills")]
        public string? QuadroKills { get; set; }

        [JsonPropertyName("Utility Success Rate per Match")]
        public string? UtilitySuccessRatePerMatch { get; set; }

        [JsonPropertyName("Sniper Kill Rate per Match")]
        public string? SniperKillRatePerMatch { get; set; }

        [JsonPropertyName("Sniper Kills")]
        public string? SniperKills { get; set; }

        [JsonPropertyName("Flash Successes")]
        public string? FlashSuccesses { get; set; }

        [JsonPropertyName("Damage")]
        public string? Damage { get; set; }

        [JsonPropertyName("1v1Count")]
        public string? _1v1Count { get; set; }

        [JsonPropertyName("Headshots")]
        public string? Headshots { get; set; }

        [JsonPropertyName("Assists")]
        public string? Assists { get; set; }

        [JsonPropertyName("K/R Ratio")]
        public string? KRRatio { get; set; }

        [JsonPropertyName("Utility Count")]
        public string? UtilityCount { get; set; }

        [JsonPropertyName("K/D Ratio")]
        public string? KDRatio { get; set; }

        [JsonPropertyName("Kills")]
        public string? Kills { get; set; }

        [JsonPropertyName("Deaths")]
        public string? Deaths { get; set; }

        [JsonPropertyName("Headshots %")]
        public string? HeadshotsPercent { get; set; }

        [JsonPropertyName("First Kills")]
        public string? FirstKills { get; set; }

        [JsonPropertyName("Entry Wins")]
        public string? EntryWins { get; set; }

        [JsonPropertyName("Enemies Flashed")]
        public string? EnemiesFlashed { get; set; }

        [JsonPropertyName("Match 1v1 Win Rate")]
        public string? Match1v1WinRate { get; set; }

        [JsonPropertyName("Flash Count")]
        public string? FlashCount { get; set; }

        [JsonPropertyName("Flash Success Rate per Match")]
        public string? FlashSuccessRatePerMatch { get; set; }

        [JsonPropertyName("Penta Kills")]
        public string? PentaKills { get; set; }

        [JsonPropertyName("Utility Successes")]
        public string? UtilitySuccesses { get; set; }

        [JsonPropertyName("Zeus Kills")]
        public string? ZeusKills { get; set; }

        [JsonPropertyName("Utility Damage per Round in a Match")]
        public string? UtilityDamagePerRoundInAMatch { get; set; }

        [JsonPropertyName("Double Kills")]
        public string? DoubleKills { get; set; }

        [JsonPropertyName("Match Entry Rate")]
        public string? MatchEntryRate { get; set; }

        [JsonPropertyName("Match Entry Success Rate")]
        public string? MatchEntrySuccessRate { get; set; }

        [JsonPropertyName("Triple Kills")]
        public string? TripleKills { get; set; }

        [JsonPropertyName("1v1Wins")]
        public string? _1v1Wins { get; set; }

        [JsonPropertyName("Match 1v2 Win Rate")]
        public string? Match1v2WinRate { get; set; }

        [JsonPropertyName("Enemies Flashed per Round in a Match")]
        public string? EnemiesFlashedPerRoundInAMatch { get; set; }

        [JsonPropertyName("Utility Usage per Round")]
        public string? UtilityUsagePerRound { get; set; }

        [JsonPropertyName("Entry Count")]
        public string? EntryCount { get; set; }
    }
}
