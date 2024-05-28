namespace VehicleApp;
internal abstract class Vehicle
{
    protected Vehicle()
    {
    }

    protected Vehicle(string? manufacturer, string? model, double ks)
    {
        Manufacturer = manufacturer;
        Model = model;
        Ks = ks;
    }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
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
