using AutoMapper;
using Contacts;
using Contracts;
using Entities.Exceptions;
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
        public async Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges)
        {

            var hamsters = await _repository.Hamster.GetAllHamsters(trackChanges);
            var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);
            return hamsterDto;

        }
        public async Task<HamsterDto> GetHamsterAsync(int id, bool trackChanges)
        {
            var hamster = await _repository.Hamster.GetHamster(id, trackChanges);
            if (hamster is null)
                throw new HamsterNotFoundException(id);

            var hamsterDto = _mapper.Map<HamsterDto>(hamster);
            return hamsterDto;
        }
        public async Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster)
        {
            var hamsterEntity = _mapper.Map<Hamster>(hamster);

            _repository.Hamster.CreateHamster(hamsterEntity);
            _repository.SaveAsync();

            var hamsterToReturn = _mapper.Map<HamsterDto>(hamsterEntity);

            return hamsterToReturn;
        }

        public async Task DeleteHamsterAsync(int id, bool trackChanges)
        {
            var hamster =await  _repository.Hamster.GetHamster(id, trackChanges);
            if (hamster is null)
                throw new HamsterNotFoundException(id);

            _repository.Hamster.DeleteHamster(hamster);
            _repository.SaveAsync();
        }
        public async Task UpdateHamsterAsync(int id, HamsterForUpdateDto hamsterForUpdate, bool trackChanges)
        {
            var hamsterEntity = await _repository.Hamster.GetHamster(id, trackChanges);
            if (hamsterEntity is null)
                throw new HamsterNotFoundException(id);

            _mapper.Map(hamsterForUpdate, hamsterEntity);
            _repository.SaveAsync();
        }


    }
}
