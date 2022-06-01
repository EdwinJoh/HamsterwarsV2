using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IHamsterService> _hamsterService;
    private readonly Lazy<IMatchService> _matchService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
    logger, IMapper mapper)
    {
        _hamsterService = new Lazy<IHamsterService>(() =>
           new HamsterService(repositoryManager, logger, mapper));
        _matchService = new Lazy<IMatchService>(() =>
           new MatchSevice(repositoryManager, logger, mapper));
    }

    public IHamsterService Hamster => _hamsterService.Value;
    public IMatchService Matches => _matchService.Value;
}
