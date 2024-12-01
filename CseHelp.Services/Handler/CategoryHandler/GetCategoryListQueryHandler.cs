using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;
using CseHelp.Services.Queries.CategoryQuery;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Handler.CategoryHandler
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<CategoryModel>>
    {
        IRepository<Category> _categoryRepository;
        IMapper _mapper;

        public GetCategoryListQueryHandler(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryModel>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var allCategory = await _categoryRepository.GetAllAsync();
                return _mapper.Map<List<CategoryModel>>(allCategory);
            }
            catch { }

            return new List<CategoryModel>();
        }
    }
}
