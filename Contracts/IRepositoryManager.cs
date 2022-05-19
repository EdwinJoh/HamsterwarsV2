using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IHamsterRepository Hamster { get; }
        IMatchRepository Matches { get; }
        Task SaveAsync();
    }
}
