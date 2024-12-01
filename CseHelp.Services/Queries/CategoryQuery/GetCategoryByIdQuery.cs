using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Queries.CategoryQuery
{
    public class GetCategoryByIdQuery:IRequest<CategoryModel>
    {
        public Guid Id { get; set; } = Guid.Empty;
    }
}
