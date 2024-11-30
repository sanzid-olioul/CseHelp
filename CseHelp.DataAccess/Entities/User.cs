using Microsoft.AspNetCore.Identity;

namespace CseHelp.Models.Entities
{
    public class User:IdentityUser
    {
        public string ImagePath { get; set; }
        public int AuthorId { get; set; }
        public Author ? Author {  get; set; }
    }
}
