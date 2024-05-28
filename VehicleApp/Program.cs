var exit = false;

while (!exit)
{
    Console.WriteLine("Select from the menu: ");
    Console.WriteLine("1. Add new vehicle");
    Console.WriteLine("2. Update vehicle");
    Console.WriteLine("3. Delete vehicle");
    Console.WriteLine("4. List vehicles");
    Console.WriteLine("5. Exit");

    var selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
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
