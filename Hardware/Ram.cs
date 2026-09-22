namespace compo;

public class Ram
{
  private int Size { get; set; }

  public Ram(int size)
    {
        Size = size;
    }

    public void loadData()
    {
        Console.WriteLine($"{Size}GB RAM is loading data");
    }
}
