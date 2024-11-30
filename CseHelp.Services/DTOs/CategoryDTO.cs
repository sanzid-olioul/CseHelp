namespace CseHelp.Services.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePatha { get; set; }
        public virtual ICollection<SubCategoryDTO> SubCategories { get; set; }
    }
}
