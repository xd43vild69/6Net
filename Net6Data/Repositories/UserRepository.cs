using Net6DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace Net6Data;

public class UserRepository<T> : IRepository<T> where T : User, new()
{
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        using (var db = new ContextDal())
        {
            return db.Set<T>().FirstOrDefault(x => x.UserId == id);
        }
    }

    public IEnumerable<T> GetLists()
    {
        using (var db = new ContextDal())
        {
            var typeList = db.Set<T>().ToList();
            return typeList;
        }
    }

    public void Insert(T entity)
    {
        using (var db = new ContextDal())
        {
            db.Entry(entity).State = EntityState.Added;
            db.SaveChangesAsync();
        }
    }

    public void Update(T entity)
    {
        using (var db = new ContextDal())
        {
            db.Update(entity);
            //db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}