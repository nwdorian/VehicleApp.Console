namespace VehicleApp;
internal abstract class Vehicle
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public double Ks { get; set; }

    public double KsToKw()
    {
        return Ks * 0.735;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Ks: {Ks}, Kw: {KsToKw()}");
    }
}
