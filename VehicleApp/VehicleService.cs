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
            Console.WriteLine("\nVEHICLE LIST\n");

            foreach (var item in vehicleList)
            {
                Console.Write("Id " + vehicleList.IndexOf(item) + ". ");
                item.PrintDetails();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("There are no items in the vehicle list.");
        }

        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    internal void DeleteVehicle()
    {
        if (vehicleList.Any())
        {
            Console.WriteLine("\nVEHICLE LIST\n");

            foreach (var item in vehicleList)
            {
                Console.Write("Id " + vehicleList.IndexOf(item) + ". ");
                item.PrintDetails();
                Console.WriteLine();
            }

            Console.Write("Enter Id of the vehicle to delete: ");
            int vehicleId;
            while (!int.TryParse(Console.ReadLine(), out vehicleId))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter Id of the vehicle to delete: ");
            }

            vehicleList.RemoveAt(vehicleId);

            Console.Write("Vehicle was deleted! Press any key to continue... ");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("There are no items in the vehicle list.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }

    internal void UpdateVehicle()
    {
        if (vehicleList.Any())
        {
            Console.WriteLine("\nVEHICLE LIST\n");

            foreach (var item in vehicleList)
            {
                Console.Write("Id " + vehicleList.IndexOf(item) + ". ");
                item.PrintDetails();
                Console.WriteLine();
            }

            Console.Write("Enter Id of the vehicle to update: ");
            int vehicleId;
            while (!int.TryParse(Console.ReadLine(), out vehicleId))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter Id of the vehicle to update: ");
            }

            //TODO fix outofrangeexception
            var vehicle = vehicleList[vehicleId];

            Console.Write("Enter new manufacturer (leave empty to skip): ");
            var manufacturer = Console.ReadLine();
            if (!String.IsNullOrEmpty(manufacturer))
            {
                vehicle.Manufacturer = manufacturer;
            }

            Console.Write("Enter new model (leave empty to skip): ");
            var model = Console.ReadLine();
            if (!String.IsNullOrEmpty(model))
            {
                vehicle.Model = model;
            }

            Console.Write("Enter new color (leave empty to skip): ");
            var color = Console.ReadLine();
            if (!String.IsNullOrEmpty(color))
            {
                vehicle.Color = color;
            }

            Console.Write("Enter new horse power (enter 0 to skip): ");
            double ks;
            while (!double.TryParse(Console.ReadLine(), out ks))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter new horse power: ");
            }
            if (ks != 0)
            {
                vehicle.Ks = ks;
            }

            Console.Write("Vehicle was updated! Press any key to continue... ");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("There are no items in the vehicle list.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
