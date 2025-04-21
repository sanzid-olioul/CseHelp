namespace CSEhelp.Entities
{
    public class Reaply
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public Guid CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
