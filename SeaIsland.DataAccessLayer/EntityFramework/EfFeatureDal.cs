using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;
using SeaIsland.DataAccessLayer.Repository;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(AppDbContext _context) : base(_context)
        {
        }
    }
}
