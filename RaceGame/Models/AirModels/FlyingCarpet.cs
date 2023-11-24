public class FlyingCarpet: AirTransport
{
    public FlyingCarpet()
    {
        Name = "Ковер-самолет";
        Speed = randomNumber.Next(1, 100);
    }

    protected override void Acceleration()
    {
        AccelerationFactor = (Speed * 2*2 - Speed * 1*1) / (2 - 1);
    }
}

