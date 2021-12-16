using Microsoft.AspNetCore.Mvc;

namespace Net6WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ThemesController : ControllerBase
{
    [HttpGet(Name = "GetThemes")]
    public IEnumerable<Theme> Get()
    {
        List<Theme> themes = new List<Theme>(){
            new Theme(){Label = "1", Value = "xx"}
        };

        return themes;
    }
}