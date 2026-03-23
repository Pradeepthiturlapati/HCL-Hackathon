namespace SocialAppAPI.Models
{
    public class FriendRequest
    {
        public int RequestId { get; set; }

        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public string Status { get; set; } = "Pending";
        // Pending / Accepted / Rejected

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
