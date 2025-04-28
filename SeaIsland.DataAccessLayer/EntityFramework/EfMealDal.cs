using Microsoft.EntityFrameworkCore;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;
using SeaIsland.DataAccessLayer.Repository;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.DataAccessLayer.EntityFramework
{
    public class EfMealDal : GenericRepository<Meal>, IMealDal
    {
        private readonly AppDbContext _context;

        public EfMealDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Meal> GetMealsWithCategory()
        {
            var values = _context.Meals.Include(x => x.Category).ToList();
            return values;
        }
    }
}
