using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
