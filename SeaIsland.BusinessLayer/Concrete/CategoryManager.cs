using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Concrete
{
    public class CategoryManager(ICategoryDal _categoryDal) : ICategoryService
    {
        public void TAdd(Category item)
        {
            _categoryDal.Add(item); 
        }

        public void TDelete(Category item)
        {
            _categoryDal.Delete(item);  
        }

        public Category TGetById(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category> TGetlistAll()
        {
            return _categoryDal.GetlistAll();   
        }

        public void TUpdate(Category item)
        {
           _categoryDal.Update(item);   
        }
    }
}
