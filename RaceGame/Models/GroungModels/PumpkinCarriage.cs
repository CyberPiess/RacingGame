public class PumpkinCarriage: GroundTransport
{
    public PumpkinCarriage()
    {
        Name = "Карета-тыква";
        Speed = randomNumber.Next(1, 100);
        TimeBeforeRest = randomNumber.Next(1, 30);
        TimeIncrement = randomNumber.Next(1, 15);
    }

    protected override void Rest()
    {
        RestTime = TimeIncrement;
    }
}
