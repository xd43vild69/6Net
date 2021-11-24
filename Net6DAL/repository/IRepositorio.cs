namespace Net6DAL;
public interface IRepositorio<T>
    {
        IEnumerable<T> GetLists();
        T GetById(int id);
        void Insert(T entidad);
        void Update(T entidad);
        void Delete(int id);
    }
