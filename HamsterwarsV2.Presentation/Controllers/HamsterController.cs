using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace HamsterwarsV2.Presentation.Controllers
{
    [Route("api/hamsters")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        private readonly IServiceManager _service;
        public HamsterController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetHamsters()
        {

            var hamsters = await _service.Hamster.GetAllHamstersAsync(trackChanges: false);
            return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name = "HamsterById")]
        public async Task<IActionResult> GetHamster(int id)
        {
            var hamster = await _service.Hamster.GetHamsterAsync(id, trackChanges: false);
            return Ok(hamster);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHamster([FromBody] HamsterForCreationDto hamster)
        {
            if (hamster is null)
                return BadRequest("HamsterForCreation object is null");
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdHamster = await _service.Hamster.CreateHamsterAsync(hamster);
            return CreatedAtRoute("HamsterById", new { id = createdHamster.id }, createdHamster);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            await _service.Hamster.DeleteHamsterAsync(id, trackChanges: false);
            return NoContent();
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamster)
        {
            if (hamster is null)
                return BadRequest("HamsterForUpdate object is null");
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

           await _service.Hamster.UpdateHamsterAsync(id, hamster, trackChanges: true);
            return NoContent();
        }

    }
}
