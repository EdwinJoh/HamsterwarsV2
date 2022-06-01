using AutoMapper;
using Entities.Models;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Mapper
{
    /// <summary>
    /// Here we handle our source objects and the destination object that they map to.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hamster, HamsterDto>();
            CreateMap<HamsterForCreationDto, Hamster>();
            CreateMap<HamsterForUpdateDto, Hamster>().ReverseMap();
            CreateMap<MatchHistoryDto, Matches>();
            CreateMap<MatchForCreationDto, Matches>();
            CreateMap<Matches, MatchDto>();
        }
    }
}
