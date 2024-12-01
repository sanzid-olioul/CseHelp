using System.ComponentModel.DataAnnotations;

namespace CseHelp.Services.Models
{
    public class QuoteModel
    {
        public Guid ?Id { get; set; } = Guid.Empty;
        [Required]
        [MaxLength(1000, ErrorMessage = "Article Length Can't be more than 1000 character")]
        public string ?Text { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Article Length Can't be more than 1000 character")]
        public string ?Author { get; set; }
    }
}
