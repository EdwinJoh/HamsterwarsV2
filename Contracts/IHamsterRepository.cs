using Entities.Models;

namespace Contracts;

public interface IHamsterRepository
{
    Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges);
    Task<Hamster> GetHamsterAsync(int id, bool trackChanges);
    void CreateHamster(Hamster hamster);
    void DeleteHamster(Hamster hamster);
    Task<Hamster> GetRandomHamster(int id, bool trackChanges);
    Task<ICollection<Hamster>> GetHamsterbyIdsAsync(bool trackChanges);
}
