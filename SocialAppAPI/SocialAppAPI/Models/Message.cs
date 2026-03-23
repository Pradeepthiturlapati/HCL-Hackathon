using System.ComponentModel.DataAnnotations.Schema;

namespace SocialAppAPI.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        
        public  int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public string MessageText { get; set; }

        public DateTime SentAt { get; set; } = DateTime.Now;
        [ForeignKey("SenderId")]    
        public User sender  { get; set; }

        [ForeignKey("ReceiverId")]
        public User receiver { get; set; }
    }
}
