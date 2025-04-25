using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class ContactManager(IContactDal _contactDal) : IContactService
    {
        public void TAdd(Contact item)
        {
            _contactDal.Add(item);  
        }

        public void TDelete(Contact item)
        {
            _contactDal.Delete(item);   
        }

        public Contact TGetById(int id)
        {
          return  _contactDal.GetById(id);    
        }

        public List<Contact> TGetlistAll()
        {
           return _contactDal.GetlistAll(); 
        }

        public void TUpdate(Contact item)
        {
            _contactDal.Update(item);   
        }
    }
}
