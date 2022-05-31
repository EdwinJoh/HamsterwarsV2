using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using SharedHelpers;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Presentation.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAutService _autService;

        public AuthController(IAutService autService)
        {
            _autService = autService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var respons = await _autService.Register(
                new User
                {
                    Email = request.Email
                },
                request.Password);

            if (!respons.Success)
            {
                return BadRequest(respons);
            }
            return Ok(respons);
        }
        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var respons = await _autService.Login(request.Email, request.Password);
            if(!respons.Success)
            {
                return BadRequest(respons);
            }

            return Ok(respons);
        }


    }
}
