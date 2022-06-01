using SharedHelpers.DataTransferObjects;

namespace Service.Contracts
{
    public interface IHamsterService
    {
        Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges);
        Task<HamsterDto> GetHamsterAsync(int id, bool trackChanges);
        Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster);
        Task DeleteHamsterAsync(int id, bool trackChanges);
        Task UpdateHamsterAsync(int id, HamsterForUpdateDto hamster, bool trackChanges);
        Task<HamsterDto> GetRandomHamsterAsync(bool trackChanges);
        Task<IEnumerable<HamsterDto>> GetTopFiveWinnersAsync(bool trackChanges);
        Task<IEnumerable<HamsterDto>> GetTopFiveLosersAsync(bool trackChanges);
    }
}
