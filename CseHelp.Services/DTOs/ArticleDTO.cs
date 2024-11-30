namespace CseHelp.Services.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorDTO? Author { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategoryDTO? SubCategory { get; set; }
    }
}
