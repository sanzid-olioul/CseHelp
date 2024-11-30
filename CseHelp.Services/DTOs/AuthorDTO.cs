using CseHelp.Models.Entities;

namespace CseHelp.Services.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public string Motive { get; set; }
        public string WrittingMotivation { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
