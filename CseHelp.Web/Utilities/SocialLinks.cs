namespace CseHelp.Web.Utilities
{
    public static class SocialLinks
    {
        public static Links Values { get; set; } = new Links();
    }
    public class Links
    {
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Github { get; set; }
        public string? Youtybe { get; set; }
        public string? Linkedin { get; set; }
        public string? Leetcode { get; set; }
    }
}
