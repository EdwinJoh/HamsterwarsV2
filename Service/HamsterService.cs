using AutoMapper;
using Contacts;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class HamsterService : IHamsterService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public HamsterService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public IEnumerable<HamsterDto> GetAllHamsters(bool trackChanges)
        {
            try
            {
                var hamsters = _repository.Hamster.GetAllHamsters(trackChanges);
                var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);
                return hamsterDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllHamsters)} service method {ex}");

                throw;
            }
        }


    }
}
