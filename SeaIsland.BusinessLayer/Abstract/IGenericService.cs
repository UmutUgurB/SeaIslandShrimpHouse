namespace SeaIsland.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetlistAll();
        void TAdd(T item);
        void TDelete(T item);
        void TUpdate(T item);
        T TGetById(int id);
    }
}
