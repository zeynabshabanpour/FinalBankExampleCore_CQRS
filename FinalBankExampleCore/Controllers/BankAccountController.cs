using FinalBankExampleCore.Features.AccountFeatures.Command.TransferThreeAccount;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinalBankExampleCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BankAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("TransferMoney")]
        public IActionResult TransferMoney(MoneyTransferCommandModel transfermony)
        { 
            var result = _mediator.Send(transfermony);
            return Ok();
        }
    }
}
