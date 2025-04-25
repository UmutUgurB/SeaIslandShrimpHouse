using AutoMapper;
using SeaIsland.DtoLayer.BookingDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap(); 
            CreateMap<Booking,CreateBookingDto>().ReverseMap(); 
            CreateMap<Booking,ResultBookingDto>().ReverseMap(); 
            
        }
    }
}
