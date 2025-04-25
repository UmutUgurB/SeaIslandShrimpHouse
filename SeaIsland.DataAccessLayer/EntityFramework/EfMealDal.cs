using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;
using SeaIsland.DataAccessLayer.Repository;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.DataAccessLayer.EntityFramework
{
    public class EfMealDal : GenericRepository<Meal>, IGenericRepository<Meal>
    {
        public EfMealDal(AppDbContext _context) : base(_context)
        {
        }
    }
}
