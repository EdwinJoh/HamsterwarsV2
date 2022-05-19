using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHamsterRepository
    {
        IEnumerable<Hamster> GetAllHamsters(bool trackChanges);
        Hamster GetHamster(int id, bool trackChanges);
        void CreateHamster(Hamster hamster);
    }
}
