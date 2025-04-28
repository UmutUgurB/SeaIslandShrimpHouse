using AutoMapper;
using SeaIsland.DtoLayer.MealDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class MealMapping:Profile
    {
        public MealMapping()
        {
            CreateMap<Meal,GetMealDto>().ReverseMap();
            CreateMap<Meal,ResultMealDto>().ReverseMap();
            CreateMap<Meal,CreateMealDto>().ReverseMap();
            CreateMap<Meal,UpdateMealDto>().ReverseMap();
            CreateMap<Meal,ResultMealWithCategory>().ReverseMap();  
        }
    }
}
