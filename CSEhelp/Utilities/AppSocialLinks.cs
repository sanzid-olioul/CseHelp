namespace CSEhelp.Utilities
{
    public static class AppSocialLinks
    {
        public static SocialLinks Values { get; set; } = new();
    }

    public class SocialLinks
    {
        public string Facebook { get; set; }
        public string Github { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Google { get; set; }
    }
}
