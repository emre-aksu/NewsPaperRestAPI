using AutoMapper;
using ModelLayer.Dtos.SpecialDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class SpecialProfile:Profile
    {
        public SpecialProfile()
        {
            CreateMap<Special,SpecialGetDto>();
            CreateMap<SpecialPostDto, Special>();
            CreateMap<SpecialPutDto, Special>();
        }
    }
}
