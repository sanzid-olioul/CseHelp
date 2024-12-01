using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;
using CseHelp.Services.Repository;
using MediatR;

namespace CseHelp.Services.Command.CategoryCommand
{
    public class AddOrUpdateCategoryCommand: CategoryModel, IRequest<ResponseModel>
    {
    }
}
