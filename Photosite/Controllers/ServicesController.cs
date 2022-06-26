using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Photosite.BLL.DTO.Services;

namespace Photosite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController: BaseController
    {
        public ServicesController(IMediator mediator): base(mediator) { }

        [HttpGet]
        public async Task<GetServicesResponse> GetAll()
        {
            return await _mediator.Send(new GetServicesQuery());
        } // GetAll

        [HttpPost]
        [Authorize]
        public async Task<CreateServiceResponse> Create(CreateServiceCommand command)
        {
            return await _mediator.Send(command);
        } // Create

        [HttpPut]
        [Authorize]
        public async Task<UpdateServiceResponse> Update(UpdateServiceCommand command)
        {
            return await _mediator.Send(command);
        } // Update

        [HttpDelete]
        [Authorize]
        public async Task<long> Delete(DeleteServiceCommand command)
        {
            return await _mediator.Send(command);
        } // Delete
    }
}
