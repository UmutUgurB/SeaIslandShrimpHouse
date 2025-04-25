namespace SeaIsland.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetlistAll();
        void Add(T item);   
        void Delete(T item);    
        void Update(T item);
        T GetById(int id);
    }
}
