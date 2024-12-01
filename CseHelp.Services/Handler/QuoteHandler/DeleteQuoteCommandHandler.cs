using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Command.QuoteCommand;
using CseHelp.Services.Models;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.QuoteHandler
{
    public class DeleteQuoteCommandHandler : IRequestHandler<DeleteQuoteCommand, ResponseModel>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Quote> _quoteRepository;
        public DeleteQuoteCommandHandler(IRepository<Quote> quoteRepository, IMapper mapper)
        {
            _quoteRepository = quoteRepository;
            _mapper = mapper;
        }
        public async Task<ResponseModel> Handle(DeleteQuoteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if(request.Id != Guid.Empty)
                {
                    bool response = await _quoteRepository.Delete((Guid) request.Id);
                    if (response)
                    {
                        await _quoteRepository.SaveChangesAsync();
                        return new ResponseModel { IsSuccess = true, Message = "Successfully Deleted Item"};
                    }
                }
            }
            catch { }

            return new ResponseModel { IsSuccess = false, Message = "Something went wrong!" };
        }
    }
}
