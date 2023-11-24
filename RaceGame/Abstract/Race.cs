public abstract class Race
{
    public string Name { get; set; }
    public int Distance { get; set; }
    public List<Transport> CompetitiongTransports { get; set; }

    public void StartRace()
    {
        string winnerName = "";
        double winnerTime = 0;
        bool firstRun = true;
        foreach (Transport transport in CompetitiongTransports)
        {
            transport.Distance = Distance;
            transport.Move();
            if (firstRun == true)
            {
                winnerName = transport.Name;
                winnerTime = transport.TotalTime;
                firstRun = false;
            }
            else
            {
                winnerTime = winnerTime < transport.TotalTime ? winnerTime : transport.TotalTime;
                winnerName = winnerTime < transport.TotalTime ? winnerName : transport.Name;
            }
        }
        double minutesTotal = 0;
        double hoursTotal = 0;
        if (winnerTime/60 > 0)
        {
            minutesTotal = Math.Round(winnerTime / 60, 0);
        }
        if (minutesTotal/60 > 0)
        {
            hoursTotal = Math.Round(minutesTotal / 60, 0);
        }
        if (hoursTotal != 0)
        {
            Console.WriteLine($"Наш победитель в гонке {Name}: {winnerName}");
            Console.WriteLine("Прошел гонку за " + hoursTotal + " часов\n");
        }
        else if ( minutesTotal != 0) 
        {
            Console.WriteLine($"Наш победитель в гонке {Name}: {winnerName}");
            Console.WriteLine("Прошел гонку за " + minutesTotal + " минут\n");
        }
        else
        {
            Console.WriteLine($"Наш победитель в гонке {Name}: {winnerName}");
            Console.WriteLine("Прошел гонку за " + Math.Round(winnerTime, 0) + " секунд\n");
        }  
    }
   
    public abstract void Registrate(TransportPark TrCollection);
}

