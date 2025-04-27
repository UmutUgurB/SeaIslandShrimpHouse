using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.AboutDto;
using SeaIsland.DtoLayer.BookingDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController(IBookingService _bookingService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooking()
        {
            var values = _bookingService.TGetlistAll(); 
            return Ok(values);  
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult Edit(UpdateBookingDto updateBookingDto)
        {
            var newValue = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Yapıldı");
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var newValue = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TAdd(newValue);
            return Ok("Rezervasyon Başarıyla Oluşturuldu");
        }

    }
}
