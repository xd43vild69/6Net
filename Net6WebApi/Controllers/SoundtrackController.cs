using Microsoft.AspNetCore.Mvc;
using Net6DTO;
using Net6Domain;

namespace Net6WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SoundtrackController : ControllerBase
{
    [HttpGet(Name = "GetSoundtrack")]
    public IEnumerable<Soundtrack> Get()
    {
        CreativityManager soundTrackManager = new CreativityManager();
        return soundTrackManager.GetSoundtrack();
    }
}