using System.ComponentModel.DataAnnotations;
namespace MP.Components.Models
{
    public class Games
    {
        [Key]
        public int GameID { get; set;  }
        [Required]

        public string? GameName { get; set; }
        [Required]

        public string? GameLink { get; set; }
        [Required]
        public List<string> Thumbnail {  get; set; } = new List<string>();
    }
}
