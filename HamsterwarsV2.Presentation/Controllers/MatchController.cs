using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterwarsV2.Presentation.Controllers
{
    [Route("matches")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IServiceManager _service;
        public MatchController(IServiceManager serviceManager) =>_service = serviceManager;
        

        [HttpGet]
        public async Task<IActionResult> GetMatches([FromQuery] MatchParameters matchParameters)
        {
            var matches = await _service.Matches.GetAllMatchesAsync(matchParameters,trackChanges: false);
            return Ok(matches);
        }
    }
}
