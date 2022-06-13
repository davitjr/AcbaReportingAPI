using AutoMapper;
using AcbaReportsApi.Application.DTOs.Report;
using AcbaReportsApi.Infrastructure.ServiceDTOs.AcbaReports;
using AcbaReportsApi.Infrastructure.Services.Template;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using AcbaReportsApi.Filters;
using System;

namespace AcbaReportsApi.Controllers
{
    [EnableCors("MyCors")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AcbaReportsController : ControllerBase
    {
        public AcbaReportsController(IAcbaReportsService AcbaReportsApiService, IMapper mapper)
        {
            _AcbaReportsApiService = AcbaReportsApiService;
            _mapper = mapper;
        }
        private readonly IAcbaReportsService _AcbaReportsApiService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Get Data From External Api
        /// </summary>
        /// <returns></returns>
        /// <response code="200">The request has succeeded.</response>
        /// <response code="400">The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).</response>
        /// <response code="401">The request has not been applied because it lacks valid authentication credentials for the target resource.</response>
        /// <response code="500">The server encountered an unexpected condition that prevented it from fulfilling the request.</response>     
        [HttpPost]
        [ProducesResponseType(typeof(SSRSResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        
        public async Task<IActionResult> GetReportRequestAsync([FromBody] SSRSRequest request)
        {
            ServiceSSRSResponse AcbaReportsApiOrder = await _AcbaReportsApiService.GetReportRequestAsync(request);
            SSRSResponse response = _mapper.Map<ServiceSSRSResponse, SSRSResponse>(AcbaReportsApiOrder);
            return Ok(response);
        }
    }
}
