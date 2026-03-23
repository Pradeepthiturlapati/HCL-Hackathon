namespace SocialAppAPI.Models
{

    public class Comment
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
            [ForeignKey("PostId")]
            public Post post { get; set; }
            [ForeignKey("UserId")]
            public User user { get; set; }
    }
}
