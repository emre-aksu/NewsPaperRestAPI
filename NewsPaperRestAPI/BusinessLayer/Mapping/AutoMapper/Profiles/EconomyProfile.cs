using AutoMapper;
using ModelLayer.Dtos.EconomyDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class EconomyProfile:Profile
    {
        public EconomyProfile()
        {
            CreateMap<Economy, EconomyGetDto>();
            CreateMap<EconomyPostDto, Economy>();
            CreateMap<EconomyPutDto, Economy>();
        }
    }
}
