using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Command.CategoryCommand
{
    public class DeleteCategoryCommand:CategoryModel, IRequest<ResponseModel>
    {
    }
}
