using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class GroundRace: Race
{
    public GroundRace(string name, int distance)
    {
        Name = name;
        Distance = distance;
        CompetitiongTransports = new List<Transport>();
    }

    public override void Registrate(TransportPark TrCollection)
    {
        TrCollection.PrintTransport();
        bool next = true;
        while (next)
        {
            Console.Write("\nВыберите транспортное средство которое хотите добавить: ");
            string choosenVehicle = Console.ReadLine();
            var checkVehicle = CompetitiongTransports.FirstOrDefault(x => x.Name.Contains(choosenVehicle));
            if (choosenVehicle != null && checkVehicle == null)
            {
                var returnedVehicle = TrCollection.Search(choosenVehicle);
                if (returnedVehicle is GroundTransport)
                {
                    CompetitiongTransports.Add(returnedVehicle);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nВ наземную гонку нельзя зарегистрировать летающий транспорт");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nЭтот транспорт вы уже добавили");
                Console.ResetColor();
            }
            Console.Write("\nХотите добавить еще один транспорт?(Да/Нет): ");
            var answer = Console.ReadLine();
            next = answer == "Да" ? true : false;
        }
        Console.WriteLine("\n-------------------------------------------------------");
    }
}

