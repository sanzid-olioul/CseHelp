using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;
using CseHelp.Services.Queries.QuoteQuery;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.QuoteHandler
{
    public class GetQuoteListQueryHandler : IRequestHandler<GetQuoteListQuery, List<QuoteModel>>
    {
        private IRepository<Quote> _quoteRepository;
        private IMapper _mapper;
        public GetQuoteListQueryHandler(IRepository<Quote> quoteRepository, IMapper mapper)
        {
            _quoteRepository = quoteRepository;
            _mapper = mapper;
        }
        public async Task<List<QuoteModel>> Handle(GetQuoteListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var quoteList = await _quoteRepository.GetAllAsync();
                return _mapper.Map<List<QuoteModel>>(quoteList);
            }
            catch 
            {
                return new();
            }
        }
    }
}
