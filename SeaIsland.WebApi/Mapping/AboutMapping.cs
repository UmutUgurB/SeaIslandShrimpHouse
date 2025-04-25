using AutoMapper;
using SeaIsland.DtoLayer.AboutDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();    
            CreateMap<About,GetAboutDto>().ReverseMap();    
            CreateMap<About,UpdateAboutDto>().ReverseMap(); 
        }
    }
}
