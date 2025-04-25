using AutoMapper;
using SeaIsland.DtoLayer.FeatureDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap(); 
            CreateMap<Feature,ResultFeatureDto>().ReverseMap(); 
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap(); 
        }
    }
}
