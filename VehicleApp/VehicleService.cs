namespace VehicleApp;
internal class VehicleService
{
    List<Vehicle> vehicleList = new();
    internal void AddVehicle()
    {

        Console.Clear();
        Console.WriteLine("SELECT FROM THE MENU");
        Console.WriteLine("1. Add new car");
        Console.WriteLine("2. Add new aeroplane");
        Console.WriteLine("3. Main menu");

        Console.Write("\nEnter selection: ");
        var selection = Console.ReadLine();

        if (selection == "1")
        {
            Car car = new();

            Console.Write("Enter car manufacturer: ");
            car.Manufacturer = Console.ReadLine();

            Console.Write("Enter car model: ");
            car.Model = Console.ReadLine();

            Console.Write("Enter car color: ");
            car.Color = Console.ReadLine();

            Console.Write("Enter horse power: ");
            double ks;
            while (!double.TryParse(Console.ReadLine(), out ks))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter car horse power: ");
            }
            car.Ks = ks;

            Console.Write("Enter engine displacement: ");
            int ccm;
            while (!int.TryParse(Console.ReadLine(), out ccm))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter engine displacement: ");
            }
            car.Ccm = ccm;

            vehicleList.Add(car);
        }
        else if (selection == "2")
        {
            Aeroplane plane = new();

            Console.Write("Enter aeroplane manufacturer: ");
            plane.Manufacturer = Console.ReadLine();

            Console.Write("Enter aeroplane model: ");
            plane.Model = Console.ReadLine();

            Console.Write("Enter aeroplane color: ");
            plane.Color = Console.ReadLine();

            Console.Write("Enter horse power: ");
            double ks;
            while (!double.TryParse(Console.ReadLine(), out ks))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter horse power: ");
            }
            plane.Ks = ks;

            Console.Write("Enter aeroplane company: ");
            plane.Company = Console.ReadLine();

            vehicleList.Add(plane);
        }
        else
        {
            return;
        }
    }

    internal void ListAllVehicles()
    {
        if (vehicleList.Any())
        {
            Console.WriteLine("VEHICLE LIST");

            foreach (var item in vehicleList)
            {
                Console.Write("Id " + vehicleList.IndexOf(item) + ". ");
                item.PrintDetails();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("There are not items in the vehicle list.");
        }

        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
