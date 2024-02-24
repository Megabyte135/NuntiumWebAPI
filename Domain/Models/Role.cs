using Domain.SeedWork;

namespace Domain.Models
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}
