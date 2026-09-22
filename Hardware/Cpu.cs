

namespace compo.Hardware;

public class Cpu
{
    public string Model { get; set; }

    public Cpu(string model)
    {
        Model = model;
    }

    public void process()
    {
        Console.WriteLine($"CPU processing: {Model}");
    }
}
