using CseHelp.DataAccess;
using CseHelp.Services.DTOs;
using CseHelp.Models.Entities;
using CseHelp.Services.Interfaces;
using AutoMapper;

namespace CseHelp.Services.Services
{
    public class QuoteRepository : Repository<Quote>, IQuoteRepository
    {
        private readonly IMapper _mapper;
        public QuoteRepository(ApplicationDbContext dbContext,IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task AddQuote(QuoteDTO quote)  
        {
            var quoteEntity = _mapper.Map<Quote>(quote);
            await Create(quoteEntity);
        }

        public async Task DeleteQuote(int id)
        {
            var quote = await Get(q=>q.Id == id);
            if (quote != null)
            {
                Delete(quote);
            }
            else
            {
                throw new Exception("No Such Quote is found");
            }
        }

        public async Task<IEnumerable<QuoteDTO>> FilterQuoteByAuthor(string author)
        {
            var quotes = await Filter(q=>q.Author == author);
            return _mapper.Map<IEnumerable<QuoteDTO>>(quotes);
        }

        public async Task<IEnumerable<QuoteDTO>> GetAllQuote(int pageNo=1, int pageSize=10)
        {
            var quotes = await  GetAll(pageNo, pageSize);
            return _mapper.Map<IEnumerable<QuoteDTO>>(quotes);
        }

        public  async Task<QuoteDTO> GetQuoteById(int id)
        {
            var quote = await Get(q => q.Id == id);
            return _mapper.Map<QuoteDTO>(quote);
        }

        public void UpdateQuote(QuoteDTO quote)
        {
            if(quote.Id != 0)
            {
                var quoteEntity = _mapper.Map<Quote>(quote);
                Update(quoteEntity);
            }
            else
            {
                throw new Exception("Invalid Quote found");
            }
            
        }
    }
}
