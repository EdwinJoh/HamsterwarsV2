using Entities.Models;
using SharedHelpers.DataTransferObjects;

namespace Contracts
{
    public interface IMatchRepository
    {
        Task<IEnumerable<Matches>> GetAllMatchesAsync(bool trackChanges);
        Task<Matches> GetMatchAsync(int id, bool trackChanges);
        void CreateMatch(Matches match);
        void DeleteMatch(Matches match);
        Task<IEnumerable<Matches>> GetMatchWinnersAsync(int id, bool trackChanges);
        Task<IEnumerable<MatchHistoryDto>> GetAllHamsterMatches();
    }
}
