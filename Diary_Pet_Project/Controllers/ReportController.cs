using Diary_Pet_Project.Domain.Dto.Report;
using Diary_Pet_Project.Domain.Interfaces.Services;
using Diary_Pet_Project.Domain.Result;
using Microsoft.AspNetCore.Mvc;

namespace Diary_Pet_Project.Api.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BaseResult<ReportDto>>> GetReport(long id)
        {
            var response = await _reportService.GetReportByIdAsync(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
