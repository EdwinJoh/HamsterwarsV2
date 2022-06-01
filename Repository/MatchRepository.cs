using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using SharedHelpers.DataTransferObjects;

namespace Repository;
/// <summary>
/// this repository layer gets the matches / information from the database to return to the requester.
/// </summary>
public class MatchRepository : RepositoryBase<Matches>, IMatchRepository
{
    public MatchRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
    public async Task<IEnumerable<Matches>> GetAllMatchesAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Id)
        .ToListAsync();

    public async Task<Matches> GetMatchAsync(int id, bool trackChanges) =>
        await FindByCondition(m => m.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

    public async Task<IEnumerable<Matches>> GetMatchWinnersAsync(int id, bool trackChanges) =>
        await FindByCondition(m => m.WinnerId == id, trackChanges).ToListAsync();

    public async Task<IEnumerable<MatchHistoryDto>> GetAllHamsterMatches()
    {
        var list = await (from md in RepositoryContext.Matches
                          join winner in RepositoryContext.Hamsters on md.WinnerId equals winner.Id
                          join loser in RepositoryContext.Hamsters on md.LoserId equals loser.Id
                          select new MatchHistoryDto
                          {
                              Id = md.Id,
                              Winner = winner,
                              Loser = loser,
                          }).ToListAsync();
        return list;
    }
    public void CreateMatch(Matches match) => Create(match);
    public void DeleteMatch(Matches match) => Delete(match);
}
