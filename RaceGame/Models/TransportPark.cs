public class TransportPark
{
    public List<Transport> Collection { get; set; }

    public TransportPark() 
    {
        Collection = new List<Transport>();
    }
    public List<Transport> GenerateCompetetors()
    {
        return new List<Transport>
        {
            new SevenLeagueBoots(),
            new PumpkinCarriage(),
            new ChicklegHut(),
            new Centaur(),
            new BabaYagaStupa(),
            new Broom(),
            new FlyingCarpet(),
            new FlyingShip()
        };
    }
    public Transport Search(string requiredObject)
    {
        var foundItem = Collection.FirstOrDefault(x => x.Name.Equals(requiredObject));
        return foundItem;
    }

    public void PrintTransport()
    {
        Console.WriteLine("Список доступных транспортных средств:\n");
        foreach (Transport t in Collection)
        {
            Console.Write(t.Name + "\n");
        }
        Console.WriteLine("\n-------------------------------------------------------");
    }
}

