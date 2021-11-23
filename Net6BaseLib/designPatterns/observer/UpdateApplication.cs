namespace Net6BaseLib.designPatterns.observer;

public class UpdateApplication
{
    public string Version { get; set; }
    public string Feature { get; set; }
    public string Name { get; set; }

    public UpdateApplication(string version, string feature, string name)
    {
        Version = version;
        Feature = feature;
        Name = name;
    }
}