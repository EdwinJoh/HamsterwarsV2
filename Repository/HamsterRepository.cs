using Contracts;
using Entities.Models;
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
        public IEnumerable<Hamster> GetAllHamsters(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
        public Hamster GetHamster(int id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefault();
        public void CreateHamster(Hamster hamster) => Create(hamster);
    }
}
