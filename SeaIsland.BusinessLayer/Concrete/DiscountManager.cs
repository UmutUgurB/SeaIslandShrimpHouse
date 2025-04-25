using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class DiscountManager(IDiscountDal _discountDal) : IDiscountService
    {
        public void TAdd(Discount item)
        {
            _discountDal.Add(item);
        }

        public void TDelete(Discount item)
        {
            _discountDal.Delete(item);  
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);    
        }

        public List<Discount> TGetlistAll()
        {
            return _discountDal.GetlistAll();
        }

        public void TUpdate(Discount item)
        {
            _discountDal.Update(item);
        }
    }
}
