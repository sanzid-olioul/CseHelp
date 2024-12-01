using CseHelp.Services.Models;

namespace CseHelp.Web.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public QuoteModel Quote { get; set; } = new();


    }
}
