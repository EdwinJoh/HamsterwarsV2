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
        public IActionResult GetHamsters()
        {

            var hamsters = _service.Hamster.GetAllHamsters(trackChanges: false);
            return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name ="HamsterById")]
        public IActionResult GetHamster(int id)
        {
            var hamster = _service.Hamster.GetHamster(id, trackChanges: false);
            return Ok(hamster);
        }

        [HttpPost]
        public IActionResult CreateHamster([FromBody] HamsterForCreationDto hamster)
        {
            if (hamster is null)
                return BadRequest("HamsterForCreation object is null");

            var createdHamster = _service.Hamster.CreateHamster(hamster);
            return CreatedAtRoute("HamsterById", new { id = createdHamster.id }, createdHamster);
        }
    }
}
