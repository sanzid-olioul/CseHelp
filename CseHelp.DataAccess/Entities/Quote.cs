using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class Quote
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(1000,ErrorMessage = "Article Length Can't be more than 1000 character")]
        public string Text { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Article Length Can't be more than 1000 character")]
        public string Author { get; set; }
    }
}
