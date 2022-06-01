using HamsterwarsV2.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;
using Shared.RequestFeatures;
using Microsoft.AspNetCore.Authorization;

namespace HamsterwarsV2.Presentation.Controllers
{
    [Route("hamster")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        private readonly IServiceManager _service;
        public HamsterController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        
        public async Task<IActionResult> GetHamsters()
        {
            var hamsters = await _service.Hamster.GetAllHamstersAsync( trackChanges: false);
            return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name = "HamsterById")]
        public async Task<IActionResult> GetHamster(int id)
        {
            var hamster = await _service.Hamster.GetHamsterAsync(id, trackChanges: false);
            return Ok(hamster);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]

        public async Task<IActionResult> CreateHamster([FromBody] HamsterForCreationDto hamster)
        {

            var createdHamster = await _service.Hamster.CreateHamsterAsync(hamster);
            return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
        }
        
        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            await _service.Hamster.DeleteHamsterAsync(id, trackChanges: false);
            return NoContent();
        }
        [HttpPut("update/{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamster)
        {
            await _service.Hamster.UpdateHamsterAsync(id, hamster, trackChanges: true);
            return NoContent();
        }
        [HttpGet("random")]
        public async Task<IActionResult> GetRandomHamster()
        {
            var hamster = await _service.Hamster.GetRandomHamsterAsync(trackChanges: false);
            return Ok(hamster);
        }

    }
}
