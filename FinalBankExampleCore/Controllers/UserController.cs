using FinalBankExampleCore.Features.UserFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinalBankExampleCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;
        public UserController( IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(mediator.Send(new GetAllUserQueryModel()));

        }
    }
}
