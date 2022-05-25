using AutoMapper;
using Contacts;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;
using Shared.RequestFeatures;

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

            var hamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges);
            var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);
            return hamsterDto;

        }
        public async Task<HamsterDto> GetHamsterAsync(int id, bool trackChanges)
        {
            await CheckIfHamsterExsist(id, trackChanges);
            var hamsterDb = await _repository.Hamster.GetHamsterAsync(id, trackChanges);

            var hamsterDto = _mapper.Map<HamsterDto>(hamsterDb);
            return hamsterDto;
        }
        public async Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster)
        {
            var hamsterEntity = _mapper.Map<Hamster>(hamster);

            _repository.Hamster.CreateHamster(hamsterEntity);
            await _repository.SaveAsync();

            var hamsterToReturn = _mapper.Map<HamsterDto>(hamsterEntity);

            return hamsterToReturn;
        }

        public async Task DeleteHamsterAsync(int id, bool trackChanges)
        {
            await CheckIfHamsterExsist(id, trackChanges);

            var hamsterDb = await _repository.Hamster.GetHamsterAsync(id, trackChanges);

            _repository.Hamster.DeleteHamster(hamsterDb);
            await _repository.SaveAsync();
        }
        public async Task UpdateHamsterAsync(int id, HamsterForUpdateDto hamsterForUpdate, bool trackChanges)
        {
            await CheckIfHamsterExsist(id, trackChanges);

            var hamsterDb = await _repository.Hamster.GetHamsterAsync(id, trackChanges);

            _mapper.Map(hamsterForUpdate, hamsterDb);
            await _repository.SaveAsync();
        }
        public async Task<HamsterDto> GetRandomHamsterAsync(bool trackChanges)
        {
            var hamsters = await _repository.Hamster.GetHamsterbyIdsAsync(trackChanges);

            Random rand = new Random();
                var hamsterEntity =  await _repository.Hamster.GetRandomHamster(rand.Next(1, hamsters.Count), trackChanges);
            while(hamsterEntity is null)
            {
                hamsterEntity = await _repository.Hamster.GetRandomHamster(rand.Next(1, hamsters.Count), trackChanges);
            }
            
            var hamsterDto = _mapper.Map<HamsterDto>(hamsterEntity);
            return hamsterDto;

        }
        public async Task<IEnumerable<HamsterDto>> GetTopFiveWinnersAsync(bool trackChanges)
        {
            var hamstersDb = await _repository.Hamster.GetAllHamstersAsync(trackChanges);
            var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamstersDb);
            var TopFive = hamsterDto.OrderByDescending(w => w.Wins).Take(5).Where(h => h.Games > 1);
            return TopFive;
        }
        public async Task<IEnumerable<HamsterDto>> GetTopFiveLosersAsync(bool trackChanges)
        {
            var hamstersDb = await _repository.Hamster.GetAllHamstersAsync(trackChanges);
            var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamstersDb);
            var TopFive = hamsterDto.OrderByDescending(w => w.Defeats).Take(5).Where(h => h.Games > 1);
            return TopFive;
        }

        private async Task CheckIfHamsterExsist(int id, bool trackChages)
        {
            var hamster = await _repository.Hamster.GetHamsterAsync(id, trackChages);
            if (hamster is null)
                throw new HamsterNotFoundException(id);
        }


    }
}
