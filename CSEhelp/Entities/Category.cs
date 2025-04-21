namespace CSEhelp.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Topic> Topics { get; set; }
    }
}
