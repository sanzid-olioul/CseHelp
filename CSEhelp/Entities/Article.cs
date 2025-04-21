namespace CSEhelp.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid AuthorId { get; set; }
        public AppUser Author { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
