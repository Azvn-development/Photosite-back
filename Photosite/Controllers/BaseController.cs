using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Photosite.Controllers
{
    public abstract class BaseController: Controller
    {
        protected IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        } // BaseController
    }
}
