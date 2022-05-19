using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> GetAllHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges);       
        Task<Hamster> GetHamsterAsync(int id, bool trackChanges);
        void CreateHamster(Hamster hamster);
        void DeleteHamster(Hamster hamster);
        Task<Hamster> GetRandomHamster(int id, bool trackChanges);
    }
}
