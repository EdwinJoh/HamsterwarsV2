using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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
            try
            {
                var hamsters = _service.Hamster.GetAllHamsters(trackChanges: false);
                return Ok(hamsters);
            }
            catch 
            {

                return StatusCode(500, "Internal server error");
            }
        }
        
    }
}
