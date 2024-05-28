using VehicleApp;

VehicleService vehicleService = new();

var exit = false;

while (!exit)
{
    Console.Clear();
    Console.WriteLine("VEHICLE MENU");
    Console.WriteLine("1. Add new vehicle");
    Console.WriteLine("2. Update vehicle");
    Console.WriteLine("3. Delete vehicle");
    Console.WriteLine("4. List vehicles");
    Console.WriteLine("5. Exit");

    Console.Write("\nEnter selection: ");
    var selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            vehicleService.AddVehicle();
            break;
        case "2":
            break;
        case "3":
            vehicleService.DeleteVehicle();
            break;
        case "4":
            vehicleService.ListAllVehicles();
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.Write("Unknown option! Press any key to continue...");
            Console.ReadKey();
            break;
    }
}
