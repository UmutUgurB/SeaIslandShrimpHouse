using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class AbaoutManger(IAboutDal _aboutDal) : IAboutService
    {
        public void TAdd(About item)
        {
            _aboutDal.Add(item);    
        }

        public void TDelete(About item)
        {
            _aboutDal.Delete(item);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetlistAll()
        {
            return _aboutDal.GetlistAll();  
        }

        public void TUpdate(About item)
        {
            _aboutDal.Update(item); 
        }
    }
}
