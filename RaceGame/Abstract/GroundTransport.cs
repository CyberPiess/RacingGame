public abstract class GroundTransport: Transport
{
    protected Random randomNumber = new Random();

    public int TimeBeforeRest { get; set; }
    protected int StopNumber { get; set; }
    public int TimeIncrement { get; set; }
    public double RestTime { get; set; }

    public override void Move()
    {
        TotalTime = Distance / Speed;
        StopNumber = (int)TotalTime / TimeBeforeRest;
        while (StopNumber > 0)
        {
            Rest();
            TotalTime += RestTime;
            StopNumber--;
        }
    }
    protected abstract void Rest();
}