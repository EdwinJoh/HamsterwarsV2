using Contracts;

namespace Repository;
/// <summary>
/// WE use this class to manage the repository layer in our api.
/// </summary>
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
