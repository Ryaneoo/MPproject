namespace MP.Components.Models;

public class LeaderboardEntry
{
    public string? name { get; set; } 
    public string? playerName { get; set; }

    public string? initials { get; set; }
    public int score { get; set; }
    public string DisplayName =>
        !string.IsNullOrWhiteSpace(playerName) ? playerName :
        !string.IsNullOrWhiteSpace(name) ? name :
        !string.IsNullOrWhiteSpace(initials) ? initials :
        "KID";
}