using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public string Motive { get; set; }
        public string WrittingMotivation { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
