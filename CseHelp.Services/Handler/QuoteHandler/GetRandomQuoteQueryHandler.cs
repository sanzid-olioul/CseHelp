using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;
using CseHelp.Services.Queries.QuoteQuery;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.QuoteHandler
{
    public class GetRandomQuoteQueryHandler : IRequestHandler<GetRandomQuoteQuery, QuoteModel>
    {
        private IRepository<Quote> _quoteRepository;
        private readonly IMapper _mapper;

        public GetRandomQuoteQueryHandler(IRepository<Quote> repository , IMapper mapper)
        {
            _quoteRepository = repository;
            _mapper = mapper;
        }

        public async Task<QuoteModel> Handle(GetRandomQuoteQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var allQuote = await _quoteRepository.GetAllAsync();
                if (allQuote.Count > 0)
                {
                    int rnadomIndex = new Random().Next(allQuote.Count) - 1;
                    var quote = allQuote.Skip(rnadomIndex).FirstOrDefault();
                    return _mapper.Map<QuoteModel>(quote);
                }
            }
            catch { }

            return new QuoteModel();
        }
    }
}
