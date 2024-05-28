namespace VehicleApp;
internal class Car : Vehicle
{
    public int Ccm { get; set; }
    internal override void PrintDetails()
    {
        Console.WriteLine($"Car details: Manufacturer: {Manufacturer}, Model: {Model}, Color: {Color} Displacement: {Ccm} Ks: {Ks}, Kw: {KsToKw()}");
    }
}
