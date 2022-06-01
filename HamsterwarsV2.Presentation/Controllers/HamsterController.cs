using HamsterwarsV2.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Presentation.Controllers;

[Route("hamster")]
[ApiController]
public class HamsterController : ControllerBase
{
    private readonly IServiceManager _service;
    public HamsterController(IServiceManager serviceManager) => _service = serviceManager;

    /// <summary>
    /// gets all the hamsters from the Database and return them to the user / application
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetHamsters()
    {
        var hamsters = await _service.Hamster.GetAllHamstersAsync(trackChanges: false);
        return Ok(hamsters);
    }

    /// <summary>
    ///  Get one hamster from the database using an parameter íd.
    ///  GET /hamster/1
    /// </summary>

    [HttpGet("{id:int}", Name = "HamsterById")]
    public async Task<IActionResult> GetHamster(int id)
    {
        var hamster = await _service.Hamster.GetHamsterAsync(id, trackChanges: false);
        return Ok(hamster);
    }
    /// <summary>
    /// Create an hamster and saves it to the database
    /// POST /hamster
    /// </summary>

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateHamster([FromBody] HamsterForCreationDto hamster)
    {
        var createdHamster = await _service.Hamster.CreateHamsterAsync(hamster);
        return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
    }

    /// <summary>
    /// Delete one hamster from the application and database.
    /// DELETE /hamster/delete/1
    /// </summary>
    [HttpDelete("delete/{id:int}")]
    public async Task<IActionResult> DeleteHamster(int id)
    {
        await _service.Hamster.DeleteHamsterAsync(id, trackChanges: false);
        return NoContent();
    }

    /// <summary>
    /// Update an hamster in the system
    /// /PUT hamster/update/1
    /// </summary>
    [HttpPut("update/{id:int}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamster)
    {
        await _service.Hamster.UpdateHamsterAsync(id, hamster, trackChanges: true);
        return NoContent();
    }

    /// <summary>
    /// Get an random hamster from the database and return it.
    /// GET /hamster/random
    /// </summary>

    [HttpGet("random")]
    public async Task<IActionResult> GetRandomHamster()
    {
        var hamster = await _service.Hamster.GetRandomHamsterAsync(trackChanges: false);
        return Ok(hamster);
    }
}
