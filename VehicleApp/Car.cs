namespace VehicleApp;
internal class Car : Vehicle
{
    public int Ccm { get; set; }
    protected override void PrintDetails()
    {
        Console.WriteLine($"Vehicle details: Manufacturer: {Manufacturer}, Model: {Model}, Displacement: {Ccm} Ks: {Ks}, Kw: {KsToKw()}");
    }
}
