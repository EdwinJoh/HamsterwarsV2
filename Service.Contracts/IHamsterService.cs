using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IHamsterService
    {
        Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges);
        Task<HamsterDto> GetHamsterAsync(int id, bool trackChanges);
        Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster);
        Task DeleteHamsterAsync(int id, bool trackChanges);
        Task UpdateHamsterAsync(int id, HamsterForUpdateDto hamster, bool trackChanges);

    }
}
