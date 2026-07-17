using System.Net.Http.Json;
using MP.Components.Models;

public class FirebaseLeaderboardService
{
    private readonly HttpClient http;

    public FirebaseLeaderboardService(HttpClient http)
    {
        this.http = http;
    }


    public async Task<List<LeaderboardEntry>> GetLeaderboard(string firebaseURL)
    {
        var json = await http.GetStringAsync(firebaseURL + "leaderboard.json");

        if (string.IsNullOrWhiteSpace(json) || json == "null")
        {
            return new List<LeaderboardEntry>();
        }


        // Try dictionary format
        if (json.StartsWith("{"))
        {
            var dictionary = System.Text.Json.JsonSerializer.Deserialize
                <Dictionary<string, LeaderboardEntry>>(json);

            return dictionary?.Values
                .OrderByDescending(x => x.score)
                .Take(5)
                .ToList()
                ?? new List<LeaderboardEntry>();
        }


        // Try array format
        if (json.StartsWith("["))
        {
            var list = System.Text.Json.JsonSerializer.Deserialize
                <List<LeaderboardEntry>>(json);

            return list?
                .OrderByDescending(x => x.score)
                .Take(5)
                .ToList()
                ?? new List<LeaderboardEntry>();
        }


        return new List<LeaderboardEntry>();
    }
}