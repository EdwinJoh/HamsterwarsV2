using AutoMapper;
using Contacts;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service
{
    internal sealed class MatchSevice : IMatchService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;



        public MatchSevice(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MatchDto>> GetAllMatchesAsync( bool trackChanges)
        {

            var matches = await _repository.Matches.GetAllMatchesAsync(trackChanges);
            var matchDto = _mapper.Map<IEnumerable<MatchDto>>(matches);
            return matchDto;

        }
        public async Task<MatchDto> GetMatchAsync(int id, bool trackChanges)
        {
            await CheckIfMatchExsist(id, trackChanges);
            var matchDb = await _repository.Matches.GetMatchAsync(id, trackChanges);
            var matchDto = _mapper.Map<MatchDto>(matchDb);

            return matchDto;
        }

        public async Task<MatchDto> CreateMatchAsync(MatchForCreationDto match)
        {
            var matchEnitity = _mapper.Map<Matches>(match);

            _repository.Matches.CreateMatch(matchEnitity);
            await _repository.SaveAsync();
            var hamsterToReturn = _mapper.Map<MatchDto>(matchEnitity);

            return hamsterToReturn;
        }
        public async Task DeleteMatchAsync(int id, bool trackChanges)
        {
            await CheckIfMatchExsist(id, trackChanges);

            var matchDb = await _repository.Matches.GetMatchAsync(id, trackChanges);
            _repository.Matches.DeleteMatch(matchDb);
            await _repository.SaveAsync();
        }
        public async Task<IEnumerable<MatchDto>> GetMatchWinnersAsync(int id, bool trackChanges)
        {
            await CheckIdExsistInMatchesASync(id, trackChanges);
            var matchesDb = await _repository.Matches.GetMatchWinnersAsync(id, trackChanges);
            var matchDto = _mapper.Map <IEnumerable<MatchDto>>(matchesDb);

            return matchDto;
        }
        private async Task CheckIfMatchExsist(int id, bool trackChanges)
        {
            var match = await _repository.Matches.GetMatchAsync(id, trackChanges);
            if (match is null)
                throw new MatchNotFoundException(id);
        }
        public async Task CheckIdExsistInMatchesASync(int id , bool trackChanges)
        {
            var match = await _repository.Matches.GetMatchWinnersAsync(id, trackChanges);
            if (match is null)
                throw new MatchNotFoundException(id);
        }
        public async Task<IEnumerable<MatchHistoryDto>> GetAllMatchHamsters()
        {
            var test = await _repository.Matches.GetAllHamsterMatches();
            var dto = _mapper.Map<IEnumerable<MatchHistoryDto>>(test);
            return dto;
        }
    }
}
