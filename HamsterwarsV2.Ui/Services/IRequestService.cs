using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterwarsV2.Ui.Services
{
    public interface IRequestService
    {
        Task<IEnumerable<Hamster>> GetAllHamstersAsync();
        Task RemoveObjectAsync<T>(string objType, int id);
        Task<Hamster> GetRandomHamsterAsync();
    }
}
