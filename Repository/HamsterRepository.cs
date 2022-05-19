using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Hamster>> GetAllHamsters(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();
        public async Task<Hamster> GetHamster(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void CreateHamster(Hamster hamster) => Create(hamster);


        public async Task< IEnumerable<Hamster>> GetByIds(IEnumerable<int> ids, bool trackChanges) => // använd för att slumpa fram 2 hamstrar ?? random generation ??
           await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();
        
        public void DeleteHamster(Hamster hamster) => Delete(hamster);
    }
}
