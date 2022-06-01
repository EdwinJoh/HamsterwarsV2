namespace Contracts;

public interface IRepositoryManager
{
    IHamsterRepository Hamster { get; }
    IMatchRepository Matches { get; }
    Task SaveAsync();
}
