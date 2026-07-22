using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.Components.Models;

namespace MP.Components.Seeding
{
    public class LeaderboardSeeding : IEntityTypeConfiguration<LeaderboardConfig>
    {
        public void Configure(EntityTypeBuilder<LeaderboardConfig> builder)
        {
            builder.HasData(
                new LeaderboardConfig
                {
                    LeaderboardID = 1,
                    LeaderboardName = "Math Space Game Leaderboard",
                    FirebaseUrl = "https://spacegame-745af-default-rtdb.asia-southeast1.firebasedatabase.app/"
                },
                new LeaderboardConfig
                {
                    LeaderboardID = 2,
                    LeaderboardName = "Counting Animals Leaderboard",
                    FirebaseUrl = "https://mpproject-ccebf-default-rtdb.asia-southeast1.firebasedatabase.app/"
                },
                // Skip Counting Sub-Modes
                new LeaderboardConfig
                {
                    LeaderboardID = 3,
                    LeaderboardName = "Skip Counting - 2s",
                    FirebaseUrl = "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_2s.json"
                },
                new LeaderboardConfig
                {
                    LeaderboardID = 4,
                    LeaderboardName = "Skip Counting - 5s",
                    FirebaseUrl = "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_5s.json"
                },
                new LeaderboardConfig
                {
                    LeaderboardID = 5,
                    LeaderboardName = "Skip Counting - 10s",
                    FirebaseUrl = "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_10s.json"
                },
                new LeaderboardConfig
                {
                    LeaderboardID = 6,
                    LeaderboardName = "Skip Counting - Everything",
                    FirebaseUrl = "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_random.json"
                }
            );
        }
    }
}