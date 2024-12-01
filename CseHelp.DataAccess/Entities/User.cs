using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CseHelp.Models.Entities
{
    public class User:IdentityUser
    {
        [Key]
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
    }
}
