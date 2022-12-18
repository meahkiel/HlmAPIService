using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMV.Application.LogSheets.Commands;
using PMV.Application.LogSheets.DTO;
using PMV.Application.LogSheets.Queries;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
public class LogSheetController : ApiBaseController
{
    public LogSheetController(IMediator mediator) : base(mediator)
    {
    }


    [HttpGet]
    public async Task<IActionResult> Index([FromQuery]  GetLogsheetsByStatus.Query query) {

        return HandleResult(await _mediator.Send(query));
    }

    [HttpGet("single")]
    public async Task<IActionResult> Single([FromQuery] GetSingleLogSheet.Query query) {
        
        return HandleResult(await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] LogSheetOpenRequest request) {
        
        
        var cmd = new CreateRecord.Command(request);

        return HandleResult(await _mediator.Send(cmd));
    }

    [HttpPost("full")]
    public async Task<IActionResult> CreateFull([FromBody] LogSheetRequest request) {

         var cmd = new CreateFullRecord.Command(request);

        return HandleResult(await _mediator.Send(cmd));

    }

    

    [HttpPost("close")]
    public async Task<IActionResult> Close([FromBody] LogSheetCloseRequest request) {

        var cmd = new ClosingRecord.Command(request);

        return HandleResult(await _mediator.Send(cmd));

    }



    [HttpPost("detail")]
    public async Task<IActionResult> CreateDetail([FromBody] LogSheetDetailRequest request) {
         
        if(!string.IsNullOrEmpty(request.Id)) {
            return HandleResult(await _mediator.Send(new UpdateDetailRecord.Command(request)));
        }
         
        return HandleResult(await _mediator.Send(new CreateDetailRecord.Command(request)));
        
    }


    [HttpPost("detail/update")]
    public async Task<IActionResult> UpdateDetail([FromBody] LogSheetDetailRequest request) {
         
        var cmd = new UpdateDetailRecord.Command(request);
        
        return HandleResult(await _mediator.Send(cmd));
    }


    [HttpGet("transaction-report")]
    public async Task<IActionResult> TransactionReport([FromQuery] GetLogSheetTransactionsReport.Query query) {
         
         return HandleResult(await _mediator.Send(query));
    }
}