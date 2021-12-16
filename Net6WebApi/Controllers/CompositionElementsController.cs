using Microsoft.AspNetCore.Mvc;
using Net6DTO;
using Net6Domain;

namespace Net6WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CompositionElementsController : ControllerBase
{
    [HttpGet(Name = "GetCompositionElements")]
    public IEnumerable<CompositionElements> Get()
    {
        CreativityManager soundTrackManager = new CreativityManager();
        return soundTrackManager.GetCompositionElements();
    }
}