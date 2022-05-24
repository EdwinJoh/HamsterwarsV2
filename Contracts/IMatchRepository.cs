using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMatchRepository
    {
        Task<IEnumerable<Matches>> GetAllMatchesAsync(MatchParameters parameters ,bool trackChanges);
        Task<Matches> GetMatchAsync(int id,bool trackChanges);
        void CreateMatch(Matches match);
        void DeleteMatch(Matches match);
        Task<IEnumerable<Matches>>GetMatchWinnersAsync(int id,bool trackChanges);
        
        
        
    }
}
