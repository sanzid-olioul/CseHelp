using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CseHelp.Web.Controllers
{
    public class BaseController : Controller
    {
        private IMediator _mediator;
        protected IMediator _mediatr => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
