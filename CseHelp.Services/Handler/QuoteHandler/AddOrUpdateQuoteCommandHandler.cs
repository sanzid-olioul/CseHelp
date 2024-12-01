using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Command.QuoteCommand;
using CseHelp.Services.Models;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.QuoteHandler
{
    public class AddOrUpdateQuoteCommandHandler : IRequestHandler<AddOrUpdateQuoteCommand, ResponseModel>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Quote> _quoteRepository;
        public AddOrUpdateQuoteCommandHandler(IRepository<Quote> quoteRepository, IMapper mapper)
        {
            _quoteRepository = quoteRepository;
            _mapper = mapper;
        }
        public async Task<ResponseModel> Handle(AddOrUpdateQuoteCommand request, CancellationToken cancellationToken)
        {
            try{
                if (request.Id != Guid.Empty)
                {
                    var quote = _mapper.Map<Quote>(request);
                    await _quoteRepository.Update(quote);
                    await _quoteRepository.SaveChangesAsync();
                    return new ResponseModel { IsSuccess = true, Message = "Successfully updated Quote." };
                }
                else
                {
                    var quote = _mapper.Map<Quote>(request);
                    await _quoteRepository.Insert(quote);
                    await _quoteRepository.SaveChangesAsync();
                    return new ResponseModel { Id = quote.Id, IsSuccess = true, Message = "Successfully saved Quote." };
                }
            }
            catch { }
            
            return new ResponseModel{ IsSuccess = false, Message= "Something went wrong, Please try again." };
        }
    }
}
