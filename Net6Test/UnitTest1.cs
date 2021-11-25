using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net6Data;
using Net6Domain;

namespace Net6Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Net6Domain.UserManager um = new Net6Domain.UserManager();
        um.GetUser();
    }
}