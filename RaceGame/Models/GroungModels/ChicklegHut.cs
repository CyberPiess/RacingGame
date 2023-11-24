public class ChicklegHut: GroundTransport
{
    public ChicklegHut()
    {
        Name = "Избушка на курьих ножках";
        Speed = randomNumber.Next(1, 100);
        TimeBeforeRest = randomNumber.Next(1, 30);
        TimeIncrement = randomNumber.Next(1, 15);
    }

    protected override void Rest()
    {
        RestTime = TimeIncrement/((StopNumber+1)/2);
    }
}

