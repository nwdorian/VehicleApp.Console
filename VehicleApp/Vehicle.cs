namespace VehicleApp;
internal abstract class Vehicle : IVehicle
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
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public string Color { get; set; } = String.Empty;
    public double Ks { get; set; }

    protected virtual double KsToKw()
    {
        return Ks * 0.735;
    }

    protected virtual void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Color: {Color} Ks: {Ks}, Kw: {KsToKw()}");
    }
}
