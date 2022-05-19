﻿using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IMatchService
    {
        Task<IEnumerable<MatchDto>> GetAllMatchesAsync(MatchParameters matchParameters, bool trackChanges);
        Task<MatchDto> GetMatchAsync(int id, bool trackChanges);
        Task<MatchDto> CreateMatchAsync(MatchForCreationDto match);
        Task DeleteMatchAsync(int id,bool trackChanges);
        
    }
}