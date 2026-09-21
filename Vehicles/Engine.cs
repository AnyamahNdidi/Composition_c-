namespace compo.Engine;


public class Engine
{
    public string Type { get ; set;}
    public int HorsePower { get; set; }

    public Engine(string type, int horsePower)
    {
        Type = type;
        HorsePower = horsePower;
        Console.WriteLine($"Engine created: {Type}, {HorsePower} HP");
    }

    public void Start()
    {
        Console.WriteLine($"Engine started: {Type}, {HorsePower} HP");
    }
    public void Stop()
    {
        Console.WriteLine($"Engine stopped: {Type}, {HorsePower} HP");
    }

}
