using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.Components.Models;
namespace MP.Components.Seeding
{
    public class LeaderboardSeeding : IEntityTypeConfiguration<LeaderboardConfig> //need add after domingo UPLOAD GAME 
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
                new LeaderboardConfig
                {
                    LeaderboardID = 3,
                    LeaderboardName = "Skip Counting Leaderboard",
                    FirebaseUrl = "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/"
                });
        }
    }
}