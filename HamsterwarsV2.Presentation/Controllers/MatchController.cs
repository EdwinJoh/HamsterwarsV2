using HamsterwarsV2.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Presentation.Controllers;

[Route("matches")]
[ApiController]
public class MatchController : ControllerBase
{
    private readonly IServiceManager _service;
    public MatchController(IServiceManager serviceManager) => _service = serviceManager;

    /// <summary>
    /// Get all the matches from the database.
    /// GET /matches
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetMatches()
    {
        var matches = await _service.Matches.GetAllMatchesAsync(trackChanges: false);
        return Ok(matches);
    }

    /// <summary>
    /// Get one match from the database and return it to the application / user.
    /// GET /matches/1
    /// </summary>
    [HttpGet("{id:int}", Name = "MatchById")]
    public async Task<IActionResult> GetMatch(int id)
    {
        var match = await _service.Matches.GetMatchAsync(id, trackChanges: false);
        return Ok(match);
    }

    /// <summary>
    /// Create an match and saves it to the database
    /// POST /matches
    /// </summary>
    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateMatch([FromBody] MatchForCreationDto match)
    {
        var createdMatch = await _service.Matches.CreateMatchAsync(match);
        return CreatedAtRoute("MatchById", new { id = createdMatch.Id }, createdMatch);
    }
    /// <summary>
    /// Delete an match using an parameter id
    /// DELETE /matches/delete/1
    /// </summary>
    [HttpDelete("delete/{id:int}")]
    public async Task<IActionResult> DeleteMatch(int id)
    {
        await _service.Matches.DeleteMatchAsync(id, trackChanges: false);
        return NoContent();
    }

    /// <summary>
    /// Get all the matches related to the id parameter posted in 
    /// GET /matches/matchWinners/1
    /// </summary>
    /// <returns>1: 1, 2 where 1 is the winner id and 2 is loser id </returns>
    [HttpGet("matchWinners{id:int}")]
    public async Task<IActionResult> GetMatchWinner(int id)
    {
        var matchwinners = await _service.Matches.GetMatchWinnersAsync(id, trackChanges: false);
        return Ok(matchwinners);
    }

    /// <summary>
    /// Gets top 5 winner hamster from the database deppending on the wins the hamster have.
    /// GET/matches/winners/
    /// </summary>
    [HttpGet("winners")]
    public async Task<IActionResult> GetTopFiveWinners()
    {
        var hamsters = await _service.Hamster.GetTopFiveWinnersAsync(trackChanges: false);
        return Ok(hamsters);

    }

    /// <summary>
    /// Gets top 5 loser hamster from the database deppending on the defeats the hamster have.
    ///  GET/matches/losers/
    /// </summary>
    [HttpGet("losers")]
    public async Task<IActionResult> GetTopFiveLosers()
    {
        var hamsters = await _service.Hamster.GetTopFiveLosersAsync(trackChanges: false);
        return Ok(hamsters);
    }

    /// <summary>
    /// Get all the hamsters that have matches, retrun an hamster object insteed of the matchobject.
    /// GET /matches/matchHamsters/
    /// </summary>
    [HttpGet("matchHamsters")]
    public async Task<IActionResult> GetMatchHamsters()
    {
        var matchHamsters = await _service.Matches.GetAllMatchHamsters();
        return Ok(matchHamsters);
    }
}
