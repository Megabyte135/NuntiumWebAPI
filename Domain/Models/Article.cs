using Domain.SeedWork;

namespace Domain.Models
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string PreviewText { get; set; } 
        public DateTime CreationDate { get; set; }
        public List<Category> Categories { get; set; }
        public Article()
        {
            Categories = new List<Category>();
        }
    }
}
