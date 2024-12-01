using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Queries.QuoteQuery
{
    public class GetRandomQuoteQuery: IRequest<QuoteModel>
    {
    }
}
