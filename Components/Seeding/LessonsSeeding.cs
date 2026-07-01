using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.Components.Models;
namespace MP.Components.Seeding
{
    public class LessonsSeeding : IEntityTypeConfiguration<Lessons>
    {
        public void Configure(EntityTypeBuilder<Lessons> builder)
        {
            builder.HasData(
                new Lessons
                {
                    LessonID = 1,
                    LessonName = "Learning Number Recognition",
                    LessonLink = "https://play.unity.com/en/games/cb9c9d93-d188-45d0-9c0d-ff33257c0d08/learning-number-recognition",
                    Thumbnail = ["/Images/LessonThumbnail1.png"]
                });
        }
    }
}