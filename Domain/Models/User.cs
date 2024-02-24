using Domain.SeedWork;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Models
{
    public class User : IdentityUser
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}