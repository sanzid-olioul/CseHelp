using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePatha { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
