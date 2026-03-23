namespace SocialAppAPI.Models
{
    
        public class User
        {
            public int UserId { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

            public string Role { get; set; } = "User"; // User/Admin

            public bool IsBlocked { get; set; } = false;

            public DateTime CreatedAt { get; set; } = DateTime.Now;
        }
    
}
