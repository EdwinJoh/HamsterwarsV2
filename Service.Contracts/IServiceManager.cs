using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IHamsterService Hamster { get; }
    }
}
// TODO: where we will hold the definitions for the service interfaces that are going to encapsulate the main business logic.