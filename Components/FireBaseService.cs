using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
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
        if (string.IsNullOrWhiteSpace(firebaseURL))
        {
            return new List<LeaderboardEntry>();
        }

        // 1. Clean URL and check if endpoint is already provided
        string targetUrl = firebaseURL.Trim();

        if (!targetUrl.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
        {
            targetUrl = targetUrl.TrimEnd('/') + "/leaderboard.json";
        }

        try
        {
            // 2. Fetch raw JSON string from Firebase
            var json = await http.GetStringAsync(targetUrl);

            if (string.IsNullOrWhiteSpace(json) || json == "null")
            {
                return new List<LeaderboardEntry>();
            }

            json = json.Trim();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // 3. Try dictionary/object format: { "-N123": { "name": "AAA", "score": 100 } }
            if (json.StartsWith("{"))
            {
                var dictionary = JsonSerializer.Deserialize<Dictionary<string, LeaderboardEntry>>(json, options);

                return dictionary?.Values
                    .Where(x => x != null)
                    .OrderByDescending(x => x.score)
                    .Take(5)
                    .ToList()
                    ?? new List<LeaderboardEntry>();
            }

            // 4. Try array/list format: [ { "name": "AAA", "score": 100 }, ... ]
            if (json.StartsWith("["))
            {
                var list = JsonSerializer.Deserialize<List<LeaderboardEntry>>(json, options);

                return list?
                    .Where(x => x != null)
                    .OrderByDescending(x => x.score)
                    .Take(5)
                    .ToList()
                    ?? new List<LeaderboardEntry>();
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Firebase Request Error: {ex.Message}");
            return new List<LeaderboardEntry>();
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON Parsing Error: {ex.Message}");
            return new List<LeaderboardEntry>();
        }

        return new List<LeaderboardEntry>();
    }
}