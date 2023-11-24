public class Menu
{
    private bool run = true;
    string subMenuLine = "зарегистрируйте транспорт для участия в гонке:";
    string raceName;
    int raceDistance;
    public void СallMenu()
    {
        var transportsCollection = new TransportPark();
        transportsCollection.Collection = transportsCollection.GenerateCompetetors();
        while (run)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Выберите пункт меню (введите цифру):");
            Console.Write("1 - Запустить наземную гонку" + "\n");
            Console.Write("2 - Запустить воздушную гонку" + "\n");
            Console.Write("3 - Запустить гонку микс" + "\n");
            Console.Write("4 - Выйти из меню" + "\n\n");
            Console.Write("Выберите пункт меню: ");
            var menuItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-------------------------------------------------------");
            switch (menuItem)
            {
                case 1:
                    CallSubMenu();
                    var groundRace = new GroundRace(raceName, raceDistance);
                    groundRace.Registrate(transportsCollection);
                    groundRace.StartRace();
                    break;
                case 2:
                    CallSubMenu();
                    var airRace = new AirRace(raceName, raceDistance);
                    airRace.Registrate(transportsCollection);
                    airRace.StartRace();
                    break;
                case 3:
                    CallSubMenu();
                    var multiRace = new MultiRace(raceName, raceDistance);
                    multiRace.Registrate(transportsCollection);
                    multiRace.StartRace();
                    break;
                case 4:
                    run = false;
                    break;
                default:
                    Console.WriteLine("Такого пункта нет в меню");
                    break;
            }
        }   
    }  
    private void CallSubMenu()
    { 
        Console.Write("Введите название гонки: ");
        raceName = Console.ReadLine();
        Console.Write("Введите дистанцию гонки: ");
        raceDistance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n-------------------------------------------------------");
    }
}

