using Net6DTO;

namespace Net6Data;

public class UserRepository<T> : IRepository<T> where T: User, new()
{
    public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetLists()
        {
            // using (var db = new ContextSAL())
            // {
            //     var typeList = db.Set<T>().ToList();
            //     return typeList;
            // }
            throw new NotImplementedException();
        }

        public void Insert(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Update(T entidad)
        {
            throw new NotImplementedException();
        }
}