using AutoMapper;
using ModelLayer.Dtos.HomeDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class HomeProfile:Profile
    {
        public HomeProfile()
        {
            CreateMap<Home,HomeGetDto>();
            CreateMap<HomePostDto, Home>();
            CreateMap<HomePutDto, Home>();
        }
    }
}
