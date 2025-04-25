using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class FeatureManager(IFeatureDal _featureDal) : IFeatureService
    {
        public void TAdd(Feature item)
        {
            _featureDal.Add(item);  
        }

        public void TDelete(Feature item)
        {
            _featureDal.Delete(item);   
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id); 
        }

        public List<Feature> TGetlistAll()
        {
            return _featureDal.GetlistAll();    
        }

        public void TUpdate(Feature item)
        {
            _featureDal.Update(item);
        }
    }
}
