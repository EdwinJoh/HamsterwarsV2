using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MatchRepository : RepositoryBase<Matches>, IMatchRepository
    {
        public MatchRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Matches>> GetAllMatchesAsync(MatchParameters matchParameters ,bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .Skip((matchParameters.PageNumber - 1) * matchParameters.PageSize)
            .Take(matchParameters.PageSize)
            .ToListAsync();


        public async Task<Matches> GetMatchAsync(int id, bool trackChanges) =>
            await FindByCondition(m => m.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        
        public void CreateMatch(Matches match) => Create(match);
        public void DeleteMatch(Matches match) => Delete(match);
    }
}
