using AutoMapper;
using SeaIsland.DtoLayer.SocialMediaDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
        }
    }
}
