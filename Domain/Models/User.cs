using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class User : IdentityUser
    {
        public List<Article> Articles { get; set; }
        public User() 
        {
            Articles = new List<Article>();
        }
    }
}
