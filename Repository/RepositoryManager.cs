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
        private readonly Lazy<IMatchRepository> _matchRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _hamsterRepository = new Lazy<IHamsterRepository>(() => new
            HamsterRepository(repositoryContext)); 
            
            _matchRepository = new Lazy<IMatchRepository>(() => new
            MatchRepository(repositoryContext));

        }

        public IHamsterRepository Hamster => _hamsterRepository.Value;
        public IMatchRepository Matches => _matchRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
