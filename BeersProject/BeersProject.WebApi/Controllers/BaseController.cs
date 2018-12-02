using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BeersProject.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? (_mediator = (IMediator) HttpContext.RequestServices.GetService(typeof(IMediator)));
    }
}
