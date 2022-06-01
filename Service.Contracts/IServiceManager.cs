namespace Service.Contracts;

public interface IServiceManager
{
    IHamsterService Hamster { get; }
    IMatchService Matches { get; }
}
