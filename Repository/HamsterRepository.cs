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
}
