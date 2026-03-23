using System.ComponentModel.DataAnnotations.Schema;

namespace SocialAppAPI.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public int UserId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ForeignKey("UserId")]
        public User user { get; set; }
    }

}
