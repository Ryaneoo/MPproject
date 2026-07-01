using System.ComponentModel.DataAnnotations;
namespace MP.Components.Models
{
    public class Lessons
    {
        [Key]
        public int LessonID { get; set; }
        [Required]

        public string? LessonName { get; set; }
        [Required]

        public string? LessonLink { get; set; }
        [Required]
        public List<string> Thumbnail { get; set; } = new List<string>();
    }
}