using AutoMapper;
using SeaIsland.DtoLayer.CategoryDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,GetCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();   
            CreateMap<Category,CreateCategoryDto>().ReverseMap();   
            CreateMap<Category,ResultCategoryDto>().ReverseMap();   
        }
    }
}
