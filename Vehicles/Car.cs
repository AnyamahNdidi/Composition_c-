namespace compo.Car;
using compo.Engine;
public class Car
{
  private Engine _engine;
  public string Model {get; set;}
  public Car(string model, string type, int horsePower)
    {
        Model = model;
        _engine = new Engine(type, horsePower);
        Console.WriteLine($"Car created: {Model}, Engine: {type}, {horsePower} HP");
    }
    
    public void startCar()
    {
        Console.WriteLine($"Car started: {Model}");
        _engine.Start();
    }
   
}
