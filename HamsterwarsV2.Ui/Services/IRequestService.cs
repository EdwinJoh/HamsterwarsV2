using Entities.Models;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Ui.Services;
/// <summary>
/// interfaces used to send request to the api from the clientside
/// </summary>
public interface IRequestService
{
    Task<IEnumerable<Hamster>> GetAllHamstersAsync();
    Task<IEnumerable<MatchHistoryDto>> GetAllMatchesAsync();
    Task RemoveObjectAsync<T>(string objType, int id);
    Task<Hamster> GetRandomHamsterAsync();
    Hamster GetMatchHamster(int id, IEnumerable<Hamster> hamsters);
    Task VotedHamsterAsync(int id, Hamster hamster, string status);
    Task<IEnumerable<Hamster>> GetWinnersAsync();
    Task<IEnumerable<Hamster>> GetLosersAsync();
    Task<Hamster> CreateHamster(Hamster hamster);
    Task<IEnumerable<Matches>> HamsterMatches(int id);
    Task CreateMatchAsync(int winnerId, int loserId);
}
