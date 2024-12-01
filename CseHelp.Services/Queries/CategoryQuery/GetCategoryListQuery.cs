﻿using CseHelp.Services.Models;
using MediatR;

namespace CseHelp.Services.Queries.CategoryQuery
{
    public class GetCategoryListQuery:IRequest<List<CategoryModel>>
    {
    }
}
