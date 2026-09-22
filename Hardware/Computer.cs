namespace compo.Computer;
using compo.Hardware;
public class Computer
{
  private Cpu _cpu;
  private Ram _ram;
  public string Brand { get; set; }

  public Computer(string brand, string cpuModel, int ramSize)
    {
        Brand = brand;
        _cpu = new Cpu(cpuModel);
        _ram = new Ram(ramSize);
    }

    public void boot()
    {
        Console.WriteLine($"Computer booting: {Brand}");
        _cpu.process();
        _ram.loadData();
         Console.WriteLine("Computer ready!");
    }


}
