namespace VehicleApp;
internal class Car : Vehicle
{
    public int Ccm { get; set; }
    protected override double KsToKw()
    {
        return Ks * 0.735;
    }
    protected override void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Displacement: {Ccm} Ks: {Ks}, Kw: {KsToKw()}");
    }
}
