using AutoMapper;
using ModelLayer.Dtos.CategoryDtos;
using ModelLayer.Entities;

namespace BusinessLayer.Mapping.AutoMapper.Profiles
{
   public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category,CategoryGetDto>();
            CreateMap<CategoryPostDto,Category>();  
            CreateMap<CategoryPutDto, Category>();
        }
    }
}
