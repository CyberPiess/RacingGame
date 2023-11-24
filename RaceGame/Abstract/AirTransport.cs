public abstract class AirTransport : Transport
{
    protected Random randomNumber = new Random();

    protected double AccelerationFactor { get; set; }


    public override void Move()
    {
        Acceleration();
        TotalTime = Math.Sqrt(Distance + 2 / AccelerationFactor);
    }
    protected abstract void Acceleration();
}
