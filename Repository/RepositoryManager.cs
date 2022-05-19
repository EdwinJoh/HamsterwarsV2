using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IHamsterRepository> _hamsterRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _hamsterRepository = new Lazy<IHamsterRepository>(() => new
            HamsterRepository(repositoryContext));

        }

        public IHamsterRepository Hamster => _hamsterRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
