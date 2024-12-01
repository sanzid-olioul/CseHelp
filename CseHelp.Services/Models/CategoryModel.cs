using CseHelp.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace CseHelp.Services.Models
{
    public class CategoryModel
    {
        public Guid? Id { get; set; } = Guid.Empty;
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePatha { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
