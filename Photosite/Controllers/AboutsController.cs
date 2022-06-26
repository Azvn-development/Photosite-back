using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Photosite.BLL.DTO.Abouts;

namespace Photosite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutsController: BaseController
    {

        public AboutsController(IMediator mediator): base(mediator) { }

        [HttpGet]
        public async Task<GetAboutsResponse> GetAll()
        {
            return await _mediator.Send(new GetAboutsQuery());
        } // GetAll

        [HttpPost]
        [Authorize]
        public async Task<long> Create(CreateAboutCommand command)
        {
            return await _mediator.Send(command);
        } // Create

        [HttpPut]
        [Authorize]
        public async Task<long> Edit(UpdateAboutCommand command)
        {
            return await _mediator.Send(command);
        } // Edit

        [HttpDelete]
        [Authorize]
        public async Task<long> Delete(DeleteAboutCommand command)
        {
            return await _mediator.Send(command);
        } // Delete
    }
}
