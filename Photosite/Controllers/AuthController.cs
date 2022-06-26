using MediatR;
using Microsoft.AspNetCore.Mvc;
using Photosite.BLL.DTO.Auth;

namespace Photosite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController: BaseController
    {
        public AuthController(IMediator mediator): base(mediator) { }

        [HttpPost]
        public async Task Login(LoginCommand command)
        {
            var token = await _mediator.Send(command);
            if(!string.IsNullOrEmpty(token))
            {
                Response.Cookies.Append("Authorization", token);
            };
        } // Login
    }
}
