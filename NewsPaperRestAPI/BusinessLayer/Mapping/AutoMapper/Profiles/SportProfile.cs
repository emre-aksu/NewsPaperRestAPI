using AutoMapper;
using ModelLayer.Dtos.SportDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class SportProfile:Profile
    {
        public SportProfile()
        {
            CreateMap<Sport,SportGetDto>();
            CreateMap<SportPostDto, Sport>();
            CreateMap<SportPutDto, Sport>();
        }
    }
}
