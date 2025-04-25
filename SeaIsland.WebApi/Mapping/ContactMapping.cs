using AutoMapper;
using SeaIsland.DtoLayer.ContactDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact,ResultContactDto>().ReverseMap(); 
            CreateMap<Contact,CreateContactDto>().ReverseMap(); 
            CreateMap<Contact,UpdateContactDto>().ReverseMap(); 
        }
    }
}
