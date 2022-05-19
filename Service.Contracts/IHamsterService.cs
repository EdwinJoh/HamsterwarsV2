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
        IEnumerable<HamsterDto> GetAllHamsters(bool trackChanges);
        HamsterDto GetHamster(int id,bool trackChanges);
        HamsterDto CreateHamster(HamsterForCreationDto hamster);
    }
}
