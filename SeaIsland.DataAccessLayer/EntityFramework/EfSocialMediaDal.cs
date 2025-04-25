using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;
using SeaIsland.DataAccessLayer.Repository;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(AppDbContext _context) : base(_context)
        {
        }
    }
}
