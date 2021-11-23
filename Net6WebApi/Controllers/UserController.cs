using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Net6BaseLib;
namespace Net6WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
  private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    //[EnableCors]
    [HttpGet(Name = "GetUser")]
    public IEnumerable<User> Get()
    {    
        Net6BaseLib.designPatterns.observer.ObserverPatternManager opm = new Net6BaseLib.designPatterns.observer.ObserverPatternManager();
        
        List<User> users = new List<User>(){
            new User(){userId=1,Name="D13",Password="12345"},
            new User(){userId=2,Name="x13",Password="12345"},
        };

        return users;
    }

    [HttpPost]
    public User Post(User user)
    {
        var x = user;
        Console.WriteLine("post called");
        return user;
    }
    
    [HttpPut]
    public User Put(User user)
    {
        var x = user;
        Console.WriteLine("post called");
        return user;
    }
}