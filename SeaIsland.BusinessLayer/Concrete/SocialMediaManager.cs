using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class SocialMediaManager(ISocialMediaDal _socialMediaDal) : ISocialMediaService
    {
        public void TAdd(SocialMedia item)
        {
            _socialMediaDal.Add(item);  
        }

        public void TDelete(SocialMedia item)
        {
            _socialMediaDal.Delete(item);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id); 
        }

        public List<SocialMedia> TGetlistAll()
        {
            return _socialMediaDal.GetlistAll();    
        }

        public void TUpdate(SocialMedia item)
        {
            _socialMediaDal.Update(item);   
        }
    }
}
