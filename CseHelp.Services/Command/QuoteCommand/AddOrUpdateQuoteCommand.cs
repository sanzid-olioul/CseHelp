using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Command.QuoteCommand
{
    public class AddOrUpdateQuoteCommand: QuoteModel , IRequest<ResponseModel>
    {
    }
}
