using System.Runtime.CompilerServices;

public class SevenLeagueBoots: GroundTransport
{
    public SevenLeagueBoots() 
    {
        Name = "Сапоги скороходы";
        Speed = randomNumber.Next(1, 100);
        TimeBeforeRest = randomNumber.Next(1, 30);
        TimeIncrement = randomNumber.Next(1, 15);
    }
    protected override void Rest()
    {
        RestTime = StopNumber * TimeIncrement;
    }
}
