namespace CSEhelp.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public virtual IEnumerable<Reaply> Reaplies { get; set; }
    }
}
