using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMV.PmvApiService.Application.DTO.Login;
using PMV.PmvApiService.Application.Users;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthRequest authRequest) {

            var result = await _mediator.Send(new UserLogin.Query(authRequest));
            
            return Ok(result.Data);
        }
    }
}