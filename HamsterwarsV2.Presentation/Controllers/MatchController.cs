using HamsterwarsV2.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace HamsterwarsV2.Presentation.Controllers
{
    [Route("matches")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IServiceManager _service;
        public MatchController(IServiceManager serviceManager) => _service = serviceManager;


        [HttpGet]
        public async Task<IActionResult> GetMatches()
        {
            var matches = await _service.Matches.GetAllMatchesAsync(trackChanges: false);
            return Ok(matches);
        }
        [HttpGet("{id:int}",Name ="MatchById")]
        public async Task<IActionResult>GetMatch(int id)
        {
            var match = await _service.Matches.GetMatchAsync(id, trackChanges: false);
            return Ok(match);
        }
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateMatch([FromBody] MatchForCreationDto match)
        {
            var createdMatch = await _service.Matches.CreateMatchAsync(match);
            return CreatedAtRoute("MatchById", new { id = createdMatch.Id }, createdMatch);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMatch(int id)
        {
            await _service.Matches.DeleteMatchAsync(id, trackChanges: false);
            return NoContent();
        }
    }
}
