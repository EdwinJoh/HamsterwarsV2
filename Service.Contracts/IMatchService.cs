using SharedHelpers.DataTransferObjects;

namespace Service.Contracts;

public interface IMatchService
{
    Task<IEnumerable<MatchDto>> GetAllMatchesAsync(bool trackChanges);
    Task<MatchDto> GetMatchAsync(int id, bool trackChanges);

    Task<MatchDto> CreateMatchAsync(MatchForCreationDto match);
    Task DeleteMatchAsync(int id, bool trackChanges);
    Task<IEnumerable<MatchDto>> GetMatchWinnersAsync(int id, bool trackChanges);
    Task<IEnumerable<MatchHistoryDto>> GetAllMatchHamsters();

}
