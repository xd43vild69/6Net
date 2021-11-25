using Net6Data;
using Net6DTO;

namespace Net6Domain;
public class UserManager
{
    public void GetUser()
    {
        Net6Data.UserRepository<User> r = new Net6Data.UserRepository<User>();
        var u = r.GetById(1);
        string x = string.Empty;
    }

    public void Insert(User user)
    {
        Net6Data.UserRepository<User> r = new Net6Data.UserRepository<User>();
        r.Insert(user);
    }

    public void Update(User user)
    {
        Net6Data.UserRepository<User> r = new Net6Data.UserRepository<User>();
        r.Update(user);
    }
}
