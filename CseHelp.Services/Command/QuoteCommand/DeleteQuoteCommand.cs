using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Command.QuoteCommand
{
    public class DeleteQuoteCommand : QuoteModel , IRequest<ResponseModel>
    {
    }
}
