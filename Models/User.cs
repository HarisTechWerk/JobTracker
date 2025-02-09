using Microsoft.AspNetCore.Identity;

namespace JobTracker.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; }

    }
}
