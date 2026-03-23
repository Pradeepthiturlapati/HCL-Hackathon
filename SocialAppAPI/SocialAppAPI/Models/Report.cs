using System.ComponentModel.DataAnnotations.Schema;

namespace SocialAppAPI.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        public int ReportedUserId { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; } = "Pending";
        // Pending / Reviewed / Resolved

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ForeignKey("ReportedUserId")]
        public User reportedUser { get; set; }
    }
}
