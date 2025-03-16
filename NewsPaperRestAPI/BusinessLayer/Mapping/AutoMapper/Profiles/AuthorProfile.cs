using AutoMapper;
using ModelLayer.Dtos.AuthorDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorGetDto>();
            CreateMap<AuthorPostDto,Author>();  
            CreateMap<AuthorPutDto, Author>();
        }
    }
}
