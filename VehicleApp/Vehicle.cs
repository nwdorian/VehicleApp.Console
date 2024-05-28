namespace VehicleApp;
internal abstract class Vehicle
{
    protected Vehicle()
    {
    }

    protected Vehicle(string? manufacturer, string? model, string color, double ks)
    {
        Manufacturer = manufacturer;
        Model = model;
        Color = color;
        Ks = ks;
    }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double Ks { get; set; }

    protected abstract double KsToKw();

    protected virtual void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Ks: {Ks}, Kw: {KsToKw()}");
    }
}
