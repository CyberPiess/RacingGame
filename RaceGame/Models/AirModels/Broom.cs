public class Broom: AirTransport
{
    public Broom()
    {
        Name = "Метла";
        Speed = randomNumber.Next(1, 100);
    }

    protected override void Acceleration()
    {
        AccelerationFactor = (Speed * Math.Log(2) - Speed * Math.Log(1)) / (2 - 1);
    }
}

