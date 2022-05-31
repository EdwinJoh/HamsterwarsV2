using AutoMapper;
using Entities.Models;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Mapper
{
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
