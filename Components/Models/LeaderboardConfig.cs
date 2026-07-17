namespace MP.Components.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class LeaderboardConfig
{
    [Key]
    public int LeaderboardID { get; set; }

    public string? LeaderboardName { get; set; }
    public string? FirebaseUrl { get; set; }
    // Temporary data loaded from Firebase
    [NotMapped]
    public List<LeaderboardEntry> Scores { get; set; } = new();
}