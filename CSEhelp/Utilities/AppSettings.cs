using NuGet.Configuration;

namespace CSEhelp.Utilities
{
    public static class AppSettings
    {
        public static Settings Settings { get; set; } = new();
    }
    public class Settings
    {
        public string ConnectionString { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
    }
}
