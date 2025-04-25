using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class TestimonialManager(ITestimonialDal _testimonialDal) : ITestimonialService
    {
        public void TAdd(Testimonial item)
        {
            _testimonialDal.Add(item); 
        }

        public void TDelete(Testimonial item)
        {
            _testimonialDal.Delete(item);   
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);    
        }

        public List<Testimonial> TGetlistAll()
        {
            return _testimonialDal.GetlistAll();    
        }

        public void TUpdate(Testimonial item)
        {
            _testimonialDal.Update(item);
        }
    }
}
