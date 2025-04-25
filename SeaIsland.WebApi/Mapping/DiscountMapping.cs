using AutoMapper;
using SeaIsland.DtoLayer.DiscountDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        }
    }
}
