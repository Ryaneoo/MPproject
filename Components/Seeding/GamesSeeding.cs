using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.Components.Models;
namespace MP.Components.Seeding
{
    public class GamesSeeding : IEntityTypeConfiguration<Games> //need add after domingo UPLOAD GAME 
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder.HasData(
                new Games
                {
                    GameID = 1,
                    GameName = "Math Space Race",
                    GameLink = "https://play.unity.com/en/games/bd29b7bb-5721-4838-b924-f3f413c7a5bd/mp",
                    Thumbnail = ["/Images/GameThumbnail1.png"]
                });
        }
    }
}