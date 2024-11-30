using CseHelp.Services.DTOs;

namespace CseHelp.Services.Interfaces
{
    public interface IQuoteRepository
    {
        Task<QuoteDTO> GetQuoteById(int id);
        Task<IEnumerable<QuoteDTO>> GetAllQuote(int pageNo = 1, int pageSize = 10);
        Task<IEnumerable<QuoteDTO>> FilterQuoteByAuthor(string author);
        Task AddQuote(QuoteDTO quote);
        void UpdateQuote(QuoteDTO quote);
        void DeleteQuote(int id);
    }
}
