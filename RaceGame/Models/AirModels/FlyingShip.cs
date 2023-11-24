public class FlyingShip: AirTransport
{
    public FlyingShip()
    {
        Name = "Летучий корабль";
        Speed = randomNumber.Next(1, 100);
    }

    protected override void Acceleration()
    {
        AccelerationFactor = ((Speed * 2 - (Speed / 2)) - (Speed * 1 - (Speed / 2))) / (2 - 1);
    }
}

