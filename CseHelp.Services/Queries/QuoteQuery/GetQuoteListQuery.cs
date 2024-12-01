using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Queries.QuoteQuery
{
    public class GetQuoteListQuery: IRequest<List<QuoteModel>>
    {
    }
}
