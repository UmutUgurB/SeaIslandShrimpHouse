using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.BusinessLayer.Abstract
{
    public interface IMealService : IGenericService<Meal>
    {
        public List<Meal> TGetMealsWithCategory();
    }
}
