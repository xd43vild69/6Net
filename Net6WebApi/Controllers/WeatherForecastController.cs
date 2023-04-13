using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Net6WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        Net6BaseLib.SearchManager sm = new Net6BaseLib.SearchManager();
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }


    [HttpPost]
    public async Task<string> Post(string AnimalInput)
    {

        // ManualManipulation
        //string AnimalInput = "crow";
        //Net6BaseLib.designPatterns.ObserverManager om = new Net6BaseLib.designPatterns.ObserverManager();

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "tokenHere");

        var request = new OpenAIRequest
        {
            Model = "text-davinci-002",
            Prompt = GetPrompt.generatePrompt2(AnimalInput), //$"Name my {AnimalInput}",
            Temperature = 0.7f,
            MaxTokens = 50
        };
        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://api.openai.com/v1/completions", content);
        var resjson = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            var errorResponse = JsonSerializer.Deserialize<OpenAIErrorResponse>(resjson);
            throw new System.Exception(errorResponse.Error.Message);
        }
        //var data = JsonSerializer.Deserialize<OpenAIResponse>(resjson);
        var data = JsonSerializer.Deserialize<Root>(resjson);
        //var data = JsonSerializer.Deserialize(resjson, typeof(object));
        var results = data.choices[0].text;

        return results;
    }
}

public static class GetPrompt
{
    //Override OpenIA call
    public static string generatePrompt2(string animal)
    {
        return animal;
    }

    public static string generatePrompt(string animal)
    {
        var capitalizedAnimal = animal.Trim();
        return "Suggest three names for an animal that is a villain." +
                "Animal: Cat" +
                "Names: Captain Sharpclaw, Agent Fluffball, The doomed Feline" +
                "Animal: Dog" +
                "Names: Ruff the evil, Wonder Canine, Sir Barks - a - Lot" +
                "Animal: " + capitalizedAnimal + " " +
                "Names:";
    }
}

public class Choice
{
    public string text { get; set; }
    public int index { get; set; }
    public object logprobs { get; set; }
    public string finish_reason { get; set; }
}
public class Root
{
    public string id { get; set; }
    public string @object { get; set; }
    public int created { get; set; }
    public string model { get; set; }
    public List<Choice> choices { get; set; }
    public Usage usage { get; set; }
}
public class Usage
{
    public int prompt_tokens { get; set; }
    public int completion_tokens { get; set; }
    public int total_tokens { get; set; }
}
public class OpenAIChoice
{
    public string text { get; set; }
    public float probability { get; set; }
    public float[] logprobs { get; set; }
    public int[] finish_reason { get; set; }
}
public class OpenAIRequest
{
    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("prompt")]
    public string Prompt { get; set; }

    [JsonPropertyName("temperature")]
    public float Temperature { get; set; }

    [JsonPropertyName("max_tokens")]
    public int MaxTokens { get; set; }
}
public class OpenAIErrorResponse
{
    [JsonPropertyName("error")]
    public OpenAIError Error { get; set; }
}
public class OpenAIError
{
    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("param")]
    public string Param { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }
}


