using Microsoft.AspNetCore.Identity;

namespace CSEhelp.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string RollDescription { get; set; } = string.Empty;
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
