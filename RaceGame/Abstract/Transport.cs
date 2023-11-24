public abstract class Transport
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Distance { get; set; }
    public double TotalTime { get; set; }

    public abstract void Move();
}
