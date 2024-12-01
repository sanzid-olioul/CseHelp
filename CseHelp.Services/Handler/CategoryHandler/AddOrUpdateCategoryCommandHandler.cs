using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Command.CategoryCommand;
using CseHelp.Services.Models;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.CategoryHandler
{
    public class AddOrUpdateCategoryCommandHandler : IRequestHandler<AddOrUpdateCategoryCommand, ResponseModel>
    {
        IRepository<Category> _categoryRepository;
        IMapper _mapper;

        public AddOrUpdateCategoryCommandHandler(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel> Handle(AddOrUpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Id != Guid.Empty)
                {
                    var category = _mapper.Map<Category>(request);
                    await _categoryRepository.Update(category);
                    await _categoryRepository.SaveChangesAsync();
                    return new ResponseModel { IsSuccess = true, Message = "Successfully updated Category." };
                }
                else
                {
                    var category = _mapper.Map<Category>(request);
                    await _categoryRepository.Insert(category);
                    await _categoryRepository.SaveChangesAsync();
                    return new ResponseModel { Id = category.Id, IsSuccess = true, Message = "Successfully saved Category." };
                }
            }
            catch { }

            return new ResponseModel { IsSuccess = false, Message = "Something went wrong, Please try again." };
        }
    }
}
