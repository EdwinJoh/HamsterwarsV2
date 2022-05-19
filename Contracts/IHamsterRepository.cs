﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> GetAllHamsters(bool trackChanges);
        Task<IEnumerable<Hamster>> GetByIds(IEnumerable<int> ids, bool trackChanges); //TODO: Använd för att slumpa fram 2 olika hamstrar??
        Task<Hamster> GetHamster(int id, bool trackChanges);
        void CreateHamster(Hamster hamster);
        void DeleteHamster(Hamster hamster);
    }
}
