using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Core;

namespace WebAPI.Controllers
{
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected IMediator _mediator;

        public ApiBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null) return NotFound();
            if (result.IsSuccess && result.Data != null)
                return Ok(result.Data);
            if (result.IsSuccess && result.Data == null)
                return NotFound();
            
            return BadRequest(result.Message);
        }
    }
}