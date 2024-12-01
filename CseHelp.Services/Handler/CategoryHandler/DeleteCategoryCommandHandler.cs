using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Command.CategoryCommand;
using CseHelp.Services.Models;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.CategoryHandler
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, ResponseModel>
    {
        IRepository<Category> _categoryRepository;
        IMapper _mapper;

        public DeleteCategoryCommandHandler(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            if (request.Id != Guid.Empty)
            {
                var result = await _categoryRepository.Delete((Guid) request.Id);
                if(result == true)
                {
                    await _categoryRepository.SaveChangesAsync();
                    return new ResponseModel { IsSuccess = true, Message = "Successfully deleted Category" };
                }
            }

            return new ResponseModel { IsSuccess = false, Message = "Something went wrong!" };
        }
    }
}
