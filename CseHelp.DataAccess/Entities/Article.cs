using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body {  get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
    }
}
