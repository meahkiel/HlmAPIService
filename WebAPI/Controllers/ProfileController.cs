using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMV.PmvApiService.Application.Users;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    public class ProfileController : ApiBaseController
    {
        public ProfileController(IMediator mediator) : base(mediator)
        {


        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UserUpdate.Command cmd)
        {
            return HandleResult(await _mediator.Send(cmd));
        }
    }
}