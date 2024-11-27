using CseHelp.Common.DTOs;
using CseHelp.Web.Utilities;

namespace CseHelp.Web.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public List<QuoteDto> Quotes { get; set; } = new List<QuoteDto>();

    }
}
