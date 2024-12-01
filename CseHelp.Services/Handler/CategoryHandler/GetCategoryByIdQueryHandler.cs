using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;
using CseHelp.Services.Queries.CategoryQuery;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.CategoryHandler
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery,CategoryModel>
    {
        IRepository<Category> _categoryRepository;
        IMapper _mapper;

        public GetCategoryByIdQueryHandler(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryModel> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != Guid.Empty)
            {
                try
                {
                    var category = await _categoryRepository.GetByIdAsync(request.Id);
                    if (category != null)
                    {
                        return _mapper.Map<CategoryModel>(category);
                    }
                }
                catch { }
            }

            return new CategoryModel();
        }
    }
}
