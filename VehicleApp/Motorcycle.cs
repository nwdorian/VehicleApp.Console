namespace VehicleApp;
internal class Motorcycle : Vehicle
{
    protected override void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Ks: {Ks}, Kw: {KsToKw()}");
    }
}
