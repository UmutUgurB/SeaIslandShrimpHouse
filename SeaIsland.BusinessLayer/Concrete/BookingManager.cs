using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class BookingManager(IBookingDal _bookingDal) : IBookingService
    {
        public void TAdd(Booking item)
        {
            _bookingDal.Add(item);
        }

        public void TDelete(Booking item)
        {
            _bookingDal.Delete(item);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);    
        }

        public List<Booking> TGetlistAll()
        {
            return _bookingDal.GetlistAll();
        }

        public void TUpdate(Booking item)
        {
            _bookingDal.Update(item);
        }
    }
}
