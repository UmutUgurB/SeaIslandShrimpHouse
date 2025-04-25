using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;

namespace SeaIsland.DataAccessLayer.Repository
{
    public class GenericRepository<T>(AppDbContext _context) : IGenericRepository<T> where T : class
    {
        public void Add(T item)
        {
            _context.Add(item);
            _context.SaveChanges(); 
        }

        public void Delete(T item)
        {
            _context.Remove(item);
            _context.SaveChanges(); 
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetlistAll()
        {
            return _context.Set<T>().ToList();  
        }

        public void Update(T item)
        {
            _context.Update(item);  
            _context.SaveChanges(); 
        }
    }

}

