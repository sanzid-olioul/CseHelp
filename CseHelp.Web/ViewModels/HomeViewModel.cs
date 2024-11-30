using CseHelp.Services.DTOs;

namespace CseHelp.Web.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public List<QuoteDTO> Quotes { get; set; } = new List<QuoteDTO>();


    }
}
