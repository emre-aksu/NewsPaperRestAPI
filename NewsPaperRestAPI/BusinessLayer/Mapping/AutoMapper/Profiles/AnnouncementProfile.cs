using AutoMapper;
using ModelLayer.Dtos.AnnouncementDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
    public class AnnouncementProfile:Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement,AnnouncementGetDto>();   
            CreateMap<AnnouncementPostDto, Announcement>();
            CreateMap<AnnouncementPutDto, Announcement>();
        }
    }
}
