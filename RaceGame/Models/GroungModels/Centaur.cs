public class Centaur: GroundTransport
{
    public Centaur()
    {
        Name = "Кентавр";
        Speed = randomNumber.Next(1, 100);
        TimeBeforeRest = randomNumber.Next(1, 30);
        TimeIncrement = randomNumber.Next(1, 15);
    }

    protected override void Rest()
    {
        RestTime = TimeIncrement * Math.Sin((double)StopNumber/4);
    }
}
