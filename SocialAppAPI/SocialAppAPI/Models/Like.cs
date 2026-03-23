namespace SocialAppAPI.Models
{
    public class Like
    {
        public int LikeId { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("PostId")]
        public Post post { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }

    }
}
