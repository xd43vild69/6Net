using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net6Data;
using Net6Domain;
using Net6DTO;

namespace Net6Test;

[TestClass]
public class UserUT
{
    [TestMethod]
    public void UserUT_Get()
    {
        Net6Domain.UserManager um = new Net6Domain.UserManager();
        um.GetUser();
    }

    [TestMethod]
    public void UserUT_Post()
    {
        Net6Domain.UserManager um = new Net6Domain.UserManager();

        User u = new User()
        {
            Name = "xx1",
            Password = "12345"
        };
        um.Insert(u);
    }

    [TestMethod]
    public void UserUT_Put()
    {
        Net6Domain.UserManager um = new Net6Domain.UserManager();

        User u = new User()
        {
            UserId = 3,
            Name = "x6",
            Password = "5555"
        };
        um.Update(u);
    }
}