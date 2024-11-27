using CseHelp.Web.Utilities;

namespace CseHelp.Web.ViewModels
{
    public class BaseViewModel
    {
        public Links Links { get; set; } = SocialLinks.Values;
    }
}
