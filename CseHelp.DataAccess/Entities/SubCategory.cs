using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class SubCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Article> Articles { get;set; }

    }
}
