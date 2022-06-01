using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;
/// <summary>
/// This repository layer is sending request to the database to get our hmasters to the requester.
/// </summary>
public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
{
    public HamsterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Id)
        .ToListAsync();

    public async Task<Hamster> GetHamsterAsync(int id, bool trackChanges) =>
        await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

    public async Task<Hamster> GetRandomHamster(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

    public async Task<ICollection<Hamster>> GetHamsterbyIdsAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .ToListAsync();


    public void CreateHamster(Hamster hamster) => Create(hamster);

    public void DeleteHamster(Hamster hamster) => Delete(hamster);
}
