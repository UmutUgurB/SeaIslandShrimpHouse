using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class MealManager(IMealDal _mealDal) : IMealService
    {
        public void TAdd(Meal item)
        {
            _mealDal.Add(item); 
        }

        public void TDelete(Meal item)
        {
            _mealDal.Delete(item);
        }

        public Meal TGetById(int id)
        {
            return _mealDal.GetById(id);        
        }

        public List<Meal> TGetlistAll()
        {
            return _mealDal.GetlistAll();   
        }

        public void TUpdate(Meal item)
        {
            _mealDal.Update(item);  
        }
    }
}
